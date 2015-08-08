// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
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
    }
}
