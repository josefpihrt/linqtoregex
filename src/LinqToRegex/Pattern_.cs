// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

public abstract partial class Pattern
{
    /// <summary>
    /// Appends a pattern that matches the current instance or a specified content.
    /// </summary>
    /// <param name="content">Alternate content to match if the current instance if not matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public Pattern Or(object content)
    {
        return PatternFactory.Or(this, content);
    }

    /// <summary>
    /// Appends a pattern that is a negation of the specified pattern.
    /// </summary>
    /// <typeparam name="TPattern"></typeparam>
    /// <param name="value">A pattern to be negated.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public TPattern Not<TPattern>(INegateable<TPattern> value) where TPattern : Pattern
    {
        return AppendInternal(PatternFactory.Not(value));
    }

    /// <summary>
    /// Appends a noncapturing group with a specified content.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    public QuantifiablePattern Any(object content)
    {
        return AppendInternal(PatternFactory.Any(content));
    }

    /// <summary>
    /// Appends a pattern that matches any one of the patterns specified in the object array.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern Any(params object[] content)
    {
        return AppendInternal(PatternFactory.Any(content));
    }

    /// <summary>
    /// Appends an if construct with the specified content to assert and a content to match if the assertion succeeds.
    /// </summary>
    /// <param name="testContent">The content to assert.</param>
    /// <param name="trueContent">The content to be matched if the assertion succeeds.</param>
    /// <exception cref="ArgumentNullException"><paramref name="testContent"/> or <paramref name="trueContent"/> is <c>null</c>.</exception>
    public QuantifiablePattern IfAssert(object testContent, object trueContent)
    {
        return AppendInternal(PatternFactory.IfAssert(testContent, trueContent));
    }

    /// <summary>
    /// Appends an if construct with the specified content to assert and a content to match if the assertion succeeds and a content to match if the assertion fails.
    /// </summary>
    /// <param name="testContent">The content to assert.</param>
    /// <param name="trueContent">The content to be matched if the assertion succeeds.</param>
    /// <param name="falseContent">The content to be matched if the assertion fails.</param>
    /// <exception cref="ArgumentNullException"><paramref name="testContent"/> or <paramref name="trueContent"/> is <c>null</c>.</exception>
    public QuantifiablePattern IfAssert(object testContent, object trueContent, object falseContent)
    {
        return AppendInternal(PatternFactory.IfAssert(testContent, trueContent, falseContent));
    }

    /// <summary>
    /// Appends an if construct with a content to match if the named group is matched.
    /// </summary>
    /// <param name="groupName">A name of the group.</param>
    /// <param name="trueContent">The content to be matched if the named group is matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="groupName"/> or <paramref name="trueContent"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="groupName"/> is not a valid regex group name.</exception>
    public QuantifiablePattern IfGroup(string groupName, object trueContent)
    {
        return AppendInternal(PatternFactory.IfGroup(groupName, trueContent));
    }

    /// <summary>
    /// Appends an if construct with a content to match if the named group is matched and a content to match if the named group is not matched.
    /// </summary>
    /// <param name="groupName">A name of the group.</param>
    /// <param name="trueContent">The content to be matched if the named group is matched.</param>
    /// <param name="falseContent">The content to be matched if the named group is not matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="groupName"/> or <paramref name="trueContent"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="groupName"/> is not a valid regex group name.</exception>
    public QuantifiablePattern IfGroup(string groupName, object trueContent, object falseContent)
    {
        return AppendInternal(PatternFactory.IfGroup(groupName, trueContent, falseContent));
    }

    /// <summary>
    /// Appends an if construct with a content to match if the numbered group is matched.
    /// </summary>
    /// <param name="groupNumber">A number of the group.</param>
    /// <param name="trueContent">The content to be matched if the numbered group is matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="trueContent"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="groupNumber"/> is less than zero.</exception>
    public QuantifiablePattern IfGroup(int groupNumber, object trueContent)
    {
        return AppendInternal(PatternFactory.IfGroup(groupNumber, trueContent));
    }

    /// <summary>
    /// Appends an if construct with a content to match if the numbered group is matched and a content to match if the numbered group is not matched.
    /// </summary>
    /// <param name="groupNumber">A number of the group.</param>
    /// <param name="trueContent">The content to be matched if the numbered group is matched.</param>
    /// <param name="falseContent">The content to be matched if the numbered group is not matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="trueContent"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="groupNumber"/> is less than zero.</exception>
    public QuantifiablePattern IfGroup(int groupNumber, object trueContent, object falseContent)
    {
        return AppendInternal(PatternFactory.IfGroup(groupNumber, trueContent, falseContent));
    }

    /// <summary>
    /// Appends a pattern that is matched at the beginning of the string.
    /// </summary>
    public QuantifiablePattern BeginInput()
    {
        return AppendInternal(PatternFactory.BeginInput());
    }

    /// <summary>
    /// Appends a pattern that is matched at the end of the string.
    /// </summary>
    public QuantifiablePattern EndInput()
    {
        return AppendInternal(PatternFactory.EndInput());
    }

    /// <summary>
    /// Appends a pattern that is matched at the beginning of the line.
    /// </summary>
    public QuantifiablePattern BeginLine()
    {
        return AppendInternal(PatternFactory.BeginLine());
    }

    /// <summary>
    /// Appends a pattern that is matched at the beginning of the string (or line if the <see cref="RegexOptions.Multiline"/> option is applied).
    /// </summary>
    public QuantifiablePattern BeginInputOrLine()
    {
        return AppendInternal(PatternFactory.BeginInputOrLine());
    }

    /// <summary>
    /// Appends a pattern that is matched at the end of the string or line. End of line is defined as the position before a linefeed.
    /// </summary>
    public QuantifiablePattern EndLine()
    {
        return AppendInternal(PatternFactory.EndLine());
    }

    /// <summary>
    /// Appends a pattern that is matched (before carriage return) at the end of the string or line. End of line is defined as the position before a linefeed.
    /// </summary>
    /// <param name="beforeCarriageReturn">Indicates whether a position of the match should be before a carriage return if present and not already consumed by regex engine.</param>
    public Pattern EndLine(bool beforeCarriageReturn)
    {
        return AppendInternal(PatternFactory.EndLine(beforeCarriageReturn));
    }

    /// <summary>
    /// Appends a pattern that is matched at the end of the string (or line if the <see cref="RegexOptions.Multiline"/> option is applied). End of line is defined as the position before a linefeed.
    /// </summary>
    public QuantifiablePattern EndInputOrLine()
    {
        return AppendInternal(PatternFactory.EndInputOrLine());
    }

    /// <summary>
    /// Appends a pattern that is matched (before carriage return) at the end of the string (or (before carriage return) at the end of line if the <see cref="RegexOptions.Multiline"/> option is applied). End of line is defined as the position before a linefeed.
    /// </summary>
    /// <param name="beforeCarriageReturn">Indicates whether a position of the match should be before a carriage return if present and not already consumed by regex engine</param>
    public QuantifiablePattern EndInputOrLine(bool beforeCarriageReturn)
    {
        return AppendInternal(PatternFactory.EndInputOrLine(beforeCarriageReturn));
    }

    /// <summary>
    /// Appends a pattern that is matched at the end of the string or before linefeed at the end of the string.
    /// </summary>
    public QuantifiablePattern EndInputOrBeforeEndingLinefeed()
    {
        return AppendInternal(PatternFactory.EndInputOrBeforeEndingLinefeed());
    }

    /// <summary>
    /// Appends a pattern that is matched at the position where the previous match ended.
    /// </summary>
    public QuantifiablePattern PreviousMatchEnd()
    {
        return AppendInternal(PatternFactory.PreviousMatchEnd());
    }

    /// <summary>
    /// Appends a pattern that is matched on a boundary between a word character and a non-word character. The pattern may be also matched on a word boundary at the beginning or end of the string.
    /// </summary>
    public QuantifiablePattern WordBoundary()
    {
        return AppendInternal(PatternFactory.WordBoundary());
    }

    /// <summary>
    /// Appends a pattern that is not matched on a boundary between a word character and a non-word character.
    /// </summary>
    public QuantifiablePattern NotWordBoundary()
    {
        return AppendInternal(PatternFactory.NotWordBoundary());
    }

    /// <summary>
    /// Appends a pattern that matches one or more word characters surrounded with a word boundary.
    /// </summary>
    public QuantifiablePattern Word()
    {
        return AppendInternal(PatternFactory.Word());
    }

    /// <summary>
    /// Appends a pattern that matches spefified pattern surrounded with a word boundary.
    /// </summary>
    /// <param name="content">A text to surround.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern SurroundWordBoundary(object content)
    {
        return AppendInternal(PatternFactory.SurroundWordBoundary(content));
    }

    /// <summary>
    /// Appends a pattern that matches specified content surrounded with a word boundary.
    /// </summary>
    /// <param name="content">An object array that contains zero or more values any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern SurroundWordBoundary(params object[] content)
    {
        return AppendInternal(PatternFactory.SurroundWordBoundary(content));
    }

    /// <summary>
    /// Appends a zero-width positive lookahead assertion with a specified content to be matched.
    /// </summary>
    /// <param name="content">A content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern Assert(object content)
    {
        return AppendInternal(PatternFactory.Assert(content));
    }

    /// <summary>
    /// Appends a zero-width positive lookahead assertion that matches any one pattern specified in the object array.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern Assert(params object[] content)
    {
        return AppendInternal(PatternFactory.Assert(content));
    }

    /// <summary>
    /// Appends a zero-width negative lookahead assertion with a specified content not to be matched.
    /// </summary>
    /// <param name="content">A content not to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern NotAssert(object content)
    {
        return AppendInternal(PatternFactory.NotAssert(content));
    }

    /// <summary>
    /// Appends a zero-width negative lookahead assertion that matches none of patterns specified in the object array.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns none of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern NotAssert(params object[] content)
    {
        return AppendInternal(PatternFactory.NotAssert(content));
    }

    /// <summary>
    /// Appends a zero-width positive lookbehind assertion with a specified content to be matched.
    /// </summary>
    /// <param name="content">A content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern AssertBack(object content)
    {
        return AppendInternal(PatternFactory.AssertBack(content));
    }

