// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Pihrtsoft.Text.RegularExpressions.Rendering;

namespace Pihrtsoft.Text.RegularExpressions;

internal class SurroundContainerPattern : Pattern
{
    private readonly object _content;
    private readonly object _contentBefore;
    private readonly object _contentAfter;

    public SurroundContainerPattern(object contentBefore, object content, object contentAfter)
    {
        _contentBefore = contentBefore ?? throw new ArgumentNullException(nameof(contentBefore));
        _content = content ?? throw new ArgumentNullException(nameof(content));
        _contentAfter = contentAfter ?? throw new ArgumentNullException(nameof(contentAfter));
    }

    internal override void AppendTo(PatternBuilder builder)
    {
        builder.Append(_contentBefore);
        builder.Append(_content);
        builder.Append(_contentAfter);
    }
}
