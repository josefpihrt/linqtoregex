// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Specifies whether a content will be enclosed in a certain kind of a group construct.
    /// </summary>
    internal enum GroupMode
    {
        /// <summary>
        /// Specifies that a content will not be enclosed in the group.
        /// </summary>
        None = 0,

        /// <summary>
        /// Specifies that a content will be enclosed in the group.
        /// </summary>
        Group = 1,

        /// <summary>
        /// Specifies that a content will be enclosed in the noncapturing group.
        /// </summary>
        NoncapturingGroup = 2,
    }
}
