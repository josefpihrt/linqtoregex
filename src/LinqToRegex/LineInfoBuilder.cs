// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static Pihrtsoft.Text.RegularExpressions.Linq.Patterns;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class LineInfoBuilder
    {
        private int _index;
        private StringBuilder _sb;
        private RegexOptions _currentOptions;
        private RegexOptions _maxOptions;
        private Dictionary<RegexOptions, string> _spaces;

        private static readonly Regex _newLineRegex = NonbacktrackingGroup(NewLine()).ToRegex();

        public string AddComments(string pattern, PatternSettings settings)
        {
            _index = 0;
            _sb = new StringBuilder();
            _spaces = CreateSpaces(_maxOptions);
            string[] splits = _newLineRegex.Split(pattern);
            int maxLength = splits.Max(f => f.Length);
            bool isFirst = true;

            foreach (string split in splits)
            {
                if (isFirst)
                    isFirst = false;
                else
                    _sb.Append(settings.NewLine);

                _sb.Append(split);
                AppendComment(maxLength - split.Length + 1);
                _index++;
            }

            return _sb.ToString();
        }

        private void AppendComment(int indexOffset)
        {
            _sb.Append(' ', indexOffset);
            _sb.Append("# ");

            if (_maxOptions != RegexOptions.None)
                AppendOptionsChars(CurrentLine.Options);

            _sb.Append(GetComment());

            if (CurrentLine.QuantifierKind != QuantifierKind.None)
            {
                _sb.Append(' ');
                _sb.Append(GetQuantifierComment(CurrentLine.QuantifierKind));

                if (CurrentLine.Lazy)
                    _sb.Append(" but as few times as possible");
            }
        }

        private static Dictionary<RegexOptions, string> CreateSpaces(RegexOptions options)
        {
            return new Dictionary<RegexOptions, string>()
            {
                [RegexOptions.None] = (options.IsNone()) ? string.Empty : " ",
                [RegexOptions.IgnoreCase] = (options.HasIgnoreCase()) ? " " : string.Empty,
                [RegexOptions.Multiline] = (options.HasMultiline()) ? " " : string.Empty,
                [RegexOptions.ExplicitCapture] = (options.HasExplicitCapture()) ? " " : string.Empty,
                [RegexOptions.Singleline] = (options.HasSingleline()) ? " " : string.Empty,
                [RegexOptions.IgnorePatternWhitespace] = (options.HasIgnorePatternWhitespace()) ? " " : string.Empty,
            };
        }

        private void AppendOptionsChars(RegexOptions options)
        {
            _sb.Append((options.HasIgnoreCase()) ? "i" : _spaces[RegexOptions.IgnoreCase]);
            _sb.Append((options.HasMultiline()) ? "m" : _spaces[RegexOptions.Multiline]);
            _sb.Append((options.HasExplicitCapture()) ? "n" : _spaces[RegexOptions.ExplicitCapture]);
            _sb.Append((options.HasSingleline()) ? "s" : _spaces[RegexOptions.Singleline]);
            _sb.Append((options.HasIgnorePatternWhitespace()) ? "x" : _spaces[RegexOptions.IgnorePatternWhitespace]);
            _sb.Append(_spaces[RegexOptions.None]);
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
                return _comments[(int)CurrentLine.Kind] + " " + ((GeneralCategoryLineInfo)CurrentLine).Category;
            }
            else if (CurrentLine.Kind == SyntaxKind.NegativeCharGroup)
            {
                int ch = ((CharLineInfo)CurrentLine).CharNumber;
                if (ch >= 0)
                {
                    if (ch < 128)
                        return "not " + AsciiCharNames.GetName((AsciiChar)ch);
                    else
                        return "not character";
                }
            }

            return _comments[(int)CurrentLine.Kind];
        }

        private string GetQuantifierComment(QuantifierKind kind)
        {
            switch (kind)
            {
                case QuantifierKind.Maybe:
                    return "zero or one time";
                case QuantifierKind.MaybeMany:
                    return "zero or more times";
                case QuantifierKind.OneMany:
                    return "one or more times";
                case QuantifierKind.Count:
                    return $"exactly {CurrentLine.Count1} times";
                case QuantifierKind.CountRange:
                    return $"from {CurrentLine.Count1} to {CurrentLine.Count2} times";
                case QuantifierKind.CountFrom:
                    return $"at least {CurrentLine.Count1} times";
                case QuantifierKind.MaybeCount:
                    return $"from zero to {CurrentLine.Count2} times";
            }

            return null;
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
                AddInfo(SyntaxKind.Text);
            else
                AddInfo(SyntaxKind.Character, value[0]);
        }

        public void AddInfo(string value, int count)
        {
            AddInfo(value, 0, count);
        }

        public void AddInfo(string value, int startIndex, int count)
        {
            if (count > 1)
                AddInfo(SyntaxKind.Text);
            else
                AddInfo(SyntaxKind.Character, value[startIndex]);
        }

        public LineInfoCollection Lines { get; } = new LineInfoCollection();
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

        private static readonly string[] _comments = new string[] {
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
            "word character",
        };
    }
}
