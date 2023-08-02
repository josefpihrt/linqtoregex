// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static Pihrtsoft.Text.RegularExpressions.PatternFactory;

namespace Pihrtsoft.Text.RegularExpressions.Rendering;

internal sealed class LineInfoBuilder
{
    private int _index;
    private RegexOptions _currentOptions;
    private RegexOptions _maxOptions;

    private static readonly Regex _newLineRegex = NonbacktrackingGroup(NewLine()).ToRegex();

    public string AddComments(string pattern, PatternOptions options)
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
                sb.Append(options.NewLine);
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
                return _asciiCharNames[ch];
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
                    return "not " + _asciiCharNames[ch];
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

    private static readonly string[] _asciiCharNames = new[] {
        "null",
        "start of heading",
        "start of text",
        "end of text",
        "end of transmission",
        "enquiry",
        "acknowledge",
        "bell",
        "backspace",
        "tab",
        "linefeed",
        "vertical tab",
        "form feed",
        "carriage return",
        "shift out",
        "shift in",
        "data link escape",
        "device control one",
        "device control two",
        "device control three",
        "device control four",
        "negative acknowledge",
        "synchronous idle",
        "end of transmission block",
        "cancel",
        "end of medium",
        "substitute",
        "escape",
        "information separator four",
        "information separator three",
        "information separator two",
        "information separator one",
        "space",
        "exclamation mark",
        "quote mark",
        "number sign",
        "dollar",
        "percent",
        "ampersand",
        "apostrophe",
        "left parenthesis",
        "right parenthesis",
        "asterisk",
        "plus",
        "comma",
        "hyphen",
        "dot",
        "slash",
        "digit zero",
        "digit one",
        "digit two",
        "digit three",
        "digit four",
        "digit five",
        "digit six",
        "digit seven",
        "digit eight",
        "digit nine",
        "colon",
        "semicolon",
        "left angle bracket",
        "equals sign",
        "right angle bracket",
        "question mark",
        "at sign",
        "capital letter a",
        "capital letter b",
        "capital letter c",
        "capital letter d",
        "capital letter e",
        "capital letter f",
        "capital letter g",
        "capital letter h",
        "capital letter i",
        "capital letter j",
        "capital letter k",
        "capital letter l",
        "capital letter m",
        "capital letter n",
        "capital letter o",
        "capital letter p",
        "capital letter q",
        "capital letter r",
        "capital letter s",
        "capital letter t",
        "capital letter u",
        "capital letter v",
        "capital letter w",
        "capital letter x",
        "capital letter y",
        "capital letter z",
        "left square bracket",
        "backslash",
        "right square bracket",
        "circumflex accent",
        "underscore",
        "grave accent",
        "small letter a",
        "small letter b",
        "small letter c",
        "small letter d",
        "small letter e",
        "small letter f",
        "small letter g",
        "small letter h",
        "small letter i",
        "small letter j",
        "small letter k",
        "small letter l",
        "small letter m",
        "small letter n",
        "small letter o",
        "small letter p",
        "small letter q",
        "small letter r",
        "small letter s",
        "small letter t",
        "small letter u",
        "small letter v",
        "small letter w",
        "small letter x",
        "small letter y",
        "small letter z",
        "left curly bracket",
        "vertical bar",
        "right curly bracket",
        "tilde",
        "delete"
    };
}
