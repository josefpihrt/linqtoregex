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

        public void AddCharacter(char character)
        {
            Add(new CharLineInfo(SyntaxKind.Character, character));
        }

        public void AddTextOrCharacter(string value)
        {
            if (value.Length > 1)
            {
                Add(SyntaxKind.Text);
            }
            else
            {
                AddCharacter(value[0]);
            }
        }

        public void AddTextOrCharacter(string value, int count)
        {
            AddTextOrCharacter(value, 0, count);
        }

        public void AddTextOrCharacter(string value, int startIndex, int count)
        {
            if (count > 1)
            {
                Add(SyntaxKind.Text);
            }
            else
            {
                AddCharacter(value[startIndex]);
            }
        }

        public LineInfo Last => this[Count - 1];
    }
}
