﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

internal sealed class AsciiCharSurroundContainer : Pattern
{
    private readonly object _content;
    private readonly AsciiChar _charBefore;
    private readonly AsciiChar _charAfter;

    public AsciiCharSurroundContainer(AsciiChar charBefore, object content, AsciiChar charAfter)
    {
        _charBefore = charBefore;
        _content = content ?? throw new ArgumentNullException(nameof(content));
        _charAfter = charAfter;
    }

    internal override void AppendTo(PatternBuilder builder)
    {
        builder.Append(_charBefore);
        builder.Append(_content);
        builder.Append(_charAfter);
    }
}
