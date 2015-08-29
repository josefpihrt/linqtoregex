// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq.Extensions
{
    /// <summary>
    /// Provides a set of static methods that extends the <see cref="Regex"/> class.
    /// </summary>
    public static class RegexExtensions
    {
        /// <summary>
        /// Searches the specified input string and returns enumerable collection of regular expression matches.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to search for a match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
        public static IEnumerable<Match> EnumerateMatches(this Regex regex, string input)
        {
            if (regex == null)
            {
                throw new ArgumentNullException(nameof(regex));
            }

            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            Match match = regex.Match(input);
            while (match.Success)
            {
                yield return match;
                match = match.NextMatch();
            }
        }

        /// <summary>
        /// Searches the specified input string beginning at the specified position and returns enumerable collection of regular expression matches.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="startAt">The position at which to start the search.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="startAt"/> is less than zero or greater that the length of <paramref name="input"/>.</exception>
        public static IEnumerable<Match> EnumerateMatches(this Regex regex, string input, int startAt)
        {
            if (regex == null)
            {
                throw new ArgumentNullException(nameof(regex));
            }

            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            Match match = regex.Match(input, startAt);
            while (match.Success)
            {
                yield return match;
                match = match.NextMatch();
            }
        }

        /// <summary>
        /// Searches the specified input string beginning at the specified position and searching only the specified number of characters and returns enumerable collection of regular expression matches.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="beginning">The position at which to start the search.</param>
        /// <param name="length">A number of characters to be searched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static IEnumerable<Match> EnumerateMatches(this Regex regex, string input, int beginning, int length)
        {
            if (regex == null)
            {
                throw new ArgumentNullException(nameof(regex));
            }

            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            Match match = regex.Match(input, beginning, length);
            while (match.Success)
            {
                yield return match;
                match = match.NextMatch();
            }
        }

        /// <summary>
        /// Searches the specified input string and returns enumerable collection of groups.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to search for a match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
        public static IEnumerable<Group> EnumerateGroups(this Regex regex, string input)
        {
            foreach (var match in EnumerateMatches(regex, input))
            {
                for (int i = 0; i < match.Groups.Count; i++)
                {
                    yield return match.Groups[i];
                }
            }
        }

        /// <summary>
        /// Searches the specified input string and returns enumerable collection of groups with a specified name.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
        public static IEnumerable<Group> EnumerateGroups(this Regex regex, string input, string groupName)
        {
            foreach (var match in EnumerateMatches(regex, input))
            {
                yield return match.Groups[groupName];
            }
        }

        /// <summary>
        /// Searches the specified input string and returns enumerable collection of groups that have a specified number.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="groupNumber">A number of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
        public static IEnumerable<Group> EnumerateGroups(this Regex regex, string input, int groupNumber)
        {
            foreach (var match in EnumerateMatches(regex, input))
            {
                yield return match.Groups[groupNumber];
            }
        }

        /// <summary>
        /// Searches the specified input string and returns enumerable collection of groups that have at least one capture.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to search for a match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
        public static IEnumerable<Group> EnumerateSuccessGroups(this Regex regex, string input)
        {
            foreach (var match in EnumerateMatches(regex, input))
            {
                for (int i = 0; i < match.Groups.Count; i++)
                {
                    var group = match.Groups[i];
                    if (group.Success)
                    {
                        yield return group;
                    }
                }
            }
        }

        /// <summary>
        /// Searches the specified input string and returns enumerable collection of groups that have a specified name and have at least one capture.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
        public static IEnumerable<Group> EnumerateSuccessGroups(this Regex regex, string input, string groupName)
        {
            foreach (var match in EnumerateMatches(regex, input))
            {
                var group = match.Groups[groupName];
                if (group.Success)
                {
                    yield return group;
                }
            }
        }

        /// <summary>
        /// Searches the specified input string and returns enumerable collection of groups that have a specified number and have at least one capture.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="groupNumber">A number of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
        public static IEnumerable<Group> EnumerateSuccessGroups(this Regex regex, string input, int groupNumber)
        {
            foreach (var match in EnumerateMatches(regex, input))
            {
                var group = match.Groups[groupNumber];
                if (group.Success)
                {
                    yield return group;
                }
            }
        }

        /// <summary>
        /// Searches the specified input string and returns enumerable collection of captures.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to search for a match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this Regex regex, string input)
        {
            foreach (var match in EnumerateMatches(regex, input))
            {
                for (int i = 0; i < match.Groups.Count; i++)
                {
                    var group = match.Groups[i];
                    if (group.Success)
                    {
                        for (int j = 0; j < group.Captures.Count; j++)
                        {
                            yield return group.Captures[j];
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Searches the specified input string and returns enumerable collection of captures from groups that have a specified name.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this Regex regex, string input, string groupName)
        {
            foreach (var match in EnumerateMatches(regex, input))
            {
                var group = match.Groups[groupName];
                if (group.Success)
                {
                    for (int i = 0; i < group.Captures.Count; i++)
                    {
                        yield return group.Captures[i];
                    }
                }
            }
        }

        /// <summary>
        /// Searches the specified input string and returns enumerable collection of captures from groups that have a specified number.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="groupNumber">A number of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this Regex regex, string input, int groupNumber)
        {
            foreach (var match in EnumerateMatches(regex, input))
            {
                var group = match.Groups[groupNumber];
                if (group.Success)
                {
                    for (int i = 0; i < group.Captures.Count; i++)
                    {
                        yield return group.Captures[i];
                    }
                }
            }
        }

#if DEBUG
        public static string ReplaceChars(this Regex regex, string input, char value)
        {
            if (regex == null)
            {
                throw new ArgumentNullException(nameof(regex));
            }

            return regex.Replace(input, match => new string(value, match.Length));
        }

        public static string ReplaceCaptureChars(this Regex regex, string input, string groupName, char value)
        {
            return ReplaceCaptures(regex, input, groupName, capture => new string(value, capture.Length));
        }

        public static string ReplaceCaptures(this Regex regex, string input, string groupName, CaptureEvaluator evaluator)
        {
            if (regex == null)
            {
                throw new ArgumentNullException(nameof(regex));
            }

            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }

            if (evaluator == null)
            {
                throw new ArgumentNullException(nameof(evaluator));
            }

            var sb = new StringBuilder();
            int index = 0;

            foreach (Match match in EnumerateMatches(regex, input))
            {
                foreach (Capture capture in match.EnumerateCaptures(groupName).OrderBy(capture => capture.Index))
                {
                    sb.Append(input, index, capture.Index - index);
                    sb.Append(evaluator(capture));
                    index = capture.Index + capture.Length;
                }
            }

            sb.Append(input, index, input.Length - index);

            return sb.ToString();
        }

        public static string ReplaceCaptures(this Regex regex, string input, int groupNumber, CaptureEvaluator evaluator)
        {
            if (regex == null)
            {
                throw new ArgumentNullException(nameof(regex));
            }

            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (evaluator == null)
            {
                throw new ArgumentNullException(nameof(evaluator));
            }

            var sb = new StringBuilder();
            int index = 0;

            foreach (Match match in EnumerateMatches(regex, input))
            {
                foreach (Capture capture in match.EnumerateCaptures(groupNumber).OrderBy(capture => capture.Index))
                {
                    sb.Append(input, index, capture.Index - index);
                    sb.Append(evaluator(capture));
                    index = capture.Index + capture.Length;
                }
            }

            sb.Append(input, index, input.Length - index);

            return sb.ToString();
        }

        /// <summary>
        /// Splits an input string into an enumerable collection of strings at the positions defined by a regular expression.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to split.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
        public static IEnumerable<string> EnumerateSplit(this Regex regex, string input)
        {
            return RegexSplit.EnumerateValues(regex, input);
        }

        /// <summary>
        /// Splits an input string a specified number of times into an enumerable collection of strings at the positions defined by a regular expression.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to split.</param>
        /// <param name="count">The maximum number of times the input can be split.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="count"/> is less than zero.</exception>
        public static IEnumerable<string> EnumerateSplit(this Regex regex, string input, int count)
        {
            return RegexSplit.EnumerateValues(regex, input, count);
        }

        /// <summary>
        /// Splits an input string a specified number of times into an enumerable collection of strings at the positions defined by a regular expression.
        /// The search starts at a specified position in the input string.
        /// </summary>
        /// <param name="regex">The regular expression to be matched.</param>
        /// <param name="input">The string to split.</param>
        /// <param name="count">The maximum number of times the input can be split.</param>
        /// <param name="startAt">The position in the input string where the search starts.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="count"/> is less than zero.
        /// <para><paramref name="startAt"/> is less than zero or greater than the length of <paramref name="input"/>.</para>
        /// </exception>
        public static IEnumerable<string> EnumerateSplit(this Regex regex, string input, int count, int startAt)
        {
            return RegexSplit.EnumerateValues(regex, input, count, startAt);
        }
#endif
    }
}
