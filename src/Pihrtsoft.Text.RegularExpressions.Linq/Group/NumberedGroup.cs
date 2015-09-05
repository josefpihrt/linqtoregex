// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class NumberedGroup
        : GroupingPattern
    {
        public NumberedGroup()
            : this(string.Empty)
        {
        }

        public NumberedGroup(object content)
            : base(content)
        {
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendNumberedGroup(Content);
        }
    }
}
