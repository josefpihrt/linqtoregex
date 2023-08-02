// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Pihrtsoft.Text.RegularExpressions.Rendering;

namespace Pihrtsoft.Text.RegularExpressions;

internal sealed class LazyQuantifierPattern : Pattern
{
    internal override void AppendTo(PatternBuilder builder)
    {
        builder.AppendLazy();
    }
}
