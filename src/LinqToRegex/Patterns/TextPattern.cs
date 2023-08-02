// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Pihrtsoft.Text.RegularExpressions.Rendering;

namespace Pihrtsoft.Text.RegularExpressions;

internal sealed class TextPattern : Pattern
{
    private readonly string? _text;

    internal TextPattern()
        : this(null)
    {
    }

    internal TextPattern(string? text)
    {
        _text = text;
    }

    internal override void AppendTo(PatternBuilder builder)
    {
        builder.Append(_text);
    }
}
