// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using static Pihrtsoft.Text.RegularExpressions.Linq.Patterns;

namespace Pihrtsoft.Text.RegularExpressions.Linq.Examples
{
    public static class Snippets
    {
        /// <summary>
        /// Returns a pattern that matches a linefeed that is not preceded with a carriage return.
        /// </summary>
        /// <returns></returns>
        public static QuantifiablePattern LinefeedWithoutCarriageReturn()
        {
            return NoncapturingGroup(
                NotAssertBack(CarriageReturn()).Linefeed());
        }

        /// <summary>
        /// Returns a pattern that matches leading whitespace of the string (or line if the <see cref="RegexOptions.Multiline"/> option is applied).
        /// </summary>
        /// <returns></returns>
        public static QuantifiablePattern LeadingWhiteSpace()
        {
            return NoncapturingGroup(
                BeginInputOrLine().WhiteSpaceExceptNewLine().OneMany());
        }

        public static QuantifiablePattern LineLeadingWhiteSpace()
        {
            return NoncapturingGroup(
                BeginLine().WhiteSpaceExceptNewLine().OneMany());
        }

        /// <summary>
        /// Returns a pattern that matches trailing whitespace of the string (or line if the <see cref="RegexOptions.Multiline"/> option is applied). A carriage return is not included in the match.
        /// </summary>
        /// <returns></returns>
        public static QuantifiablePattern TrailingWhiteSpace()
        {
            return NoncapturingGroup(
                WhiteSpaceExceptNewLine().OneMany()
                .EndInputOrLine(true));
        }

        public static QuantifiablePattern LineTrailingWhiteSpace()
        {
            return NoncapturingGroup(
                WhiteSpaceExceptNewLine().OneMany()
                .EndLine(true));
        }

        /// <summary>
        /// Returns a pattern that matches leading and trailing whitespace of the string (or line if the <see cref="RegexOptions.Multiline"/> option is applied). A carriage return is not included in the match.
        /// </summary>
        /// <returns></returns>
        public static QuantifiablePattern LeadingTrailingWhiteSpace()
        {
            return LeadingWhiteSpace() | TrailingWhiteSpace();
        }

        /// <summary>
        /// Returns a pattern that matches a line that is empty or contains only whitespace(s). Neither carriage return nor linefeed is included in the match.
        /// </summary>
        /// <returns></returns>
        public static QuantifiablePattern EmptyOrWhiteSpaceLine()
        {
            return EmptyOrWhiteSpaceLine(false);
        }

        /// <summary>
        /// Returns a pattern that matches a line that is empty or contains only whitespace(s), optionally including new line characters.
        /// </summary>
        /// <param name="includeNewLine">Indicates whether new line characters should be included in the match.</param>
        /// <returns></returns>
        public static QuantifiablePattern EmptyOrWhiteSpaceLine(bool includeNewLine)
        {
            if (includeNewLine)
            {
                return BeginLine()
                    .WhileWhiteSpaceExceptNewLine()
                    .Any(NewLine() | EndInput());
            }
            else
            {
                return BeginLine()
                    .WhileWhiteSpaceExceptNewLine()
                    .Assert(NewLine() | EndInput());
            }
        }

        /// <summary>
        /// Returns a pattern that matches an empty line. Neither carriage return nor linefeed is included in the match.
        /// </summary>
        /// <returns></returns>
        public static QuantifiablePattern EmptyLine()
        {
            return EmptyLine(false);
        }

        /// <summary>
        /// Returns a pattern that matches an empty line, optionally including new line characters.
        /// Empty line is defined as a start of line
        /// </summary>
        /// <param name="includeNewLine">Indicates whether new line characters should be included in the match.</param>
        /// <returns></returns>
        public static QuantifiablePattern EmptyLine(bool includeNewLine)
        {
            if (includeNewLine)
            {
                return BeginLine().NewLine();
            }
            else
            {
                return BeginLine().Assert(NewLine());
            }
        }

        /// <summary>
        /// Returns a pattern that matches a line that contains at least one non-whitespace character. New line characters are not included in the match.
        /// </summary>
        /// <returns></returns>
        public static QuantifiablePattern NonEmptyOrWhiteSpaceLine()
        {
            return NonEmptyOrWhiteSpaceLine(false);
        }

