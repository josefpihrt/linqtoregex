// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class CharSubstitution
        : Substitution
    {
        private readonly char _char;

        internal CharSubstitution(char character)
        {
            _char = character;
        }

        internal override void AppendTo(StringBuilder builder)
        {
            if (_char == '$')
            {
                builder.Append("$$");
            }
            else
            {
                builder.Append(_char);
            }
        }

        internal override string Value => (_char == '$') ? "$$" : _char.ToString();
    }
}