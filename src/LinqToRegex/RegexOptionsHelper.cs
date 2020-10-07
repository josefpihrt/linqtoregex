// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal static class RegexOptionsHelper
    {
        public static RegexOptions GetInlineOptions(RegexOptions options)
        {
            return options
                & ~(
#if NETFRAMEWORK
                RegexOptions.Compiled |
#endif
                RegexOptions.CultureInvariant
                    | RegexOptions.ECMAScript
                    | RegexOptions.RightToLeft);
        }

        public static bool IsNone(this RegexOptions options)
        {
            return options == RegexOptions.None;
        }

        public static bool HasIgnoreCase(this RegexOptions options)
        {
            return (options & RegexOptions.IgnoreCase) != 0;
        }

        public static bool HasMultiline(this RegexOptions options)
        {
            return (options & RegexOptions.Multiline) != 0;
        }

        public static bool HasExplicitCapture(this RegexOptions options)
        {
            return (options & RegexOptions.ExplicitCapture) != 0;
        }

        public static bool HasSingleline(this RegexOptions options)
        {
            return (options & RegexOptions.Singleline) != 0;
        }

        public static bool HasIgnorePatternWhitespace(this RegexOptions options)
        {
            return (options & RegexOptions.IgnorePatternWhitespace) != 0;
        }
    }
}
