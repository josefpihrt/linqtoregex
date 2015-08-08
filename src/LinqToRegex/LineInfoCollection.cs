// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.ObjectModel;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class LineInfoCollection
        : Collection<LineInfo>
    {
        public LineInfoCollection()
        {
        }

        public void Add(SyntaxKind kind)
        {
            Add(new LineInfo(kind));
        }

        public LineInfo Last => this[Count - 1];
    }
}
