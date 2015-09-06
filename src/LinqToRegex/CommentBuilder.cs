// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static Pihrtsoft.Text.RegularExpressions.Linq.Patterns;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class CommentBuilder
    {
        private int _index;
        private StringBuilder _sb;
        private LineInfoCollection _lines;

        private static readonly Regex _newLineRegex = NonbacktrackingGroup(NewLine()).ToRegex();

        public string AddComments(string pattern, LineInfoCollection lines, PatternSettings settings)
        {
            _index = 0;
            _sb = new StringBuilder();
            _lines = lines;
            string newLine = settings.NewLine;
            var splits = _newLineRegex.Split(pattern);
            int maxLength = splits.Max(f => f.Length);
            bool isFirst = true;

            foreach (var split in splits)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    _sb.Append(newLine);
                }

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
            _sb.Append(GetComment());

            if (Current.QuantifierKind != QuantifierKind.None)
            {
                _sb.Append(' ');
                _sb.Append(GetQuantifierComment(Current.QuantifierKind));

                if (Current.Lazy)
                {
                    _sb.Append(" but as few times as possible");
                }
            }
        }

        private string GetComment()
        {
            if (Current.Kind == SyntaxKind.GroupEnd && Current.QuantifierKind != QuantifierKind.None)
            {
                return "group";
            }
            else if (Current.Kind == SyntaxKind.Character)
            {
                int ch = ((CharLineInfo)Current).CharNumber;
                if (ch >= 0 && ch < 128)
                {
                    return TextUtility.GetAsciiCharName((AsciiChar)ch);
                }
            }
            else if (Current.Kind == SyntaxKind.GeneralCategory || Current.Kind == SyntaxKind.NotGeneralCategory)
            {
                return _comments[(int)Current.Kind] + " " + ((GeneralCategoryLineInfo)Current).Category;
            }
            else if (Current.Kind == SyntaxKind.NegativeCharGroup)
            {
                int ch = ((CharLineInfo)Current).CharNumber;
                if (ch >= 0)
                {
                    if (ch < 128)
                    {
                        return "not " + TextUtility.GetAsciiCharName((AsciiChar)ch);
                    }
                    else
                    {
                        return "not character";
                    }
                }
            }

            return _comments[(int)Current.Kind];
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
                    return $"exactly {Current.Count1} times";
                case QuantifierKind.CountRange:
                    return $"from {Current.Count1} to {Current.Count2} times";
                case QuantifierKind.CountFrom:
                    return $"at least {Current.Count1} times";
                case QuantifierKind.MaybeCount:
                    return $"from zero to {Current.Count2} times";
            }

            return null;
        }

        public LineInfo Current => _lines[_index];

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
