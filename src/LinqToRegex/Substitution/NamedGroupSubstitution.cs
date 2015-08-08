// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

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

        internal override string Value => "${" + GroupName + "}";

        public string GroupName { get; }
    }
}