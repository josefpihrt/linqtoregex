// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class NamedGroupSubstitution
        : Substitution
    {
        internal NamedGroupSubstitution(string groupName)
        {
            RegexUtility.CheckGroupName(groupName);

            GroupName = groupName;
        }

        internal override void AppendTo(StringBuilder builder)
        {
            builder.Append("${");
            builder.Append(GroupName);
            builder.Append("}");
        }

        internal override string Value => "${" + GroupName + "}";

        public string GroupName { get; }
    }
}