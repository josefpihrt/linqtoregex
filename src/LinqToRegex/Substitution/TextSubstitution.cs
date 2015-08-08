// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class TextSubstitution
        : Substitution
    {
        private readonly string _text;

        internal TextSubstitution(string text)
        {
            _text = text;
        }

        internal override string Value
        {
            get
            {
                if (string.IsNullOrEmpty(_text))
                {
                    return string.Empty;
                }
                else
                {
                    return RegexUtility.EscapeSubstitution(_text);
                }
            }
        }
    }
}