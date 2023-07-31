﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using static Pihrtsoft.Text.RegularExpressions.Linq.PatternFactory;

namespace Pihrtsoft.Text.RegularExpressions.Linq.Examples;

public static class StringInterpolation
{
    public const string OpenToken = "$\"";

    public static Pattern Pattern
    {
        get
        {
            return OpenToken
                + Open()
                + MaybeMany(
                    OneMany(NamedGroup("open", OpenToken) + Open())
                        + OneMany(BalancingGroup("close", "open", '"') + Close())
                )
                + '"';
        }
    }

    private static Pattern Open()
    {
        return
            TextPart()
                + MaybeMany('{' + CodePart() + '}' + TextPart())
                + Any(
                    Assert('"'),
                    '{' + CodePart() + Assert(OpenToken)
                    );
    }

    private static Pattern Close()
    {
        return
            CodePart()
                + MaybeMany('}' + TextPart() + '{' + CodePart())
                + Any(
                    Assert(OpenToken),
                    '}' + TextPart() + Assert('"')
                    );
    }

    private static Pattern TextPart()
    {
        QuantifiedPattern whileNot = WhileNotChar('\\', '{', '"');

        return NamedGroup(
            "text",
            whileNot
                + MaybeMany(
                    Any(
                        '\\' + NotNewLineChar(),
                        "{{"
                    )
                        + whileNot
                    )
        );
    }

    private static Pattern CodePart()
    {
        QuantifiedPattern whileNot = WhileNotChar('\'', '"', '@', '/', '}', '$');

        return whileNot
            + MaybeMany(
                Any(
                    NamedGroup("text", Snippets.CSharpEscapedTextLiteral()),
                    NamedGroup("text", Snippets.CSharpVerbatimTextLiteral()),
                    NamedGroup("char", Snippets.CSharpCharacterLiteral()),
                    NamedGroup("comment", Snippets.CSharpMultilineComment())
                )
                    + whileNot
            );
    }
}
