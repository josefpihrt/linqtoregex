// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

/// <summary>
/// Represents a pattern that matches a specified content with lookbehind assertion on the left side and lookahead assertion on the right side. This class cannot be inherited.
/// </summary>
public sealed class SurroundAssertion : Pattern
{
    private readonly object _content;
    private readonly object _backAssertion;
    private readonly object _assertion;

    internal SurroundAssertion(object backAssertion, object content, object assertion)
    {
        _backAssertion = backAssertion ?? throw new ArgumentNullException(nameof(backAssertion));
        _content = content ?? throw new ArgumentNullException(nameof(content));
        _assertion = assertion ?? throw new ArgumentNullException(nameof(assertion));
    }

    internal override void AppendTo(PatternBuilder builder)
    {
        builder.AppendBackAssertion(_backAssertion);
        builder.Append(_content);
        builder.AppendAssertion(_assertion);
    }
}
