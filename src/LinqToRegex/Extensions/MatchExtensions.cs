// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
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
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Group Group(this Match match, string groupName)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            return match.Groups[groupName];
        }

        /// <summary>
        /// Returns a group that has a specified number and it is contained in a specified match.
        /// </summary>
        /// <param name="match">A regular expression match.</param>
        /// <param name="groupNumber">A number of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Group Group(this Match match, int groupNumber)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            return match.Groups[groupNumber];
        }

        /// <summary>
        /// Returns an enumerable collection of captures from a specified match.
        /// </summary>
        /// <param name="match">A regular expression match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="match"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this Match match)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            return match.Captures.Cast<Capture>();
        }

        /// <summary>
        /// Returns an enumerable collection of captures from a group with a specified name that is from a specified match.
        /// </summary>
        /// <param name="match">A regular expression match.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="match"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this Match match, string groupName)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }

            return match.Groups[groupName].Captures.Cast<Capture>();
        }

        /// <summary>
        /// Returns an enumerable collection of captures from a group with a specified number that is from a specified match.
        /// </summary>
        /// <param name="match">A regular expression match.</param>
        /// <param name="groupNumber">A number of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="match"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this Match match, int groupNumber)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            return match.Groups[groupNumber].Captures.Cast<Capture>();
        }
    }
}
