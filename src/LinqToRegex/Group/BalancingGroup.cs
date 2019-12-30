// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class BalancingGroup : GroupingPattern
    {
        public BalancingGroup(string name1, string name2, object content)
            : base(content)
        {
            RegexUtility.CheckGroupName(name1, nameof(name1));
            RegexUtility.CheckGroupName(name2, nameof(name2));

            Name1 = name1;
            Name2 = name2;
        }

        public string Name1 { get; }

        public string Name2 { get; }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendBalancingGroup(Name1, Name2, Content);
        }
    }
}