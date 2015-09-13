// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal class SurroundPattern
        : Pattern
    {
        private readonly object _content;
        private readonly object _contentBefore;
        private readonly object _contentAfter;

        public SurroundPattern(object contentBefore, object content, object contentAfter)
        {
            if (contentBefore == null)
                throw new ArgumentNullException(nameof(contentBefore));

            if (content == null)
                throw new ArgumentNullException(nameof(content));

            if (contentAfter == null)
                throw new ArgumentNullException(nameof(contentAfter));

            _contentBefore = contentBefore;
            _content = content;
            _contentAfter = contentAfter;
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.Append(_contentBefore);

            builder.Append(_content);

            builder.Append(_contentAfter);
        }
    }
}
