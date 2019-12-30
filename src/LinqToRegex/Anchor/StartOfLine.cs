// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Represents a pattern that is matched at the beginning of the string (or line if the <see cref="RegexOptions.Multiline"/> option is applied). This class cannot be inherited.
    /// </summary>
    internal sealed class StartOfLine : QuantifiablePattern
    {
        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendBeginningOfInputOrLine();
        }
    }
}
