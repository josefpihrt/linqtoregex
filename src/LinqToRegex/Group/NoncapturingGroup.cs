// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq;

internal sealed class NoncapturingGroup : GroupingPattern
{
    public NoncapturingGroup(object content)
        : base(content)
    {
    }

    internal override void AppendTo(PatternBuilder builder)
    {
        builder.AppendNoncapturingGroup(Content);
    }
}
