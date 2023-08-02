// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Pihrtsoft.Text.RegularExpressions.Rendering;

namespace Pihrtsoft.Text.RegularExpressions;

/// <summary>
/// Represents a pattern that is quantified, i.e. quantifier is applied on it. This class is abstract.
/// </summary>
public abstract class QuantifiedPattern : Pattern
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QuantifiedPattern"/> class.
    /// </summary>
    protected QuantifiedPattern()
    {
    }

    /// <summary>
    /// Specifies that the quantifier is lazy. Quantified pattern will be matched as few times as possible.
    /// </summary>
    public Pattern Lazy() => AppendInternal(new LazyQuantifierPattern());

    internal sealed class CountQuantifiedPattern : QuantifiedPattern
    {
        private readonly int _count1;
        private readonly int _count2;

        internal CountQuantifiedPattern(int exactCount)
        {
            if (exactCount < 0)
                throw new ArgumentOutOfRangeException(nameof(exactCount));

            _count1 = exactCount;
            _count2 = -1;
        }

        internal CountQuantifiedPattern(int minCount, int maxCount)
        {
            if (minCount < 0 || maxCount < minCount)
                throw new ArgumentOutOfRangeException(nameof(minCount));

            _count1 = minCount;
            _count2 = maxCount;
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            if (_count2 == -1)
            {
                builder.AppendCountInternal(_count1);
            }
            else
            {
                builder.AppendCountInternal(_count1, _count2);
            }
        }
    }

    internal sealed class CountFromQuantifiedPattern : QuantifiedPattern
    {
        private readonly int _minCount;

        internal CountFromQuantifiedPattern(int minCount)
        {
            if (minCount < 0)
                throw new ArgumentOutOfRangeException(nameof(minCount));

            _minCount = minCount;
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendCountFromInternal(_minCount);
        }
    }

    internal sealed class MaybeQuantifiedPattern : QuantifiedPattern
    {
        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendMaybe();
        }
    }

    internal sealed class MaybeManyQuantifiedPattern : QuantifiedPattern
    {
        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendMaybeMany();
        }
    }

    internal sealed class OneManyQuantifiedPattern : QuantifiedPattern
    {
        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendOneMany();
        }
    }
}
