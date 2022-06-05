// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq.Extensions
{
    /// <summary>
    /// Provides a set of static methods that extends the <see cref="Match"/> class.
    /// </summary>
    public static class MatchExtensions
    {
        /// <summary>
        /// Returns a group that has a specified name and it is contained in a specified match.
        /// </summary>
        /// <param name="match">A regular expression match.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <exception cref="ArgumentNullException"><paramref name="match"/> is <c>null</c>.</exception>
        public static Group Group(this Match match, string groupName)
        {
            if (match is null)
                throw new ArgumentNullException(nameof(match));

            return match.Groups[groupName];
        }

        /// <summary>
        /// Returns a group that has a specified number and it is contained in a specified match.
        /// </summary>
        /// <param name="match">A regular expression match.</param>
        /// <param name="groupNumber">A number of the group.</param>
        /// <exception cref="ArgumentNullException"><paramref name="match"/> is <c>null</c>.</exception>
        public static Group Group(this Match match, int groupNumber)
        {
            if (match is null)
                throw new ArgumentNullException(nameof(match));

            return match.Groups[groupNumber];
        }

        /// <summary>
        /// Returns enumerable collection of group of a specified match.
        /// </summary>
        /// <param name="match">A regular expression match.</param>
        /// <exception cref="ArgumentNullException"><paramref name="match"/> is <c>null</c>.</exception>
        public static IEnumerable<Group> EnumerateGroups(this Match match)
        {
            if (match is null)
                throw new ArgumentNullException(nameof(match));

            return EnumerateGroups();

            IEnumerable<Group> EnumerateGroups()
            {
                for (int i = 0; i < match.Groups.Count; i++)
                    yield return match.Groups[i];
            }
        }

        /// <summary>
        /// Enumerates through groups of a specified match and returns each capture from each group.
        /// </summary>
        /// <param name="match">A regular expression match.</param>
        /// <exception cref="ArgumentNullException"><paramref name="match"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this Match match)
        {
            if (match is null)
                throw new ArgumentNullException(nameof(match));

            return EnumerateCaptures();

            IEnumerable<Capture> EnumerateCaptures()
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
        /// Returns an enumerable collection of captures of a group with a specified name that is from a specified match.
        /// </summary>
        /// <param name="match">A regular expression match.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <exception cref="ArgumentNullException"><paramref name="match"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this Match match, string groupName)
        {
            if (match is null)
                throw new ArgumentNullException(nameof(match));

            return EnumerateCaptures();

            IEnumerable<Capture> EnumerateCaptures()
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
        /// Returns an enumerable collection of captures of a group with a specified number that is from a specified match.
        /// </summary>
        /// <param name="match">A regular expression match.</param>
        /// <param name="groupNumber">A number of the group.</param>
        /// <exception cref="ArgumentNullException"><paramref name="match"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this Match match, int groupNumber)
        {
            if (match is null)
                throw new ArgumentNullException(nameof(match));

            return EnumerateCaptures();

            IEnumerable<Capture> EnumerateCaptures()
            {
                Group group = match.Groups[groupNumber];
                if (group.Success)
                {
                    for (int i = 0; i < group.Captures.Count; i++)
                        yield return group.Captures[i];
                }
            }
        }
    }
}
