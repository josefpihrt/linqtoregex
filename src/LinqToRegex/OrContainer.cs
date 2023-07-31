﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

internal sealed class OrContainer : GroupingPattern
{
    internal OrContainer(object first, object second)
        : base(Combine(first, second))
    {
    }

    private static object Combine(object first, object second)
    {
        if (first is OrContainer x)
        {
            if (second is OrContainer y)
            {
                return Combine((object[])x.Content, (object[])y.Content);
            }
            else
            {
                return Combine((object[])x.Content, second);
            }
        }
        else if (second is OrContainer y)
        {
            return Combine(first, (object[])y.Content);
        }
        else
        {
            return new object[] { first, second };
        }
    }

    private static object[] Combine(object[] left, object[] right)
    {
        var result = new object[left.Length + right.Length];

        Array.Copy(left, result, left.Length);
        Array.Copy(right, 0, result, left.Length, right.Length);

        return result;
    }

    private static object[] Combine(object[] left, object right)
    {
        var result = new object[left.Length + 1];

        Array.Copy(left, result, left.Length);

        result[left.Length] = right;

        return result;
    }

    private static object[] Combine(object left, object[] right)
    {
        var result = new object[right.Length + 1];

        result[0] = left;

        Array.Copy(right, 0, result, 1, right.Length);

        return result;
    }

    internal override void AppendTo(PatternBuilder builder)
    {
        builder.AppendNoncapturingGroup(Content);
    }
}
