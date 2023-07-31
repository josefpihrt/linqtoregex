// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

internal sealed class IfAssert : QuantifiablePattern
{
    private readonly object _testContent;
    private readonly object _trueContent;
    private readonly object? _falseContent;

    public IfAssert(object testContent, object trueContent, object? falseContent)
    {
        _testContent = testContent ?? throw new ArgumentNullException(nameof(testContent));
        _trueContent = trueContent ?? throw new ArgumentNullException(nameof(trueContent));
        _falseContent = falseContent;
    }

    internal override void AppendTo(PatternBuilder builder)
    {
        builder.AppendIfAssert(_testContent, _trueContent, _falseContent);
    }
}