        /// <summary>
        /// Returns a pattern that matches a line that contains at least one non-whitespace character, optionally including new line characters.
        /// </summary>
        /// <param name="includeNewLine">Indicates whether new line characters should be included in the match.</param>
        /// <returns></returns>
        public static QuantifiablePattern NonEmptyOrWhiteSpaceLine(bool includeNewLine)
        {
            return NoncapturingGroup(
                BeginLine()
                    .WhileNotNewLineChar().Lazy()
                    .NotWhiteSpace()
                    .WhileNotNewLineChar()
                    .AppendIf(includeNewLine, NewLine().Maybe()));
        }

        /// <summary>
        /// Returns a pattern that matches a line that contains at least one character.  New line characters are not included in the match.
        /// </summary>
        /// <returns></returns>
        public static QuantifiablePattern NonEmptyLine()
        {
            return NonEmptyLine(false);
        }

        /// <summary>
        /// Returns a pattern that matches a line that contains at least one character, optionally including new line characters.
        /// </summary>
        /// <param name="includeNewLine">Indicates whether new line characters should be included in the match.</param>
        /// <returns></returns>
        public static QuantifiablePattern NonEmptyLine(bool includeNewLine)
        {
            return NoncapturingGroup(
                BeginLine()
                .NotNewLineChar().OneMany()
                .AppendIf(includeNewLine, NewLine().Maybe()));
        }

        /// <summary>
        /// Returns a pattern that matches first line of the string. Neither carriage return nor linefeed is included in the match.
        /// </summary>
        /// <returns></returns>
        public static QuantifiablePattern FirstLineWithoutNewLine()
        {
            return NoncapturingGroup(
                BeginInput().WhileNotNewLineChar());
        }

        public static Pattern CSharpLiteralOrComment()
        {
            return Any(
                CSharpEscapedTextLiteral(),
                CSharpVerbatimTextLiteral(),
                CSharpCharacterLiteral(),
                CSharpLineComment(),
                CSharpMultilineComment());
        }

        public static Pattern CSharpLiteral()
        {
            return CSharpEscapedTextLiteral() | CSharpVerbatimTextLiteral() | CSharpCharacterLiteral();
        }

        public static Pattern CSharpTextLiteral()
        {
            return CSharpEscapedTextLiteral() | CSharpVerbatimTextLiteral();
        }

        public static Pattern CSharpEscapedTextLiteral()
        {
            QuantifiedGroup chars = MaybeMany(!Chars.QuoteMark().Backslash().NewLineChar());

            return SurroundQuoteMarks(chars + MaybeMany(Backslash().NotNewLineChar() + chars));
        }

        public static Pattern CSharpVerbatimTextLiteral()
        {
            const string q = "\"";

            return "@" + q + WhileNotChar(q) + MaybeMany(q + q + WhileNotChar(q)) + q;
        }

        public static Pattern CSharpCharacterLiteral()
        {
            QuantifiedGroup chars = MaybeMany(!Chars.Apostrophe().Backslash().NewLineChar());

            return SurroundApostrophes(chars + MaybeMany(Backslash().NotNewLineChar() + chars));
        }

        public static Pattern CSharpLineComment()
        {
            return "//" + NotNewLineChar().MaybeMany();
        }

        public static Pattern CSharpMultilineComment()
        {
            return "/*" + Until("*/");
        }

        public static Pattern XmlCData()
        {
            return "<![CDATA[" + Until("]]>");
        }

        public static Pattern EmailAddress()
        {
            QuantifiedGroup left = OneMany(Chars.Alphanumeric() + "!#$%&'*+/=?^_`{|}~-");

            QuantifiedGroup right = Maybe(MaybeMany(Chars.Alphanumeric() + "-") + Alphanumeric());

            return NoncapturingGroup(
                left
                + MaybeMany("." + left)
                + "@"
                + OneMany(Alphanumeric() + right + ".")
                + Alphanumeric()
                + right);
        }
    }
}
