// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal static class RegexReplace
    {
        public static string ReplaceGroup(string input, IEnumerable<Group> groups, string replacement)
        {
            if (replacement == null)
                throw new ArgumentNullException(nameof(replacement));

            return ReplaceGroup(input, groups, group => replacement);
        }

        public static string ReplaceGroup(string input, IEnumerable<Group> groups, GroupEvaluator evaluator)
        {
            if (evaluator == null)
                throw new ArgumentNullException(nameof(evaluator));

            var sb = new StringBuilder();
            int index = 0;

            foreach (Group group in groups)
            {
                sb.Append(input, index, group.Index - index);
                sb.Append(evaluator(group));
                index = group.Index + group.Length;
            }

            sb.Append(input, index, input.Length - index);

            return sb.ToString();
        }
    }
}
