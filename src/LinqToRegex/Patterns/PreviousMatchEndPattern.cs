// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Pihrtsoft.Text.RegularExpressions.Rendering;

namespace Pihrtsoft.Text.RegularExpressions;

/// <summary>
/// Represents a pattern that is matched at the position where the previous match ended. This class cannot be inherited.
/// </summary>
internal sealed class PreviousMatchEndPattern : QuantifiablePattern
{
    internal override void AppendTo(PatternBuilder builder)
    {
        builder.AppendPreviousMatchEnd();
    }
}
