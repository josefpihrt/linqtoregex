// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal static class RegexSplit
    {
        public static IEnumerable<string> EnumerateValues(Regex regex, string input)
        {
            return EnumerateValues(regex, input, SplitOptions.None);
        }

        public static IEnumerable<string> EnumerateValues(Regex regex, string input, SplitOptions options)
        {
            return EnumerateValues(regex, input, 0, options);
        }

        public static IEnumerable<string> EnumerateValues(Regex regex, string input, int count)
        {
            return EnumerateValues(regex, input, count, SplitOptions.None);
        }

        public static IEnumerable<string> EnumerateValues(Regex regex, string input, int count, SplitOptions options)
        {
            return EnumerateValues(regex, input, count, regex.RightToLeft ? input.Length : 0, options);
        }

        public static IEnumerable<string> EnumerateValues(Regex regex, string input, int count, int startAt)
        {
            return EnumerateValues(regex, input, count, startAt, SplitOptions.None);
        }

        public static IEnumerable<string> EnumerateValues(Regex regex, string input, int count, int startAt, SplitOptions options)
        {
            if (regex == null)
                throw new ArgumentNullException(nameof(regex));

            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (startAt < 0 || startAt > input.Length)
                throw new ArgumentOutOfRangeException(nameof(startAt));

            if (count == 1)
            {
                yield return input;
                yield break;
            }

            Match firstMatch = regex.Match(input, startAt);

            if (!firstMatch.Success)
            {
                yield return input;
                yield break;
            }

            bool omitGroups = (options & SplitOptions.OmitGroupValues) != 0;
            bool omitEmptyValues = (options & SplitOptions.OmitEmptyValues) != 0;
            int prevIndex = 0;

            foreach (var match in EnumerateMatches(firstMatch, count, regex.RightToLeft))
            {
                if (!omitEmptyValues || ((match.Index - prevIndex) > 0))
                    yield return input.Substring(prevIndex, match.Index - prevIndex);

                prevIndex = match.Index + match.Length;

                if (!omitGroups)
                {
                    foreach (Group group in EnumerateGroups(match.Groups, regex.RightToLeft))
                    {
                        if (group.Success && (!omitEmptyValues || group.Length > 0))
                            yield return group.Value;
                    }
                }
            }

            yield return input.Substring(prevIndex, input.Length - prevIndex);
        }

        private static IEnumerable<Group> EnumerateGroups(GroupCollection groups, bool rightToLeft)
        {
            if (rightToLeft)
            {
                for (int i = (groups.Count - 1); i >= 1; i--)
                    yield return groups[i];
            }
            else
            {
                for (int i = 1; i < groups.Count; i++)
                    yield return groups[i];
            }
        }

        private static IEnumerable<Match> EnumerateMatches(Match match, int count, bool rightToLeft)
        {
            count--;

            if (rightToLeft)
            {
                var matches = new List<Match>();
                while (match.Success)
                {
                    matches.Add(match);

                    count--;

                    if (count == 0)
                        break;

                    match = match.NextMatch();
                }

                for (int i = (matches.Count - 1); i >= 0; i--)
                    yield return matches[i];
            }
            else
            {
                while (match.Success)
                {
                    yield return match;

                    count--;

                    if (count == 0)
                        yield break;

                    match = match.NextMatch();
                }
            }
        }
    }
}
