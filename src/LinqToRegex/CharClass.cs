// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Specifies a character class.
    /// </summary>
    internal enum CharClass
    {
        /// <summary>
        /// Digit character class.
        /// </summary>
        Digit,

        /// <summary>
        /// Word character class.
        /// </summary>
        WordChar,

        /// <summary>
        /// White-space character class.
        /// </summary>
        WhiteSpace,

        /// <summary>
        /// Non-digit character class.
        /// </summary>
        NotDigit,

        /// <summary>
        /// Non-word character class.
        /// </summary>
        NotWordChar,

        /// <summary>
        /// Non-whitespace character class.
        /// </summary>
        NotWhiteSpace
    }
}
