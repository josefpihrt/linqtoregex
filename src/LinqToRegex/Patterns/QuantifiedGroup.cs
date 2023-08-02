// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Pihrtsoft.Text.RegularExpressions.Rendering;

namespace Pihrtsoft.Text.RegularExpressions;

/// <summary>
/// Represents a pattern that is quantified, i.e. the quantifier is applied on it. If required, pattern will be enclosed in the (noncapturing) group. This class is abstract.
/// </summary>
public abstract class QuantifiedGroup : QuantifiedPattern
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QuantifiedGroup"/> class with a specified content.
    /// </summary>
    /// <param name="content">The content of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    protected QuantifiedGroup(object content)
    {
        Content = content ?? throw new ArgumentNullException(nameof(content));
    }

    /// <summary>
    /// Appends a quantifier to a specified <see cref="PatternBuilder"/>.
    /// </summary>
    /// <param name="builder">The builder to use for appending the text.</param>
    private protected abstract void AppendQuantifierTo(PatternBuilder builder);

    internal override void AppendTo(PatternBuilder builder)
    {
        if (AddGroup)
        {
            builder.AppendNoncapturingGroup(Content);
        }
        else
        {
            builder.AppendGroupContent(Content);
        }

        AppendQuantifierTo(builder);
    }

    private bool AddGroup
    {
        get
        {
            if (Content is QuantifiablePattern pattern)
                return pattern.Previous is not null;

            if (Content is string s)
                return s.Length == 0 || s.Length > 1;

            return Content is not CharGrouping;
        }
    }

    internal object Content { get; }

    internal sealed class CountQuantifiedGroup : QuantifiedGroup
    {
        private readonly int _count1;
        private readonly int _count2;

        public CountQuantifiedGroup(int exactCount, object content)
            : base(content)
        {
            if (exactCount < 0)
                throw new ArgumentOutOfRangeException(nameof(exactCount));

            _count1 = exactCount;
            _count2 = -1;
        }

        public CountQuantifiedGroup(int minCount, int maxCount, object content)
            : base(content)
        {
            if (minCount < 0 || maxCount < minCount)
                throw new ArgumentOutOfRangeException(nameof(minCount));

            _count1 = minCount;
            _count2 = maxCount;
        }

        private protected override void AppendQuantifierTo(PatternBuilder builder)
        {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

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

    internal sealed class CountFromQuantifiedGroup : QuantifiedGroup
    {
        private readonly int _minCount;

        public CountFromQuantifiedGroup(int minCount, object content)
            : base(content)
        {
            if (minCount < 0)
                throw new ArgumentOutOfRangeException(nameof(minCount));

            _minCount = minCount;
        }

        private protected override void AppendQuantifierTo(PatternBuilder builder)
        {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            builder.AppendCountFromInternal(_minCount);
        }
    }

    internal sealed class MaybeQuantifiedGroup : QuantifiedGroup
    {
        public MaybeQuantifiedGroup(object content)
            : base(content)
        {
        }

        private protected override void AppendQuantifierTo(PatternBuilder builder)
        {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            builder.AppendMaybe();
        }
    }

    internal sealed class MaybeManyQuantifiedGroup : QuantifiedGroup
    {
        public MaybeManyQuantifiedGroup(object content)
            : base(content)
        {
        }

        private protected override void AppendQuantifierTo(PatternBuilder builder)
        {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            builder.AppendMaybeMany();
        }
    }

    internal sealed class OneManyQuantifiedGroup : QuantifiedGroup
    {
        public OneManyQuantifiedGroup(object content)
            : base(content)
        {
        }

        private protected override void AppendQuantifierTo(PatternBuilder builder)
        {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            builder.AppendOneMany();
        }
    }
}
