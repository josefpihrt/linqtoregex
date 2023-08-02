// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Rendering;

internal class LineInfo
{
    public LineInfo(SyntaxKind kind, RegexOptions options)
    {
        Kind = kind;
        Options = options;
    }

    public SyntaxKind Kind { get; }

    public QuantifierKind QuantifierKind { get; set; }

    public bool Lazy { get; set; }

    public RegexOptions Options { get; set; }

    public int Count1 { get; set; } = -1;

    public int Count2 { get; set; } = -1;
}
