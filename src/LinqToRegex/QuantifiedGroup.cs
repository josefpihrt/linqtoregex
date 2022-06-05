// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Represents a pattern that is quantified, i.e. the quantifier is applied on it. If required, pattern will be enclosed in the (noncapturing) group. This class is abstract.
    /// </summary>
    public abstract partial class QuantifiedGroup : QuantifiedPattern
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
        protected abstract void AppendQuantifierTo(PatternBuilder builder);

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
    }
}
