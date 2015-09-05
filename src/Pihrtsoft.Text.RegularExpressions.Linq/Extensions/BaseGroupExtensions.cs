// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Provides a set of static methods that extends <see cref="IBaseGroup"/> interface.
    /// </summary>
    public static class BaseGroupExtensions
    {
        /// <summary>
        /// Returns a pattern that matches a character from a specified base group except characters from a specified excluded group.
        /// </summary>
        /// <param name="baseGroup">A base group.</param>
        /// <param name="excludedGroup">An excluded group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="baseGroup"/> or <paramref name="excludedGroup"/> is <c>null</c>.</exception>
        public static CharSubtraction Except(this IBaseGroup baseGroup, IExcludedGroup excludedGroup)
        {
            return new CharSubtraction(baseGroup, excludedGroup);
        }
    }
}
