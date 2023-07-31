// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq;

/// <summary>
/// Represents the base part of the character subtraction pattern.
/// </summary>
internal interface IBaseGroup
{
    /// <summary>
    /// Appends the text representation of the base group to the specified <see cref="PatternBuilder"/>.
    /// </summary>
    /// <param name="builder">The builder to use for appending the text.</param>
    void AppendBaseGroupTo(PatternBuilder builder);
}
