// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
#if DEBUG
    internal static class RegexSplit
    {
        public static IEnumerable<string> EnumerateValues(Regex regex, string input)
        {
            Match firstMatch = regex.Match(input);
            if (!firstMatch.Success)
            {
                yield return input;
                yield break;
            }

            int prevIndex = 0;

            foreach (var match in EnumerateMatches(firstMatch, regex.RightToLeft))
            {
                yield return input.Substring(prevIndex, match.Index - prevIndex);
                prevIndex = match.Index + match.Length;

                if (regex.RightToLeft)
                {
                    for (int i = (match.Groups.Count - 1); i >= 1; i--)
                    {
                        if (match.Groups[i].Index != 0)
                        {
                            var group = match.Groups[i];
                            if (group.Success)
                            {
                                yield return group.Value;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < match.Groups.Count; i++)
                    {
                        var group = match.Groups[i];
                        if (group.Success)
                        {
                            yield return group.Value;
                        }
                    }
                }
            }

            yield return input.Substring(prevIndex, input.Length - prevIndex);
        }

        private static IEnumerable<Match> EnumerateMatches(Match match, bool rightToLeft)
        {
            if (rightToLeft)
            {
                var matches = new List<Match>();
                while (match.Success)
                {
                    matches.Add(match);
                    match = match.NextMatch();
                }

                for (int i = (matches.Count - 1); i >= 0; i--)
                {
                    yield return matches[i];
                }
            }
            else
            {
                var matches = new List<Match>();
                while (match.Success)
                {
                    yield return match;
                    match = match.NextMatch();
                }
            }
        }
    }
#endif
}
