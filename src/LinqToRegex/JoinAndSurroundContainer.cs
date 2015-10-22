// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
#if DEBUG
    internal sealed class JoinAndSurroundContainer
        : JoinContainer
    {
        public JoinAndSurroundContainer(object separator, object content)
            : base(separator, content)
        {
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.Append(Separator);
            base.AppendTo(builder);
            builder.Append(Separator);
        }
    }
#endif
}
