// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Represents an immutable content of the character group. Content can be a base group or an excluded group. This class is abstract.
    /// </summary>
    public abstract partial class CharGrouping
        : IBaseGroup, IExcludedGroup
    {
        /// <summary>
        /// Creates and returns a new instance of the <see cref="CharGrouping"/> class.
        /// </summary>
        protected CharGrouping()
        {
        }

        /// <summary>
        /// Returns the text representation of this instance.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var builder = new PatternBuilder();
            AppendContentTo(builder);
            return builder.ToString();
        }

        private CharGrouping Append(CharGrouping value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            CharGrouping first = value;

            while (first.Previous != null)
                first = first.Previous;

            first.Previous = this;
            return value;
        }

        /// <summary>
        /// Appends a pattern that matches specified Unicode character.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        /// <returns></returns>
        public CharGrouping Append(char value) => Append(Chars.Character(value));

        /// <summary>
        /// Appends a pattern that matches specified Unicode character.
        /// </summary>
        /// <param name="value">An enumerated constant that identifies ASCII character.</param>
        /// <returns></returns>
        public CharGrouping Append(AsciiChar value) => Append(Chars.Character(value));

        /// <summary>
        /// Appends a pattern that matches any one of the specified characters.
        /// </summary>
        /// <param name="characters">A set of Unicode characters.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="characters"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException"><paramref name="characters"/> length is equal to zero.</exception>
        public CharGrouping Append(string characters) => Append(Chars.Character(characters));

        /// <summary>
        /// Appends a pattern that matches a character from the specified Unicode block.
        /// </summary>
        /// <param name="block">An enumerated constant that identifies Unicode block.</param>
        /// <returns></returns>
        public CharGrouping Append(NamedBlock block) => Append(Chars.Character(block));

        /// <summary>
        /// Appends a pattern that matches a character from the specified Unicode category.
        /// </summary>
        /// <param name="category">An enumerated constant that identifies Unicode category.</param>
        /// <returns></returns>
        public CharGrouping Append(GeneralCategory category) => Append(Chars.Character(category));

        /// <summary>
        /// Appends a pattern that matches any one character from the specified range.
        /// </summary>
        /// <param name="first">The first character of the range.</param>
        /// <param name="last">The last character of the range.</param>
        /// <returns></returns>
        public CharGrouping Range(char first, char last) => Append(Chars.Range(first, last));

        /// <summary>
        /// Appends a pattern that matches a character that is not from the specified Unicode block.
        /// </summary>
        /// <param name="block">An enumerated constant that identifies Unicode block.</param>
        /// <returns></returns>
        public CharGrouping Not(NamedBlock block) => Append(Chars.Not(block));

        /// <summary>
        /// Appends a pattern that matches a character that is not from the specified Unicode category.
        /// </summary>
        /// <param name="category">An enumerated constant that identifies Unicode category.</param>
        /// <returns></returns>
        public CharGrouping Not(GeneralCategory category) => Append(Chars.Not(category));

        /// <summary>
        /// Appends a pattern that matches a character from the digit character class.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Digit() => Append(Chars.Digit());

        /// <summary>
        /// Appends a pattern that matches a character that is not from the digit character class.
        /// </summary>
        /// <returns></returns>
        public CharGrouping NotDigit() => Append(Chars.NotDigit());

        /// <summary>
        /// Appends a pattern that matches a character from the white-space character class.
        /// </summary>
        /// <returns></returns>
        public CharGrouping WhiteSpace() => Append(Chars.WhiteSpace());

        /// <summary>
        /// Appends a pattern that matches a character that is not from the white-space character class.
        /// </summary>
        /// <returns></returns>
        public CharGrouping NotWhiteSpace() => Append(Chars.NotWhiteSpace());

        /// <summary>
        /// Appends a pattern that matches a character from the word character class.
        /// </summary>
        /// <returns></returns>
        public CharGrouping WordChar() => Append(Chars.WordChar());

        /// <summary>
        /// Appends a pattern that matches a character that is not from the word character class.
        /// </summary>
        /// <returns></returns>
        public CharGrouping NotWordChar() => Append(Chars.NotWordChar());

        /// <summary>
        /// Appends a pattern that matches a latin alphabet letter or an arabic digit.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Alphanumeric() => Append(Chars.Alphanumeric());

        /// <summary>
        /// Appends a pattern that matches a latin alphabet letter, an arabic digit or an underscore.
        /// </summary>
        /// <returns></returns>
        public CharGrouping AlphanumericUnderscore() => Append(Chars.AlphanumericUnderscore());

        /// <summary>
        /// Appends a pattern that matches a latin alphabet letter.
        /// </summary>
        /// <returns></returns>
        public CharGrouping LatinLetter() => Append(Chars.LatinLetter());

        /// <summary>
        /// Matches an arabic digit.
        /// </summary>
        /// <returns></returns>
        public CharGrouping ArabicDigit() => Append(Chars.ArabicDigit());

        /// <summary>
        /// Appends a pattern that matches a new line character, i.e. a linefeed character or a carriage return character.
        /// </summary>
        /// <returns></returns>
        public CharGrouping NewLineChar() => Append(Chars.NewLineChar());

        /// <summary>
        /// Appends a pattern that matches a tab.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Tab() => Append(Chars.Tab());

        /// <summary>
        /// Appends a pattern that matches a linefeed.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Linefeed() => Append(Chars.Linefeed());

        /// <summary>
        /// Appends a pattern that matches a carriage return.
        /// </summary>
        /// <returns></returns>
        public CharGrouping CarriageReturn() => Append(Chars.CarriageReturn());

        /// <summary>
        /// Appends a pattern that matches a space character.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Space() => Append(Chars.Space());

        /// <summary>
        /// Appends a pattern that matches an exclamation mark.
        /// </summary>
        /// <returns></returns>
        public CharGrouping ExclamationMark() => Append(Chars.ExclamationMark());

        /// <summary>
        /// Appends a pattern that matches a quotation mark.
        /// </summary>
        /// <returns></returns>
        public CharGrouping QuoteMark() => Append(Chars.QuoteMark());

        /// <summary>
        /// Appends a pattern that matches a number sign.
        /// </summary>
        /// <returns></returns>
        public CharGrouping NumberSign() => Append(Chars.NumberSign());

        /// <summary>
        /// Appends a pattern that matches a dollar character.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Dollar() => Append(Chars.Dollar());

        /// <summary>
        /// Appends a pattern that matches a percent sign.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Percent() => Append(Chars.Percent());

        /// <summary>
        /// Matches an ampersand.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Ampersand() => Append(Chars.Ampersand());

        /// <summary>
        /// Appends a pattern that matches an apostrophe.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Apostrophe() => Append(Chars.Apostrophe());

        /// <summary>
        /// Appends a pattern that matches left parenthesis.
        /// </summary>
        /// <returns></returns>
        public CharGrouping LeftParenthesis() => Append(Chars.LeftParenthesis());

        /// <summary>
        /// Appends a pattern that matches right parenthesis.
        /// </summary>
        /// <returns></returns>
        public CharGrouping RightParenthesis() => Append(Chars.RightParenthesis());

        /// <summary>
        /// Appends a pattern that matches an asterisk.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Asterisk() => Append(Chars.Asterisk());

        /// <summary>
        /// Appends a pattern that matches a plus sign.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Plus() => Append(Chars.Plus());

        /// <summary>
        /// Appends a pattern that matches a comma.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Comma() => Append(Chars.Comma());

        /// <summary>
        /// Appends a pattern that matches a hyphen.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Hyphen() => Append(Chars.Hyphen());

        /// <summary>
        /// Appends a pattern that matches a period.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Dot() => Append(Chars.Dot());

        /// <summary>
        /// Appends a pattern that matches a slash.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Slash() => Append(Chars.Slash());

        /// <summary>
        /// Appends a pattern that matches a colon.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Colon() => Append(Chars.Colon());

        /// <summary>
        /// Appends a pattern that matches a semicolon.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Semicolon() => Append(Chars.Semicolon());

        /// <summary>
        /// Appends a pattern that matches a left angle bracket (less-than sign).
        /// </summary>
        /// <returns></returns>
        public CharGrouping LeftAngleBracket() => Append(Chars.LeftAngleBracket());

        /// <summary>
        /// Appends a pattern that matches an equals sign.
        /// </summary>
        /// <returns></returns>
        public CharGrouping EqualsSign() => Append(Chars.EqualsSign());

        /// <summary>
        /// Appends a pattern that matches a right angle bracket (greater-than sign).
        /// </summary>
        /// <returns></returns>
        public CharGrouping RightAngleBracket() => Append(Chars.RightAngleBracket());

        /// <summary>
        /// Appends a pattern that matches a question mark.
        /// </summary>
        /// <returns></returns>
        public CharGrouping QuestionMark() => Append(Chars.QuestionMark());

        /// <summary>
        /// Appends a pattern that matches an at sign.
        /// </summary>
        /// <returns></returns>
        public CharGrouping AtSign() => Append(Chars.AtSign());

        /// <summary>
        /// Appends a pattern that matches left square bracket.
        /// </summary>
        /// <returns></returns>
        public CharGrouping LeftSquareBracket() => Append(Chars.LeftSquareBracket());

        /// <summary>
        /// Appends a pattern that matches a backslash.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Backslash() => Append(Chars.Backslash());

        /// <summary>
        /// Appends a pattern that matches right square bracket.
        /// </summary>
        /// <returns></returns>
        public CharGrouping RightSquareBracket() => Append(Chars.RightSquareBracket());

        /// <summary>
        /// Appends a pattern that matches a circumflex accent.
        /// </summary>
        /// <returns></returns>
        public CharGrouping CircumflexAccent() => Append(Chars.CircumflexAccent());

        /// <summary>
        /// Appends a pattern that matches an underscore.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Underscore() => Append(Chars.Underscore());

        /// <summary>
        /// Appends a pattern that matches a grave accent.
        /// </summary>
        /// <returns></returns>
        public CharGrouping GraveAccent() => Append(Chars.GraveAccent());

        /// <summary>
        /// Appends a pattern that matches left curly bracket.
        /// </summary>
        /// <returns></returns>
        public CharGrouping LeftCurlyBracket() => Append(Chars.LeftCurlyBracket());

        /// <summary>
        /// Appends a pattern that matches a vertical bar.
        /// </summary>
        /// <returns></returns>
        public CharGrouping VerticalBar() => Append(Chars.VerticalBar());

        /// <summary>
        /// Appends a pattern that matches right curly bracket.
        /// </summary>
        /// <returns></returns>
        public CharGrouping RightCurlyBracket() => Append(Chars.RightCurlyBracket());

        /// <summary>
        /// Appends a pattern that matches left or right parenthesis.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Parenthesis() => Append(Chars.Parenthesis());

        /// <summary>
        /// Appends a pattern that matches left or right square bracket.
        /// </summary>
        /// <returns></returns>
        public CharGrouping SquareBracket() => Append(Chars.SquareBracket());

        /// <summary>
        /// Appends a pattern that matches left or right curly bracket.
        /// </summary>
        /// <returns></returns>
        public CharGrouping CurlyBracket() => Append(Chars.CurlyBracket());

        /// <summary>
        /// Appends a pattern that matches a tilde.
        /// </summary>
        /// <returns></returns>
        public CharGrouping Tilde() => Append(Chars.Tilde());

        /// <summary>
        /// Converts the current instance of the <see cref="CharGrouping"/> to the positive character group.
        /// </summary>
        /// <returns></returns>
        public CharGroup ToGroup() => CharGroup.Create(this, false);

        /// <summary>
        /// Converts the current instance of the <see cref="CharGrouping"/> to the negative character group.
        /// </summary>
        /// <returns></returns>
        public CharGroup ToNegativeGroup() => CharGroup.Create(this, true);

        /// <summary>
        /// Appends a core content of the current instance to a specified <see cref="PatternBuilder"/>.
        /// </summary>
        /// <param name="builder">The builder to use for appending the text.</param>
        protected abstract void AppendItemContentTo(PatternBuilder builder);

        /// <summary>
        /// Appends the text representation of the current instance of the character grouping to the specified <see cref="PatternBuilder"/>.
        /// </summary>
        /// <param name="builder">The builder to use for appending the text.</param>
        /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <c>null</c>.</exception>
        public void AppendBaseGroupTo(PatternBuilder builder)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            AppendContentTo(builder);
        }

        /// <summary>
        /// Appends the text representation of the character group containing the current instance to the specified <see cref="PatternBuilder"/>.
        /// </summary>
        /// <param name="builder">The builder to use for appending the text.</param>
        /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <c>null</c>.</exception>
        public void AppendExcludedGroupTo(PatternBuilder builder)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            builder.Append(this);
        }

        internal void AppendContentTo(PatternBuilder builder)
        {
            if (Previous != null)
            {
                Stack<CharGrouping> stack = builder.CharGroupings;
                int cnt = stack.Count;
                CharGrouping item = this;

                do
                {
                    stack.Push(item);
                    item = item.Previous;
                } while (item != null);

                while (stack.Count > cnt)
                    stack.Pop().AppendItemContentTo(builder);
            }
            else
            {
                AppendItemContentTo(builder);
            }
        }

        /// <summary>
        /// Concatenate two elements into a new <see cref="CharGrouping"/>.
        /// </summary>
        /// <param name="left">The first element to concatenate.</param>
        /// <param name="right">The second element to concatenate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
        public static CharGrouping operator +(CharGrouping left, CharGrouping right)
        {
            if (left == null)
                throw new ArgumentNullException(nameof(left));

            if (right == null)
                throw new ArgumentNullException(nameof(right));

            return left.Append(Chars.Character(right));
        }

        /// <summary>
        /// Concatenate two elements into a new <see cref="CharGrouping"/>.
        /// </summary>
        /// <param name="left">The first element to concatenate.</param>
        /// <param name="right">The second element to concatenate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
        public static CharGrouping operator +(CharGrouping left, string right)
        {
            if (left == null)
                throw new ArgumentNullException(nameof(left));

            if (right == null)
                throw new ArgumentNullException(nameof(right));

            return left.Append(right);
        }

        /// <summary>
        /// Concatenate two elements into a new <see cref="CharGrouping"/>.
        /// </summary>
        /// <param name="left">The first element to concatenate.</param>
        /// <param name="right">The second element to concatenate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
        public static CharGrouping operator +(string left, CharGrouping right)
        {
            if (left == null)
                throw new ArgumentNullException(nameof(left));

            if (right == null)
                throw new ArgumentNullException(nameof(right));

            return Chars.Character(left).Append(Chars.Character(right));
        }

        /// <summary>
        /// Concatenate two elements into a new <see cref="CharGrouping"/>.
        /// </summary>
        /// <param name="left">The first element to concatenate.</param>
        /// <param name="right">The second element to concatenate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="left"/> is <c>null</c>.</exception>
        public static CharGrouping operator +(CharGrouping left, char right)
        {
            if (left == null)
                throw new ArgumentNullException(nameof(left));

            return left.Append(right);
        }

        /// <summary>
        /// Concatenate two elements into a new <see cref="CharGrouping"/>.
        /// </summary>
        /// <param name="left">The first element to concatenate.</param>
        /// <param name="right">The second element to concatenate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="right"/> is <c>null</c>.</exception>
        public static CharGrouping operator +(char left, CharGrouping right)
        {
            if (right == null)
                throw new ArgumentNullException(nameof(right));

            return Chars.Character(left).Append(Chars.Character(right));
        }

        /// <summary>
        /// Converts the current instance to the negative character group.
        /// </summary>
        /// <param name="value">A value</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
        public static CharGroup operator !(CharGrouping value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return Patterns.NotChar(value);
        }

        /// <summary>
        /// Returns a pattern that matches a character from a specified base group except characters from a specified excluded group.
        /// </summary>
        /// <param name="baseGroup">A base group.</param>
        /// <param name="excludedGroup">An excluded group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="baseGroup"/> or <paramref name="excludedGroup"/> is <c>null</c>.</exception>
        public static CharSubtraction operator -(CharGrouping baseGroup, CharGrouping excludedGroup)
        {
            return new CharSubtraction(baseGroup, excludedGroup);
        }

        /// <summary>
        /// Returns a pattern that matches a character from a specified base group except characters from a specified excluded group.
        /// </summary>
        /// <param name="baseGroup">A base group.</param>
        /// <param name="excludedGroup">An excluded group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="baseGroup"/> or <paramref name="excludedGroup"/> is <c>null</c>.</exception>
        public static CharSubtraction operator -(CharGrouping baseGroup, CharGroup excludedGroup)
        {
            return new CharSubtraction(baseGroup, excludedGroup);
        }

        /// <summary>
        /// Returns a pattern that matches a character from a specified base group except characters from a specified excluded group.
        /// </summary>
        /// <param name="baseGroup">A base group.</param>
        /// <param name="excludedGroup">An excluded group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="baseGroup"/> or <paramref name="excludedGroup"/> is <c>null</c>.</exception>
        public static CharSubtraction operator -(CharGrouping baseGroup, CharPattern excludedGroup)
        {
            return new CharSubtraction(baseGroup, excludedGroup);
        }

        /// <summary>
        /// Converts specified characters to an instance of the <see cref="CharGrouping"/> class.
        /// </summary>
        /// <param name="characters">A set of Unicode characters.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="characters"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException"><paramref name="characters"/> length is equal to zero.</exception>
        public static explicit operator CharGrouping(string characters)
        {
            return Chars.Character(characters);
        }

        /// <summary>
        /// Converts specified character to an instance of the <see cref="CharGrouping"/> class.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        /// <returns></returns>
        public static explicit operator CharGrouping(char value)
        {
            return Chars.Character(value);
        }

        internal CharGrouping Previous { get; set; }
    }
}
