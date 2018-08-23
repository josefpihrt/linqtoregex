// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Specifies a set of features to support on the <see cref="PatternBuilder"/> object. This class cannot be inherited.
    /// </summary>
    public sealed class PatternSettings
    {
        private const string InitialNewLine = "\r\n";

        private char[] _coreNewLine = new char[] { '\r', '\n' };
        private int _indentSize;
        private PatternOptions _options;

        /// <summary>
        /// Initializes a new instance of the <see cref="PatternSettings"/> class.
        /// </summary>
        public PatternSettings()
            : this(PatternOptions.None)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatternSettings"/> class with a specified options.
        /// </summary>
        /// <param name="options">A bitwise combination of the enumeration values.</param>
        /// <exception cref="ArgumentException"><paramref name="options"/> has both <see cref="PatternOptions.CSharpLiteral"/> flag and <see cref="PatternOptions.VisualBasicLiteral"/> flag set.</exception>
        public PatternSettings(PatternOptions options)
        {
            Options = options;
            IdentifierBoundary = IdentifierBoundary.AngleBrackets;
            IndentSize = 4;
        }

        /// <summary>
        /// Determines whether specified options are set in the options of the current instance.
        /// </summary>
        /// <param name="options">A bitwise combination of the enumeration values.</param>
        public bool HasOptions(PatternOptions options) => (Options & options) == options;

        internal bool HasOption(PatternOptions options) => (Options & options) != 0;

        /// <summary>
        /// Gets or sets the options of this instance.
        /// </summary>
        /// <exception cref="ArgumentException"><paramref name="value"/> has both <see cref="PatternOptions.CSharpLiteral"/> flag and <see cref="PatternOptions.VisualBasicLiteral"/> flag set.</exception>
        public PatternOptions Options
        {
            get { return _options; }
            set
            {
                if ((value & (PatternOptions.CSharpLiteral | PatternOptions.VisualBasicLiteral)) == (PatternOptions.CSharpLiteral | PatternOptions.VisualBasicLiteral))
                    throw new ArgumentException(ExceptionHelper.InvalidPatternOptions);

                _options = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether a group name will be enclosed in angle brackets or apostrophes.
        /// </summary>
        public IdentifierBoundary IdentifierBoundary { get; set; }

        /// <summary>
        /// Gets or sets the number of spaces in an indent.
        /// </summary>
        public int IndentSize
        {
            get { return _indentSize; }
            set { _indentSize = Math.Max(value, 1); }
        }

        /// <summary>
        /// Gets or sets the line terminator string used by the current <see cref="PatternSettings"/>.
        /// </summary>
        public string NewLine
        {
            get { return new string(_coreNewLine); }
            set { _coreNewLine = (value ?? InitialNewLine).ToCharArray(); }
        }

        internal char OpenIdentifierBoundaryChar
        {
            get
            {
                if (IdentifierBoundary == IdentifierBoundary.Apostrophe)
                {
                    return '\'';
                }
                else
                {
                    return '<';
                }
            }
        }

        internal char CloseIdentifierBoundaryChar
        {
            get
            {
                if (IdentifierBoundary == IdentifierBoundary.Apostrophe)
                {
                    return '\'';
                }
                else
                {
                    return '>';
                }
            }
        }
    }
}
