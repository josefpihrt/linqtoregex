// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class GroupNumberReference
        : QuantifiablePattern
    {
        private readonly int _groupNumber;

        public GroupNumberReference(int groupNumber)
        {
            if (groupNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(groupNumber));
            }

            _groupNumber = groupNumber;
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendGroupReferenceInternal(GroupNumber);
        }

        public int GroupNumber => _groupNumber;
    }
}
