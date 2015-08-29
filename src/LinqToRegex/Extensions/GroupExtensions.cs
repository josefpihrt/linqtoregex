// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq.Extensions
{
    /// <summary>
    /// Provides a set of static methods that extends the <see cref="Group"/> class.
    /// </summary>
    public static class GroupExtensions
    {
        /// <summary>
        /// Returns enumerable collection of captures of a specified group.
        /// </summary>
        /// <param name="group">A regular expression group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="group"/> is <c>null</c>.</exception>
        public static IEnumerable<Capture> EnumerateCaptures(this Group group)
        {
            if (group == null)
            {
                throw new ArgumentNullException(nameof(group));
            }

            for (int i = 0; i < group.Captures.Count; i++)
            {
                yield return group.Captures[i];
            }
        }
    }
}