    /// <summary>
    /// Appends a zero-width positive lookbehind assertion that matches any one pattern specified in the object array.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern AssertBack(params object[] content)
    {
        return AppendInternal(PatternFactory.AssertBack(content));
    }

    /// <summary>
    /// Appends a zero-width negative lookbehind assertion with a specified content not to be matched.
    /// </summary>
    /// <param name="content">A content not to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern NotAssertBack(object content)
    {
        return AppendInternal(PatternFactory.NotAssertBack(content));
    }

    /// <summary>
    /// Appends a zero-width negative lookbehind assertion that matches none of patterns specified in the object array.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns none of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern NotAssertBack(params object[] content)
    {
        return AppendInternal(PatternFactory.NotAssertBack(content));
    }

    /// <summary>
    /// Appends an empty numbered group.
    /// </summary>
    public QuantifiablePattern Group()
    {
        return AppendInternal(PatternFactory.Group());
    }

    /// <summary>
    /// Appends a numbered group with a specified content.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern Group(object content)
    {
        return AppendInternal(PatternFactory.Group(content));
    }

    /// <summary>
    /// Appends a numbered group with a specified content.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern Group(params object[] content)
    {
        return AppendInternal(PatternFactory.Group(content));
    }

    /// <summary>
    /// Appends a named group with a specified name and content.
    /// </summary>
    /// <param name="name">A name of the group.</param>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="name"/> or <paramref name="content"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="name"/> is not a valid regex group name.</exception>
    public QuantifiablePattern NamedGroup(string name, object content)
    {
        return AppendInternal(PatternFactory.NamedGroup(name, content));
    }

    /// <summary>
    /// Appends a named group with a specified name and content.
    /// </summary>
    /// <param name="name">A name of the group.</param>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="name"/> or <paramref name="content"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="name"/> is not a valid regex group name.</exception>
    public QuantifiablePattern NamedGroup(string name, params object[] content)
    {
        return AppendInternal(PatternFactory.NamedGroup(name, content));
    }

    /// <summary>
    /// Appends a noncapturing group with a specified content.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern NoncapturingGroup(object content)
    {
        return AppendInternal(PatternFactory.NoncapturingGroup(content));
    }

    /// <summary>
    /// Appends a noncapturing group with a specified content.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern NoncapturingGroup(params object[] content)
    {
        return AppendInternal(PatternFactory.NoncapturingGroup(content));
    }

    /// <summary>
    /// Appends a balancing group with specified group names and a content.
    /// </summary>
    /// <param name="name1">Current group name.</param>
    /// <param name="name2">Previously defined group name.</param>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="name1"/> or <paramref name="name2"/> or <paramref name="content"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="name1"/> or <paramref name="name2"/> is not a valid regex group name.</exception>
    public QuantifiablePattern BalancingGroup(string name1, string name2, object content)
    {
        return AppendInternal(PatternFactory.BalancingGroup(name1, name2, content));
    }

    /// <summary>
    /// Appends a balancing group with specified group names and a content.
    /// </summary>
    /// <param name="name1">Current group name.</param>
    /// <param name="name2">Previously defined group name.</param>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="name1"/> or <paramref name="name2"/> or <paramref name="content"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="name1"/> or <paramref name="name2"/> is not a valid regex group name.</exception>
    public QuantifiablePattern BalancingGroup(string name1, string name2, params object[] content)
    {
        return AppendInternal(PatternFactory.BalancingGroup(name1, name2, content));
    }

    /// <summary>
    /// Appends a nonbacktracking group with a specified content.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern NonbacktrackingGroup(object content)
    {
        return AppendInternal(PatternFactory.NonbacktrackingGroup(content));
    }

    /// <summary>
    /// Appends a nonbacktracking group with a specified content.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern NonbacktrackingGroup(params object[] content)
    {
        return AppendInternal(PatternFactory.NonbacktrackingGroup(content));
    }

    /// <summary>
    /// Appends a pattern that applies specified options.
    /// </summary>
    /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
    public Pattern Options(RegexOptions applyOptions)
    {
        return AppendInternal(PatternFactory.Options(applyOptions));
    }

    /// <summary>
    /// Appends a pattern that applies specified options to a specified pattern.
    /// </summary>
    /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern Options(RegexOptions applyOptions, object content)
    {
        return AppendInternal(PatternFactory.Options(applyOptions, content));
    }

    /// <summary>
    /// Appends a pattern that applies specified options to a specified pattern.
    /// </summary>
    /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern Options(RegexOptions applyOptions, params object[] content)
    {
        return AppendInternal(PatternFactory.Options(applyOptions, content));
    }

    /// <summary>
    /// Appends a pattern that applies and disables specified options to a specified pattern.
    /// </summary>
    /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
    /// <param name="disableOptions">A bitwise combination of the enumeration values that are disabled.</param>
    public Pattern Options(RegexOptions applyOptions, RegexOptions disableOptions)
    {
        return AppendInternal(PatternFactory.Options(applyOptions, disableOptions));
    }

    /// <summary>
    /// Appends a pattern that applies and disables specified options to a specified pattern.
    /// </summary>
    /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
    /// <param name="disableOptions">A bitwise combination of the enumeration values that are disabled.</param>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern Options(RegexOptions applyOptions, RegexOptions disableOptions, object content)
    {
        return AppendInternal(PatternFactory.Options(applyOptions, disableOptions, content));
    }

    /// <summary>
    /// Appends a pattern that applies and disables specified options to a specified pattern.
    /// </summary>
    /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
    /// <param name="disableOptions">A bitwise combination of the enumeration values that are disabled.</param>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern Options(RegexOptions applyOptions, RegexOptions disableOptions, params object[] content)
    {
        return AppendInternal(PatternFactory.Options(applyOptions, disableOptions, content));
    }

    /// <summary>
    /// Appends a pattern that disables specified options.
    /// </summary>
    /// <param name="options">A bitwise combination of the enumeration values that are disabled.</param>
    public Pattern DisableOptions(RegexOptions options)
    {
        return AppendInternal(PatternFactory.DisableOptions(options));
    }

    /// <summary>
    /// Appends a pattern that disables specified options to a specified pattern.
    /// </summary>
    /// <param name="options">A bitwise combination of the enumeration values that are disabled.</param>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern DisableOptions(RegexOptions options, object content)
    {
        return AppendInternal(PatternFactory.DisableOptions(options, content));
    }

    /// <summary>
    /// Appends a pattern that disables specified options to a specified pattern.
    /// </summary>
    /// <param name="options">A bitwise combination of the enumeration values that are disabled.</param>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern DisableOptions(RegexOptions options, params object[] content)
    {
        return AppendInternal(PatternFactory.DisableOptions(options, content));
    }

    /// <summary>
    /// Appends a pattern that matches two apostrophes, allowing zero or more characters that are not an apostrophe between the apostrophes.
    /// </summary>
    public Pattern SurroundApostrophes()
    {
        return AppendInternal(PatternFactory.SurroundApostrophes());
    }

    /// <summary>
    /// Appends a pattern that matches specified pattern surrounded with apostrophes.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public Pattern SurroundApostrophes(object content)
    {
        return AppendInternal(PatternFactory.SurroundApostrophes(content));
    }

    /// <summary>
    /// Appends a pattern that matches specified content surrounded with apostrophes.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public Pattern SurroundApostrophes(params object[] content)
    {
        return AppendInternal(PatternFactory.SurroundApostrophes(content));
    }

    /// <summary>
    /// Appends a pattern that matches two quotation marks, allowing zero or more characters that are not a quotation mark between the quotation marks.
    /// </summary>
    public Pattern SurroundQuoteMarks()
    {
        return AppendInternal(PatternFactory.SurroundQuoteMarks());
    }

    /// <summary>
    /// Appends a pattern that matches specified pattern surrounded with quotation marks.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public Pattern SurroundQuoteMarks(object content)
    {
        return AppendInternal(PatternFactory.SurroundQuoteMarks(content));
    }

    /// <summary>
    /// Appends a pattern that matches specified content surrounded with quotation marks.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public Pattern SurroundQuoteMarks(params object[] content)
    {
        return AppendInternal(PatternFactory.SurroundQuoteMarks(content));
    }

    /// <summary>
    /// Appends a pattern that matches two quotation marks (apostrophes), allowing zero or more characters that are not a quotation mark (apostrophe) between the quotation marks (apostrophes).
    /// </summary>
    public QuantifiablePattern SurroundQuoteMarksOrApostrophes()
    {
        return AppendInternal(PatternFactory.SurroundQuoteMarksOrApostrophes());
    }

    /// <summary>
    /// Appends a pattern that matches specified pattern surrounded with quotation marks or apostrophes.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern SurroundQuoteMarksOrApostrophes(object content)
    {
        return AppendInternal(PatternFactory.SurroundQuoteMarksOrApostrophes(content));
    }

    /// <summary>
    /// Appends a pattern that matches specified content surrounded with quotation marks or apostrophes.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiablePattern SurroundQuoteMarksOrApostrophes(params object[] content)
    {
        return AppendInternal(PatternFactory.SurroundQuoteMarksOrApostrophes(content));
    }

    /// <summary>
    /// Appends a pattern that matches a text consisting of a left parenthesis and a right parenthesis, allowing zero or more characters that are not a right parenthesis between the parentheses.
    /// </summary>
    public Pattern SurroundParentheses()
    {
        return AppendInternal(PatternFactory.SurroundParentheses());
    }

    /// <summary>
    /// Appends a pattern that matches specified pattern surrounded with left and right parenthesis.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public Pattern SurroundParentheses(object content)
    {
        return AppendInternal(PatternFactory.SurroundParentheses(content));
    }

    /// <summary>
    /// Appends a pattern that matches specified content surrounded with left and right parenthesis.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public Pattern SurroundParentheses(params object[] content)
    {
        return AppendInternal(PatternFactory.SurroundParentheses(content));
    }

    /// <summary>
    /// Appends a pattern that matches a text consisting of left and right curly bracket, allowing zero or more characters that are not a right curly bracket between the brackets.
    /// </summary>
    public Pattern SurroundCurlyBrackets()
    {
        return AppendInternal(PatternFactory.SurroundCurlyBrackets());
    }

