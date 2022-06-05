// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Represents a class that enables to create a text representation of the <see cref="Pattern"/>. This class cannot be inherited.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public sealed class PatternBuilder
    {
        private readonly StringBuilder _sb;
        private Stack<Pattern> _patterns;
        private Stack<CharGrouping> _charGroupings;
        private RegexOptions _currentOptions;
        private bool _pendingOr;
        private int _charGroupLevel;
        private int _indentLevel;
        private bool _isMultiline;
        private readonly LineInfoBuilder _builder;

        internal PatternBuilder()
            : this(new PatternSettings())
        {
        }

        internal PatternBuilder(PatternSettings settings)
            : this(settings, RegexOptions.None)
        {
        }

        internal PatternBuilder(PatternSettings settings, RegexOptions options)
        {
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));

            _sb = new StringBuilder();

            if (settings.HasOptions(PatternOptions.Format) && settings.HasOption(PatternOptions.Comment | PatternOptions.InlineOptions))
                _builder = new LineInfoBuilder();

            CurrentOptions = RegexOptionsHelper.GetInlineOptions(options);
        }

        /// <summary>
        /// Converts the value of this instance to a <see cref="string"/>.
        /// </summary>
        public override string ToString()
        {
            if (Settings.HasOption(PatternOptions.CSharpLiteral | PatternOptions.VisualBasicLiteral))
            {
                return GetLiteral();
            }
            else
            {
                return GetPattern();
            }
        }

        private string GetPattern()
        {
            if (_builder is not null)
            {
                return _builder.AddComments(_sb.ToString(), Settings);
            }
            else
            {
                return _sb.ToString();
            }
        }

        private string GetLiteral()
        {
            var sb = new StringBuilder();

            if (Settings.HasOptions(PatternOptions.CSharpLiteral))
                sb.Append("@");

            sb.Append('"');

            if (_isMultiline)
                sb.Append(Settings.NewLine);

            sb.Append(GetPattern());

            if (_isMultiline)
                sb.Append(Settings.NewLine);

            sb.Append('"');

            return sb.ToString();
        }

        /// <summary>
        /// Appends specified text to this instance.
        /// </summary>
        /// <param name="value">The text to append.</param>
        public void Append(string value)
        {
            Append(value, false);
        }

        /// <summary>
        /// Appends specified characters to this instance.
        /// </summary>
        /// <param name="characters">Unicode characters.</param>
        /// <exception cref="ArgumentNullException"><paramref name="characters"/> is <c>null</c>.</exception>
        public void Append(char[] characters)
        {
            Append(characters, false);
        }

        internal void Append(char[] characters, bool inCharGroup)
        {
            if (characters is null)
                throw new ArgumentNullException(nameof(characters));

            foreach (char value in characters)
                Append(value, inCharGroup);
        }

        internal void Append(string value, bool inCharGroup)
        {
            if (string.IsNullOrEmpty(value))
                return;

            for (int i = 0; i < value.Length; i++)
            {
                CharEscapeMode mode = RegexUtility.GetEscapeMode((int)value[i], inCharGroup);
                if (mode != CharEscapeMode.None)
                {
                    char ch = value[i];
                    int lastPos;

                    if (i > 0)
                    {
                        Append();
                        AppendDirect(value, 0, i);

                        if (_builder is not null && !inCharGroup)
                            _builder.AddInfo(value, i);
                    }

                    do
                    {
                        Append(ch, mode);

                        if (_builder is not null && !inCharGroup)
                            _builder.AddInfo(SyntaxKind.Character, ch);

                        i++;
                        lastPos = i;

                        while (i < value.Length)
                        {
                            ch = value[i];
                            mode = RegexUtility.GetEscapeMode((int)ch, inCharGroup);

                            if (mode != CharEscapeMode.None)
                                break;

                            i++;
                        }

                        if ((i - lastPos) > 0)
                        {
                            Append();
                            AppendDirect(value, lastPos, i - lastPos);

                            if (_builder is not null && !inCharGroup)
                                _builder.AddInfo(value, lastPos, i - lastPos);
                        }
                    }
                    while (i < value.Length);

                    return;
                }
            }

            Append();
            AppendDirect(value);

            if (_builder is not null && !inCharGroup)
                _builder.AddInfo(value);
        }

        private void Append(char ch, CharEscapeMode mode)
        {
            switch (mode)
            {
                case CharEscapeMode.AsciiHexadecimal:
                    {
                        AppendAsciiHexadecimal((int)ch);
                        break;
                    }
                case CharEscapeMode.Backslash:
                    {
                        AppendBackslash(ch);
                        break;
                    }
                case CharEscapeMode.Bell:
                    {
                        AppendBackslash('a');
                        break;
                    }
                case CharEscapeMode.CarriageReturn:
                    {
                        AppendBackslash('r');
                        break;
                    }
                case CharEscapeMode.Escape:
                    {
                        AppendBackslash('e');
                        break;
                    }
                case CharEscapeMode.FormFeed:
                    {
                        AppendBackslash('f');
                        break;
                    }
                case CharEscapeMode.Linefeed:
                    {
                        AppendBackslash('n');
                        break;
                    }
                case CharEscapeMode.VerticalTab:
                    {
                        AppendBackslash('v');
                        break;
                    }
                case CharEscapeMode.Tab:
                    {
                        AppendBackslash('t');
                        break;
                    }
            }
        }

        /// <summary>
        /// Appends specified character to this instance.
        /// </summary>
        /// <param name="value">The character to append.</param>
        public void Append(char value)
        {
            Append(value, false);
        }

        internal void Append(char value, bool inCharGroup)
        {
            AppendInternal((int)value, inCharGroup);
        }

        /// <summary>
        /// Appends specified character to this instance.
        /// </summary>
        /// <param name="value">An enumerated constant that identifies an ASCII character to append.</param>
        public void Append(AsciiChar value)
        {
            Append(value, false);
        }

        internal void Append(AsciiChar value, bool inCharGroup)
        {
            AppendInternal((int)value, inCharGroup);
        }

        /// <summary>
        /// Appends specified character to this instance.
        /// </summary>
        /// <param name="value">A code of the character to append.</param>
        public void Append(int value)
        {
            Append(value, false);
        }

        internal void Append(int value, bool inCharGroup)
        {
            if (value < 0 || value > 0xFFFF)
                throw new ArgumentOutOfRangeException(nameof(value));

            AppendInternal(value, inCharGroup);
        }

        internal void AppendInternal(int value, bool inCharGroup)
        {
            switch (RegexUtility.GetEscapeMode(value, inCharGroup))
            {
                case CharEscapeMode.None:
                    {
                        AppendInternal((char)value);
                        break;
                    }
                case CharEscapeMode.AsciiHexadecimal:
                    {
                        AppendAsciiHexadecimal(value);
                        break;
                    }
                case CharEscapeMode.Backslash:
                    {
                        AppendBackslash((char)value);
                        break;
                    }
                case CharEscapeMode.Bell:
                    {
                        AppendBackslash('a');
                        break;
                    }
                case CharEscapeMode.CarriageReturn:
                    {
                        AppendBackslash('r');
                        break;
                    }
                case CharEscapeMode.Escape:
                    {
                        AppendBackslash('e');
                        break;
                    }
                case CharEscapeMode.FormFeed:
                    {
                        AppendBackslash('f');
                        break;
                    }
                case CharEscapeMode.Linefeed:
                    {
                        AppendBackslash('n');
                        break;
                    }
                case CharEscapeMode.VerticalTab:
                    {
                        AppendBackslash('v');
                        break;
                    }
                case CharEscapeMode.Tab:
                    {
                        AppendBackslash('t');
                        break;
                    }
            }

            if (_builder is not null && !inCharGroup)
                _builder.AddInfo(SyntaxKind.Character, (char)value);
        }

        internal void AppendCharRange(char firstChar, char lastChar)
        {
            Append(firstChar, true);
            AppendDirect('-');
            Append(lastChar, true);
        }

        /// <summary>
        /// Appends the text representation of the pattern to this instance.
        /// </summary>
        /// <param name="pattern">The pattern to append.</param>
        /// <exception cref="ArgumentNullException"><paramref name="pattern"/> is <c>null</c>.</exception>
        public void Append(Pattern pattern)
        {
            if (pattern is null)
                throw new ArgumentNullException(nameof(pattern));

            if (pattern.Previous is not null)
            {
                if (_patterns is null)
                    _patterns = new Stack<Pattern>();

                int cnt = _patterns.Count;
                Pattern item = pattern;

                do
                {
                    _patterns.Push(item);
                    item = item.Previous;
                }
                while (item is not null);

                while (_patterns.Count > cnt)
                    _patterns.Pop().AppendTo(this);
            }
            else
            {
                pattern.AppendTo(this);
            }
        }

        /// <summary>
        /// Appends the text representation of the pattern to this instance.
        /// </summary>
        /// <param name="value">The pattern to append.</param>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
        public void Append(CharGrouping value)
        {
            AppendCharGroup(value);
        }

        private void AppendOr(object value)
        {
            _pendingOr = true;
            Append(value);
            _pendingOr = false;
        }

        /// <summary>
        /// Appends the pattern representation of an object. The object must be convertible to <see cref="Pattern"/>, <see cref="CharGrouping"/>, <see cref="string"/>, <see cref="char"/>, object array or <see cref="IEnumerable"/>.
        /// </summary>
        /// <param name="value">The object to append.</param>
        public void Append(object value)
        {
            Append(value, GroupMode.NoncapturingGroup);
        }

        internal void Append(object value, GroupMode mode)
        {
            if (value is null)
                return;

            if (value is Pattern pattern)
            {
                Append(pattern);
                return;
            }

            if (value is string text)
            {
                Append(text);
                return;
            }

            if (value is char ch)
            {
                Append(ch);
                return;
            }

            if (value is CharGrouping charGrouping)
            {
                Append(charGrouping);
                return;
            }

            if (value is object[] values)
            {
                Append(values, mode);
                return;
            }

            if (value is IEnumerable items)
                Append(items, mode);
        }

        private void Append(object[] values, GroupMode mode)
        {
            if (values.Length == 0)
                return;

            if (mode == GroupMode.Group)
            {
                AppendNumberedGroupStart();
            }
            else if (mode == GroupMode.NoncapturingGroup)
            {
                AppendNoncapturingGroupStart();
            }

            _pendingOr = false;
            int length = Length;

            for (int i = 0; i < values.Length; i++)
            {
                _pendingOr = _pendingOr || (Length > length);
                length = Length;
                Append(values[i]);
            }

            _pendingOr = false;

            if (mode != GroupMode.None)
                AppendGroupEnd();
        }

        private void Append(IEnumerable items, GroupMode mode)
        {
            IEnumerator en = items.GetEnumerator();

            if (!en.MoveNext())
                return;

            if (mode == GroupMode.Group)
            {
                AppendNumberedGroupStart();
            }
            else if (mode == GroupMode.NoncapturingGroup)
            {
                AppendNoncapturingGroupStart();
            }

            _pendingOr = false;
            int length = Length;
            Append(en.Current);

            while (en.MoveNext())
            {
                _pendingOr = _pendingOr || (Length > length);
                length = Length;
                Append(en.Current);
            }

            _pendingOr = false;

            if (mode != GroupMode.None)
                AppendGroupEnd();
        }

        private void AppendGroupStart()
        {
            AppendGroupStart(true);
        }

        internal void AppendGroupStart(bool indent)
        {
            AppendInternal('(');
            AppendDirect('?');

            if (indent)
                _indentLevel++;
        }

        internal void AppendGroupContent(object content)
        {
            AppendGroupContent(content, RegexOptions.None, RegexOptions.None);
        }

        internal void AppendGroupContent(object content, RegexOptions applyOptions, RegexOptions disableOptions)
        {
            RegexOptions currentOptions = CurrentOptions;

            CurrentOptions |= applyOptions;
            CurrentOptions &= ~disableOptions;

            Append(content, GroupMode.None);

            CurrentOptions = currentOptions;
        }

        /// <summary>
        /// Appends an if construct.
        /// </summary>
        /// <param name="testContent">The pattern to assert.</param>
        /// <param name="trueContent">The pattern to match if the assertion succeeds.</param>
        /// <param name="falseContent">The pattern to match if the assertion fails.</param>
        /// <exception cref="ArgumentNullException"><paramref name="testContent"/> or <paramref name="trueContent"/> is <c>null</c>.</exception>
        public void AppendIfAssert(object testContent, object trueContent, object falseContent)
        {
            if (testContent is null)
                throw new ArgumentNullException(nameof(testContent));

            if (trueContent is null)
                throw new ArgumentNullException(nameof(trueContent));

            AppendGroupStart();
            AppendDirect('(');

            _builder?.AddInfo(SyntaxKind.IfAssert);

            if (!Settings.HasOptions(PatternOptions.IfConditionWithoutAssertion))
                AppendDirect("?=");

            AppendGroupContent(testContent);
            AppendGroupEnd();

            RegexOptions currentOptions = CurrentOptions;

            _indentLevel++;

            if (falseContent is null)
            {
                Append(trueContent, GroupMode.None);
            }
            else
            {
                Append(trueContent);
                AppendOr(falseContent);
            }

            AppendGroupEnd();

            CurrentOptions = currentOptions;
        }

        /// <summary>
        /// Appends an if construct.
        /// </summary>
        /// <param name="groupName">A name of the group.</param>
        /// <param name="trueContent">The pattern to match if the named group is matched.</param>
        /// <param name="falseContent">The pattern to match if the named group is not matched.</param>
        /// <exception cref="ArgumentNullException"><paramref name="groupName"/> or <paramref name="trueContent"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException"><paramref name="groupName"/> is not a valid regex group name.</exception>
        public void AppendIfGroup(string groupName, object trueContent, object falseContent)
        {
            AppendIfGroupInternal(groupName, trueContent, falseContent, true);
        }

        internal void AppendIfGroupInternal(string groupName, object trueContent, object falseContent, bool checkGroupName)
        {
            if (checkGroupName)
                RegexUtility.CheckGroupName(groupName);

            if (trueContent is null)
                throw new ArgumentNullException(nameof(trueContent));

            AppendGroupStart(false);
            AppendDirect('(');
            AppendDirect(groupName);
            AppendGroupEnd(false);

            _builder?.AddInfo(SyntaxKind.IfGroup);

            RegexOptions currentOptions = CurrentOptions;

            _indentLevel++;

            if (falseContent is null)
            {
                Append(trueContent, GroupMode.None);
            }
            else
            {
                Append(trueContent);
                AppendOr(falseContent);
            }

            AppendGroupEnd();

            CurrentOptions = currentOptions;
        }

        /// <summary>
        /// Appends an if construct.
        /// </summary>
        /// <param name="groupNumber">A number of the group.</param>
        /// <param name="trueContent">The pattern to match if the named group is matched.</param>
        /// <param name="falseContent">The pattern to match if the named group is not matched.</param>
        /// <exception cref="ArgumentNullException"><paramref name="trueContent"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="groupNumber"/> is less than zero.</exception>
        public void AppendIfGroup(int groupNumber, object trueContent, object falseContent)
        {
            if (groupNumber < 0)
                throw new ArgumentOutOfRangeException(nameof(groupNumber));

            AppendIfGroup(Convert.ToString(groupNumber, CultureInfo.InvariantCulture), trueContent, falseContent);
        }

        /// <summary>
        /// Appends a positive lookahead assertion with a specified content.
        /// </summary>
        /// <param name="content">An assertion content.</param>
        public void AppendAssertion(object content)
        {
            AppendGroupStart();

            _builder?.AddInfo(SyntaxKind.Assertion);

            AppendDirect("=");
            AppendGroupContent(content);
            AppendGroupEnd();
        }

        /// <summary>
        /// Appends a negative lookahead assertion with a specified content.
        /// </summary>
        /// <param name="content">An assertion content.</param>
        public void AppendNegativeAssertion(object content)
        {
            AppendGroupStart();

            _builder?.AddInfo(SyntaxKind.NegativeAssertion);

            AppendDirect("!");
            AppendGroupContent(content);
            AppendGroupEnd();
        }

        /// <summary>
        /// Appends a positive lookbehind assertion with a specified content.
        /// </summary>
        /// <param name="content">An assertion content.</param>
        public void AppendBackAssertion(object content)
        {
            AppendGroupStart();

            _builder?.AddInfo(SyntaxKind.BackAssertion);

            AppendDirect("<=");
            AppendGroupContent(content);
            AppendGroupEnd();
        }

        /// <summary>
        /// Appends a negative lookbehind assertion with a specified content.
        /// </summary>
        /// <param name="content">An assertion content.</param>
        public void AppendNegativeBackAssertion(object content)
        {
            AppendGroupStart();

            _builder?.AddInfo(SyntaxKind.NegativeBackAssertion);

            AppendDirect("<!");
            AppendGroupContent(content);
            AppendGroupEnd();
        }

        /// <summary>
        /// Appends a pattern that matches the beginning of the string.
        /// </summary>
        public void AppendBeginningOfInput()
        {
            AppendBackslash('A');

            _builder?.AddInfo(SyntaxKind.BeginningOfInput);
        }

        /// <summary>
        /// Appends a pattern that matches the beginning of the string (or line if the <see cref="RegexOptions.Multiline"/> option is applied).
        /// </summary>
        public void AppendBeginningOfInputOrLine()
        {
            AppendInternal('^');

            _builder?.AddInfo((IsCurrentOptions(RegexOptions.Multiline)) ? SyntaxKind.BeginningOfInputOrLine : SyntaxKind.BeginningOfInput);
        }

        /// <summary>
        /// Appends a pattern that matches the end of the string.
        /// </summary>
        public void AppendEndOfInput()
        {
            AppendBackslash('z');

            _builder?.AddInfo(SyntaxKind.EndOfInput);
        }

        /// <summary>
        /// Appends a pattern that is matched at the end of the string (or line if the <see cref="RegexOptions.Multiline"/> option is applied). End of line is defined as the position before a linefeed.
        /// </summary>
        public void AppendEndOfInputOrLine()
        {
            AppendInternal('$');

            _builder?.AddInfo((IsCurrentOptions(RegexOptions.Multiline)) ? SyntaxKind.EndOfInputOrLine : SyntaxKind.EndOfInput);
        }

        /// <summary>
        /// Appends a pattern that is matched at the end of the string or before linefeed at the end of the string.
        /// </summary>
        public void AppendEndOfInputOrBeforeEndingLinefeed()
        {
            AppendBackslash('Z');

            _builder?.AddInfo(SyntaxKind.EndOfInputOrBeforeEndingLinefeed);
        }

        /// <summary>
        /// Appends a pattern that is matched on a boundary between a word character and a non-word character. The pattern may be also matched on a word boundary at the beginning or end of the string.
        /// </summary>
        public void AppendWordBoundary()
        {
            AppendBackslash('b');

            _builder?.AddInfo(SyntaxKind.WordBoundary);
        }

        /// <summary>
        /// Appends a pattern that is not matched on a boundary between a word character and a non-word character.
        /// </summary>
        public void AppendNegativeWordBoundary()
        {
            AppendBackslash('B');

            _builder?.AddInfo(SyntaxKind.NegativeWordBoundary);
        }

        /// <summary>
        /// Appends a pattern that is matched at the position where the previous match ended.
        /// </summary>
        public void AppendPreviousMatchEnd()
        {
            AppendBackslash('G');

            _builder?.AddInfo(SyntaxKind.PreviousMatchEnd);
        }

        /// <summary>
        /// Appends a numbered group with a specified content.
        /// </summary>
        /// <param name="content">The content to be matched.</param>
        /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
        public void AppendNumberedGroup(object content)
        {
            if (content is null)
                throw new ArgumentNullException(nameof(content));

            AppendNumberedGroupStart();
            AppendGroupContent(content);
            AppendGroupEnd();
        }

        private void AppendNumberedGroupStart()
        {
            AppendInternal('(');
            _indentLevel++;

            _builder?.AddInfo(SyntaxKind.Group);
        }

        /// <summary>
        /// Appends a named group with a specified name and content.
        /// </summary>
        /// <param name="name">A name of the group.</param>
        /// <param name="content">The content to be matched.</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> or <paramref name="content"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException"><paramref name="name"/> is not a valid regex group name.</exception>
        public void AppendNamedGroup(string name, object content)
        {
            RegexUtility.CheckGroupName(name, nameof(name));

            if (content is null)
                throw new ArgumentNullException(nameof(content));

            AppendNamedGroupInternal(name, content);
        }

        internal void AppendNamedGroupInternal(string groupName, object content)
        {
            AppendGroupStart();
            AppendDirect(Settings.OpenIdentifierBoundaryChar);
            AppendDirect(groupName);
            AppendDirect(Settings.CloseIdentifierBoundaryChar);

            _builder?.AddInfo(SyntaxKind.NamedGroup);

            AppendGroupContent(content);
            AppendGroupEnd();
        }

        /// <summary>
        /// Appends a noncapturing group with a specified content.
        /// </summary>
        /// <param name="content">The content to be matched.</param>
        /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
        public void AppendNoncapturingGroup(object content)
        {
            if (content is null)
                throw new ArgumentNullException(nameof(content));

            AppendNoncapturingGroupStart();
            AppendGroupContent(content);
            AppendGroupEnd();
        }

        internal void AppendNoncapturingGroupStart()
        {
            AppendGroupStart();
            AppendDirect(':');

            _builder?.AddInfo(SyntaxKind.NoncapturingGroup);
        }

        /// <summary>
        /// Appends a nonbacktracking group with a specified content.
        /// </summary>
        /// <param name="content">The content to be matched.</param>
        /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
        public void AppendNonbacktrackingGroup(object content)
        {
            if (content is null)
                throw new ArgumentNullException(nameof(content));

            AppendGroupStart();
            AppendDirect('>');

            _builder?.AddInfo(SyntaxKind.NonbacktrackingGroup);

            AppendGroupContent(content);
            AppendGroupEnd();
        }

        internal void AppendBalancingGroup(string name1, string name2, object content)
        {
            if (content is null)
                throw new ArgumentNullException(nameof(content));

            AppendGroupStart();
            AppendDirect(Settings.OpenIdentifierBoundaryChar);
            AppendDirect(name1);
            AppendDirect('-');
            AppendDirect(name2);
            AppendDirect(Settings.CloseIdentifierBoundaryChar);

            _builder?.AddInfo(SyntaxKind.BalancingGroup);

            AppendGroupContent(content);
            AppendGroupEnd();
        }

        internal void AppendGroupEnd()
        {
            AppendGroupEnd(true);
        }

        internal void AppendGroupEnd(bool unindent)
        {
            if (Settings.HasOptions(PatternOptions.Format) && unindent)
            {
                _indentLevel--;
                AppendLineAndIndent();
            }

            AppendDirect(')');

            if (_builder is not null && unindent)
                _builder.AddInfo(SyntaxKind.GroupEnd);
        }

        /// <summary>
        /// Appends a pattern that matches any character.
        /// </summary>
        public void AppendAnyChar()
        {
            AppendInternal('[');
            _charGroupLevel++;

            _builder?.AddInfo(SyntaxKind.AnyChar);

            AppendWhiteSpace();
            AppendNotWhiteSpace();

            _charGroupLevel--;
            AppendDirect(']');
        }

        /// <summary>
        /// Appends a pattern that matches any character except linefeed (or any character if the <see cref="RegexOptions.Singleline"/> option is applied).
        /// </summary>
        public void AppendAnyCharNative()
        {
            AppendInternal('.');

            _builder?.AddInfo((IsCurrentOptions(RegexOptions.Singleline)) ? SyntaxKind.AnyChar : SyntaxKind.AnyCharExceptLinefeed);
        }

        /// <summary>
        /// Appends a pattern that matches a character from a specified character class.
        /// </summary>
        /// <param name="value">An enumerated constant that identifies character class.</param>
        internal void AppendCharClass(CharClass value)
        {
            switch (value)
            {
                case CharClass.Digit:
                    {
                        AppendDigit();
                        break;
                    }
                case CharClass.WordChar:
                    {
                        AppendWordChar();
                        break;
                    }
                case CharClass.WhiteSpace:
                    {
                        AppendWhiteSpace();
                        break;
                    }
                case CharClass.NotDigit:
                    {
                        AppendNotDigit();
                        break;
                    }
                case CharClass.NotWordChar:
                    {
                        AppendNotWordChar();
                        break;
                    }
                case CharClass.NotWhiteSpace:
                    {
                        AppendNotWhiteSpace();
                        break;
                    }
            }
        }

        /// <summary>
        /// Appends a pattern that matches a digit character.
        /// </summary>
        public void AppendDigit()
        {
            AppendBackslash('d');

            if (_builder is not null && _charGroupLevel == 0)
                _builder.AddInfo(SyntaxKind.Digit);
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a digit character.
        /// </summary>
        public void AppendNotDigit()
        {
            AppendBackslash('D');

            if (_builder is not null && _charGroupLevel == 0)
                _builder.AddInfo(SyntaxKind.NotDigit);
        }

        /// <summary>
        /// Appends a pattern that matches a white-space character.
        /// </summary>
        public void AppendWhiteSpace()
        {
            AppendBackslash('s');

            if (_builder is not null && _charGroupLevel == 0)
                _builder.AddInfo(SyntaxKind.WhiteSpace);
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a white-space character.
        /// </summary>
        public void AppendNotWhiteSpace()
        {
            AppendBackslash('S');

            if (_builder is not null && _charGroupLevel == 0)
                _builder.AddInfo(SyntaxKind.NotWhiteSpace);
        }

        /// <summary>
        /// Appends a pattern that matches a word character.
        /// </summary>
        public void AppendWordChar()
        {
            AppendBackslash('w');

            if (_builder is not null && _charGroupLevel == 0)
                _builder.AddInfo(SyntaxKind.WordChar);
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a word character.
        /// </summary>
        public void AppendNotWordChar()
        {
            AppendBackslash('W');

            if (_builder is not null && _charGroupLevel == 0)
                _builder.AddInfo(SyntaxKind.NotWordChar);
        }

        internal void AppendCharGroupStart()
        {
            AppendCharGroupStart(false);
        }

        internal void AppendCharGroupStart(bool negative)
        {
            AppendCharGroupStart(negative, -1);
        }

        private void AppendCharGroupStart(bool negative, int charNumber)
        {
            AppendInternal('[');
            _charGroupLevel++;

            if (negative)
                AppendDirect('^');

            if (_builder is not null && _charGroupLevel == 1)
                _builder.AddInfo((negative) ? SyntaxKind.NegativeCharGroup : SyntaxKind.CharGroup, (char)charNumber);
        }

        internal void AppendCharGroupEnd()
        {
            AppendDirect(']');
            _charGroupLevel--;
        }

        /// <summary>
        /// Appends a pattern that matches a character from a specified Unicode block.
        /// </summary>
        /// <param name="block">An enumerated constant that identifies Unicode block.</param>
        public void AppendCharGroup(NamedBlock block)
        {
            AppendCharGroup(block, false);
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not from a specified Unicode block.
        /// </summary>
        /// <param name="block">An enumerated constant that identifies Unicode block.</param>
        public void AppendNegativeCharGroup(NamedBlock block)
        {
            AppendCharGroup(block, true);
        }

        internal void AppendCharGroup(NamedBlock block, bool negative)
        {
            AppendCharGroupStart();
            AppendNamedBlock(block, negative);
            AppendCharGroupEnd();
        }

        /// <summary>
        /// Appends a pattern that matches a character from a specified Unicode category.
        /// </summary>
        /// <param name="category">An enumerated constant that identifies Unicode category.</param>
        public void AppendCharGroup(GeneralCategory category)
        {
            AppendCharGroup(category, false);
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not from a specified Unicode category.
        /// </summary>
        /// <param name="category">An enumerated constant that identifies Unicode category.</param>
        public void AppendNegativeCharGroup(GeneralCategory category)
        {
            AppendCharGroup(category, true);
        }

        internal void AppendCharGroup(GeneralCategory category, bool negative)
        {
            AppendCharGroupStart();
            AppendGeneralCategory(category, negative);
            AppendCharGroupEnd();
        }

        /// <summary>
        /// Appends a pattern that matches a character from a specified character class.
        /// </summary>
        /// <param name="value">An enumerated constant that identifies character class.</param>
        internal void AppendCharGroup(CharClass value)
        {
            AppendCharGroupStart();
            AppendCharClass(value);
            AppendCharGroupEnd();
        }

        /// <summary>
        /// Appends a pattern that matches a specified character.
        /// </summary>
        /// <param name="value">An enumerated constant that identifies ASCII character.</param>
        public void AppendCharGroup(AsciiChar value)
        {
            AppendCharGroup(value, false);
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a specified character.
        /// </summary>
        /// <param name="value">An enumerated constant that identifies ASCII character.</param>
        public void AppendNegativeCharGroup(AsciiChar value)
        {
            AppendCharGroup(value, true);
        }

        internal void AppendCharGroup(AsciiChar value, bool negative)
        {
            AppendCharGroupStart(negative, (int)value);
            Append(value, true);
            AppendCharGroupEnd();
        }

        /// <summary>
        /// Appends a character group containing specified characters.
        /// </summary>
        /// <param name="characters">A set of characters any one of which has to be matched.</param>
        /// <exception cref="ArgumentNullException"><paramref name="characters"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException"><paramref name="characters"/> length is equal to zero.</exception>
        public void AppendCharGroup(string characters)
        {
            AppendCharGroup(characters, false);
        }

        /// <summary>
        /// Appends a negative character group containing specified characters.
        /// </summary>
        /// <param name="characters">Unicode characters.</param>
        /// <exception cref="ArgumentNullException"><paramref name="characters"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException"><paramref name="characters"/> length is equal to zero.</exception>
        public void AppendNegativeCharGroup(string characters)
        {
            AppendCharGroup(characters, true);
        }

        internal void AppendCharGroup(string characters, bool negative)
        {
            if (characters is null)
                throw new ArgumentNullException(nameof(characters));

            if (characters.Length == 0)
                throw new ArgumentException(ExceptionHelper.CharGroupCannotBeEmpty, nameof(characters));

            if (characters.Length == 1)
            {
                AppendCharGroup(characters[0], negative);
            }
            else
            {
                AppendCharGroupStart(negative);
                Append(characters, true);
                AppendCharGroupEnd();
            }
        }

        internal void AppendCharGroup(char[] characters, bool negative)
        {
            if (characters is null)
                throw new ArgumentNullException(nameof(characters));

            if (characters.Length == 0)
                throw new ArgumentException(ExceptionHelper.CharGroupCannotBeEmpty, nameof(characters));

            if (characters.Length == 1)
            {
                AppendCharGroup(characters[0], negative);
            }
            else
            {
                AppendCharGroupStart(negative);
                Append(characters, true);
                AppendCharGroupEnd();
            }
        }

        internal void AppendCharGroup(char value, bool negative)
        {
            AppendCharGroupStart(negative, value);
            Append(value, true);
            AppendCharGroupEnd();
        }

        /// <summary>
        /// Appends a pattern that matches a character in the specified range.
        /// </summary>
        /// <param name="first">The first character of the range.</param>
        /// <param name="last">The last character of the range.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="last"/> character number is less than <paramref name="first"/> character number.</exception>
        public void AppendCharGroup(char first, char last)
        {
            if (last < first)
                throw new ArgumentOutOfRangeException(nameof(last));

            AppendCharGroup(first, last, false);
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not in the specified range.
        /// </summary>
        /// <param name="first">The first character of the range.</param>
        /// <param name="last">The last character of the range.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="last"/> character number is less than <paramref name="first"/> character number.</exception>
        public void AppendNegativeCharGroup(char first, char last)
        {
            if (last < first)
                throw new ArgumentOutOfRangeException(nameof(last));

            AppendCharGroup(first, last, true);
        }

        internal void AppendCharGroup(char first, char last, bool negative)
        {
            AppendCharGroupStart(negative);
            AppendCharRange(first, last);
            AppendCharGroupEnd();
        }

        /// <summary>
        /// Appends a character group containing specified <see cref="CharGrouping"/>.
        /// </summary>
        /// <param name="value">A content of a character group.</param>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
        public void AppendCharGroup(CharGrouping value)
        {
            AppendCharGroup(value, false);
        }

        /// <summary>
        /// Appends a negative character group containing specified <see cref="CharGrouping"/>.
        /// </summary>
        /// <param name="value">A content of a character group.</param>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
        public void AppendNegativeCharGroup(CharGrouping value)
        {
            AppendCharGroup(value, true);
        }

        internal void AppendCharGroup(CharGrouping value, bool negative)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));

            AppendCharGroupStart(negative);
            value.AppendContentTo(this);
            AppendCharGroupEnd();
        }

        /// <summary>
        /// Appends a pattern that matches a character from a specified base group except characters from a specified excluded group.
        /// </summary>
        /// <param name="baseGroup">A base group.</param>
        /// <param name="excludedGroup">An excluded group.</param>
        /// <exception cref="ArgumentNullException"><paramref name="baseGroup"/> or <paramref name="excludedGroup"/> is <c>null</c>.</exception>
        public void AppendSubtraction(IBaseGroup baseGroup, IExcludedGroup excludedGroup)
        {
            if (baseGroup is null)
                throw new ArgumentNullException(nameof(baseGroup));

            if (excludedGroup is null)
                throw new ArgumentNullException(nameof(excludedGroup));

            AppendCharGroupStart();

            baseGroup.AppendBaseGroupTo(this);

            AppendDirect('-');

            excludedGroup.AppendExcludedGroupTo(this);

            AppendCharGroupEnd();
        }

        /// <summary>
        /// Appends a pattern that matches a character from a specified Unicode category.
        /// </summary>
        /// <param name="category">An enumerated constant that identifies Unicode category.</param>
        public void AppendGeneralCategory(GeneralCategory category)
        {
            AppendGeneralCategory(category, false);
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not from a specified Unicode category.
        /// </summary>
        /// <param name="category">An enumerated constant that identifies Unicode category.</param>
        public void AppendNotGeneralCategory(GeneralCategory category)
        {
            AppendGeneralCategory(category, true);
        }

        internal void AppendGeneralCategory(GeneralCategory category, bool negative)
        {
            AppendBackslash((negative) ? 'P' : 'p');
            AppendDirect('{');
            AppendDirect(RegexUtility.CategoryDesignations[(int)category]);
            AppendDirect('}');

            if (_builder is not null && _charGroupLevel == 0)
                _builder.AddInfo(category, negative);
        }

        /// <summary>
        /// Appends a pattern that matches a character from a specified Unicode block.
        /// </summary>
        /// <param name="block">An enumerated constant that identifies Unicode block.</param>
        public void AppendNamedBlock(NamedBlock block)
        {
            AppendNamedBlock(block, false);
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not from a specified Unicode block.
        /// </summary>
        /// <param name="block">An enumerated constant that identifies Unicode block.</param>
        public void AppendNotNamedBlock(NamedBlock block)
        {
            AppendNamedBlock(block, true);
        }

        internal void AppendNamedBlock(NamedBlock block, bool negative)
        {
            AppendBackslash((negative) ? 'P' : 'p');
            AppendDirect('{');
            AppendDirect(RegexUtility.BlockDesignations[(int)block]);
            AppendDirect('}');

            if (_builder is not null && _charGroupLevel == 0)
                _builder.AddInfo((negative) ? SyntaxKind.NotNamedBlock : SyntaxKind.NamedBlock);
        }

        /// <summary>
        /// Appends a quantifier that matches previous element zero or one time.
        /// </summary>
        public void AppendMaybe()
        {
            AppendMaybe(false);
        }

        /// <summary>
        /// Appends a quantifier that matches previous element zero or one time.
        /// </summary>
        /// <param name="lazy">Indicates whether the quantifier will be greedy or lazy.</param>
        public void AppendMaybe(bool lazy)
        {
            AppendDirect('?');

            if (_builder is not null)
                _builder.LastLine.QuantifierKind = QuantifierKind.Maybe;

            if (lazy)
                AppendLazy();
        }

        /// <summary>
        /// Appends a quantifier that matches previous element zero or more times.
        /// </summary>
        public void AppendMaybeMany()
        {
            AppendMaybeMany(false);
        }

        /// <summary>
        /// Appends a quantifier that matches previous element zero or more times.
        /// </summary>
        /// <param name="lazy">Indicates whether the quantifier will be greedy or lazy.</param>
        public void AppendMaybeMany(bool lazy)
        {
            AppendDirect('*');

            if (_builder is not null)
                _builder.LastLine.QuantifierKind = QuantifierKind.MaybeMany;

            if (lazy)
                AppendLazy();
        }

        /// <summary>
        /// Appends a quantifier that matches previous element one or more times.
        /// </summary>
        public void AppendOneMany()
        {
            AppendOneMany(false);
        }

        /// <summary>
        /// Appends a quantifier that matches previous element one or more times.
        /// </summary>
        /// <param name="lazy">Indicates whether the quantifier will be greedy or lazy.</param>
        public void AppendOneMany(bool lazy)
        {
            AppendDirect('+');

            if (_builder is not null)
                _builder.LastLine.QuantifierKind = QuantifierKind.OneMany;

            if (lazy)
                AppendLazy();
        }

        /// <summary>
        /// Appends a quantifier that matches previous element specific number of times.
        /// </summary>
        /// <param name="exactCount">A number of times the pattern must be matched.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
        public void AppendCount(int exactCount)
        {
            AppendCount(exactCount, false);
        }

        /// <summary>
        /// Appends a quantifier that matches previous element specific number of times.
        /// </summary>
        /// <param name="exactCount">A number of times the pattern must be matched.</param>
        /// <param name="lazy">Indicates whether the quantifier will be greedy or lazy.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
        public void AppendCount(int exactCount, bool lazy)
        {
            if (exactCount < 0)
                throw new ArgumentOutOfRangeException(nameof(exactCount));

            AppendCountInternal(exactCount);

            if (lazy)
                AppendLazy();
        }

        internal void AppendCountInternal(int exactCount)
        {
            AppendDirect('{');
            AppendDirect(exactCount);
            AppendDirect('}');

            if (_builder is not null)
            {
                _builder.LastLine.QuantifierKind = QuantifierKind.Count;
                _builder.LastLine.Count1 = exactCount;
            }
        }

        /// <summary>
        /// Appends a quantifier that matches previous element from minimal to maximum times.
        /// </summary>
        /// <param name="minCount">A minimal number of times the pattern must be matched.</param>
        /// <param name="maxCount">A maximum number of times the pattern can be matched.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minCount"/> is less than zero or <paramref name="maxCount"/> is less than <paramref name="minCount"/>.</exception>
        public void AppendCount(int minCount, int maxCount)
        {
            AppendCount(minCount, maxCount, false);
        }

        /// <summary>
        /// Appends a quantifier that matches previous element from minimal to maximum times.
        /// </summary>
        /// <param name="minCount">A minimal number of times the pattern must be matched.</param>
        /// <param name="maxCount">A maximum number of times the pattern can be matched.</param>
        /// <param name="lazy">Indicates whether the quantifier will be greedy or lazy.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minCount"/> is less than zero or <paramref name="maxCount"/> is less than <paramref name="minCount"/>.</exception>
        public void AppendCount(int minCount, int maxCount, bool lazy)
        {
            if (minCount < 0 || maxCount < minCount)
                throw new ArgumentOutOfRangeException(nameof(minCount));

            AppendCountInternal(minCount, maxCount);

            if (lazy)
                AppendLazy();
        }

        internal void AppendCountInternal(int minCount, int maxCount)
        {
            AppendDirect('{');
            AppendDirect(minCount);
            AppendDirect(',');
            AppendDirect(maxCount);
            AppendDirect('}');

            if (_builder is not null)
            {
                _builder.LastLine.QuantifierKind = QuantifierKind.CountRange;
                _builder.LastLine.Count1 = minCount;
                _builder.LastLine.Count2 = maxCount;
            }
        }

        /// <summary>
        /// Appends a quantifier that matches previous element at least specified number of times.
        /// </summary>
        /// <param name="minCount">A minimal number of times the pattern must be matched.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minCount"/> is less than zero.</exception>
        public void AppendCountFrom(int minCount)
        {
            AppendCountFrom(minCount, false);
        }

        /// <summary>
        /// Appends a quantifier that matches previous element at least specified number of times.
        /// </summary>
        /// <param name="minCount">A minimal number of times the pattern must be matched.</param>
        /// <param name="lazy">Indicates whether the quantifier will be greedy or lazy.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minCount"/> is less than zero.</exception>
        public void AppendCountFrom(int minCount, bool lazy)
        {
            if (minCount < 0)
                throw new ArgumentOutOfRangeException(nameof(minCount));

            AppendCountFromInternal(minCount);

            if (lazy)
                AppendLazy();
        }

        internal void AppendCountFromInternal(int minCount)
        {
            AppendDirect('{');
            AppendDirect(minCount);
            AppendDirect(',');
            AppendDirect('}');

            if (_builder is not null)
            {
                _builder.LastLine.QuantifierKind = QuantifierKind.CountFrom;
                _builder.LastLine.Count1 = minCount;
            }
        }

        /// <summary>
        /// Appends a quantifier that matches previous element at most specified number of times.
        /// </summary>
        /// <param name="maxCount">A maximum number of times the pattern can be matched.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="maxCount"/> is less than zero.</exception>
        public void AppendMaybeCount(int maxCount)
        {
            AppendMaybeCount(maxCount, false);
        }

        /// <summary>
        /// Appends a quantifier that matches previous element at most specified number of times.
        /// </summary>
        /// <param name="maxCount">A maximum number of times the pattern can be matched.</param>
        /// <param name="lazy">Indicates whether the quantifier will be greedy or lazy.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="maxCount"/> is less than zero.</exception>
        public void AppendMaybeCount(int maxCount, bool lazy)
        {
            if (maxCount < 0)
                throw new ArgumentOutOfRangeException(nameof(maxCount));

            AppendDirect('{');
            AppendDirect('0');
            AppendDirect(',');
            AppendDirect(maxCount);
            AppendDirect('}');

            if (_builder is not null)
            {
                _builder.LastLine.QuantifierKind = QuantifierKind.MaybeCount;
                _builder.LastLine.Count1 = 0;
                _builder.LastLine.Count2 = maxCount;
            }

            if (lazy)
                AppendLazy();
        }

        internal void AppendLazy()
        {
            AppendDirect('?');

            if (_builder is not null)
                _builder.LastLine.Lazy = true;
        }

        internal void AppendGroupReferenceInternal(int groupNumber)
        {
            AppendInternal('\\');
            AppendDirect(groupNumber);

            if (!Settings.HasOptions(PatternOptions.Format) && Settings.HasOptions(PatternOptions.SeparateGroupNumberReference))
                AppendDirect("(?:)");

            _builder?.AddInfo(SyntaxKind.GroupReference);
        }

        internal void AppendGroupReferenceInternal(string groupName)
        {
            AppendBackslash('k');
            AppendDirect(Settings.OpenIdentifierBoundaryChar);
            AppendDirect(groupName);
            AppendDirect(Settings.CloseIdentifierBoundaryChar);

            _builder?.AddInfo(SyntaxKind.GroupReference);
        }

        /// <summary>
        /// Appends a pattern that applies specified options.
        /// </summary>
        /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
        /// <exception cref="ArgumentException"><paramref name="applyOptions"/> value is not convertible to inline chars.</exception>
        public void AppendOptions(RegexOptions applyOptions)
        {
            AppendOptions(applyOptions, RegexOptions.None);
        }

        /// <summary>
        /// Appends a pattern that applies and disables specified options to a specified pattern.
        /// </summary>
        /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
        /// <param name="disableOptions">A bitwise combination of the enumeration values that are disabled.</param>
        /// <exception cref="ArgumentException"><paramref name="applyOptions"/> or <paramref name="disableOptions"/> value is not convertible to inline chars.</exception>
        public void AppendOptions(RegexOptions applyOptions, RegexOptions disableOptions)
        {
            if (applyOptions == RegexOptions.None
                && disableOptions == RegexOptions.None)
            {
                return;
            }

            if (!RegexUtility.IsValidInlineOptions(applyOptions))
                throw new ArgumentException(ExceptionHelper.RegexOptionsNotConvertibleToInlineChars, nameof(applyOptions));

            if (!RegexUtility.IsValidInlineOptions(disableOptions))
                throw new ArgumentException(ExceptionHelper.RegexOptionsNotConvertibleToInlineChars, nameof(disableOptions));

            AppendGroupStart(false);
            AppendOptionsChars(applyOptions, disableOptions);
            AppendGroupEnd(false);

            _builder?.AddInfo(SyntaxKind.Options);

            CurrentOptions |= applyOptions;
            CurrentOptions &= ~disableOptions;
        }

        /// <summary>
        /// Appends a pattern that applies specified options to a specified pattern.
        /// </summary>
        /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
        /// <param name="content">The pattern to match.</param>
        /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException"><paramref name="applyOptions"/> value is not convertible to inline chars.</exception>
        public void AppendOptions(RegexOptions applyOptions, object content)
        {
            AppendOptions(applyOptions, RegexOptions.None, content);
        }

        /// <summary>
        /// Appends a pattern that applies and disables specified options to a specified pattern.
        /// </summary>
        /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
        /// <param name="disableOptions">A bitwise combination of the enumeration values that are disabled.</param>
        /// <param name="content">The pattern to match.</param>
        /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException"><paramref name="applyOptions"/> or <paramref name="disableOptions"/> value is not convertible to inline chars.</exception>
        internal void AppendOptions(RegexOptions applyOptions, RegexOptions disableOptions, object content)
        {
            if (!RegexUtility.IsValidInlineOptions(applyOptions))
                throw new ArgumentException(ExceptionHelper.RegexOptionsNotConvertibleToInlineChars, nameof(applyOptions));

            if (!RegexUtility.IsValidInlineOptions(disableOptions))
                throw new ArgumentException(ExceptionHelper.RegexOptionsNotConvertibleToInlineChars, nameof(disableOptions));

            if (content is null)
                throw new ArgumentNullException(nameof(content));

            if (applyOptions != RegexOptions.None || disableOptions != RegexOptions.None)
            {
                AppendGroupStart();
                AppendOptionsChars(applyOptions, disableOptions);
                AppendDirect(':');

                _builder?.AddInfo(SyntaxKind.GroupOptions);
            }
            else
            {
                AppendNoncapturingGroupStart();
            }

            AppendGroupContent(content, applyOptions, disableOptions);

            AppendGroupEnd();
        }

        private void AppendOptionsChars(RegexOptions applyOptions, RegexOptions disableOptions)
        {
            if (applyOptions != RegexOptions.None)
            {
                if (disableOptions != RegexOptions.None)
                {
                    AppendOptionsChars(applyOptions);
                    AppendDirect('-');
                    AppendOptionsChars(disableOptions);
                }
                else
                {
                    AppendOptionsChars(applyOptions);
                }
            }
            else if (disableOptions != RegexOptions.None)
            {
                AppendDirect('-');
                AppendOptionsChars(disableOptions);
            }
        }

        private void AppendOptionsChars(RegexOptions options)
        {
            if ((options & RegexOptions.IgnoreCase) != 0)
                AppendDirect('i');

            if ((options & RegexOptions.Multiline) != 0)
                AppendDirect('m');

            if ((options & RegexOptions.ExplicitCapture) != 0)
                AppendDirect('n');

            if ((options & RegexOptions.Singleline) != 0)
                AppendDirect('s');

            if ((options & RegexOptions.IgnorePatternWhitespace) != 0)
                AppendDirect('x');
        }

        private void AppendBackslash(char value)
        {
            AppendInternal('\\');
            AppendDirect(value);
        }

        internal void AppendAsciiHexadecimal(int charCode)
        {
            if (charCode < 0 || charCode > 0xFF)
                throw new ArgumentOutOfRangeException(nameof(charCode));

            AppendBackslash('x');
            AppendDirect(charCode.ToString("X2", CultureInfo.InvariantCulture));
        }

        internal void AppendUnicodeHexadecimal(int charCode)
        {
            if (charCode < 0 || charCode > 0xFFFF)
                throw new ArgumentOutOfRangeException(nameof(charCode));

            AppendBackslash('u');
            AppendDirect(charCode.ToString("X4", CultureInfo.InvariantCulture).PadLeft(4, '0'));
        }

        internal void AppendDirect(int number)
        {
            _sb.Append(Convert.ToString(number, CultureInfo.InvariantCulture));
        }

        internal void AppendDirect(char value)
        {
            if (Settings.HasOption(PatternOptions.CSharpLiteral | PatternOptions.VisualBasicLiteral) && value == '"')
                _sb.Append('"');

            _sb.Append(value);
        }

        internal void AppendDirect(string value)
        {
            if (Settings.HasOption(PatternOptions.CSharpLiteral | PatternOptions.VisualBasicLiteral))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == '"')
                        _sb.Append('"');

                    _sb.Append(value[i]);
                }
            }
            else
            {
                _sb.Append(value);
            }
        }

        private void AppendDirect(string value, int startIndex, int count)
        {
            if (Settings.HasOption(PatternOptions.CSharpLiteral | PatternOptions.VisualBasicLiteral))
            {
                int length = startIndex + count;
                for (int i = startIndex; i < length; i++)
                {
                    if (value[i] == '"')
                        _sb.Append('"');

                    _sb.Append(value[i]);
                }
            }
            else
            {
                _sb.Append(value, startIndex, count);
            }
        }

        private void AppendInternal(char value)
        {
            Append();
            AppendDirect(value);
        }

        private void Append()
        {
            if (Settings.HasOptions(PatternOptions.Format))
            {
                if (_charGroupLevel == 0)
                {
                    if (_pendingOr)
                    {
                        _indentLevel--;
                        AppendLineAndIndent();
                        _sb.Append('|');

                        _builder?.AddInfo(SyntaxKind.Or);

                        _pendingOr = false;
                        _indentLevel++;
                    }

                    if (_sb.Length > 0)
                        AppendLineAndIndent();
                }
            }
            else if (_pendingOr)
            {
                _sb.Append('|');
                _pendingOr = false;
            }
        }

        private void AppendLineAndIndent()
        {
            AppendLine();
            _sb.Append(' ', _indentLevel * Settings.IndentSize);
        }

        private void AppendLine()
        {
            _sb.Append(Settings.NewLine);
            _isMultiline = true;
        }

        private bool IsCurrentOptions(RegexOptions options) => (CurrentOptions & options) == options;

        /// <summary>
        /// Gets the <see cref="PatternSettings"/> object that modifies the pattern.
        /// </summary>
        public PatternSettings Settings { get; }

        internal int Length => _sb.Length;

        internal Stack<CharGrouping> CharGroupings
        {
            get { return _charGroupings ??= new Stack<CharGrouping>(); }
        }

        private RegexOptions CurrentOptions
        {
            get { return _currentOptions; }
            set
            {
                if (Settings.HasOptions(PatternOptions.Format | PatternOptions.InlineOptions))
                    _builder.CurrentOptions = value;

                _currentOptions = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay
        {
            get { return ToString(); }
        }
    }
}
