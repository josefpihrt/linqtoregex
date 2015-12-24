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

            bool omitGroupValues = (options & SplitOptions.OmitGroupValues) != 0;
            bool omitEmptyValues = (options & SplitOptions.OmitEmptyValues) != 0;
            int prevIndex = 0;

            count--;

            foreach (Match match in (regex.RightToLeft) ? EnumerateMatchesRightToLeft(firstMatch, count) : EnumerateMatches(firstMatch, count))
            {
                if (!omitEmptyValues || ((match.Index - prevIndex) > 0))
                    yield return input.Substring(prevIndex, match.Index - prevIndex);

                prevIndex = match.Index + match.Length;

                if (!omitGroupValues)
                {
                    foreach (Group group in (regex.RightToLeft) ? EnumerateGroupsRightToLeft(match) : EnumerateGroups(match))
                    {
                        if (group.Success && (!omitEmptyValues || group.Length > 0))
                            yield return group.Value;
                    }
                }
            }

            yield return input.Substring(prevIndex, input.Length - prevIndex);
        }

        private static IEnumerable<Group> EnumerateGroups(Match match)
        {
            for (int i = 1; i < match.Groups.Count; i++)
                yield return match.Groups[i];
        }

        private static IEnumerable<Group> EnumerateGroupsRightToLeft(Match match)
        {
            for (int i = (match.Groups.Count - 1); i >= 1; i--)
                yield return match.Groups[i];
        }

        private static IEnumerable<Match> EnumerateMatches(Match match, int count)
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

        private static IEnumerable<Match> EnumerateMatchesRightToLeft(Match match, int count)
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
    }
}
