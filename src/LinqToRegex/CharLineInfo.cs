// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

internal sealed class CharLineInfo : LineInfo
{
    public CharLineInfo(SyntaxKind kind, int charNumber, RegexOptions options)
        : base(kind, options)
    {
        CharNumber = charNumber;
    }

    public int CharNumber { get; }
}
