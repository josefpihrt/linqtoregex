// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Text.RegularExpressions;
using Pihrtsoft.Text.RegularExpressions.Rendering;

namespace Pihrtsoft.Text.RegularExpressions;

internal sealed class GroupOptionsPattern : GroupingPattern
{
    private readonly RegexOptions _applyOptions;
    private readonly RegexOptions _disableOptions;

    public GroupOptionsPattern(RegexOptions applyOptions, object content)
        : this(applyOptions, RegexOptions.None, content)
    {
    }

    public GroupOptionsPattern(RegexOptions applyOptions, RegexOptions disableOptions, object content)
        : base(content)
    {
        if (!RegexUtility.IsValidInlineOptions(applyOptions))
            throw new ArgumentException(ExceptionMessages.RegexOptionsNotConvertibleToInlineChars, nameof(applyOptions));

        if (!RegexUtility.IsValidInlineOptions(disableOptions))
            throw new ArgumentException(ExceptionMessages.RegexOptionsNotConvertibleToInlineChars, nameof(disableOptions));

        _applyOptions = applyOptions;
        _disableOptions = disableOptions;
    }

    internal override void AppendTo(PatternBuilder builder)
    {
        builder.AppendOptions(_applyOptions, _disableOptions, Content);
    }
}
