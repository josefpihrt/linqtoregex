// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

#pragma warning disable RCS1223

namespace Pihrtsoft.Text.RegularExpressions;

/// <summary>
/// Specifies a set of features to support on the <see cref="PatternBuilder"/> object. This class cannot be inherited.
/// </summary>
public sealed class PatternOptions
{
    private const string InitialNewLine = "\r\n";

    private char[] _coreNewLine = new[] { '\r', '\n' };
    private int _indentSize;

    /// <summary>
    /// Initializes a new instance of the <see cref="PatternOptions"/> class.
    /// </summary>
    public PatternOptions()
    {
        IdentifierBoundary = IdentifierBoundary.AngleBrackets;
        IndentSize = 4;
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
        get => _indentSize;
        set => _indentSize = Math.Max(value, 1);
    }

    /// <summary>
    /// Gets or sets the line terminator string used by the current <see cref="PatternOptions"/>.
    /// </summary>
    public string NewLine
    {
        get => new(_coreNewLine);
        set => _coreNewLine = (value ?? InitialNewLine).ToCharArray();
    }

    /// <summary>
    /// Specifies that an if construct condition will not be expressed as an assertion.
    /// </summary>
    public bool IfConditionWithoutAssertion { get; set; }

    /// <summary>
    /// Specifies that an empty (noncapturing) group will be added after the group number backreference.
    /// </summary>
    public bool SeparateGroupNumberReference { get; set; }

    /// <summary>
    /// Specifies that a pattern text will be formatted.
    /// </summary>
    public bool Indented { get; set; }

    /// <summary>
    /// Specifies that a comment will be added to the end of each line. This options is relevant only in combination with <see cref="Indented"/> option.
    /// </summary>
    public bool IncludeComment { get; set; }

    /// <summary>
    /// Specifies that a pattern will be converted to C# multiline literal. This option cannot be used in a combination with <see cref="VisualBasicLiteral"/>.
    /// </summary>
    public bool CSharpLiteral { get; set; }

    /// <summary>
    /// Specifies that a pattern will be converted to Visual Basic multiline literal. This option cannot be used in a combination with <see cref="CSharpLiteral"/>.
    /// </summary>
    public bool VisualBasicLiteral { get; set; }

    /// <summary>
    /// Specifies that current inline options will be added to each line. This options is relevant only in combination with <see cref="Indented"/> option.
    /// </summary>
    public bool IncludeInlineOptions { get; set; }

    internal char OpenIdentifierBoundaryChar => (IdentifierBoundary == IdentifierBoundary.Apostrophe) ? '\'' : '<';

    internal char CloseIdentifierBoundaryChar => (IdentifierBoundary == IdentifierBoundary.Apostrophe) ? '\'' : '>';
}
