// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Pihrtsoft.Text.RegularExpressions.Linq.Extensions;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal static class RegexReplace
    {
        public static string ReplaceGroups(Regex regex, string input, string groupName, GroupEvaluator evaluator)
        {
            return ReplaceGroups(input, regex.EnumerateSuccessGroups(input, groupName), evaluator, regex.RightToLeft);
        }

        public static string ReplaceGroups(Regex regex, string input, int groupNumber, GroupEvaluator evaluator)
        {
            return ReplaceGroups(input, regex.EnumerateSuccessGroups(input, groupNumber), evaluator, regex.RightToLeft);
        }

        private static string ReplaceGroups(string input, IEnumerable<Group> groups, GroupEvaluator evaluator, bool rightToLeft)
        {
            if (rightToLeft)
                groups = groups.Reverse();

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
