// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Provides enumerated values to use when converting a text to a language literal.
    /// </summary>
    public enum LiteralOptions
    {
        /// <summary>
        /// Specifies that no options are set.
        /// </summary>
        None = 0,

        /// <summary>
        /// Specifies that new line literal is at the beginning of line.
        /// </summary>
        ConcatAtBeginningOfLine = 1,

        /// <summary>
        /// Specifies multiline language literal.
        /// </summary>
        Multiline = 2,

        /// <summary>
        /// Specifies verbatim language literal. This option is relevant for a C# only.
        /// </summary>
        Verbatim = 4
    }
}
