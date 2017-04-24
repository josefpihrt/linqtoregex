// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Specifies a character class.
    /// </summary>
    internal enum CharClass
    {
        /// <summary>
        /// None character class.
        /// </summary>
        None = 0,

        /// <summary>
        /// Digit character class.
        /// </summary>
        Digit = 1,

        /// <summary>
        /// Word character class.
        /// </summary>
        WordChar = 2,

        /// <summary>
        /// White-space character class.
        /// </summary>
        WhiteSpace = 3,

        /// <summary>
        /// Non-digit character class.
        /// </summary>
        NotDigit = 4,

        /// <summary>
        /// Non-word character class.
        /// </summary>
        NotWordChar = 5,

        /// <summary>
        /// Non-whitespace character class.
        /// </summary>
        NotWhiteSpace = 6
    }
}
