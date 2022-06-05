// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Represents a zero-width negative lookahead assertion. This class cannot be inherited.
    /// </summary>
    public sealed class NegativeAssertion : GroupingPattern
    {
        internal NegativeAssertion(object content)
            : base(content)
        {
        }

        internal NegativeAssertion(Assertion value)
            : base(value)
        {
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendNegativeAssertion(Content);
        }
    }
}