    /// <summary>
    /// Appends a pattern that matches specified pattern surrounded with left and right curly bracket.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public Pattern SurroundCurlyBrackets(object content)
    {
        return AppendInternal(PatternFactory.SurroundCurlyBrackets(content));
    }

    /// <summary>
    /// Appends a pattern that matches specified content surrounded with left and right curly bracket.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public Pattern SurroundCurlyBrackets(params object[] content)
    {
        return AppendInternal(PatternFactory.SurroundCurlyBrackets(content));
    }

    /// <summary>
    /// Appends a pattern that matches a text consisting of left and right square bracket, allowing zero or more characters that are not a right square bracket between the brackets.
    /// </summary>
    public Pattern SurroundSquareBrackets()
    {
        return AppendInternal(PatternFactory.SurroundSquareBrackets());
    }

    /// <summary>
    /// Appends a pattern that matches specified pattern surrounded with left and right square bracket.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public Pattern SurroundSquareBrackets(object content)
    {
        return AppendInternal(PatternFactory.SurroundSquareBrackets(content));
    }

    /// <summary>
    /// Appends a pattern that matches specified content surrounded with left and right square bracket.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public Pattern SurroundSquareBrackets(params object[] content)
    {
        return AppendInternal(PatternFactory.SurroundSquareBrackets(content));
    }

    /// <summary>
    /// Appends a pattern that matches a text consisting of left and right angle bracket, allowing zero or more characters that are not a right angle bracket between the brackets.
    /// </summary>
    public Pattern SurroundAngleBrackets()
    {
        return AppendInternal(PatternFactory.SurroundAngleBrackets());
    }

    /// <summary>
    /// Appends a pattern that matches specified pattern surrounded with left and right angle bracket.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public Pattern SurroundAngleBrackets(object content)
    {
        return AppendInternal(PatternFactory.SurroundAngleBrackets(content));
    }

    /// <summary>
    /// Appends a pattern that matches specified content surrounded with left and right angle bracket.
    /// </summary>
    /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public Pattern SurroundAngleBrackets(params object[] content)
    {
        return AppendInternal(PatternFactory.SurroundAngleBrackets(content));
    }

