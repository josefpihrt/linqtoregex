// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq.Extensions
{
    /// <summary>
    /// Provides a set of static methods that extends the <see cref="Group"/> class.
    /// </summary>
    public static class GroupExtensions
    {
        /// <summary>
        /// Returns last <see cref="Capture"/> of a specified <see cref="Group"/>.
        /// </summary>
        /// <param name="group">A regular expression group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Capture LastCapture(this Group group)
        {
            if (group == null)
            {
                throw new ArgumentNullException(nameof(group));
            }

            if (group.Captures.Count > 0)
            {
                return group.Captures[group.Captures.Count - 1];
            }

            return null;
        }
    }
}
