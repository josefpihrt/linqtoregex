// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq.Extensions
{
    /// <summary>
    /// Provides a set of static methods that extends the <see cref="IEnumerable&lt;T&gt;"/> whose generic type argument is <see cref="Match"/> or <see cref="Group"/>.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Returns an enumerable collection of groups.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <exception cref="ArgumentNullException"><paramref name="matches"/> is <c>null</c>.</exception>
        public static IEnumerable<Group> EnumerateGroups(this IEnumerable<Match> matches)
        {
            if (matches == null)
                throw new ArgumentNullException(nameof(matches));

            foreach (Match match in matches)
            {
                for (int i = 0; i < match.Groups.Count; i++)
                    yield return match.Groups[i];
            }
        }

        /// <summary>
        /// Returns an enumerable collection of groups with a specified name.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <exception cref="ArgumentNullException"><paramref name="matches"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
        public static IEnumerable<Group> EnumerateGroups(this IEnumerable<Match> matches, string groupName)
        {
            if (matches == null)
                throw new ArgumentNullException(nameof(matches));

            if (groupName == null)
                throw new ArgumentNullException(nameof(groupName));

            foreach (Match match in matches)
                yield return match.Groups[groupName];
        }

        /// <summary>
        /// Returns an enumerable collection of groups with a specified number.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <param name="groupNumber">A number of the group.</param>
        /// <exception cref="ArgumentNullException"><paramref name="matches"/> is <c>null</c>.</exception>
        public static IEnumerable<Group> EnumerateGroups(this IEnumerable<Match> matches, int groupNumber)
        {
            if (matches == null)
                throw new ArgumentNullException(nameof(matches));

            foreach (Match match in matches)
                yield return match.Groups[groupNumber];
        }

        /// <summary>
        /// Returns an enumerable collection of groups that have at least one capture.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <exception cref="ArgumentNullException"><paramref name="matches"/> is <c>null</c>.</exception>
        public static IEnumerable<Group> EnumerateSuccessGroups(this IEnumerable<Match> matches)
        {
            foreach (Match match in matches)
            {
                for (int i = 0; i < match.Groups.Count; i++)
                {
                    Group group = match.Groups[i];

                    if (group.Success)
                        yield return group;
                }
            }
        }

        /// <summary>
        /// Returns an enumerable collection of groups thas have a specified name and have at least one capture.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <exception cref="ArgumentNullException"><paramref name="matches"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
        public static IEnumerable<Group> EnumerateSuccessGroups(this IEnumerable<Match> matches, string groupName)
        {
            foreach (Match match in matches)
            {
                Group group = match.Groups[groupName];

                if (group.Success)
                    yield return group;
            }
        }

        /// <summary>
        /// Returns an enumerable collection of groups that have a specified name and have at least one capture.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <param name="groupNumber">A number of the group.</param>
        /// <exception cref="ArgumentNullException"><paramref name="matches"/> is <c>null</c>.</exception>
        public static IEnumerable<Group> EnumerateSuccessGroups(this IEnumerable<Match> matches, int groupNumber)
        {
            foreach (Match match in matches)
            {
                Group group = match.Groups[groupNumber];

                if (group.Success)
                    yield return group;
            }
        }

        /// <summary>
        /// Returns an enumerable collection of captures.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <exception cref="ArgumentNullException"><paramref name="matches"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this IEnumerable<Match> matches)
        {
            foreach (Match match in matches)
            {
                for (int i = 0; i < match.Groups.Count; i++)
                {
                    Group group = match.Groups[i];
                    if (group.Success)
                    {
                        for (int j = 0; j < group.Captures.Count; j++)
                            yield return group.Captures[j];
                    }
                }
            }
        }

        /// <summary>
        /// Returns an enumerable collection of captures from groups thas have a specified name.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <exception cref="ArgumentNullException"><paramref name="matches"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this IEnumerable<Match> matches, string groupName)
        {
            foreach (Match match in matches)
            {
                Group group = match.Groups[groupName];
                if (group.Success)
                {
                    for (int i = 0; i < group.Captures.Count; i++)
                        yield return group.Captures[i];
                }
            }
        }

        /// <summary>
        /// Returns an enumerable collection of captures from groups that have a specified number.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <param name="groupNumber">A number of the group.</param>
        /// <exception cref="ArgumentNullException"><paramref name="matches"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this IEnumerable<Match> matches, int groupNumber)
        {
            foreach (Match match in matches)
            {
                Group group = match.Groups[groupNumber];
                if (group.Success)
                {
                    for (int i = 0; i < group.Captures.Count; i++)
                        yield return group.Captures[i];
                }
            }
        }

        /// <summary>
        /// Returns an enumerable collection of captures.
        /// </summary>
        /// <param name="groups">The sequence to enumerate.</param>
        /// <exception cref="ArgumentNullException"><paramref name="groups"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this IEnumerable<Group> groups)
        {
            if (groups == null)
                throw new ArgumentNullException(nameof(groups));

            foreach (Group group in groups)
            {
                for (int i = 0; i < group.Captures.Count; i++)
                    yield return group.Captures[i];
            }
        }

        /// <summary>
        /// Returns an enumerable collection of captures indexes.
        /// </summary>
        /// <param name="captures">The sequence to enumerate.</param>
        /// <exception cref="ArgumentNullException"><paramref name="captures"/> is <c>null</c>.</exception>
        public static IEnumerable<int> EnumerateIndexes(this IEnumerable<Capture> captures)
        {
            if (captures == null)
                throw new ArgumentNullException(nameof(captures));

            foreach (Capture capture in captures)
                yield return capture.Index;
        }

        /// <summary>
        /// Returns enumerable collection of captures lengths.
        /// </summary>
        /// <param name="captures">The sequence to enumerate.</param>
        /// <exception cref="ArgumentNullException"><paramref name="captures"/> is <c>null</c>.</exception>
        public static IEnumerable<int> EnumerateLengths(this IEnumerable<Capture> captures)
        {
            if (captures == null)
                throw new ArgumentNullException(nameof(captures));

            foreach (Capture capture in captures)
                yield return capture.Length;
        }

        /// <summary>
        /// Returns enumerable collection of captures values.
        /// </summary>
        /// <param name="captures">The sequence to enumerate.</param>
        /// <exception cref="ArgumentNullException"><paramref name="captures"/> is <c>null</c>.</exception>
        public static IEnumerable<string> EnumerateValues(this IEnumerable<Capture> captures)
        {
            if (captures == null)
                throw new ArgumentNullException(nameof(captures));

            foreach (Capture capture in captures)
                yield return capture.Value;
        }
    }
}
