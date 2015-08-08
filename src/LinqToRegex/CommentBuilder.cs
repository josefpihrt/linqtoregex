// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class CommentBuilder
    {
        private int _index;
        private StringBuilder _sb;
        private LineInfoCollection _lines;

        private static readonly Regex _newLineRegex = Patterns.NewLine().ToRegex();

        public string AddComments(string pattern, LineInfoCollection lines)
        {
            _index = 0;
            _sb = new StringBuilder();
            _lines = lines;
            var splits = _newLineRegex.Split(pattern);
            int maxLength = splits.Max(f => f.Length);

            foreach (var split in splits)
            {
                _sb.Append(split);
                AppendComment(maxLength - split.Length + 1);
                _sb.AppendLine();
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

            return _comments[(int)Current.Kind];
        }

        private static string GetQuantifierComment(QuantifierKind kind)
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
                    return "exactly n times";
                case QuantifierKind.CountRange:
                    return "from n to m times";
                case QuantifierKind.CountFrom:
                    return "at least n times";
                case QuantifierKind.MaybeCount:
                    return "from zero to n times";
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
