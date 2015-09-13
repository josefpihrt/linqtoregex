// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    public abstract partial class QuantifiedGroup
    {
        internal sealed class CountQuantifiedGroup
            : QuantifiedGroup
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

            protected override void AppendQuantifierTo(PatternBuilder builder)
            {
                if (builder == null)
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

        internal sealed class CountFromQuantifiedGroup
            : QuantifiedGroup
        {
            private readonly int _minCount;

            public CountFromQuantifiedGroup(int minCount, object content)
                : base(content)
            {
                if (minCount < 0)
                    throw new ArgumentOutOfRangeException(nameof(minCount));

                _minCount = minCount;
            }

            protected override void AppendQuantifierTo(PatternBuilder builder)
            {
                if (builder == null)
                    throw new ArgumentNullException(nameof(builder));

                builder.AppendCountFromInternal(_minCount);
            }
        }

        internal sealed class MaybeQuantifiedGroup
            : QuantifiedGroup
        {
            public MaybeQuantifiedGroup(object content)
                : base(content)
            {
            }

            protected override void AppendQuantifierTo(PatternBuilder builder)
            {
                if (builder == null)
                    throw new ArgumentNullException(nameof(builder));

                builder.AppendMaybe();
            }
        }

        internal sealed class MaybeManyQuantifiedGroup
            : QuantifiedGroup
        {
            public MaybeManyQuantifiedGroup(object content)
                : base(content)
            {
            }

            protected override void AppendQuantifierTo(PatternBuilder builder)
            {
                if (builder == null)
                    throw new ArgumentNullException(nameof(builder));

                builder.AppendMaybeMany();
            }
        }

        internal sealed class OneManyQuantifiedGroup
            : QuantifiedGroup
        {
            public OneManyQuantifiedGroup(object content)
                : base(content)
            {
            }

            protected override void AppendQuantifierTo(PatternBuilder builder)
            {
                if (builder == null)
                    throw new ArgumentNullException(nameof(builder));

                builder.AppendOneMany();
            }
        }
    }
}
