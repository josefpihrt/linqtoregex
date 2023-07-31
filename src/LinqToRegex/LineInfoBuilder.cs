// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static Pihrtsoft.Text.RegularExpressions.Linq.PatternFactory;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

internal sealed class LineInfoBuilder
{
    private int _index;
    private RegexOptions _currentOptions;
    private RegexOptions _maxOptions;

    private static readonly Regex _newLineRegex = NonbacktrackingGroup(NewLine()).ToRegex();

    public string AddComments(string pattern, PatternSettings settings)
    {
        _index = 0;
        var sb = new StringBuilder();
        Dictionary<RegexOptions, string> spaces = CreateSpaces(_maxOptions);
        string[] splits = _newLineRegex.Split(pattern);
        int maxLength = splits.Max(f => f.Length);
        var isFirst = true;

        foreach (string split in splits)
        {
            if (isFirst)
            {
                isFirst = false;
            }
            else
            {
                sb.Append(settings.NewLine);
            }

            sb.Append(split);
            AppendComment(sb, spaces, maxLength - split.Length + 1);
            _index++;
        }

        return sb.ToString();
    }

    private void AppendComment(StringBuilder sb, Dictionary<RegexOptions, string> spaces, int indexOffset)
    {
        sb.Append(' ', indexOffset);
        sb.Append("# ");

        if (_maxOptions != RegexOptions.None)
            AppendOptionsChars(sb, spaces, CurrentLine.Options);

        sb.Append(GetComment());

        if (CurrentLine.QuantifierKind != QuantifierKind.None)
        {
            sb.Append(' ');
            sb.Append(GetQuantifierComment(CurrentLine.QuantifierKind));

            if (CurrentLine.Lazy)
                sb.Append(" but as few times as possible");
        }
    }

    private static Dictionary<RegexOptions, string> CreateSpaces(RegexOptions options)
    {
        return new Dictionary<RegexOptions, string>()
        {
            [RegexOptions.None] = (options.IsNone()) ? "" : " ",
            [RegexOptions.IgnoreCase] = (options.HasIgnoreCase()) ? " " : "",
            [RegexOptions.Multiline] = (options.HasMultiline()) ? " " : "",
            [RegexOptions.ExplicitCapture] = (options.HasExplicitCapture()) ? " " : "",
            [RegexOptions.Singleline] = (options.HasSingleline()) ? " " : "",
            [RegexOptions.IgnorePatternWhitespace] = (options.HasIgnorePatternWhitespace()) ? " " : ""
        };
    }

    private void AppendOptionsChars(StringBuilder sb, Dictionary<RegexOptions, string> spaces, RegexOptions options)
    {
        sb.Append((options.HasIgnoreCase()) ? "i" : spaces[RegexOptions.IgnoreCase]);
        sb.Append((options.HasMultiline()) ? "m" : spaces[RegexOptions.Multiline]);
        sb.Append((options.HasExplicitCapture()) ? "n" : spaces[RegexOptions.ExplicitCapture]);
        sb.Append((options.HasSingleline()) ? "s" : spaces[RegexOptions.Singleline]);
        sb.Append((options.HasIgnorePatternWhitespace()) ? "x" : spaces[RegexOptions.IgnorePatternWhitespace]);
        sb.Append(spaces[RegexOptions.None]);
    }

    private string GetComment()
    {
        if (CurrentLine.Kind == SyntaxKind.GroupEnd && CurrentLine.QuantifierKind != QuantifierKind.None)
        {
            return "group";
        }
        else if (CurrentLine.Kind == SyntaxKind.Character)
        {
            int ch = ((CharLineInfo)CurrentLine).CharNumber;
            if (ch >= 0 && ch < 128)
                return AsciiCharNames.GetName((AsciiChar)ch);
        }
        else if (CurrentLine.Kind == SyntaxKind.GeneralCategory || CurrentLine.Kind == SyntaxKind.NotGeneralCategory)
        {
            return _comments[(int)CurrentLine.Kind] + " " + ((GeneralCategoryLineInfo)CurrentLine).Category.ToString();
        }
        else if (CurrentLine.Kind == SyntaxKind.NegativeCharGroup)
        {
            int ch = ((CharLineInfo)CurrentLine).CharNumber;
            if (ch >= 0)
            {
                if (ch < 128)
                {
                    return "not " + AsciiCharNames.GetName((AsciiChar)ch);
                }
                else
                {
                    return "not character";
                }
            }
        }

        return _comments[(int)CurrentLine.Kind];
    }

    private string GetQuantifierComment(QuantifierKind kind)
    {
        return kind switch
        {
            QuantifierKind.Maybe => "zero or one time",
            QuantifierKind.MaybeMany => "zero or more times",
            QuantifierKind.OneMany => "one or more times",
            QuantifierKind.Count => $"exactly {CurrentLine.Count1} times",
            QuantifierKind.CountRange => $"from {CurrentLine.Count1} to {CurrentLine.Count2} times",
            QuantifierKind.CountFrom => $"at least {CurrentLine.Count1} times",
            QuantifierKind.MaybeCount => $"from zero to {CurrentLine.Count2} times",
            _ => "",
        };
    }

    public void AddInfo(SyntaxKind kind)
    {
        Lines.Add(new LineInfo(kind, CurrentOptions));
    }

    public void AddInfo(SyntaxKind kind, char character)
    {
        Lines.Add(new CharLineInfo(kind, character, CurrentOptions));
    }

    public void AddInfo(GeneralCategory category, bool negative)
    {
        Lines.Add(new GeneralCategoryLineInfo((negative) ? SyntaxKind.NotGeneralCategory : SyntaxKind.GeneralCategory, category, CurrentOptions));
    }

    public void AddInfo(string value)
    {
        if (value.Length > 1)
        {
            AddInfo(SyntaxKind.Text);
        }
        else
        {
            AddInfo(SyntaxKind.Character, value[0]);
        }
    }

    public void AddInfo(string value, int count)
    {
        AddInfo(value, 0, count);
    }

    public void AddInfo(string value, int startIndex, int count)
    {
        if (count > 1)
        {
            AddInfo(SyntaxKind.Text);
        }
        else
        {
            AddInfo(SyntaxKind.Character, value[startIndex]);
        }
    }

    public List<LineInfo> Lines { get; } = new();
    public LineInfo CurrentLine => Lines[_index];
    public LineInfo LastLine => Lines[Lines.Count - 1];

    public RegexOptions CurrentOptions
    {
        get { return _currentOptions; }
        set
        {
            _maxOptions |= value;
            _currentOptions = value;
        }
    }

    private static readonly string[] _comments = new[] {
        "any character",
        "any character except linefeed",
        "positive lookahead assertion",
        "positive lookbehind assertion",
        "balancing group",
        "beginning of input",
        "beginning of input or line",
        "character",
        "character group",
        "digit",
        "end of input",
        "end of input or before ending linefeed",
        "end of input or line",
        "Unicode category",
        "numbered group",
        "group end",
        "group options",
        "group reference",
        "if assert",
        "if group",
        "Unicode block",
        "named group",
        "negative lookahead assertion",
        "negative lookbehind assertion",
        "negative character group",
        "negative word boundary",
        "nonbacktracking group",
        "noncapturing group",
        "non-digit",
        "not Unicode category",
        "not Unicode block",
        "non-white-space",
        "non-word character",
        "options",
        "or",
        "previous match end",
        "text",
        "white-space",
        "word boundary",
        "word character"
    };
}
