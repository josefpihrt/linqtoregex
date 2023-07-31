// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

internal sealed class TextSubstitution : Substitution
{
    private readonly string _text;

    internal TextSubstitution(string text)
    {
        _text = text;
    }

    internal override void AppendTo(StringBuilder builder)
    {
        if (string.IsNullOrEmpty(_text))
            return;

        for (int i = 0; i < _text.Length; i++)
        {
            if (_text[i] == '$')
            {
                RegexUtility.EscapeSubstitution(_text, i, builder);
                return;
            }
        }

        builder.Append(_text);
    }

    internal override string Value => (!string.IsNullOrEmpty(_text)) ? RegexUtility.EscapeSubstitution(_text) : "";
}
