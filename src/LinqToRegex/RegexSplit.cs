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
            return EnumerateValues(regex, input, 0);
        }

        public static IEnumerable<string> EnumerateValues(Regex regex, string input, int count)
        {
            if (regex == null)
                throw new ArgumentNullException(nameof(regex));

            return EnumerateValues(regex, input, count, regex.RightToLeft ? input.Length : 0);
        }

        public static IEnumerable<string> EnumerateValues(Regex regex, string input, int count, int startAt)
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

            int prevIndex = 0;

            foreach (var match in EnumerateMatches(firstMatch, count, regex.RightToLeft))
            {
                yield return input.Substring(prevIndex, match.Index - prevIndex);
                prevIndex = match.Index + match.Length;

                if (regex.RightToLeft)
                {
                    for (int i = (match.Groups.Count - 1); i >= 1; i--)
                    {
                        if (match.Groups[i].Success)
                            yield return match.Groups[i].Value;
                    }
                }
                else
                {
                    for (int i = 1; i < match.Groups.Count; i++)
                    {
                        if (match.Groups[i].Success)
                            yield return match.Groups[i].Value;
                    }
                }
            }

            yield return input.Substring(prevIndex, input.Length - prevIndex);
        }

#if DEBUG
        public static IEnumerable<string> EnumerateValues(Regex regex, string input, SplitOptions options)
        {
            return EnumerateValues(regex, input, 0, options);
        }

        public static IEnumerable<string> EnumerateValues(Regex regex, string input, int count, SplitOptions options)
        {
            if (regex == null)
                throw new ArgumentNullException(nameof(regex));

            return EnumerateValues(regex, input, count, regex.RightToLeft ? input.Length : 0, options);
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

            bool fIgnoreGroups = (options & SplitOptions.IgnoreGroups) != 0;
            int prevIndex = 0;

            foreach (var match in EnumerateMatches(firstMatch, count, regex.RightToLeft))
            {
                yield return input.Substring(prevIndex, match.Index - prevIndex);
                prevIndex = match.Index + match.Length;

                if (!fIgnoreGroups)
                {
                    if (regex.RightToLeft)
                    {
                        for (int i = (match.Groups.Count - 1); i >= 1; i--)
                        {
                            if (match.Groups[i].Success)
                                yield return match.Groups[i].Value;
                        }
                    }
                    else
                    {
                        for (int i = 1; i < match.Groups.Count; i++)
                        {
                            if (match.Groups[i].Success)
                                yield return match.Groups[i].Value;
                        }
                    }
                }
            }

            yield return input.Substring(prevIndex, input.Length - prevIndex);
        }
#endif

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
