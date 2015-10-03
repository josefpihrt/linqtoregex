// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class ConcatContainer
        : Pattern
    {
        private readonly object _content;

        public ConcatContainer(object content)
        {
            if (content == null)
                throw new ArgumentNullException(nameof(content));

            _content = content;
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            var values = _content as object[];
            if (values != null)
            {
                for (int i = 0; i < values.Length; i++)
                    builder.Append(values[i]);
            }
            else
            {
                var items = _content as IEnumerable;
                if (items != null)
                {
                    foreach (var item in items)
                        builder.Append(item);
                }
            }
        }
    }
}
