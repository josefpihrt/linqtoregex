// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

/// <summary>
/// Represents a zero-width positive lookahead assertion. This class cannot be inherited.
/// </summary>
public sealed class Assertion : GroupingPattern, INegateable<NegativeAssertion>
{
    internal Assertion(object content)
        : base(content)
    {
    }

    /// <summary>
    /// Returns an instance of the <see cref="NegativeAssertion"/> class.
    /// </summary>
    public NegativeAssertion Negate() => new(this);

    internal override void AppendTo(PatternBuilder builder)
    {
        builder.AppendAssertion(Content);
    }

    /// <summary>
    /// Returns an instance of the <see cref="NegativeAssertion"/> class.
    /// </summary>
    /// <param name="value">A value to negate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public static NegativeAssertion operator !(Assertion value)
    {
        if (value is null)
            throw new ArgumentNullException(nameof(value));

        return value.Negate();
    }
}
