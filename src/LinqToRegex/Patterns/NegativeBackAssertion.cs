// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Pihrtsoft.Text.RegularExpressions.Rendering;

namespace Pihrtsoft.Text.RegularExpressions;

/// <summary>
/// Represents a zero-width negative lookbehind assertion. This class cannot be inherited.
/// </summary>
public sealed class NegativeBackAssertion : GroupingPattern
{
    internal NegativeBackAssertion(object content)
        : base(content)
    {
    }

    internal NegativeBackAssertion(BackAssertion value)
        : base(value)
    {
    }

    internal override void AppendTo(PatternBuilder builder)
    {
        builder.AppendNegativeBackAssertion(Content);
    }
}
