// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Specifies how the character is represented in the regular expression pattern.
    /// </summary>
    public enum CharEscapeMode
    {
        /// <summary>
        /// No escape mode.
        /// </summary>
        None,

        /// <summary>
        /// Hexadecimal ASCII pattern.
        /// </summary>
        AsciiHexadecimal,

        /// <summary>
        /// Escape using backslash.
        /// </summary>
        Backslash,

        /// <summary>
        /// A bell character.
        /// </summary>
        Bell,

        /// <summary>
        /// A carriage return character.
        /// </summary>
        CarriageReturn,

        /// <summary>
        /// An escape character.
        /// </summary>
        Escape,

        /// <summary>
        /// A form feed character.
        /// </summary>
        FormFeed,

        /// <summary>
        /// A linefeed character.
        /// </summary>
        Linefeed,

        /// <summary>
        /// A tab character.
        /// </summary>
        Tab,

        /// <summary>
        /// A vertical tab character.
        /// </summary>
        VerticalTab
    }
}
