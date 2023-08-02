// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text.RegularExpressions;
using Pihrtsoft.Text.RegularExpressions.Rendering;

namespace Pihrtsoft.Text.RegularExpressions;

internal sealed class CaseAwareTextPattern : QuantifiablePattern
{
    private readonly string _text;
    private readonly bool _ignoreCase;

    public CaseAwareTextPattern(string text, bool ignoreCase)
    {
        _text = text;
        _ignoreCase = ignoreCase;
    }

    internal override void AppendTo(PatternBuilder builder)
    {
        if (string.IsNullOrEmpty(_text))
            return;

        if (_ignoreCase)
        {
            builder.AppendOptions(RegexOptions.IgnoreCase, _text);
        }
        else
        {
            builder.AppendOptions(RegexOptions.None, RegexOptions.IgnoreCase, _text);
        }
    }
}
