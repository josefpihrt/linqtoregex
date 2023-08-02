// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Pihrtsoft.Text.RegularExpressions.Rendering;

namespace Pihrtsoft.Text.RegularExpressions;

internal sealed class GroupNumberReferencePattern : QuantifiablePattern
{
    public GroupNumberReferencePattern(int groupNumber)
    {
        if (groupNumber < 0)
            throw new ArgumentOutOfRangeException(nameof(groupNumber));

        GroupNumber = groupNumber;
    }

    internal override void AppendTo(PatternBuilder builder)
    {
        builder.AppendGroupReferenceInternal(GroupNumber);
    }

    public int GroupNumber { get; }
}
