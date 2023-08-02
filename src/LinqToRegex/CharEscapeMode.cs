// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions;

/// <summary>
/// Specifies how the character is represented in the regular expression pattern.
/// </summary>
public enum CharEscapeMode
{
    /// <summary>
    /// No escape mode.
    /// </summary>
    None = 0,

    /// <summary>
    /// Hexadecimal ASCII pattern.
    /// </summary>
    AsciiHexadecimal = 1,

    /// <summary>
    /// Escape using backslash.
    /// </summary>
    Backslash = 2,

    /// <summary>
    /// A bell character.
    /// </summary>
    Bell = 3,

    /// <summary>
    /// A carriage return character.
    /// </summary>
    CarriageReturn = 4,

    /// <summary>
    /// An escape character.
    /// </summary>
    Escape = 5,

    /// <summary>
    /// A form feed character.
    /// </summary>
    FormFeed = 6,

    /// <summary>
    /// A linefeed character.
    /// </summary>
    Linefeed = 7,

    /// <summary>
    /// A tab character.
    /// </summary>
    Tab = 8,

    /// <summary>
    /// A vertical tab character.
    /// </summary>
    VerticalTab = 9,
}
