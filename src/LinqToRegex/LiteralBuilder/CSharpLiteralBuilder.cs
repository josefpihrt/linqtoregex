// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class CSharpLiteralBuilder
        : LiteralBuilder
    {
        public CSharpLiteralBuilder()
            : base()
        {
        }

        public CSharpLiteralBuilder(LiteralSettings settings)
            : base(settings)
        {
        }

        protected override void AppendChar(char value)
        {
            switch (value)
            {
                case '"':
                    {
                        Append(Settings.HasOptions(LiteralOptions.Verbatim) ? '"' : '\\');
                        break;
                    }
                case '\\':
                    {
                        if (!Settings.HasOptions(LiteralOptions.Verbatim))
                        {
                            Append("\\");
                        }

                        break;
                    }
            }

            base.AppendChar(value);
        }

        protected override void EndLine()
        {
            AppendQuoteMark();

            if (Settings.HasOptions(LiteralOptions.ConcatAtBeginningOfLine))
            {
                AppendNewLine();
            }
            else
            {
                Append(" ");
            }

            Append("+ ");
            AppendNewLineLiteral();
        }

        protected override void BeginLine()
        {
            Append(" + ");

            if (!Settings.HasOptions(LiteralOptions.ConcatAtBeginningOfLine))
            {
                AppendNewLine();
            }

            AppendStartQuoteMark();
        }

        protected override string GetNewLineLiteral()
        {
            switch (Settings.NewLineLiteral)
            {
                case NewLineKind.Linefeed:
                    return @"'\n'";
                case NewLineKind.CarriageReturnLinefeed:
                    return @"""\r\n\""";
                case NewLineKind.Environment:
                    return "Environment.NewLine";
                default:
                    Debug.Assert(false);
                    return string.Empty;
            }
        }

        protected override void AppendStartQuoteMark()
        {
            if (Settings.HasOptions(LiteralOptions.Verbatim))
            {
                Append('@');
            }

            base.AppendStartQuoteMark();
        }
    }
}
