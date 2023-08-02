﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections;
using Pihrtsoft.Text.RegularExpressions.Rendering;

namespace Pihrtsoft.Text.RegularExpressions;

internal class JoinContainerPattern : Pattern
{
    public JoinContainerPattern(object separator, object content)
    {
        Separator = separator;
        Content = content ?? throw new ArgumentNullException(nameof(content));
    }

    internal override void AppendTo(PatternBuilder builder)
    {
        if (Content is object[] values)
        {
            if (values.Length > 0)
            {
                builder.Append(values[0]);

                if (values.Length > 1)
                {
                    for (int i = 1; i < values.Length; i++)
                    {
                        builder.Append(Separator);
                        builder.Append(values[i]);
                    }
                }
            }
        }
        else if (Content is IEnumerable items)
        {
            IEnumerator en = items.GetEnumerator();

            if (en.MoveNext())
            {
                builder.Append(en.Current);

                if (en.MoveNext())
                {
                    builder.Append(Separator);
                    builder.Append(en.Current);

                    while (en.MoveNext())
                    {
                        builder.Append(Separator);
                        builder.Append(en.Current);
                    }
                }
            }
        }
    }

    public object Separator { get; }

    public object Content { get; }
}
