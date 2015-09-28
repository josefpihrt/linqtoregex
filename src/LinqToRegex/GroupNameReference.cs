// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class GroupNameReference
        : QuantifiablePattern
    {
        public GroupNameReference(string groupName)
        {
            RegexUtility.CheckGroupName(groupName);

            GroupName = groupName;
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendGroupReferenceInternal(GroupName);
        }

        public string GroupName { get; }
    }
}
