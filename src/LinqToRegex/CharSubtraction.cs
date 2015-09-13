// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Represents a character subtraction pattern. This pattern matches a character from a base group except characters from a excluded group.
    /// </summary>
    public class CharSubtraction
        : QuantifiablePattern, IExcludedGroup
    {
        private readonly IBaseGroup _baseGroup;
        private readonly IExcludedGroup _excludedGroup;

        internal CharSubtraction(IBaseGroup baseGroup, IExcludedGroup excludedGroup)
        {
            if (baseGroup == null)
                throw new ArgumentNullException(nameof(baseGroup));

            if (excludedGroup == null)
                throw new ArgumentNullException(nameof(excludedGroup));

            _baseGroup = baseGroup;
            _excludedGroup = excludedGroup;
        }

        /// <summary>
        /// Appends the text representation of the current instance of the character subtraction to the specified <see cref="PatternBuilder"/>.
        /// </summary>
        /// <param name="builder">The builder to use for appending the text.</param>
        /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <c>null</c>.</exception>
        public void AppendExcludedGroupTo(PatternBuilder builder)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            AppendTo(builder);
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendSubtraction(_baseGroup, _excludedGroup);
        }
    }
}