    /// <summary>
    /// Appends a pattern that matches a character in the specified range.
    /// </summary>
    /// <param name="first">The first character of the range.</param>
    /// <param name="last">The last character of the range.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="last"/> character number is less than <paramref name="first"/> character number.</exception>
    public QuantifiablePattern Range(char first, char last)
    {
        return AppendInternal(PatternFactory.Range(first, last));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not in the specified range.
    /// </summary>
    /// <param name="first">The first character of the range.</param>
    /// <param name="last">The last character of the range.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="last"/> character number is less than <paramref name="first"/> character number.</exception>
    public QuantifiablePattern NotRange(char first, char last)
    {
        return AppendInternal(PatternFactory.NotRange(first, last));
    }

    /// <summary>
    /// Appends a pattern that matches a white-space character except carriage return and linefeed.
    /// </summary>
    public QuantifiablePattern WhiteSpaceExceptNewLine()
    {
        return AppendInternal(PatternFactory.WhiteSpaceExceptNewLine());
    }

    /// <summary>
    /// Appends a pattern that matches a white-space character except carriage return and linefeed. The character has to be matched specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup WhiteSpaceExceptNewLine(int exactCount)
    {
        return AppendInternal(PatternFactory.WhiteSpaceExceptNewLine(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a specified character zero or more times.
    /// </summary>
    /// <param name="value">A Unicode character.</param>
    public Pattern WhileChar(char value)
    {
        return AppendInternal(PatternFactory.WhileChar(value));
    }

    /// <summary>
    /// Appends a pattern that matches a specified character zero or more times.
    /// </summary>
    /// <param name="value">An enumerated constant that identifies ASCII character.</param>
    public Pattern WhileChar(AsciiChar value)
    {
        return AppendInternal(PatternFactory.WhileChar(value));
    }

    /// <summary>
    /// Appends a pattern that matches a specified character zero or more times.
    /// </summary>
    /// <param name="value">A set of Unicode characters.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public Pattern WhileChar(CharGrouping value)
    {
        return AppendInternal(PatternFactory.WhileChar(value));
    }

    /// <summary>
    /// Appends a pattern that matches a digit character zero or more times.
    /// </summary>
    public QuantifiedPattern WhileDigit()
    {
        return AppendInternal(PatternFactory.WhileDigit());
    }

    /// <summary>
    /// Appends a pattern that matches a word character zero or more times.
    /// </summary>
    public QuantifiedPattern WhileWordChar()
    {
        return AppendInternal(PatternFactory.WhileWordChar());
    }

    /// <summary>
    /// Appends a pattern that matches a white-space character zero or more times.
    /// </summary>
    public QuantifiedPattern WhileWhiteSpace()
    {
        return AppendInternal(PatternFactory.WhileWhiteSpace());
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters that are white-space characters but a neither carriage return nor a linefeed.
    /// </summary>
    public QuantifiedPattern WhileWhiteSpaceExceptNewLine()
    {
        return AppendInternal(PatternFactory.WhileWhiteSpaceExceptNewLine());
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters that are not followed with a specified <paramref name="value"/>.
    /// </summary>
    /// <param name="value">A text to find but not to match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public Pattern WhileNot(string value)
    {
        return AppendInternal(PatternFactory.WhileNot(value));
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters that are not a specified character.
    /// </summary>
    /// <param name="value">A Unicode character.</param>
    public Pattern WhileNotChar(char value)
    {
        return AppendInternal(PatternFactory.WhileNotChar(value));
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters that are not contained in the specified characters
    /// </summary>
    /// <param name="characters">Unicode characters.</param>
    /// <exception cref="ArgumentNullException"><paramref name="characters"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="characters"/> is empty.</exception>
    public QuantifiedPattern WhileNotChar(params char[] characters)
    {
        return AppendInternal(PatternFactory.WhileNotChar(characters));
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters that are not contained in the specified <see cref="string"/>.
    /// </summary>
    /// <param name="characters">Unicode characters.</param>
    /// <exception cref="ArgumentNullException"><paramref name="characters"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="characters"/> length is equal to zero.</exception>
    public QuantifiedPattern WhileNotChar(string characters)
    {
        return AppendInternal(PatternFactory.WhileNotChar(characters));
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters that are not a specified character.
    /// </summary>
    /// <param name="value">An enumerated constant that identifies ASCII character.</param>
    public Pattern WhileNotChar(AsciiChar value)
    {
        return AppendInternal(PatternFactory.WhileNotChar(value));
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters that are not matched by a specified <see cref="CharGrouping"/>.
    /// </summary>
    /// <param name="value">A set of Unicode characters.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public Pattern WhileNotChar(CharGrouping value)
    {
        return AppendInternal(PatternFactory.WhileNotChar(value));
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters that are neither a carriage return nor a linefeed.
    /// </summary>
    public QuantifiedPattern WhileNotNewLineChar()
    {
        return AppendInternal(PatternFactory.WhileNotNewLineChar());
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters that are not a digit.
    /// </summary>
    public QuantifiedPattern WhileNotDigit()
    {
        return AppendInternal(PatternFactory.WhileNotDigit());
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters that are not a white-space.
    /// </summary>
    public QuantifiedPattern WhileNotWhiteSpace()
    {
        return AppendInternal(PatternFactory.WhileNotWhiteSpace());
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters that are not a word character.
    /// </summary>
    public QuantifiedPattern WhileNotWordChar()
    {
        return AppendInternal(PatternFactory.WhileNotWordChar());
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters until it reaches a specified character.
    /// </summary>
    /// <param name="value">A Unicode character.</param>
    public QuantifiablePattern UntilChar(char value)
    {
        return AppendInternal(PatternFactory.UntilChar(value));
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters until it reaches a specified character.
    /// </summary>
    /// <param name="value">An enumerated constant that identifies ASCII character.</param>
    public QuantifiablePattern UntilChar(AsciiChar value)
    {
        return AppendInternal(PatternFactory.UntilChar(value));
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters until it reaches a character that is matched by a specified <see cref="CharGrouping"/>.
    /// </summary>
    /// <param name="value">A content of a character group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public QuantifiablePattern UntilChar(CharGrouping value)
    {
        return AppendInternal(PatternFactory.UntilChar(value));
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters until it reaches any one of the specified characters.
    /// </summary>
    /// <param name="characters">Unicode characters.</param>
    /// <exception cref="ArgumentNullException"><paramref name="characters"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="characters"/> length is equal to zero.</exception>
    public QuantifiablePattern UntilChar(string characters)
    {
        return AppendInternal(PatternFactory.UntilChar(characters));
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters until it reaches a linefeed.
    /// </summary>
    public QuantifiablePattern UntilNewLine()
    {
        return AppendInternal(PatternFactory.UntilNewLine());
    }

    /// <summary>
    /// Appends a pattern that matches zero or more characters until it reaches a specified <paramref name="value"/>.
    /// </summary>
    /// <param name="value">A text to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public Pattern Until(string value)
    {
        return AppendInternal(PatternFactory.Until(value));
    }

    /// <summary>
    /// Appends a pattern that matches any character.
    /// </summary>
    public QuantifiablePattern Any()
    {
        return AppendInternal(PatternFactory.Any());
    }

    /// <summary>
    /// Appends a pattern that matches any character specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Any(int exactCount)
    {
        return AppendInternal(PatternFactory.Any(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches any character except linefeed.
    /// </summary>
    public QuantifiablePattern AnyExceptLinefeed()
    {
        return AppendInternal(PatternFactory.AnyExceptLinefeed());
    }

    /// <summary>
    /// Appends a pattern that matches any character except linefeed specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup AnyExceptLinefeed(int exactCount)
    {
        return AppendInternal(PatternFactory.AnyExceptLinefeed(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches any character except linefeed (or any character if the <see cref="RegexOptions.Singleline"/> option is applied).
    /// </summary>
    public QuantifiablePattern AnyNative()
    {
        return AppendInternal(PatternFactory.AnyNative());
    }

    /// <summary>
    /// Appends a pattern that matches any character except linefeed (or any character if the <see cref="RegexOptions.Singleline"/> option is applied) specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup AnyNative(int exactCount)
    {
        return AppendInternal(PatternFactory.AnyNative(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches any character zero or more times but as few times as possible.
    /// </summary>
    public Pattern Crawl()
    {
        return AppendInternal(PatternFactory.Crawl());
    }

    /// <summary>
    /// Appends a pattern that matches any character except linefeed and carriage return zero or more times but as few times as possible.
    /// </summary>
    public Pattern CrawlLine()
    {
        return AppendInternal(PatternFactory.CrawlLine());
    }

    /// <summary>
    /// Appends a pattern that matches any character except linefeed (or any character if the <see cref="RegexOptions.Singleline"/> option is applied) zero or more times but as few times as possible.
    /// </summary>
    public Pattern CrawlNative()
    {
        return AppendInternal(PatternFactory.CrawlNative());
    }

    /// <summary>
    /// Appends a pattern that matches an alphanumeric character. Alphanumeric character is a latin alphabet letter or an arabic digit.
    /// </summary>
    public CharGroup Alphanumeric()
    {
        return AppendInternal(PatternFactory.Alphanumeric());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of alphanumeric characters. Alphanumeric character is a latin alphabet letter or an arabic digit.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Alphanumeric(int exactCount)
    {
        return AppendInternal(PatternFactory.Alphanumeric(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an alphanumeric character. Alphanumeric character is a latin alphabet letter or an arabic digit.
    /// </summary>
    public CharGroup NotAlphanumeric()
    {
        return AppendInternal(PatternFactory.NotAlphanumeric());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an alphanumeric character specified number of times. Alphanumeric character is a latin alphabet letter or an arabic digit.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotAlphanumeric(int exactCount)
    {
        return AppendInternal(PatternFactory.NotAlphanumeric(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a lower-case alphanumeric character. Alphanumeric character is a latin alphabet lower-case letter or an arabic digit.
    /// </summary>
    public QuantifiablePattern AlphanumericLower()
    {
        return AppendInternal(PatternFactory.AlphanumericLower());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of lower-case alphanumeric characters. Alphanumeric character is a latin alphabet lower-case letter or an arabic digit.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup AlphanumericLower(int exactCount)
    {
        return AppendInternal(PatternFactory.AlphanumericLower(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a lower-case alphanumeric character. Alphanumeric character is a latin alphabet lower-case letter or an arabic digit.
    /// </summary>
    public QuantifiablePattern NotAlphanumericLower()
    {
        return AppendInternal(PatternFactory.NotAlphanumericLower());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a lower-case alphanumeric character specified number of times. Alphanumeric character is a latin alphabet lower-case letter or an arabic digit.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotAlphanumericLower(int exactCount)
    {
        return AppendInternal(PatternFactory.NotAlphanumericLower(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches an upper-case alphanumeric character. Alphanumeric character is a latin alphabet upper-case letter or an arabic digit.
    /// </summary>
    public QuantifiablePattern AlphanumericUpper()
    {
        return AppendInternal(PatternFactory.AlphanumericUpper());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of upper-case alphanumeric characters. Alphanumeric character is a latin alphabet upper-case letter or an arabic digit.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup AlphanumericUpper(int exactCount)
    {
        return AppendInternal(PatternFactory.AlphanumericUpper(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an upper-case alphanumeric character. Alphanumeric character is a latin alphabet upper-case letter or an arabic digit.
    /// </summary>
    public QuantifiablePattern NotAlphanumericUpper()
    {
        return AppendInternal(PatternFactory.NotAlphanumericUpper());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an upper-case alphanumeric character specified number of times. Alphanumeric character is a latin alphabet upper-case letter or an arabic digit.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotAlphanumericUpper(int exactCount)
    {
        return AppendInternal(PatternFactory.NotAlphanumericUpper(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches an alphanumeric character or an underscore. Alphanumeric character is a latin alphabet letter or an arabic digit.
    /// </summary>
    public CharGroup AlphanumericUnderscore()
    {
        return AppendInternal(PatternFactory.AlphanumericUnderscore());
    }

    /// <summary>
    /// Appends a pattern that matches an alphanumeric character or an underscore specified number of times. Alphanumeric character is a latin alphabet letter or an arabic digit.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup AlphanumericUnderscore(int exactCount)
    {
        return AppendInternal(PatternFactory.AlphanumericUnderscore(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is neither alphanumeric character nor underscore. Alphanumeric character is a latin alphabet letter or an arabic digit.
    /// </summary>
    public CharGroup NotAlphanumericUnderscore()
    {
        return AppendInternal(PatternFactory.NotAlphanumericUnderscore());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is neither alphanumeric character nor underscore specified number of times. Alphanumeric character is a latin alphabet letter or an arabic digit.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotAlphanumericUnderscore(int exactCount)
    {
        return AppendInternal(PatternFactory.NotAlphanumericUnderscore(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a latin alphabet letter.
    /// </summary>
    public CharGroup LatinLetter()
    {
        return AppendInternal(PatternFactory.LatinLetter());
    }

    /// <summary>
    /// Appends a pattern that matches one or more latin alphabet letter.
    /// </summary>
    public QuantifiedPattern LatinLetters()
    {
        return AppendInternal(PatternFactory.LatinLetters());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of latin alphabet letters.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup LatinLetter(int exactCount)
    {
        return AppendInternal(PatternFactory.LatinLetter(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a latin alphabet lower-case letter.
    /// </summary>
    public QuantifiablePattern LatinLetterLower()
    {
        return AppendInternal(PatternFactory.LatinLetterLower());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of latin alphabet lower-case letters.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup LatinLetterLower(int exactCount)
    {
        return AppendInternal(PatternFactory.LatinLetterLower(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a latin alphabet upper-case letter.
    /// </summary>
    public QuantifiablePattern LatinLetterUpper()
    {
        return AppendInternal(PatternFactory.LatinLetterUpper());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of latin alphabet upper-case letters.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup LatinLetterUpper(int exactCount)
    {
        return AppendInternal(PatternFactory.LatinLetterUpper(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a latin alphabet letter.
    /// </summary>
    public CharGroup NotLatinLetter()
    {
        return AppendInternal(PatternFactory.NotLatinLetter());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a latin alphabet letter specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotLatinLetter(int exactCount)
    {
        return AppendInternal(PatternFactory.NotLatinLetter(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a latin alphabet lower-case letter.
    /// </summary>
    public QuantifiablePattern NotLatinLetterLower()
    {
        return AppendInternal(PatternFactory.NotLatinLetterLower());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a latin alphabet lower-case letter specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotLatinLetterLower(int exactCount)
    {
        return AppendInternal(PatternFactory.NotLatinLetterLower(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a latin alphabet upper-case letter.
    /// </summary>
    public QuantifiablePattern NotLatinLetterUpper()
    {
        return AppendInternal(PatternFactory.NotLatinLetterUpper());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a latin alphabet upper-case letter specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotLatinLetterUpper(int exactCount)
    {
        return AppendInternal(PatternFactory.NotLatinLetterUpper(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character from <see cref="GeneralCategory.LetterLowercase"/>.
    /// </summary>
    public QuantifiablePattern LetterLower()
    {
        return AppendInternal(PatternFactory.LetterLower());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of letters from <see cref="GeneralCategory.LetterLowercase"/>.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup LetterLower(int exactCount)
    {
        return AppendInternal(PatternFactory.LetterLower(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a character from <see cref="GeneralCategory.LetterLowercase"/>.
    /// </summary>
    public QuantifiablePattern NotLetterLower()
    {
        return AppendInternal(PatternFactory.NotLetterLower());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a character from <see cref="GeneralCategory.LetterLowercase"/> specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotLetterLower(int exactCount)
    {
        return AppendInternal(PatternFactory.NotLetterLower(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character from <see cref="GeneralCategory.LetterUppercase"/>.
    /// </summary>
    public QuantifiablePattern LetterUpper()
    {
        return AppendInternal(PatternFactory.LetterUpper());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of letters from <see cref="GeneralCategory.LetterUppercase"/>.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup LetterUpper(int exactCount)
    {
        return AppendInternal(PatternFactory.LetterUpper(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a character from <see cref="GeneralCategory.LetterUppercase"/>.
    /// </summary>
    public QuantifiablePattern NotLetterUpper()
    {
        return AppendInternal(PatternFactory.NotLetterUpper());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a character from <see cref="GeneralCategory.LetterUppercase"/> specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotLetterUpper(int exactCount)
    {
        return AppendInternal(PatternFactory.NotLetterUpper(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches an arabic digit.
    /// </summary>
    public QuantifiablePattern ArabicDigit()
    {
        return AppendInternal(PatternFactory.ArabicDigit());
    }

    /// <summary>
    /// Appends a pattern that matches one or more arabic digits.
    /// </summary>
    public QuantifiedPattern ArabicDigits()
    {
        return AppendInternal(PatternFactory.ArabicDigits());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of arabic digits.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup ArabicDigit(int exactCount)
    {
        return AppendInternal(PatternFactory.ArabicDigit(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an arabic digit.
    /// </summary>
    public QuantifiablePattern NotArabicDigit()
    {
        return AppendInternal(PatternFactory.NotArabicDigit());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an arabic digit specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotArabicDigit(int exactCount)
    {
        return AppendInternal(PatternFactory.NotArabicDigit(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a hexadecimal digit.
    /// </summary>
    public QuantifiablePattern HexadecimalDigit()
    {
        return AppendInternal(PatternFactory.HexadecimalDigit());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of hexadecimal digits.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup HexadecimalDigit(int exactCount)
    {
        return AppendInternal(PatternFactory.HexadecimalDigit(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a hexadecimal digit.
    /// </summary>
    public QuantifiablePattern NotHexadecimalDigit()
    {
        return AppendInternal(PatternFactory.NotHexadecimalDigit());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a hexadecimal digit specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotHexadecimalDigit(int exactCount)
    {
        return AppendInternal(PatternFactory.NotHexadecimalDigit(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a digit character.
    /// </summary>
    public QuantifiablePattern Digit()
    {
        return AppendInternal(PatternFactory.Digit());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of digit characters.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Digit(int exactCount)
    {
        return AppendInternal(PatternFactory.Digit(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches one or more digit characters.
    /// </summary>
    public QuantifiedGroup Digits()
    {
        return AppendInternal(PatternFactory.Digits());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a digit character.
    /// </summary>
    public QuantifiablePattern NotDigit()
    {
        return AppendInternal(PatternFactory.NotDigit());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a digit character specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotDigit(int exactCount)
    {
        return AppendInternal(PatternFactory.NotDigit(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches one or more characters that are not a digit character.
    /// </summary>
    public QuantifiedGroup NotDigits()
    {
        return AppendInternal(PatternFactory.NotDigits());
    }

    /// <summary>
    /// Appends a pattern that matches a white-space character.
    /// </summary>
    public QuantifiablePattern WhiteSpace()
    {
        return AppendInternal(PatternFactory.WhiteSpace());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of white-space characters.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup WhiteSpace(int exactCount)
    {
        return AppendInternal(PatternFactory.WhiteSpace(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches one or more white-space characters.
    /// </summary>
    public QuantifiedGroup WhiteSpaces()
    {
        return AppendInternal(PatternFactory.WhiteSpaces());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a white-space character.
    /// </summary>
    public QuantifiablePattern NotWhiteSpace()
    {
        return AppendInternal(PatternFactory.NotWhiteSpace());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a white-space character specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotWhiteSpace(int exactCount)
    {
        return AppendInternal(PatternFactory.NotWhiteSpace(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches one or more characters that are not a white-space character.
    /// </summary>
    public QuantifiedGroup NotWhiteSpaces()
    {
        return AppendInternal(PatternFactory.NotWhiteSpaces());
    }

    /// <summary>
    /// Appends a pattern that matches a word character.
    /// </summary>
    public QuantifiablePattern WordChar()
    {
        return AppendInternal(PatternFactory.WordChar());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of word characters.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup WordChar(int exactCount)
    {
        return AppendInternal(PatternFactory.WordChar(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches one or more word characters.
    /// </summary>
    public QuantifiedGroup WordChars()
    {
        return AppendInternal(PatternFactory.WordChars());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a word character.
    /// </summary>
    public QuantifiablePattern NotWordChar()
    {
        return AppendInternal(PatternFactory.NotWordChar());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a word character specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotWordChar(int exactCount)
    {
        return AppendInternal(PatternFactory.NotWordChar(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches one or more characters that are not a word character.
    /// </summary>
    public QuantifiedGroup NotWordChars()
    {
        return AppendInternal(PatternFactory.NotWordChars());
    }

    /// <summary>
    /// Appends a pattern that matches a specified character.
    /// </summary>
    /// <param name="value">A Unicode character.</param>
    public QuantifiablePattern Character(char value)
    {
        return AppendInternal(PatternFactory.Character(value));
    }

    /// <summary>
    /// Appends a pattern that matches a specified character.
    /// </summary>
    /// <param name="value">An enumerated constant that identifies ASCII character.</param>
    public QuantifiablePattern Character(AsciiChar value)
    {
        return AppendInternal(PatternFactory.Character(value));
    }

    /// <summary>
    /// Appends a pattern that matches a character from a specified Unicode block.
    /// </summary>
    /// <param name="block">An enumerated constant that identifies Unicode block.</param>
    public QuantifiablePattern Character(NamedBlock block)
    {
        return AppendInternal(PatternFactory.Character(block));
    }

    /// <summary>
    /// Appends a pattern that matches a character from a specified Unicode category.
    /// </summary>
    /// <param name="category">An enumerated constant that identifies Unicode category.</param>
    public QuantifiablePattern Character(GeneralCategory category)
    {
        return AppendInternal(PatternFactory.Character(category));
    }

    /// <summary>
    /// Appends a pattern that matches a character from a specified <see cref="string"/>.
    /// </summary>
    /// <param name="characters">A set of characters any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="characters"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="characters"/> length is equal to zero.</exception>
    public QuantifiablePattern Character(string characters)
    {
        return AppendInternal(PatternFactory.Character(characters));
    }

    /// <summary>
    /// Appends a pattern that matches a character from a specified <see cref="CharGrouping"/>.
    /// </summary>
    /// <param name="value">A content of a character group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public QuantifiablePattern Character(CharGrouping value)
    {
        return AppendInternal(PatternFactory.Character(value));
    }

    /// <summary>
    /// Appends a pattern that matches a specified character one or more times.
    /// </summary>
    /// <param name="value">A Unicode character.</param>
    public QuantifiedGroup Characters(char value)
    {
        return AppendInternal(PatternFactory.Characters(value));
    }

    /// <summary>
    /// Appends a pattern that matches a specified character one or more times.
    /// </summary>
    /// <param name="value">An enumerated constant that identifies ASCII character.</param>
    public QuantifiedGroup Characters(AsciiChar value)
    {
        return AppendInternal(PatternFactory.Characters(value));
    }

    /// <summary>
    /// Appends a pattern that matches one or more characters from a specified Unicode block.
    /// </summary>
    /// <param name="block">An enumerated constant that identifies Unicode block.</param>
    public QuantifiedGroup Characters(NamedBlock block)
    {
        return AppendInternal(PatternFactory.Characters(block));
    }

    /// <summary>
    /// Appends a pattern that matches one or more characters from a specified Unicode category.
    /// </summary>
    /// <param name="category">An enumerated constant that identifies Unicode category.</param>
    public QuantifiedGroup Characters(GeneralCategory category)
    {
        return AppendInternal(PatternFactory.Characters(category));
    }

    /// <summary>
    /// Appends a pattern that matches one or more characters from a specified <see cref="string"/>.
    /// </summary>
    /// <param name="value">A set of characters any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="value"/> length is equal to zero.</exception>
    public QuantifiedGroup Characters(string value)
    {
        return AppendInternal(PatternFactory.Characters(value));
    }

    /// <summary>
    /// Appends a pattern that matches one or more characters from a specified <see cref="CharGrouping"/>.
    /// </summary>
    /// <param name="value">A content of a character group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public QuantifiedGroup Characters(CharGrouping value)
    {
        return AppendInternal(PatternFactory.Characters(value));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a specified character.
    /// </summary>
    /// <param name="value">A Unicode character.</param>
    public QuantifiablePattern NotChar(char value)
    {
        return AppendInternal(PatternFactory.NotChar(value));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a specified character.
    /// </summary>
    /// <param name="value">An enumerated constant that identifies ASCII character.</param>
    public QuantifiablePattern NotChar(AsciiChar value)
    {
        return AppendInternal(PatternFactory.NotChar(value));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not from a specified Unicode block.
    /// </summary>
    /// <param name="block">An enumerated constant that identifies Unicode block.</param>
    public QuantifiablePattern NotChar(NamedBlock block)
    {
        return AppendInternal(PatternFactory.NotChar(block));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not from a specified Unicode category.
    /// </summary>
    /// <param name="category">An enumerated constant that identifies Unicode category.</param>
    public QuantifiablePattern NotChar(GeneralCategory category)
    {
        return AppendInternal(PatternFactory.NotChar(category));
    }

    /// <summary>
    /// Appends a pattern that matches any character that is not contained in the specified <see cref="string"/>.
    /// </summary>
    /// <param name="characters">Unicode characters.</param>
    /// <exception cref="ArgumentNullException"><paramref name="characters"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="characters"/> length is equal to zero.</exception>
    public QuantifiablePattern NotChar(string characters)
    {
        return AppendInternal(PatternFactory.NotChar(characters));
    }

    /// <summary>
    /// Appends a pattern that matches any character that is not contained in the specified characters.
    /// </summary>
    /// <param name="characters">Unicode characters.</param>
    /// <exception cref="ArgumentNullException"><paramref name="characters"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="characters"/> is empty.</exception>
    public CharGroup NotChar(params char[] characters)
    {
        return AppendInternal(PatternFactory.NotChar(characters));
    }

    /// <summary>
    /// Appends a negative character group containing specified <see cref="CharGrouping"/>.
    /// </summary>
    /// <param name="value">A content of a character group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public QuantifiablePattern NotChar(CharGrouping value)
    {
        return AppendInternal(PatternFactory.NotChar(value));
    }

    /// <summary>
    /// Appends a pattern that matches a tab.
    /// </summary>
    public QuantifiablePattern Tab()
    {
        return AppendInternal(PatternFactory.Tab());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of tabs.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Tab(int exactCount)
    {
        return AppendInternal(PatternFactory.Tab(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a tab.
    /// </summary>
    public QuantifiablePattern NotTab()
    {
        return AppendInternal(PatternFactory.NotTab());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a tab.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotTab(int exactCount)
    {
        return AppendInternal(PatternFactory.NotTab(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a linefeed.
    /// </summary>
    public QuantifiablePattern Linefeed()
    {
        return AppendInternal(PatternFactory.Linefeed());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of linefeeds.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Linefeed(int exactCount)
    {
        return AppendInternal(PatternFactory.Linefeed(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a linefeed.
    /// </summary>
    public QuantifiablePattern NotLinefeed()
    {
        return AppendInternal(PatternFactory.NotLinefeed());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a linefeed.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotLinefeed(int exactCount)
    {
        return AppendInternal(PatternFactory.NotLinefeed(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a carriage return.
    /// </summary>
    public QuantifiablePattern CarriageReturn()
    {
        return AppendInternal(PatternFactory.CarriageReturn());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of carriage returns.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup CarriageReturn(int exactCount)
    {
        return AppendInternal(PatternFactory.CarriageReturn(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a carriage return.
    /// </summary>
    public QuantifiablePattern NotCarriageReturn()
    {
        return AppendInternal(PatternFactory.NotCarriageReturn());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a carriage return.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotCarriageReturn(int exactCount)
    {
        return AppendInternal(PatternFactory.NotCarriageReturn(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a space.
    /// </summary>
    public QuantifiablePattern Space()
    {
        return AppendInternal(PatternFactory.Space());
    }

    /// <summary>
    /// Appends a pattern that matches one or more spaces.
    /// </summary>
    public QuantifiedPattern Spaces()
    {
        return AppendInternal(PatternFactory.Spaces());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of spaces.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Space(int exactCount)
    {
        return AppendInternal(PatternFactory.Space(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a space.
    /// </summary>
    public QuantifiablePattern NotSpace()
    {
        return AppendInternal(PatternFactory.NotSpace());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a space.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotSpace(int exactCount)
    {
        return AppendInternal(PatternFactory.NotSpace(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches an exclamation mark.
    /// </summary>
    public QuantifiablePattern ExclamationMark()
    {
        return AppendInternal(PatternFactory.ExclamationMark());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of exclamation marks.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup ExclamationMark(int exactCount)
    {
        return AppendInternal(PatternFactory.ExclamationMark(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an exclamation mark.
    /// </summary>
    public QuantifiablePattern NotExclamationMark()
    {
        return AppendInternal(PatternFactory.NotExclamationMark());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not an exclamation mark.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotExclamationMark(int exactCount)
    {
        return AppendInternal(PatternFactory.NotExclamationMark(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a quote mark.
    /// </summary>
    public QuantifiablePattern QuoteMark()
    {
        return AppendInternal(PatternFactory.QuoteMark());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of quote marks.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup QuoteMark(int exactCount)
    {
        return AppendInternal(PatternFactory.QuoteMark(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a quote mark.
    /// </summary>
    public QuantifiablePattern NotQuoteMark()
    {
        return AppendInternal(PatternFactory.NotQuoteMark());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a quote mark.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotQuoteMark(int exactCount)
    {
        return AppendInternal(PatternFactory.NotQuoteMark(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a number sign.
    /// </summary>
    public QuantifiablePattern NumberSign()
    {
        return AppendInternal(PatternFactory.NumberSign());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of number signs.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NumberSign(int exactCount)
    {
        return AppendInternal(PatternFactory.NumberSign(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a number sign.
    /// </summary>
    public QuantifiablePattern NotNumberSign()
    {
        return AppendInternal(PatternFactory.NotNumberSign());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a number sign.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotNumberSign(int exactCount)
    {
        return AppendInternal(PatternFactory.NotNumberSign(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a dollar.
    /// </summary>
    public QuantifiablePattern Dollar()
    {
        return AppendInternal(PatternFactory.Dollar());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of dollars.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Dollar(int exactCount)
    {
        return AppendInternal(PatternFactory.Dollar(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a dollar.
    /// </summary>
    public QuantifiablePattern NotDollar()
    {
        return AppendInternal(PatternFactory.NotDollar());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a dollar.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotDollar(int exactCount)
    {
        return AppendInternal(PatternFactory.NotDollar(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a percent.
    /// </summary>
    public QuantifiablePattern Percent()
    {
        return AppendInternal(PatternFactory.Percent());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of percents.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Percent(int exactCount)
    {
        return AppendInternal(PatternFactory.Percent(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a percent.
    /// </summary>
    public QuantifiablePattern NotPercent()
    {
        return AppendInternal(PatternFactory.NotPercent());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a percent.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotPercent(int exactCount)
    {
        return AppendInternal(PatternFactory.NotPercent(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches an ampersand.
    /// </summary>
    public QuantifiablePattern Ampersand()
    {
        return AppendInternal(PatternFactory.Ampersand());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of ampersands.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Ampersand(int exactCount)
    {
        return AppendInternal(PatternFactory.Ampersand(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an ampersand.
    /// </summary>
    public QuantifiablePattern NotAmpersand()
    {
        return AppendInternal(PatternFactory.NotAmpersand());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not an ampersand.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotAmpersand(int exactCount)
    {
        return AppendInternal(PatternFactory.NotAmpersand(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches an apostrophe.
    /// </summary>
    public QuantifiablePattern Apostrophe()
    {
        return AppendInternal(PatternFactory.Apostrophe());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of apostrophes.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Apostrophe(int exactCount)
    {
        return AppendInternal(PatternFactory.Apostrophe(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an apostrophe.
    /// </summary>
    public QuantifiablePattern NotApostrophe()
    {
        return AppendInternal(PatternFactory.NotApostrophe());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not an apostrophe.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotApostrophe(int exactCount)
    {
        return AppendInternal(PatternFactory.NotApostrophe(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a left parenthesis.
    /// </summary>
    public QuantifiablePattern LeftParenthesis()
    {
        return AppendInternal(PatternFactory.LeftParenthesis());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of left parentheses.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup LeftParenthesis(int exactCount)
    {
        return AppendInternal(PatternFactory.LeftParenthesis(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a left parenthesis.
    /// </summary>
    public QuantifiablePattern NotLeftParenthesis()
    {
        return AppendInternal(PatternFactory.NotLeftParenthesis());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a left parenthesis.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotLeftParenthesis(int exactCount)
    {
        return AppendInternal(PatternFactory.NotLeftParenthesis(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a right parenthesis.
    /// </summary>
    public QuantifiablePattern RightParenthesis()
    {
        return AppendInternal(PatternFactory.RightParenthesis());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of right parentheses.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup RightParenthesis(int exactCount)
    {
        return AppendInternal(PatternFactory.RightParenthesis(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a right parenthesis.
    /// </summary>
    public QuantifiablePattern NotRightParenthesis()
    {
        return AppendInternal(PatternFactory.NotRightParenthesis());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a right parenthesis.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotRightParenthesis(int exactCount)
    {
        return AppendInternal(PatternFactory.NotRightParenthesis(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches an asterisk.
    /// </summary>
    public QuantifiablePattern Asterisk()
    {
        return AppendInternal(PatternFactory.Asterisk());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of asterisks.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Asterisk(int exactCount)
    {
        return AppendInternal(PatternFactory.Asterisk(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an asterisk.
    /// </summary>
    public QuantifiablePattern NotAsterisk()
    {
        return AppendInternal(PatternFactory.NotAsterisk());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not an asterisk.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotAsterisk(int exactCount)
    {
        return AppendInternal(PatternFactory.NotAsterisk(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a plus.
    /// </summary>
    public QuantifiablePattern Plus()
    {
        return AppendInternal(PatternFactory.Plus());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of pluses.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Plus(int exactCount)
    {
        return AppendInternal(PatternFactory.Plus(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a plus.
    /// </summary>
    public QuantifiablePattern NotPlus()
    {
        return AppendInternal(PatternFactory.NotPlus());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a plus.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotPlus(int exactCount)
    {
        return AppendInternal(PatternFactory.NotPlus(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a comma.
    /// </summary>
    public QuantifiablePattern Comma()
    {
        return AppendInternal(PatternFactory.Comma());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of commas.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Comma(int exactCount)
    {
        return AppendInternal(PatternFactory.Comma(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a comma.
    /// </summary>
    public QuantifiablePattern NotComma()
    {
        return AppendInternal(PatternFactory.NotComma());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a comma.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotComma(int exactCount)
    {
        return AppendInternal(PatternFactory.NotComma(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a hyphen.
    /// </summary>
    public QuantifiablePattern Hyphen()
    {
        return AppendInternal(PatternFactory.Hyphen());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of hyphens.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Hyphen(int exactCount)
    {
        return AppendInternal(PatternFactory.Hyphen(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a hyphen.
    /// </summary>
    public QuantifiablePattern NotHyphen()
    {
        return AppendInternal(PatternFactory.NotHyphen());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a hyphen.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotHyphen(int exactCount)
    {
        return AppendInternal(PatternFactory.NotHyphen(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a dot.
    /// </summary>
    public QuantifiablePattern Dot()
    {
        return AppendInternal(PatternFactory.Dot());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of dots.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Dot(int exactCount)
    {
        return AppendInternal(PatternFactory.Dot(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a dot.
    /// </summary>
    public QuantifiablePattern NotDot()
    {
        return AppendInternal(PatternFactory.NotDot());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a dot.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotDot(int exactCount)
    {
        return AppendInternal(PatternFactory.NotDot(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a slash.
    /// </summary>
    public QuantifiablePattern Slash()
    {
        return AppendInternal(PatternFactory.Slash());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of slashes.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Slash(int exactCount)
    {
        return AppendInternal(PatternFactory.Slash(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a slash.
    /// </summary>
    public QuantifiablePattern NotSlash()
    {
        return AppendInternal(PatternFactory.NotSlash());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a slash.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotSlash(int exactCount)
    {
        return AppendInternal(PatternFactory.NotSlash(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a slash or a backslash.
    /// </summary>
    public CharGroup SlashOrBackslash()
    {
        return AppendInternal(PatternFactory.SlashOrBackslash());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are slash or backslash.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup SlashOrBackslash(int exactCount)
    {
        return AppendInternal(PatternFactory.SlashOrBackslash(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a slash or backslash.
    /// </summary>
    public QuantifiablePattern NotSlashOrBackslash()
    {
        return AppendInternal(PatternFactory.NotSlashOrBackslash());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a slash or backslash
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotSlashOrBackslash(int exactCount)
    {
        return AppendInternal(PatternFactory.NotSlashOrBackslash(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a colon.
    /// </summary>
    public QuantifiablePattern Colon()
    {
        return AppendInternal(PatternFactory.Colon());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of colons.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Colon(int exactCount)
    {
        return AppendInternal(PatternFactory.Colon(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a colon.
    /// </summary>
    public QuantifiablePattern NotColon()
    {
        return AppendInternal(PatternFactory.NotColon());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a colon.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotColon(int exactCount)
    {
        return AppendInternal(PatternFactory.NotColon(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a semicolon.
    /// </summary>
    public QuantifiablePattern Semicolon()
    {
        return AppendInternal(PatternFactory.Semicolon());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of semicolons.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Semicolon(int exactCount)
    {
        return AppendInternal(PatternFactory.Semicolon(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a semicolon.
    /// </summary>
    public QuantifiablePattern NotSemicolon()
    {
        return AppendInternal(PatternFactory.NotSemicolon());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a semicolon.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotSemicolon(int exactCount)
    {
        return AppendInternal(PatternFactory.NotSemicolon(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a left angle bracket (less-than sign).
    /// </summary>
    public QuantifiablePattern LeftAngleBracket()
    {
        return AppendInternal(PatternFactory.LeftAngleBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of left angle brackets (less-than signs).
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup LeftAngleBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.LeftAngleBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a left angle bracket (less-than sign).
    /// </summary>
    public QuantifiablePattern NotLeftAngleBracket()
    {
        return AppendInternal(PatternFactory.NotLeftAngleBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a left angle bracket (less-than sign).
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotLeftAngleBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.NotLeftAngleBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches an equals sign.
    /// </summary>
    public QuantifiablePattern EqualsSign()
    {
        return AppendInternal(PatternFactory.EqualsSign());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of equals signs.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup EqualsSign(int exactCount)
    {
        return AppendInternal(PatternFactory.EqualsSign(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an equals sign.
    /// </summary>
    public QuantifiablePattern NotEqualsSign()
    {
        return AppendInternal(PatternFactory.NotEqualsSign());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not an equals sign.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotEqualsSign(int exactCount)
    {
        return AppendInternal(PatternFactory.NotEqualsSign(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a right angle bracket (greater-than sign).
    /// </summary>
    public QuantifiablePattern RightAngleBracket()
    {
        return AppendInternal(PatternFactory.RightAngleBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of right angle brackets (greater-than signs).
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup RightAngleBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.RightAngleBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an right angle bracket (greater-than sign).
    /// </summary>
    public QuantifiablePattern NotRightAngleBracket()
    {
        return AppendInternal(PatternFactory.NotRightAngleBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a right angle bracket (greater-than sign).
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotRightAngleBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.NotRightAngleBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a question mark.
    /// </summary>
    public QuantifiablePattern QuestionMark()
    {
        return AppendInternal(PatternFactory.QuestionMark());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of question marks.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup QuestionMark(int exactCount)
    {
        return AppendInternal(PatternFactory.QuestionMark(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a question mark.
    /// </summary>
    public QuantifiablePattern NotQuestionMark()
    {
        return AppendInternal(PatternFactory.NotQuestionMark());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a question mark.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotQuestionMark(int exactCount)
    {
        return AppendInternal(PatternFactory.NotQuestionMark(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches an at sign.
    /// </summary>
    public QuantifiablePattern AtSign()
    {
        return AppendInternal(PatternFactory.AtSign());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of at signs.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup AtSign(int exactCount)
    {
        return AppendInternal(PatternFactory.AtSign(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an at sign.
    /// </summary>
    public QuantifiablePattern NotAtSign()
    {
        return AppendInternal(PatternFactory.NotAtSign());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not an at sign.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotAtSign(int exactCount)
    {
        return AppendInternal(PatternFactory.NotAtSign(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a left square bracket.
    /// </summary>
    public QuantifiablePattern LeftSquareBracket()
    {
        return AppendInternal(PatternFactory.LeftSquareBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of left square brackets.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup LeftSquareBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.LeftSquareBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a left square bracket.
    /// </summary>
    public QuantifiablePattern NotLeftSquareBracket()
    {
        return AppendInternal(PatternFactory.NotLeftSquareBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a left square bracket.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotLeftSquareBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.NotLeftSquareBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a backslash.
    /// </summary>
    public QuantifiablePattern Backslash()
    {
        return AppendInternal(PatternFactory.Backslash());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of backslashes.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Backslash(int exactCount)
    {
        return AppendInternal(PatternFactory.Backslash(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a backslash.
    /// </summary>
    public QuantifiablePattern NotBackslash()
    {
        return AppendInternal(PatternFactory.NotBackslash());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a backslash.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotBackslash(int exactCount)
    {
        return AppendInternal(PatternFactory.NotBackslash(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a right square bracket.
    /// </summary>
    public QuantifiablePattern RightSquareBracket()
    {
        return AppendInternal(PatternFactory.RightSquareBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of right square brackets.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup RightSquareBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.RightSquareBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a right square bracket.
    /// </summary>
    public QuantifiablePattern NotRightSquareBracket()
    {
        return AppendInternal(PatternFactory.NotRightSquareBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a right square bracket.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotRightSquareBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.NotRightSquareBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a circumflex accent.
    /// </summary>
    public QuantifiablePattern CircumflexAccent()
    {
        return AppendInternal(PatternFactory.CircumflexAccent());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of circumflex accents.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup CircumflexAccent(int exactCount)
    {
        return AppendInternal(PatternFactory.CircumflexAccent(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a circumflex accent.
    /// </summary>
    public QuantifiablePattern NotCircumflexAccent()
    {
        return AppendInternal(PatternFactory.NotCircumflexAccent());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a circumflex accent.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotCircumflexAccent(int exactCount)
    {
        return AppendInternal(PatternFactory.NotCircumflexAccent(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches an underscore.
    /// </summary>
    public QuantifiablePattern Underscore()
    {
        return AppendInternal(PatternFactory.Underscore());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of underscores.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Underscore(int exactCount)
    {
        return AppendInternal(PatternFactory.Underscore(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not an underscore.
    /// </summary>
    public QuantifiablePattern NotUnderscore()
    {
        return AppendInternal(PatternFactory.NotUnderscore());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not an underscore.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotUnderscore(int exactCount)
    {
        return AppendInternal(PatternFactory.NotUnderscore(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a grave accent.
    /// </summary>
    public QuantifiablePattern GraveAccent()
    {
        return AppendInternal(PatternFactory.GraveAccent());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of grave accents.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup GraveAccent(int exactCount)
    {
        return AppendInternal(PatternFactory.GraveAccent(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a grave accent.
    /// </summary>
    public QuantifiablePattern NotGraveAccent()
    {
        return AppendInternal(PatternFactory.NotGraveAccent());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a grave accent.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotGraveAccent(int exactCount)
    {
        return AppendInternal(PatternFactory.NotGraveAccent(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a left curly bracket.
    /// </summary>
    public QuantifiablePattern LeftCurlyBracket()
    {
        return AppendInternal(PatternFactory.LeftCurlyBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of left curly brackets.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup LeftCurlyBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.LeftCurlyBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a left curly bracket.
    /// </summary>
    public QuantifiablePattern NotLeftCurlyBracket()
    {
        return AppendInternal(PatternFactory.NotLeftCurlyBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a left curly bracket.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotLeftCurlyBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.NotLeftCurlyBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a vertical bar.
    /// </summary>
    public QuantifiablePattern VerticalBar()
    {
        return AppendInternal(PatternFactory.VerticalBar());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of vertical bars.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup VerticalBar(int exactCount)
    {
        return AppendInternal(PatternFactory.VerticalBar(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a vertical bar.
    /// </summary>
    public QuantifiablePattern NotVerticalBar()
    {
        return AppendInternal(PatternFactory.NotVerticalBar());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a vertical bar.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotVerticalBar(int exactCount)
    {
        return AppendInternal(PatternFactory.NotVerticalBar(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a right curly bracket.
    /// </summary>
    public QuantifiablePattern RightCurlyBracket()
    {
        return AppendInternal(PatternFactory.RightCurlyBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of right curly brackets.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup RightCurlyBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.RightCurlyBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a right curly bracket.
    /// </summary>
    public QuantifiablePattern NotRightCurlyBracket()
    {
        return AppendInternal(PatternFactory.NotRightCurlyBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a right curly bracket.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotRightCurlyBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.NotRightCurlyBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a tilde.
    /// </summary>
    public QuantifiablePattern Tilde()
    {
        return AppendInternal(PatternFactory.Tilde());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of tildes.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Tilde(int exactCount)
    {
        return AppendInternal(PatternFactory.Tilde(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a tilde.
    /// </summary>
    public QuantifiablePattern NotTilde()
    {
        return AppendInternal(PatternFactory.NotTilde());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of characters that are not a tilde.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotTilde(int exactCount)
    {
        return AppendInternal(PatternFactory.NotTilde(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches left or right parenthesis.
    /// </summary>
    public CharGroup Parenthesis()
    {
        return AppendInternal(PatternFactory.Parenthesis());
    }

    /// <summary>
    /// Appends a pattern that matches left or right parenthesis specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Parenthesis(int exactCount)
    {
        return AppendInternal(PatternFactory.Parenthesis(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is neither left nor right parenthesis.
    /// </summary>
    public CharGroup NotParenthesis()
    {
        return AppendInternal(PatternFactory.NotParenthesis());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is neither left nor right parenthesis specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotParenthesis(int exactCount)
    {
        return AppendInternal(PatternFactory.NotParenthesis(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches left or right curly bracket.
    /// </summary>
    public CharGroup CurlyBracket()
    {
        return AppendInternal(PatternFactory.CurlyBracket());
    }

    /// <summary>
    /// Appends a pattern that matches left or right curly bracket specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup CurlyBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.CurlyBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is neither left nor right curly bracket.
    /// </summary>
    public CharGroup NotCurlyBracket()
    {
        return AppendInternal(PatternFactory.NotCurlyBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is neither left nor right curly bracket specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotCurlyBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.NotCurlyBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches left or right square bracket.
    /// </summary>
    public CharGroup SquareBracket()
    {
        return AppendInternal(PatternFactory.SquareBracket());
    }

    /// <summary>
    /// Appends a pattern that matches left or right square bracket specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup SquareBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.SquareBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is neither left nor right square bracket.
    /// </summary>
    public CharGroup NotSquareBracket()
    {
        return AppendInternal(PatternFactory.NotSquareBracket());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is neither left nor right square bracket specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotSquareBracket(int exactCount)
    {
        return AppendInternal(PatternFactory.NotSquareBracket(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches specified content zero or one time.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiedGroup Maybe(object content)
    {
        return AppendInternal(PatternFactory.Maybe(content));
    }

    /// <summary>
    /// Appends a pattern that matches any one specified element zero or one time.
    /// </summary>
    /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
    /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="first"/> is <c>null</c>.</exception>
    public QuantifiedGroup Maybe(object first, params object[] others)
    {
        return AppendInternal(PatternFactory.Maybe(first, others));
    }

    /// <summary>
    /// Appends a pattern that matches specified content zero or more times.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiedGroup MaybeMany(object content)
    {
        return AppendInternal(PatternFactory.MaybeMany(content));
    }

    /// <summary>
    /// Appends a pattern that matches any one specified element zero or more times.
    /// </summary>
    /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
    /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="first"/> is <c>null</c>.</exception>
    public QuantifiedGroup MaybeMany(object first, params object[] others)
    {
        return AppendInternal(PatternFactory.MaybeMany(first, others));
    }

    /// <summary>
    /// Appends a pattern that matches specified content one or more times.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    public QuantifiedGroup OneMany(object content)
    {
        return AppendInternal(PatternFactory.OneMany(content));
    }

    /// <summary>
    /// Appends a pattern that matches any one specified element one or more times.
    /// </summary>
    /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
    /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="first"/> is <c>null</c>.</exception>
    public QuantifiedGroup OneMany(object first, params object[] others)
    {
        return AppendInternal(PatternFactory.OneMany(first, others));
    }

    /// <summary>
    /// Appends a pattern that matches specified pattern specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times the pattern has to be matched.</param>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Count(int exactCount, object content)
    {
        return AppendInternal(PatternFactory.Count(exactCount, content));
    }

    /// <summary>
    /// Appends a pattern that matches any one specified pattern specified number of times.
    /// </summary>
    /// <param name="exactCount">A number of times the pattern has to be matched.</param>
    /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
    /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="first"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup Count(int exactCount, object first, params object[] others)
    {
        return AppendInternal(PatternFactory.Count(exactCount, first, others));
    }

    /// <summary>
    /// Appends a pattern that matches specified pattern from minimal to maximum number of times.
    /// </summary>
    /// <param name="minCount">A minimal number of times the pattern must be matched.</param>
    /// <param name="maxCount">A maximum number of times the pattern can be matched.</param>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="minCount"/> is less than zero or <paramref name="maxCount"/> is less than <paramref name="minCount"/>.</exception>
    public QuantifiedGroup Count(int minCount, int maxCount, object content)
    {
        return AppendInternal(PatternFactory.Count(minCount, maxCount, content));
    }

    /// <summary>
    /// Appends a pattern that matches any one specified pattern from minimal to maximum number of times.
    /// </summary>
    /// <param name="minCount">A minimal number of times the pattern must be matched.</param>
    /// <param name="maxCount">A maximum number of times the pattern can be matched.</param>
    /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
    /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="first"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="minCount"/> is less than zero or <paramref name="maxCount"/> is less than <paramref name="minCount"/>.</exception>
    public QuantifiedGroup Count(int minCount, int maxCount, object first, params object[] others)
    {
        return AppendInternal(PatternFactory.Count(minCount, maxCount, first, others));
    }

    /// <summary>
    /// Appends a pattern that matches specified pattern at least specified number of times.
    /// </summary>
    /// <param name="minCount">A minimal number of times the pattern must be matched.</param>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="minCount"/> is less than zero.</exception>
    public QuantifiedGroup CountFrom(int minCount, object content)
    {
        return AppendInternal(PatternFactory.CountFrom(minCount, content));
    }

    /// <summary>
    /// Appends a pattern that matches any one specified pattern at least specified number of times.
    /// </summary>
    /// <param name="minCount">A minimal number of times the pattern must be matched.</param>
    /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
    /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="first"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="minCount"/> is less than zero.</exception>
    public QuantifiedGroup CountFrom(int minCount, object first, params object[] others)
    {
        return AppendInternal(PatternFactory.CountFrom(minCount, first, others));
    }

    /// <summary>
    /// Appends a pattern that matches specified pattern at most specified number of times.
    /// </summary>
    /// <param name="maxCount">A maximum number of times the pattern can be matched.</param>
    /// <param name="content">The content to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="maxCount"/> is less than zero.</exception>
    public QuantifiedGroup MaybeCount(int maxCount, object content)
    {
        return AppendInternal(PatternFactory.MaybeCount(maxCount, content));
    }

    /// <summary>
    /// Appends a pattern that matches any one specified pattern at most specified number of times.
    /// </summary>
    /// <param name="maxCount">A maximum number of times the pattern can be matched.</param>
    /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
    /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="first"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="maxCount"/> is less than zero.</exception>
    public QuantifiedGroup MaybeCount(int maxCount, object first, params object[] others)
    {
        return AppendInternal(PatternFactory.MaybeCount(maxCount, first, others));
    }

    /// <summary>
    /// Appends a pattern that matches previously defined numbered group.
    /// </summary>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="groupNumber"/> is less than zero.</exception>
    public QuantifiablePattern GroupReference(int groupNumber)
    {
        return AppendInternal(PatternFactory.GroupReference(groupNumber));
    }

    /// <summary>
    /// Appends a pattern that matches previously defined named group.
    /// </summary>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="groupName"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="groupName"/> is not a valid regex group name.</exception>
    public QuantifiablePattern GroupReference(string groupName)
    {
        return AppendInternal(PatternFactory.GroupReference(groupName));
    }

    /// <summary>
    /// Appends a pattern that matches a combination of an optional carriage return and a linefeed.
    /// </summary>
    public QuantifiablePattern NewLine()
    {
        return AppendInternal(PatternFactory.NewLine());
    }

    /// <summary>
    /// Appends a pattern that matches a newline character. Newline character is a carriage return or a linefeed.
    /// </summary>
    public QuantifiablePattern NewLineChar()
    {
        return AppendInternal(PatternFactory.NewLineChar());
    }

    /// <summary>
    /// Appends a pattern that matches a specified number of newline characters. Newline character is a carriage return or a linefeed.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NewLineChar(int exactCount)
    {
        return AppendInternal(PatternFactory.NewLineChar(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a newline character. Newline character is a carriage return or a linefeed.
    /// </summary>
    public QuantifiablePattern NotNewLineChar()
    {
        return AppendInternal(PatternFactory.NotNewLineChar());
    }

    /// <summary>
    /// Appends a pattern that matches a character that is not a newline character specified number of times. Newline character is a carriage return or a linefeed.
    /// </summary>
    /// <param name="exactCount">A number of times a character has to be matched.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="exactCount"/> is less than zero.</exception>
    public QuantifiedGroup NotNewLineChar(int exactCount)
    {
        return AppendInternal(PatternFactory.NotNewLineChar(exactCount));
    }

    /// <summary>
    /// Appends a pattern that matches one or many opening characters balanced with one or many closing characters.
    /// Between the characters can be zero or many characters that are neither opening nor closing character.
    /// </summary>
    /// <param name="openingCharacter">Opening Unicode character to balance.</param>
    /// <param name="closingCharacter">Closing Unicode character to balance.</param>
    /// <param name="groupName">A name of the group that contains balanced content of the opening and closing character.</param>
    /// <exception cref="ArgumentNullException"><paramref name="groupName"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="groupName"/> is not a valid regex group name.</exception>
    public Pattern BalanceChar(char openingCharacter, char closingCharacter, string groupName)
    {
        return AppendInternal(PatternFactory.BalanceChar(openingCharacter, closingCharacter, groupName));
    }

    /// <summary>
    /// Appends a pattern that matches one or many left parenthesis balanced with one or many right parenthesis.
    /// Between the characters can be zero or many characters that are neither left nor right parenthesis.
    /// </summary>
    /// <param name="groupName">A name of the group that contains balanced content between left and right parenthesis.</param>
    /// <exception cref="ArgumentNullException"><paramref name="groupName"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="groupName"/> is not a valid regex group name.</exception>
    public Pattern BalanceParentheses(string groupName)
    {
        return AppendInternal(PatternFactory.BalanceParentheses(groupName));
    }

    /// <summary>
    /// Appends a pattern that matches one or many left square bracket balanced with one or many right square bracket.
    /// Between the characters can be zero or many characters that are neither left nor right square bracket.
    /// </summary>
    /// <param name="groupName">A name of the group that contains balanced content between left and right square bracket.</param>
    /// <exception cref="ArgumentNullException"><paramref name="groupName"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="groupName"/> is not a valid regex group name.</exception>
    public Pattern BalanceSquareBrackets(string groupName)
    {
        return AppendInternal(PatternFactory.BalanceSquareBrackets(groupName));
    }

    /// <summary>
    /// Appends a pattern that matches one or many left curly bracket balanced with one or many right curly bracket.
    /// Between the characters can be zero or many characters that are neither left nor right curly bracket.
    /// </summary>
    /// <param name="groupName">A name of the group that contains balanced content between left and right curly bracket.</param>
    /// <exception cref="ArgumentNullException"><paramref name="groupName"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="groupName"/> is not a valid regex group name.</exception>
    public Pattern BalanceCurlyBrackets(string groupName)
    {
        return AppendInternal(PatternFactory.BalanceCurlyBrackets(groupName));
    }

    /// <summary>
    /// Appends a pattern that matches one or many left angle bracket balanced with one or many right angle bracket.
    /// Between the characters can be zero or many characters that are neither left nor right angle bracket.
    /// </summary>
    /// <param name="groupName">A name of the group that contains balanced content between left and right angle bracket.</param>
    /// <exception cref="ArgumentNullException"><paramref name="groupName"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="groupName"/> is not a valid regex group name.</exception>
    public Pattern BalanceAngleBrackets(string groupName)
    {
        return AppendInternal(PatternFactory.BalanceAngleBrackets(groupName));
    }

    /// <summary>
    /// Returns a noncapturing group with current instance as a content.
    /// </summary>
    internal QuantifiablePattern AsNoncapturingGroup()
    {
        return PatternFactory.NoncapturingGroup(this);
    }

    /// <summary>
    /// Appends an empty negative lookahead assertion. This pattern is never matched.
    /// </summary>
    public Pattern Never()
    {
        return AppendInternal(PatternFactory.Never());
    }

    /// <summary>
    /// Appends a pattern that requires previously defined group with a specified name to be matched. Otherwise, a match will fail.
    /// </summary>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="groupName"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="groupName"/> is not a valid regex group name.</exception>
    public Pattern RequireGroup(string groupName)
    {
        return AppendInternal(PatternFactory.RequireGroup(groupName));
    }

    /// <summary>
    /// Appends a pattern that requires previously defined group with a specified number to be matched. Otherwise, a match will fail.
    /// </summary>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="groupNumber"/> is less than zero.</exception>
    public Pattern RequireGroup(int groupNumber)
    {
        return AppendInternal(PatternFactory.RequireGroup(groupNumber));
    }

    /// <summary>
    /// Appends a pattern that requires previously defined group with a specified name not to be matched. Otherwise, a match will fail.
    /// </summary>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="groupName"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="groupName"/> is not a valid regex group name.</exception>
    public Pattern DisallowGroup(string groupName)
    {
        return AppendInternal(PatternFactory.DisallowGroup(groupName));
    }

    /// <summary>
    /// Appends a pattern that requires previously defined group with a specified number not to be matched. Otherwise, a match will fail.
    /// </summary>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="groupNumber"/> is less than zero.</exception>
    public Pattern DisallowGroup(int groupNumber)
    {
        return AppendInternal(PatternFactory.DisallowGroup(groupNumber));
    }
}
