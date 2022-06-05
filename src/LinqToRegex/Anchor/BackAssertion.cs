// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Represents a zero-width positive lookbehind assertion. This class cannot be inherited.
    /// </summary>
    public sealed class BackAssertion : GroupingPattern, INegateable<NegativeBackAssertion>
    {
        internal BackAssertion(object content)
            : base(content)
        {
        }

        /// <summary>
        /// Returns a new instance of the <see cref="NegativeBackAssertion"/> class.
        /// </summary>
        public NegativeBackAssertion Negate() => new(this);

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendBackAssertion(Content);
        }

        /// <summary>
        /// Returns a new instance of the <see cref="NegativeBackAssertion"/> class.
        /// </summary>
        /// <param name="value">A value to negate.</param>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
        public static NegativeBackAssertion operator !(BackAssertion value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));

            return value.Negate();
        }
    }
}
