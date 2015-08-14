
// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class VisualBasicLiteralBuilder
        : LiteralBuilder
    {
        public VisualBasicLiteralBuilder()
            : base()
        {
        }

        public VisualBasicLiteralBuilder(LiteralSettings settings)
            : base(settings)
        {
        }

        protected override void AppendChar(char value)
        {
            if (value == '"')
            {
                Append('"');
            }

            base.AppendChar(value);
        }

        protected override void EndLine()
        {
            AppendQuoteMark();

            if (Settings.HasOptions(LiteralOptions.ConcatAtBeginningOfLine))
            {
                Append(" _");
                AppendNewLine();
            }
            else
            {
                Append(' ');
            }

            Append(Settings.ConcatOperator);
            Append(' ');
            AppendNewLineLiteral();
        }

        protected override void BeginLine()
        {
            Append(' ');
            Append(Settings.ConcatOperator);

            if (Settings.HasOptions(LiteralOptions.ConcatAtBeginningOfLine))
            {
                Append(' ');
            }
            else
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
                    return "vbLf";
                case NewLineKind.CarriageReturnLinefeed:
                    return "vbCrLf";
                case NewLineKind.Environment:
                    return "Environment.NewLine";
                default:
                    Debug.Assert(false);
                    return string.Empty;
            }
        }
    }
}
