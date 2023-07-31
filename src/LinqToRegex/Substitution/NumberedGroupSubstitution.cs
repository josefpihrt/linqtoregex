// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Globalization;
using System.Text;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

internal sealed class NumberedGroupSubstitution : Substitution
{
    internal NumberedGroupSubstitution(int groupNumber)
    {
        if (groupNumber < 0)
            throw new ArgumentOutOfRangeException(nameof(groupNumber));

        GroupNumber = groupNumber;
    }

    internal override void AppendTo(StringBuilder builder)
    {
        builder.Append("${");
        builder.Append(Convert.ToString(GroupNumber, CultureInfo.InvariantCulture));
        builder.Append("}");
    }

    internal override string Value => "${" + Convert.ToString(GroupNumber, CultureInfo.InvariantCulture) + "}";

    public int GroupNumber { get; }
}
