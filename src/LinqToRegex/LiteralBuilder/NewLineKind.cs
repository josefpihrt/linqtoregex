// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Specifies a character or a combination of characters that are used to create new line.
    /// </summary>
    public enum NewLineKind
    {
        /// <summary>
        /// A linefeed character.
        /// </summary>
        Linefeed,

        /// <summary>
        /// A combination of a carriage return and a linefeed.
        /// </summary>
        CarriageReturnLinefeed,

        /// <summary>
        /// New line characters are specified by <see cref="Environment.NewLine"/> property.
        /// </summary>
        Environment
    }
}
