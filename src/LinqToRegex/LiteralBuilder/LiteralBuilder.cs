// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Text;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Enables to convert a text to a language literal.
    /// </summary>
    internal abstract class LiteralBuilder
    {
        private StringBuilder _sb;
        private readonly LiteralSettings _settings;

        /// <summary>
        /// Initializes a new instance <see cref="LiteralBuilder"/> class.
        /// </summary>
        protected LiteralBuilder()
            : this(new LiteralSettings())
        {
        }

        /// <summary>
        /// Initializes a new instance <see cref="LiteralBuilder"/> class with a specified settings.
        /// </summary>
        /// <param name="settings"></param>
        /// <exception cref="ArgumentNullException"><paramref name="settings"/> is <c>null</c>.</exception>
        protected LiteralBuilder(LiteralSettings settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            _settings = settings;
        }

        /// <summary>
        /// Returns a Visual Basic string literal created from a specified text.
        /// </summary>
        /// <param name="text">A text to be converted to a string literal.</param>
        /// <returns>Visual Basic string literal.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="text"/> is <c>null</c>.</exception>
        public static string ToVisualBasicLiteral(string text)
        {
            return ToVisualBasicLiteral(text, new LiteralSettings());
        }

        /// <summary>
        /// Returns a Visual Basic string literal created from a specified text, using a specified settings.
        /// </summary>
        /// <param name="text">A text to be converted to a string literal.</param>
        /// <param name="settings">A literal settings.</param>
        /// <returns>Visual Basic string literal.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="text"/> or <paramref name="settings"/> is <c>null</c>.</exception>
        public static string ToVisualBasicLiteral(string text, LiteralSettings settings)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            var builder = new VisualBasicLiteralBuilder(settings);
            return builder.GetText(text);
        }

        /// <summary>
        /// Returns a C# string literal created from a specified text.
        /// </summary>
        /// <param name="text">A text to be converted to a string literal.</param>
        /// <returns>C# string literal.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="text"/> is <c>null</c>.</exception>
        public static string ToCSharpLiteral(string text)
        {
            return ToCSharpLiteral(text, new LiteralSettings());
        }

        /// <summary>
        /// Returns a C# string literal created from a specified text, using a specified settings.
        /// </summary>
        /// <param name="text">A text to be converted to a string literal.</param>
        /// <param name="settings">A literal settings.</param>
        /// <returns>C# string literal.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="text"/> or <paramref name="settings"/> is <c>null</c>.</exception>
        public static string ToCSharpLiteral(string text, LiteralSettings settings)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            var builder = new CSharpLiteralBuilder(settings);
            return builder.GetText(text);
        }

        protected abstract void BeginLine();
        protected abstract void EndLine();
        protected abstract string GetNewLineLiteral();

        private string GetText(string code)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            _sb = new StringBuilder(code.Length);
            bool isNewLine = false;

            AppendStartQuoteMark();

            for (int i = 0; i < code.Length; i++)
            {
                char ch = code[i];

                if (ch == '\n')
                {
                    isNewLine = true;
                    EndLine();
                }
                else
                {
                    if (isNewLine)
                    {
                        if (Settings.HasOptions(LiteralOptions.Multiline))
                        {
                            AppendNewLine();
                        }
                        else
                        {
                            BeginLine();
                        }

                        isNewLine = false;
                    }

                    AppendChar(ch);
                }
            }

            if (!isNewLine)
            {
                AppendQuoteMark();
            }

            return _sb.ToString();
        }

        protected virtual void AppendChar(char value)
        {
            _sb.Append(value);
        }

        protected void Append(char value)
        {
            _sb.Append(value);
        }

        protected void Append(string value)
        {
            _sb.Append(value);
        }

        protected virtual void AppendStartQuoteMark()
        {
            _sb.Append('"');
        }

        protected void AppendQuoteMark()
        {
            _sb.Append('"');
        }

        protected void AppendNewLine()
        {
            _sb.Append('\n');
        }

        protected void AppendNewLineLiteral()
        {
            _sb.Append(GetNewLineLiteral());
        }

        /// <summary>
        /// Gets a settings of the current instance.
        /// </summary>
        public LiteralSettings Settings => _settings;
    }
}
