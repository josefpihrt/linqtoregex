// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
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
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IEnumerable<Group> EnumerateGroups(this IEnumerable<Match> matches)
        {
            if (matches == null)
            {
                throw new ArgumentNullException(nameof(matches));
            }

            return matches.SelectMany(match => match.Groups.Cast<Group>());
        }

        /// <summary>
        /// Returns an enumerable collection of groups with a specified name.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IEnumerable<Group> EnumerateGroups(this IEnumerable<Match> matches, string groupName)
        {
            if (matches == null)
            {
                throw new ArgumentNullException(nameof(matches));
            }

            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }

            return matches.Select(match => match.Groups[groupName]);
        }

        /// <summary>
        /// Returns an enumerable collection of groups with a specified number.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <param name="groupNumber">A number of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static IEnumerable<Group> EnumerateGroups(this IEnumerable<Match> matches, int groupNumber)
        {
            if (matches == null)
            {
                throw new ArgumentNullException(nameof(matches));
            }

            if (groupNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(groupNumber));
            }

            return matches.Select(match => match.Groups[groupNumber]);
        }

        /// <summary>
        /// Returns an enumerable collection of groups that have at least one capture.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IEnumerable<Group> EnumerateSuccessGroups(this IEnumerable<Match> matches)
        {
            return EnumerateGroups(matches)
                .Where(group => group.Success);
        }

        /// <summary>
        /// Returns an enumerable collection of groups thas have a specified name and have at least one capture.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static IEnumerable<Group> EnumerateSuccessGroups(this IEnumerable<Match> matches, string groupName)
        {
            return EnumerateGroups(matches, groupName)
                .Where(group => group.Success);
        }

        /// <summary>
        /// Returns an enumerable collection of groups that have a specified name and have at least one capture.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <param name="groupNumber">A number of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static IEnumerable<Group> EnumerateSuccessGroups(this IEnumerable<Match> matches, int groupNumber)
        {
            return EnumerateGroups(matches, groupNumber)
                .Where(group => group.Success);
        }

        /// <summary>
        /// Returns an enumerable collection of captures.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IEnumerable<Capture> EnumerateCaptures(this IEnumerable<Match> matches)
        {
            return EnumerateSuccessGroups(matches)
                .EnumerateCaptures();
        }

        /// <summary>
        /// Returns an enumerable collection of captures from groups thas have a specified name.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static IEnumerable<Capture> EnumerateCaptures(this IEnumerable<Match> matches, string groupName)
        {
            return EnumerateSuccessGroups(matches, groupName)
                .EnumerateCaptures();
        }

        /// <summary>
        /// Returns an enumerable collection of captures from groups that have a specified number.
        /// </summary>
        /// <param name="matches">The sequence to enumerate.</param>
        /// <param name="groupNumber">A number of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static IEnumerable<Capture> EnumerateCaptures(this IEnumerable<Match> matches, int groupNumber)
        {
            return EnumerateSuccessGroups(matches, groupNumber)
                .EnumerateCaptures();
        }

        /// <summary>
        /// Returns an enumerable collection of captures.
        /// </summary>
        /// <param name="groups">The sequence to enumerate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IEnumerable<Capture> EnumerateCaptures(this IEnumerable<Group> groups)
        {
            if (groups == null)
            {
                throw new ArgumentNullException(nameof(groups));
            }

            return groups.SelectMany(group => group.Captures.Cast<Capture>());
        }

        /// <summary>
        /// Returns enumerable collection of captures values.
        /// </summary>
        /// <param name="collection">The sequence to enumerate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IEnumerable<string> EnumerateValues(this IEnumerable<Capture> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            return collection.Select(capture => capture.Value);
        }
    }
}
