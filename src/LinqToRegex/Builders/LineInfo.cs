// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal class LineInfo
    {
        public LineInfo(SyntaxKind kind)
        {
            Kind = kind;
        }

        public SyntaxKind Kind { get; set; }
        public QuantifierKind QuantifierKind { get; set; }
        public bool Lazy { get; set; }
    }
}
