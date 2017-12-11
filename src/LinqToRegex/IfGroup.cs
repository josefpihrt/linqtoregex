// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Globalization;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class IfGroup
        : QuantifiablePattern
    {
        private readonly object _trueContent;
        private readonly object _falseContent;

        public IfGroup(string groupName, object trueContent, object falseContent)
        {
            RegexUtility.CheckGroupName(groupName);

            GroupName = groupName;
            _trueContent = trueContent ?? throw new ArgumentNullException(nameof(trueContent));
            _falseContent = falseContent;
        }

        public IfGroup(int groupNumber, object trueContent, object falseContent)
        {
            if (groupNumber < 0)
                throw new ArgumentOutOfRangeException(nameof(groupNumber));

            GroupName = groupNumber.ToString(CultureInfo.InvariantCulture);
            _trueContent = trueContent ?? throw new ArgumentNullException(nameof(trueContent));
            _falseContent = falseContent;
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendIfGroupInternal(GroupName, _trueContent, _falseContent, false);
        }

        public string GroupName { get; }
    }
}
