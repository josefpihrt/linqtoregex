// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Specifies which characters will be used to surround group name in the named group, balancing group and named group backreference.
    /// </summary>
    public enum IdentifierBoundary
    {
        /// <summary>
        /// Group name will be surrounded with less-than character on the left side and greater-than character on the right side.
        /// </summary>
        AngleBrackets = 0,

        /// <summary>
        /// Group name will be surrounded with apostrophes.
        /// </summary>
        Apostrophe = 1,
    }
}
