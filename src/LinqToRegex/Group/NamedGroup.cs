// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class NamedGroup : GroupingPattern
    {
        public NamedGroup(string name, object content)
            : base(content)
        {
            RegexUtility.CheckGroupName(name, nameof(name));

            Name = name;
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendNamedGroupInternal(Name, Content);
        }

        public string Name { get; }
    }
}
