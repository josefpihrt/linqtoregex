// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class JoinContainer
        : Pattern
    {
        private readonly object _separator;
        private readonly object _values;

        public JoinContainer(object separator, object values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            _separator = separator;
            _values = values;
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            var values = _values as object[];
            if (values != null)
            {
                if (values.Length > 0)
                {
                    builder.Append(values[0]);

                    if (values.Length > 1)
                    {
                        for (int i = 1; i < values.Length; i++)
                        {
                            builder.Append(_separator);
                            builder.Append(values[i]);
                        }
                    }
                }
            }
            else
            {
                var items = _values as IEnumerable;

                IEnumerator en = items.GetEnumerator();

                if (en.MoveNext())
                {
                    builder.Append(en.Current);

                    if (en.MoveNext())
                    {
                        builder.Append(_separator);
                        builder.Append(en.Current);

                        while (en.MoveNext())
                        {
                            builder.Append(_separator);
                            builder.Append(en.Current);
                        }
                    }
                }
            }
        }
    }
}
