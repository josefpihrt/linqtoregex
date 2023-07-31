// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq;

/// <summary>
/// Represents a pattern that is matched at the end of the string. This class cannot be inherited.
/// </summary>
internal sealed class EndOfInput : QuantifiablePattern
{
    internal override void AppendTo(PatternBuilder builder)
    {
        builder.AppendEndOfInput();
    }
}
