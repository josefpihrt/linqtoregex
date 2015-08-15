// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    public abstract partial class Pattern
    {
        /// <summary>
        /// Appends a pattern that matches the current instance or a specified content.
        /// </summary>
        /// <param name="content">Alternate content to match if the current instance if not matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern Or(object content)
        {
            return Patterns.Or(this, content);
        }

        /// <summary>
        /// Appends a pattern that is a negation of the specified pattern.
        /// </summary>
        /// <typeparam name="TPattern"></typeparam>
        /// <param name="value">A pattern to be negated.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public TPattern Not<TPattern>(INegateable<TPattern> value) where TPattern : Pattern
        {
            return AppendInternal(Patterns.Not(value));
        }

        /// <summary>
        /// Appends a pattern that matches any one of the patterns specified in the collection.
        /// </summary>
        /// <param name="content">A collection that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        public QuantifiablePattern Any(IEnumerable content)
        {
            return AppendInternal(Patterns.Any(content));
        }

        /// <summary>
        /// Appends a pattern that matches any one of the patterns specified in the object array.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern Any(params object[] content)
        {
            return AppendInternal(Patterns.Any(content));
        }

        /// <summary>
        /// Appends an if construct with the specified content to assert and a content to match if the assertion succeeds.
        /// </summary>
        /// <param name="testContent">The content to assert.</param>
        /// <param name="trueContent">The content to be matched if the assertion succeeds.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern IfAssert(object testContent, object trueContent)
        {
            return AppendInternal(Patterns.IfAssert(testContent, trueContent));
        }

        /// <summary>
        /// Appends an if construct with the specified content to assert and a content to match if the assertion succeeds and a content to match if the assertion fails.
        /// </summary>
        /// <param name="testContent">The content to assert.</param>
        /// <param name="trueContent">The content to be matched if the assertion succeeds.</param>
        /// <param name="falseContent">The content to be matched if the assertion fails.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern IfAssert(object testContent, object trueContent, object falseContent)
        {
            return AppendInternal(Patterns.IfAssert(testContent, trueContent, falseContent));
        }

        /// <summary>
        /// Appends an if construct with a content to match if the named group is matched.
        /// </summary>
        /// <param name="groupName">A name of the group.</param>
        /// <param name="trueContent">The content to be matched if the named group is matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public QuantifiablePattern IfGroup(string groupName, object trueContent)
        {
            return AppendInternal(Patterns.IfGroup(groupName, trueContent));
        }

        /// <summary>
        /// Appends an if construct with a content to match if the named group is matched and a content to match if the named group is not matched.
        /// </summary>
        /// <param name="groupName">A name of the group.</param>
        /// <param name="trueContent">The content to be matched if the named group is matched.</param>
        /// <param name="falseContent">The content to be matched if the named group is not matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public QuantifiablePattern IfGroup(string groupName, object trueContent, object falseContent)
        {
            return AppendInternal(Patterns.IfGroup(groupName, trueContent, falseContent));
        }

        /// <summary>
        /// Appends an if construct with a content to match if the numbered group is matched.
        /// </summary>
        /// <param name="groupNumber">A number of the group.</param>
        /// <param name="trueContent">The content to be matched if the numbered group is matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiablePattern IfGroup(int groupNumber, object trueContent)
        {
            return AppendInternal(Patterns.IfGroup(groupNumber, trueContent));
        }

        /// <summary>
        /// Appends an if construct with a content to match if the numbered group is matched and a content to match if the numbered group is not matched.
        /// </summary>
        /// <param name="groupNumber">A number of the group.</param>
        /// <param name="trueContent">The content to be matched if the numbered group is matched.</param>
        /// <param name="falseContent">The content to be matched if the numbered group is not matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiablePattern IfGroup(int groupNumber, object trueContent, object falseContent)
        {
            return AppendInternal(Patterns.IfGroup(groupNumber, trueContent, falseContent));
        }

        /// <summary>
        /// Appends a pattern that is matched at the beginning of the string.
        /// </summary>
        public QuantifiablePattern BeginInput()
        {
            return AppendInternal(Patterns.BeginInput());
        }

        /// <summary>
        /// Appends a pattern that is matched at the end of the string.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern EndInput()
        {
            return AppendInternal(Patterns.EndInput());
        }

        /// <summary>
        /// Appends a pattern that is matched at the beginning of the line.
        /// </summary>
        public QuantifiablePattern BeginLine()
        {
            return AppendInternal(Patterns.BeginLine());
        }

        /// <summary>
        /// Appends a pattern that is matched at the beginning of the string (or line if the <see cref="RegexOptions.Multiline"/> option is applied).
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern BeginInputOrLine()
        {
            return AppendInternal(Patterns.BeginInputOrLine());
        }

        /// <summary>
        /// Appends a pattern that is matched at the end of the string or line. End of line is defined as the position before a linefeed.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern EndLine()
        {
            return AppendInternal(Patterns.EndLine());
        }

        /// <summary>
        /// Appends a pattern that is matched (before carriage return) at the end of the string or line. End of line is defined as the position before a linefeed.
        /// </summary>
        /// <param name="beforeCarriageReturn">Indicates whether a position of the match should be before a carriage return if present and not already consumed by regex engine.</param>
        /// <returns></returns>
        public Pattern EndLine(bool beforeCarriageReturn)
        {
            return AppendInternal(Patterns.EndLine(beforeCarriageReturn));
        }

        /// <summary>
        /// Appends a pattern that is matched at the end of the string (or line if the <see cref="RegexOptions.Multiline"/> option is applied). End of line is defined as the position before a linefeed.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern EndInputOrLine()
        {
            return AppendInternal(Patterns.EndInputOrLine());
        }

        /// <summary>
        /// Appends a pattern that is matched (before carriage return) at the end of the string (or (before carriage return) at the end of line if the <see cref="RegexOptions.Multiline"/> option is applied). End of line is defined as the position before a linefeed.
        /// </summary>
        /// <param name="beforeCarriageReturn">Indicates whether a position of the match should be before a carriage return if present and not already consumed by regex engine</param>
        /// <returns></returns>
        public QuantifiablePattern EndInputOrLine(bool beforeCarriageReturn)
        {
            return AppendInternal(Patterns.EndInputOrLine(beforeCarriageReturn));
        }

        /// <summary>
        /// Appends a pattern that is matched at the end of the string or before linefeed at the end of the string.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern EndInputOrBeforeEndingLinefeed()
        {
            return AppendInternal(Patterns.EndInputOrBeforeEndingLinefeed());
        }

        /// <summary>
        /// Appends a pattern that is matched at the position where the previous match ended.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern PreviousMatchEnd()
        {
            return AppendInternal(Patterns.PreviousMatchEnd());
        }

        /// <summary>
        /// Appends a pattern that is matched on a boundary between a word character and a non-word character. The pattern may be also matched on a word boundary at the beginning or end of the string.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern WordBoundary()
        {
            return AppendInternal(Patterns.WordBoundary());
        }

        /// <summary>
        /// Appends a pattern that is not matched on a boundary between a word character and a non-word character.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotWordBoundary()
        {
            return AppendInternal(Patterns.NotWordBoundary());
        }

        /// <summary>
        /// Appends a pattern that matches one or more word characters surrounded with a word boundary.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Word()
        {
            return AppendInternal(Patterns.Word());
        }

        /// <summary>
        /// Appends a pattern that matches spefified pattern surrounded with a word boundary.
        /// </summary>
        /// <param name="content">A text to surround.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern SurroundWordBoundary(object content)
        {
            return AppendInternal(Patterns.SurroundWordBoundary(content));
        }

        /// <summary>
        /// Appends a pattern that matches specified content surrounded with a word boundary.
        /// </summary>
        /// <param name="content">An object array that contains zero or more values any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern SurroundWordBoundary(params object[] content)
        {
            return AppendInternal(Patterns.SurroundWordBoundary(content));
        }

        /// <summary>
        /// Appends a zero-width positive lookahead assertion with a specified content to be matched.
        /// </summary>
        /// <param name="content">A content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern Assert(object content)
        {
            return AppendInternal(Patterns.Assert(content));
        }

        /// <summary>
        /// Appends a zero-width positive lookahead assertion that matches any one pattern specified in the object array.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern Assert(params object[] content)
        {
            return AppendInternal(Patterns.Assert(content));
        }

        /// <summary>
        /// Appends a zero-width negative lookahead assertion with a specified content not to be matched.
        /// </summary>
        /// <param name="content">A content not to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern NotAssert(object content)
        {
            return AppendInternal(Patterns.NotAssert(content));
        }

        /// <summary>
        /// Appends a zero-width negative lookahead assertion that matches none of patterns specified in the object array.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns none of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern NotAssert(params object[] content)
        {
            return AppendInternal(Patterns.NotAssert(content));
        }

        /// <summary>
        /// Appends a zero-width positive lookbehind assertion with a specified content to be matched.
        /// </summary>
        /// <param name="content">A content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern AssertBack(object content)
        {
            return AppendInternal(Patterns.AssertBack(content));
        }

        /// <summary>
        /// Appends a zero-width positive lookbehind assertion that matches any one pattern specified in the object array.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern AssertBack(params object[] content)
        {
            return AppendInternal(Patterns.AssertBack(content));
        }

        /// <summary>
        /// Appends a zero-width negative lookbehind assertion with a specified content not to be matched.
        /// </summary>
        /// <param name="content">A content not to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern NotAssertBack(object content)
        {
            return AppendInternal(Patterns.NotAssertBack(content));
        }

        /// <summary>
        /// Appends a zero-width negative lookbehind assertion that matches none of patterns specified in the object array.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns none of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern NotAssertBack(params object[] content)
        {
            return AppendInternal(Patterns.NotAssertBack(content));
        }

        /// <summary>
        /// Appends an empty numbered group.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Group()
        {
            return AppendInternal(Patterns.Group());
        }

        /// <summary>
        /// Appends a numbered group with a specified content.
        /// </summary>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern Group(object content)
        {
            return AppendInternal(Patterns.Group(content));
        }

        /// <summary>
        /// Appends a numbered group with a specified content.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern Group(params object[] content)
        {
            return AppendInternal(Patterns.Group(content));
        }

        /// <summary>
        /// Appends a named group with a specified name and content.
        /// </summary>
        /// <param name="name">A name of the group.</param>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public QuantifiablePattern NamedGroup(string name, object content)
        {
            return AppendInternal(Patterns.NamedGroup(name, content));
        }

        /// <summary>
        /// Appends a named group with a specified name and content.
        /// </summary>
        /// <param name="name">A name of the group.</param>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public QuantifiablePattern NamedGroup(string name, params object[] content)
        {
            return AppendInternal(Patterns.NamedGroup(name, content));
        }

        /// <summary>
        /// Appends a noncapturing group with a specified content.
        /// </summary>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern NoncapturingGroup(object content)
        {
            return AppendInternal(Patterns.NoncapturingGroup((content)));
        }

        /// <summary>
        /// Appends a noncapturing group with a specified content.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern NoncapturingGroup(params object[] content)
        {
            return AppendInternal(Patterns.NoncapturingGroup(content));
        }

        /// <summary>
        /// Appends a balancing group with specified group names and a content.
        /// </summary>
        /// <param name="name1">Current group name.</param>
        /// <param name="name2">Previously defined group name.</param>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public QuantifiablePattern BalancingGroup(string name1, string name2, object content)
        {
            return AppendInternal(Patterns.BalancingGroup(name1, name2, content));
        }

        /// <summary>
        /// Appends a balancing group with specified group names and a content.
        /// </summary>
        /// <param name="name1">Current group name.</param>
        /// <param name="name2">Previously defined group name.</param>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public QuantifiablePattern BalancingGroup(string name1, string name2, params object[] content)
        {
            return AppendInternal(Patterns.BalancingGroup(name1, name2, content));
        }

        /// <summary>
        /// Appends a nonbacktracking group with a specified content.
        /// </summary>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern NonbacktrackingGroup(object content)
        {
            return AppendInternal(Patterns.NonbacktrackingGroup(content));
        }

        /// <summary>
        /// Appends a nonbacktracking group with a specified content.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern NonbacktrackingGroup(params object[] content)
        {
            return AppendInternal(Patterns.NonbacktrackingGroup(content));
        }

        /// <summary>
        /// Appends a pattern that applies specified options.
        /// </summary>
        /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
        /// <returns></returns>
        public Pattern Options(RegexOptions applyOptions)
        {
            return AppendInternal(Patterns.Options(applyOptions));
        }

        /// <summary>
        /// Appends a pattern that applies specified options to a specified pattern.
        /// </summary>
        /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern Options(RegexOptions applyOptions, object content)
        {
            return AppendInternal(Patterns.Options(applyOptions, content));
        }

        /// <summary>
        /// Appends a pattern that applies specified options to a specified pattern.
        /// </summary>
        /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern Options(RegexOptions applyOptions, params object[] content)
        {
            return AppendInternal(Patterns.Options(applyOptions, content));
        }

        /// <summary>
        /// Appends a pattern that applies and disables specified options to a specified pattern.
        /// </summary>
        /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
        /// <param name="disableOptions">A bitwise combination of the enumeration values that are disabled.</param>
        /// <returns></returns>
        public Pattern Options(RegexOptions applyOptions, RegexOptions disableOptions)
        {
            return AppendInternal(Patterns.Options(applyOptions, disableOptions));
        }

        /// <summary>
        /// Appends a pattern that applies and disables specified options to a specified pattern.
        /// </summary>
        /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
        /// <param name="disableOptions">A bitwise combination of the enumeration values that are disabled.</param>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern Options(RegexOptions applyOptions, RegexOptions disableOptions, object content)
        {
            return AppendInternal(Patterns.Options(applyOptions, disableOptions, content));
        }

        /// <summary>
        /// Appends a pattern that applies and disables specified options to a specified pattern.
        /// </summary>
        /// <param name="applyOptions">A bitwise combination of the enumeration values that are applied.</param>
        /// <param name="disableOptions">A bitwise combination of the enumeration values that are disabled.</param>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        public QuantifiablePattern Options(RegexOptions applyOptions, RegexOptions disableOptions, params object[] content)
        {
            return AppendInternal(Patterns.Options(applyOptions, disableOptions, content));
        }

        /// <summary>
        /// Appends a pattern that disables specified options.
        /// </summary>
        /// <param name="options">A bitwise combination of the enumeration values that are disabled.</param>
        /// <returns></returns>
        public Pattern DisableOptions(RegexOptions options)
        {
            return AppendInternal(Patterns.DisableOptions(options));
        }

        /// <summary>
        /// Appends a pattern that disables specified options to a specified pattern.
        /// </summary>
        /// <param name="options">A bitwise combination of the enumeration values that are disabled.</param>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern DisableOptions(RegexOptions options, object content)
        {
            return AppendInternal(Patterns.DisableOptions(options, content));
        }

        /// <summary>
        /// Appends a pattern that disables specified options to a specified pattern.
        /// </summary>
        /// <param name="options">A bitwise combination of the enumeration values that are disabled.</param>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern DisableOptions(RegexOptions options, params object[] content)
        {
            return AppendInternal(Patterns.DisableOptions(options, content));
        }

        /// <summary>
        /// Appends a pattern that matches two apostrophes, allowing zero or more characters that are not an apostrophe between the apostrophes.
        /// </summary>
        /// <returns></returns>
        public Pattern SurroundApostrophes()
        {
            return AppendInternal(Patterns.SurroundApostrophes());
        }

        /// <summary>
        /// Appends a pattern that matches specified pattern surrounded with apostrophes.
        /// </summary>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern SurroundApostrophes(object content)
        {
            return AppendInternal(Patterns.SurroundApostrophes(content));
        }

        /// <summary>
        /// Appends a pattern that matches specified content surrounded with apostrophes.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern SurroundApostrophes(params object[] content)
        {
            return AppendInternal(Patterns.SurroundApostrophes(content));
        }

        /// <summary>
        /// Appends a pattern that matches two quotation marks, allowing zero or more characters that are not a quotation mark between the quotation marks.
        /// </summary>
        /// <returns></returns>
        public Pattern SurroundQuoteMarks()
        {
            return AppendInternal(Patterns.SurroundQuoteMarks());
        }

        /// <summary>
        /// Appends a pattern that matches specified pattern surrounded with quotation marks.
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern SurroundQuoteMarks(object content)
        {
            return AppendInternal(Patterns.SurroundQuoteMarks(content));
        }

        /// <summary>
        /// Appends a pattern that matches specified content surrounded with quotation marks.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern SurroundQuoteMarks(params object[] content)
        {
            return AppendInternal(Patterns.SurroundQuoteMarks(content));
        }

        /// <summary>
        /// Appends a pattern that matches two quotation marks (apostrophes), allowing zero or more characters that are not a quotation mark (apostrophe) between the quotation marks (apostrophes).
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern SurroundQuoteMarksOrApostrophes()
        {
            return AppendInternal(Patterns.SurroundQuoteMarksOrApostrophes());
        }

        /// <summary>
        /// Appends a pattern that matches specified pattern surrounded with quotation marks or apostrophes.
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern SurroundQuoteMarksOrApostrophes(object content)
        {
            return AppendInternal(Patterns.SurroundQuoteMarksOrApostrophes(content));
        }

        /// <summary>
        /// Appends a pattern that matches specified content surrounded with quotation marks or apostrophes.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern SurroundQuoteMarksOrApostrophes(params object[] content)
        {
            return AppendInternal(Patterns.SurroundQuoteMarksOrApostrophes(content));
        }

        /// <summary>
        /// Appends a pattern that matches a text consisting of a left parenthesis and a right parenthesis, allowing zero or more characters that are not a right parenthesis between the parentheses.
        /// </summary>
        /// <returns></returns>
        public Pattern SurroundParentheses()
        {
            return AppendInternal(Patterns.SurroundParentheses());
        }

        /// <summary>
        /// Appends a pattern that matches specified pattern surrounded with left and right parenthesis.
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern SurroundParentheses(object content)
        {
            return AppendInternal(Patterns.SurroundParentheses(content));
        }

        /// <summary>
        /// Appends a pattern that matches specified content surrounded with left and right parenthesis.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern SurroundParentheses(params object[] content)
        {
            return AppendInternal(Patterns.SurroundParentheses(content));
        }

        /// <summary>
        /// Appends a pattern that matches a text consisting of left and right curly bracket, allowing zero or more characters that are not a right curly bracket between the brackets.
        /// </summary>
        /// <returns></returns>
        public Pattern SurroundCurlyBrackets()
        {
            return AppendInternal(Patterns.SurroundCurlyBrackets());
        }

        /// <summary>
        /// Appends a pattern that matches specified pattern surrounded with left and right curly bracket.
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern SurroundCurlyBrackets(object content)
        {
            return AppendInternal(Patterns.SurroundCurlyBrackets(content));
        }

        /// <summary>
        /// Appends a pattern that matches specified content surrounded with left and right curly bracket.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern SurroundCurlyBrackets(params object[] content)
        {
            return AppendInternal(Patterns.SurroundCurlyBrackets(content));
        }

        /// <summary>
        /// Appends a pattern that matches a text consisting of left and right square bracket, allowing zero or more characters that are not a right square bracket between the brackets.
        /// </summary>
        /// <returns></returns>
        public Pattern SurroundSquareBrackets()
        {
            return AppendInternal(Patterns.SurroundSquareBrackets());
        }

        /// <summary>
        /// Appends a pattern that matches specified pattern surrounded with left and right square bracket.
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern SurroundSquareBrackets(object content)
        {
            return AppendInternal(Patterns.SurroundSquareBrackets(content));
        }

        /// <summary>
        /// Appends a pattern that matches specified content surrounded with left and right square bracket.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern SurroundSquareBrackets(params object[] content)
        {
            return AppendInternal(Patterns.SurroundSquareBrackets(content));
        }

        /// <summary>
        /// Appends a pattern that matches a text consisting of left and right angle bracket, allowing zero or more characters that are not a right angle bracket between the brackets.
        /// </summary>
        /// <returns></returns>
        public Pattern SurroundAngleBrackets()
        {
            return AppendInternal(Patterns.SurroundAngleBrackets());
        }

        /// <summary>
        /// Appends a pattern that matches specified pattern surrounded with left and right angle bracket.
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern SurroundAngleBrackets(object content)
        {
            return AppendInternal(Patterns.SurroundAngleBrackets(content));
        }

        /// <summary>
        /// Appends a pattern that matches specified content surrounded with left and right angle bracket.
        /// </summary>
        /// <param name="content">An object array that contains zero or more patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern SurroundAngleBrackets(params object[] content)
        {
            return AppendInternal(Patterns.SurroundAngleBrackets(content));
        }

        /// <summary>
        /// Appends a pattern that matches a character in the specified range.
        /// </summary>
        /// <param name="first">The first character of the range.</param>
        /// <param name="last">The last character of the range.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiablePattern Range(char first, char last)
        {
            return AppendInternal(Patterns.Range(first, last));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not in the specified range.
        /// </summary>
        /// <param name="first">The first character of the range.</param>
        /// <param name="last">The last character of the range.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiablePattern NotRange(char first, char last)
        {
            return AppendInternal(Patterns.NotRange(first, last));
        }

        /// <summary>
        /// Appends a pattern that matches a white-space character except carriage return and linefeed.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern WhiteSpaceExceptNewLine()
        {
            return AppendInternal(Patterns.WhiteSpaceExceptNewLine());
        }

        /// <summary>
        /// Appends a pattern that matches a white-space character except carriage return and linefeed. The character has to be matched specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup WhiteSpaceExceptNewLine(int exactCount)
        {
            return AppendInternal(Patterns.WhiteSpaceExceptNewLine(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a specified character zero or more times.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        /// <returns></returns>
        public Pattern WhileChar(char value)
        {
            return AppendInternal(Patterns.WhileChar(value));
        }

        /// <summary>
        /// Appends a pattern that matches a specified character zero or more times.
        /// </summary>
        /// <param name="value">An enumerated constant that identifies ASCII character.</param>
        /// <returns></returns>
        public Pattern WhileChar(AsciiChar value)
        {
            return AppendInternal(Patterns.WhileChar(value));
        }

        /// <summary>
        /// Appends a pattern that matches a specified character zero or more times.
        /// </summary>
        /// <param name="value">A set of Unicode characters.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern WhileChar(CharGrouping value)
        {
            return AppendInternal(Patterns.WhileChar(value));
        }

        /// <summary>
        /// Appends a pattern that matches a digit character zero or more times.
        /// </summary>
        /// <returns></returns>
        public QuantifiedPattern WhileDigit()
        {
            return AppendInternal(Patterns.WhileDigit());
        }

        /// <summary>
        /// Appends a pattern that matches a word character zero or more times.
        /// </summary>
        /// <returns></returns>
        public QuantifiedPattern WhileWordChar()
        {
            return AppendInternal(Patterns.WhileWordChar());
        }

        /// <summary>
        /// Appends a pattern that matches a white-space character zero or more times.
        /// </summary>
        /// <returns></returns>
        public QuantifiedPattern WhileWhiteSpace()
        {
            return AppendInternal(Patterns.WhileWhiteSpace());
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters that are white-space characters but a neither carriage return nor a linefeed.
        /// </summary>
        /// <returns></returns>
        public QuantifiedPattern WhileWhiteSpaceExceptNewLine()
        {
            return AppendInternal(Patterns.WhileWhiteSpaceExceptNewLine());
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters that are not a specified character.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        /// <returns></returns>
        public Pattern WhileNotChar(char value)
        {
            return AppendInternal(Patterns.WhileNotChar(value));
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters that are not contained in the specified characters
        /// </summary>
        /// <param name="characters">Unicode characters.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public QuantifiedPattern WhileNotChar(params char[] characters)
        {
            return AppendInternal(Patterns.WhileNotChar(characters));
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters that are not contained in the specified <see cref="string"/>.
        /// </summary>
        /// <param name="characters">Unicode characters.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public QuantifiedPattern WhileNotChar(string characters)
        {
            return AppendInternal(Patterns.WhileNotChar(characters));
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters that are not a specified character.
        /// </summary>
        /// <param name="value">An enumerated constant that identifies ASCII character.</param>
        /// <returns></returns>
        public Pattern WhileNotChar(AsciiChar value)
        {
            return AppendInternal(Patterns.WhileNotChar(value));
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters that are not matched by a specified <see cref="CharGrouping"/>.
        /// </summary>
        /// <param name="value">A set of Unicode characters.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern WhileNotChar(CharGrouping value)
        {
            return AppendInternal(Patterns.WhileNotChar(value));
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters that are neither a carriage return nor a linefeed.
        /// </summary>
        /// <returns></returns>
        public QuantifiedPattern WhileNotNewLineChar()
        {
            return AppendInternal(Patterns.WhileNotNewLineChar());
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters that are not a digit.
        /// </summary>
        /// <returns></returns>
        public QuantifiedPattern WhileNotDigit()
        {
            return AppendInternal(Patterns.WhileNotDigit());
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters that are not a white-space.
        /// </summary>
        /// <returns></returns>
        public QuantifiedPattern WhileNotWhiteSpace()
        {
            return AppendInternal(Patterns.WhileNotWhiteSpace());
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters that are not a word character.
        /// </summary>
        /// <returns></returns>
        public QuantifiedPattern WhileNotWordChar()
        {
            return AppendInternal(Patterns.WhileNotWordChar());
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters until it reaches a specified character.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        /// <returns></returns>
        public QuantifiablePattern UntilChar(char value)
        {
            return AppendInternal(Patterns.UntilChar(value));
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters until it reaches a specified character.
        /// </summary>
        /// <param name="value">An enumerated constant that identifies ASCII character.</param>
        /// <returns></returns>
        public QuantifiablePattern UntilChar(AsciiChar value)
        {
            return AppendInternal(Patterns.UntilChar(value));
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters until it reaches a character that is matched by a specified <see cref="CharGrouping"/>.
        /// </summary>
        /// <param name="value">A content of a character group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern UntilChar(CharGrouping value)
        {
            return AppendInternal(Patterns.UntilChar(value));
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters until it reaches a linefeed.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern UntilNewLine()
        {
            return AppendInternal(Patterns.UntilNewLine());
        }

        /// <summary>
        /// Appends a pattern that matches zero or more characters until it reaches a specified <paramref name="value"/>.
        /// </summary>
        /// <param name="value">A text to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Pattern Until(string value)
        {
            return AppendInternal(Patterns.Until(value));
        }

        /// <summary>
        /// Appends a pattern that matches any character.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Any()
        {
            return AppendInternal(Patterns.Any());
        }

        /// <summary>
        /// Appends a pattern that matches any character specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Any(int exactCount)
        {
            return AppendInternal(Patterns.Any(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches any character except linefeed.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern AnyExceptLinefeed()
        {
            return AppendInternal(Patterns.AnyExceptLinefeed());
        }

        /// <summary>
        /// Appends a pattern that matches any character except linefeed specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup AnyExceptLinefeed(int exactCount)
        {
            return AppendInternal(Patterns.AnyExceptLinefeed(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches any character except linefeed (or any character if the <see cref="RegexOptions.Singleline"/> option is applied).
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern AnyNative()
        {
            return AppendInternal(Patterns.AnyNative());
        }

        /// <summary>
        /// Appends a pattern that matches any character except linefeed (or any character if the <see cref="RegexOptions.Singleline"/> option is applied) specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup AnyNative(int exactCount)
        {
            return AppendInternal(Patterns.AnyNative(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches any character zero or more times but as few times as possible.
        /// </summary>
        /// <returns></returns>
        public Pattern Crawl()
        {
            return AppendInternal(Patterns.Crawl());
        }

        /// <summary>
        /// Appends a pattern that matches any character except linefeed (or any character if the <see cref="RegexOptions.Singleline"/> option is applied) zero or more times but as few times as possible.
        /// </summary>
        /// <returns></returns>
        public Pattern CrawlNative()
        {
            return AppendInternal(Patterns.CrawlNative());
        }

        /// <summary>
        /// Appends a pattern that matches an alphanumeric character. Alphanumeric character is a latin alphabet letter or an arabic digit.
        /// </summary>
        /// <returns></returns>
        public CharGroup Alphanumeric()
        {
            return AppendInternal(Patterns.Alphanumeric());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of alphanumeric characters. Alphanumeric character is a latin alphabet letter or an arabic digit.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Alphanumeric(int exactCount)
        {
            return AppendInternal(Patterns.Alphanumeric(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an alphanumeric character. Alphanumeric character is a latin alphabet letter or an arabic digit.
        /// </summary>
        /// <returns></returns>
        public CharGroup NotAlphanumeric()
        {
            return AppendInternal(Patterns.NotAlphanumeric());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an alphanumeric character specified number of times. Alphanumeric character is a latin alphabet letter or an arabic digit.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotAlphanumeric(int exactCount)
        {
            return AppendInternal(Patterns.NotAlphanumeric(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a lower-case alphanumeric character. Alphanumeric character is a latin alphabet lower-case letter or an arabic digit.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern AlphanumericLower()
        {
            return AppendInternal(Patterns.AlphanumericLower());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of lower-case alphanumeric characters. Alphanumeric character is a latin alphabet lower-case letter or an arabic digit.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup AlphanumericLower(int exactCount)
        {
            return AppendInternal(Patterns.AlphanumericLower(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a lower-case alphanumeric character. Alphanumeric character is a latin alphabet lower-case letter or an arabic digit.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotAlphanumericLower()
        {
            return AppendInternal(Patterns.NotAlphanumericLower());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a lower-case alphanumeric character specified number of times. Alphanumeric character is a latin alphabet lower-case letter or an arabic digit.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotAlphanumericLower(int exactCount)
        {
            return AppendInternal(Patterns.NotAlphanumericLower(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches an upper-case alphanumeric character. Alphanumeric character is a latin alphabet upper-case letter or an arabic digit.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern AlphanumericUpper()
        {
            return AppendInternal(Patterns.AlphanumericUpper());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of upper-case alphanumeric characters. Alphanumeric character is a latin alphabet upper-case letter or an arabic digit.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup AlphanumericUpper(int exactCount)
        {
            return AppendInternal(Patterns.AlphanumericUpper(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an upper-case alphanumeric character. Alphanumeric character is a latin alphabet upper-case letter or an arabic digit.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotAlphanumericUpper()
        {
            return AppendInternal(Patterns.NotAlphanumericUpper());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an upper-case alphanumeric character specified number of times. Alphanumeric character is a latin alphabet upper-case letter or an arabic digit.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotAlphanumericUpper(int exactCount)
        {
            return AppendInternal(Patterns.NotAlphanumericUpper(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches an alphanumeric character or an underscore. Alphanumeric character is a latin alphabet letter or an arabic digit.
        /// </summary>
        /// <returns></returns>
        public CharGroup AlphanumericUnderscore()
        {
            return AppendInternal(Patterns.AlphanumericUnderscore());
        }

        /// <summary>
        /// Appends a pattern that matches an alphanumeric character or an underscore specified number of times. Alphanumeric character is a latin alphabet letter or an arabic digit.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup AlphanumericUnderscore(int exactCount)
        {
            return AppendInternal(Patterns.AlphanumericUnderscore(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is neither alphanumeric character nor underscore. Alphanumeric character is a latin alphabet letter or an arabic digit.
        /// </summary>
        /// <returns></returns>
        public CharGroup NotAlphanumericUnderscore()
        {
            return AppendInternal(Patterns.NotAlphanumericUnderscore());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is neither alphanumeric character nor underscore specified number of times. Alphanumeric character is a latin alphabet letter or an arabic digit.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotAlphanumericUnderscore(int exactCount)
        {
            return AppendInternal(Patterns.NotAlphanumericUnderscore(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a latin alphabet letter.
        /// </summary>
        /// <returns></returns>
        public CharGroup LatinLetter()
        {
            return AppendInternal(Patterns.LatinLetter());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of latin alphabet letters.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup LatinLetter(int exactCount)
        {
            return AppendInternal(Patterns.LatinLetter(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a latin alphabet lower-case letter.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern LatinLetterLower()
        {
            return AppendInternal(Patterns.LatinLetterLower());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of latin alphabet lower-case letters.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup LatinLetterLower(int exactCount)
        {
            return AppendInternal(Patterns.LatinLetterLower(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a latin alphabet upper-case letter.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern LatinLetterUpper()
        {
            return AppendInternal(Patterns.LatinLetterUpper());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of latin alphabet upper-case letters.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup LatinLetterUpper(int exactCount)
        {
            return AppendInternal(Patterns.LatinLetterUpper(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a latin alphabet letter.
        /// </summary>
        /// <returns></returns>
        public CharGroup NotLatinLetter()
        {
            return AppendInternal(Patterns.NotLatinLetter());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a latin alphabet letter specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotLatinLetter(int exactCount)
        {
            return AppendInternal(Patterns.NotLatinLetter(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a latin alphabet lower-case letter.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotLatinLetterLower()
        {
            return AppendInternal(Patterns.NotLatinLetterLower());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a latin alphabet lower-case letter specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotLatinLetterLower(int exactCount)
        {
            return AppendInternal(Patterns.NotLatinLetterLower(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a latin alphabet upper-case letter.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotLatinLetterUpper()
        {
            return AppendInternal(Patterns.NotLatinLetterUpper());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a latin alphabet upper-case letter specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotLatinLetterUpper(int exactCount)
        {
            return AppendInternal(Patterns.NotLatinLetterUpper(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character from <see cref="GeneralCategory.LetterLowercase"/>.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern LetterLower()
        {
            return AppendInternal(Patterns.LetterLower());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of letters from <see cref="GeneralCategory.LetterLowercase"/>.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup LetterLower(int exactCount)
        {
            return AppendInternal(Patterns.LetterLower(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a character from <see cref="GeneralCategory.LetterLowercase"/>.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotLetterLower()
        {
            return AppendInternal(Patterns.NotLetterLower());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a character from <see cref="GeneralCategory.LetterLowercase"/> specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotLetterLower(int exactCount)
        {
            return AppendInternal(Patterns.NotLetterLower(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character from <see cref="GeneralCategory.LetterUppercase"/>.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern LetterUpper()
        {
            return AppendInternal(Patterns.LetterUpper());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of letters from <see cref="GeneralCategory.LetterUppercase"/>.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup LetterUpper(int exactCount)
        {
            return AppendInternal(Patterns.LetterUpper(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a character from <see cref="GeneralCategory.LetterUppercase"/>.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotLetterUpper()
        {
            return AppendInternal(Patterns.NotLetterUpper());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a character from <see cref="GeneralCategory.LetterUppercase"/> specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotLetterUpper(int exactCount)
        {
            return AppendInternal(Patterns.NotLetterUpper(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches an arabic digit.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern ArabicDigit()
        {
            return AppendInternal(Patterns.ArabicDigit());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of arabic digits.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup ArabicDigit(int exactCount)
        {
            return AppendInternal(Patterns.ArabicDigit(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an arabic digit.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotArabicDigit()
        {
            return AppendInternal(Patterns.NotArabicDigit());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an arabic digit specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotArabicDigit(int exactCount)
        {
            return AppendInternal(Patterns.NotArabicDigit(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a hexadecimal digit.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern HexadecimalDigit()
        {
            return AppendInternal(Patterns.HexadecimalDigit());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of hexadecimal digits.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup HexadecimalDigit(int exactCount)
        {
            return AppendInternal(Patterns.HexadecimalDigit(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a hexadecimal digit.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotHexadecimalDigit()
        {
            return AppendInternal(Patterns.NotHexadecimalDigit());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a hexadecimal digit specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotHexadecimalDigit(int exactCount)
        {
            return AppendInternal(Patterns.NotHexadecimalDigit(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a digit character.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Digit()
        {
            return AppendInternal(Patterns.Digit());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of digit characters.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Digit(int exactCount)
        {
            return AppendInternal(Patterns.Digit(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches one or more digit characters.
        /// </summary>
        /// <returns></returns>
        public QuantifiedGroup Digits()
        {
            return AppendInternal(Patterns.Digits());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a digit character.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotDigit()
        {
            return AppendInternal(Patterns.NotDigit());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a digit character specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotDigit(int exactCount)
        {
            return AppendInternal(Patterns.NotDigit(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches one or more characters that are not a digit character.
        /// </summary>
        /// <returns></returns>
        public QuantifiedGroup NotDigits()
        {
            return AppendInternal(Patterns.NotDigits());
        }

        /// <summary>
        /// Appends a pattern that matches a white-space character.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern WhiteSpace()
        {
            return AppendInternal(Patterns.WhiteSpace());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of white-space characters.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup WhiteSpace(int exactCount)
        {
            return AppendInternal(Patterns.WhiteSpace(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches one or more white-space characters.
        /// </summary>
        /// <returns></returns>
        public QuantifiedGroup WhiteSpaces()
        {
            return AppendInternal(Patterns.WhiteSpaces());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a white-space character.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotWhiteSpace()
        {
            return AppendInternal(Patterns.NotWhiteSpace());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a white-space character specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotWhiteSpace(int exactCount)
        {
            return AppendInternal(Patterns.NotWhiteSpace(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches one or more characters that are not a white-space character.
        /// </summary>
        /// <returns></returns>
        public QuantifiedGroup NotWhiteSpaces()
        {
            return AppendInternal(Patterns.NotWhiteSpaces());
        }

        /// <summary>
        /// Appends a pattern that matches a word character.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern WordChar()
        {
            return AppendInternal(Patterns.WordChar());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of word characters.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup WordChar(int exactCount)
        {
            return AppendInternal(Patterns.WordChar(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches one or more word characters.
        /// </summary>
        /// <returns></returns>
        public QuantifiedGroup WordChars()
        {
            return AppendInternal(Patterns.WordChars());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a word character.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotWordChar()
        {
            return AppendInternal(Patterns.NotWordChar());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a word character specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotWordChar(int exactCount)
        {
            return AppendInternal(Patterns.NotWordChar(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches one or more characters that are not a word character.
        /// </summary>
        /// <returns></returns>
        public QuantifiedGroup NotWordChars()
        {
            return AppendInternal(Patterns.NotWordChars());
        }

        /// <summary>
        /// Appends a pattern that matches a specified character.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        /// <returns></returns>
        public QuantifiablePattern Character(char value)
        {
            return AppendInternal(Patterns.Character(value));
        }

        /// <summary>
        /// Appends a pattern that matches a specified character.
        /// </summary>
        /// <param name="value">An enumerated constant that identifies ASCII character.</param>
        /// <returns></returns>
        public QuantifiablePattern Character(AsciiChar value)
        {
            return AppendInternal(Patterns.Character(value));
        }

        /// <summary>
        /// Appends a pattern that matches a character from a specified Unicode block.
        /// </summary>
        /// <param name="block">An enumerated constant that identifies Unicode block.</param>
        /// <returns></returns>
        public QuantifiablePattern Character(NamedBlock block)
        {
            return AppendInternal(Patterns.Character(block));
        }

        /// <summary>
        /// Appends a pattern that matches a character from a specified Unicode category.
        /// </summary>
        /// <param name="category">An enumerated constant that identifies Unicode category.</param>
        /// <returns></returns>
        public QuantifiablePattern Character(GeneralCategory category)
        {
            return AppendInternal(Patterns.Character(category));
        }

        /// <summary>
        /// Appends a character group containing specified characters.
        /// </summary>
        /// <param name="characters">A set of characters any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public QuantifiablePattern Character(string characters)
        {
            return AppendInternal(Patterns.Character(characters));
        }

        /// <summary>
        /// Appends a character group containing specified <see cref="CharGrouping"/>.
        /// </summary>
        /// <param name="value">A content of a character group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern Character(CharGrouping value)
        {
            return AppendInternal(Patterns.Character(value));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a specified character.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        /// <returns></returns>
        public QuantifiablePattern NotChar(char value)
        {
            return AppendInternal(Patterns.NotChar(value));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a specified character.
        /// </summary>
        /// <param name="value">An enumerated constant that identifies ASCII character.</param>
        /// <returns></returns>
        public QuantifiablePattern NotChar(AsciiChar value)
        {
            return AppendInternal(Patterns.NotChar(value));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not from a specified Unicode block.
        /// </summary>
        /// <param name="block">An enumerated constant that identifies Unicode block.</param>
        /// <returns></returns>
        public QuantifiablePattern NotChar(NamedBlock block)
        {
            return AppendInternal(Patterns.NotChar(block));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not from a specified Unicode category.
        /// </summary>
        /// <param name="category">An enumerated constant that identifies Unicode category.</param>
        /// <returns></returns>
        public QuantifiablePattern NotChar(GeneralCategory category)
        {
            return AppendInternal(Patterns.NotChar(category));
        }

        /// <summary>
        /// Appends a pattern that matches any character that is not contained in the specified <see cref="string"/>.
        /// </summary>
        /// <param name="characters">Unicode characters.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public QuantifiablePattern NotChar(string characters)
        {
            return AppendInternal(Patterns.NotChar(characters));
        }

        /// <summary>
        /// Appends a pattern that matches any character that is not contained in the specified characters.
        /// </summary>
        /// <param name="characters">Unicode characters.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public CharGroup NotChar(params char[] characters)
        {
            return AppendInternal(Patterns.NotChar(characters));
        }

        /// <summary>
        /// Appends a negative character group containing specified <see cref="CharGrouping"/>.
        /// </summary>
        /// <param name="value">A content of a character group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiablePattern NotChar(CharGrouping value)
        {
            return AppendInternal(Patterns.NotChar(value));
        }

        /// <summary>
        /// Appends a pattern that matches a tab.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Tab()
        {
            return AppendInternal(Patterns.Tab());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of tabs.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Tab(int exactCount)
        {
            return AppendInternal(Patterns.Tab(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a tab.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotTab()
        {
            return AppendInternal(Patterns.NotTab());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a tab.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotTab(int exactCount)
        {
            return AppendInternal(Patterns.NotTab(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a linefeed.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Linefeed()
        {
            return AppendInternal(Patterns.Linefeed());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of linefeeds.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Linefeed(int exactCount)
        {
            return AppendInternal(Patterns.Linefeed(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a linefeed.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotLinefeed()
        {
            return AppendInternal(Patterns.NotLinefeed());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a linefeed.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotLinefeed(int exactCount)
        {
            return AppendInternal(Patterns.NotLinefeed(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a carriage return.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern CarriageReturn()
        {
            return AppendInternal(Patterns.CarriageReturn());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of carriage returns.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup CarriageReturn(int exactCount)
        {
            return AppendInternal(Patterns.CarriageReturn(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a carriage return.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotCarriageReturn()
        {
            return AppendInternal(Patterns.NotCarriageReturn());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a carriage return.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotCarriageReturn(int exactCount)
        {
            return AppendInternal(Patterns.NotCarriageReturn(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a space.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Space()
        {
            return AppendInternal(Patterns.Space());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of spaces.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Space(int exactCount)
        {
            return AppendInternal(Patterns.Space(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a space.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotSpace()
        {
            return AppendInternal(Patterns.NotSpace());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a space.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotSpace(int exactCount)
        {
            return AppendInternal(Patterns.NotSpace(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches an exclamation mark.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern ExclamationMark()
        {
            return AppendInternal(Patterns.ExclamationMark());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of exclamation marks.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup ExclamationMark(int exactCount)
        {
            return AppendInternal(Patterns.ExclamationMark(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an exclamation mark.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotExclamationMark()
        {
            return AppendInternal(Patterns.NotExclamationMark());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not an exclamation mark.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotExclamationMark(int exactCount)
        {
            return AppendInternal(Patterns.NotExclamationMark(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a quote mark.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern QuoteMark()
        {
            return AppendInternal(Patterns.QuoteMark());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of quote marks.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup QuoteMark(int exactCount)
        {
            return AppendInternal(Patterns.QuoteMark(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a quote mark.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotQuoteMark()
        {
            return AppendInternal(Patterns.NotQuoteMark());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a quote mark.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotQuoteMark(int exactCount)
        {
            return AppendInternal(Patterns.NotQuoteMark(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a number sign.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NumberSign()
        {
            return AppendInternal(Patterns.NumberSign());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of number signs.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NumberSign(int exactCount)
        {
            return AppendInternal(Patterns.NumberSign(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a number sign.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotNumberSign()
        {
            return AppendInternal(Patterns.NotNumberSign());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a number sign.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotNumberSign(int exactCount)
        {
            return AppendInternal(Patterns.NotNumberSign(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a dollar.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Dollar()
        {
            return AppendInternal(Patterns.Dollar());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of dollars.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Dollar(int exactCount)
        {
            return AppendInternal(Patterns.Dollar(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a dollar.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotDollar()
        {
            return AppendInternal(Patterns.NotDollar());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a dollar.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotDollar(int exactCount)
        {
            return AppendInternal(Patterns.NotDollar(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a percent.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Percent()
        {
            return AppendInternal(Patterns.Percent());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of percents.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Percent(int exactCount)
        {
            return AppendInternal(Patterns.Percent(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a percent.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotPercent()
        {
            return AppendInternal(Patterns.NotPercent());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a percent.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotPercent(int exactCount)
        {
            return AppendInternal(Patterns.NotPercent(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches an ampersand.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Ampersand()
        {
            return AppendInternal(Patterns.Ampersand());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of ampersands.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Ampersand(int exactCount)
        {
            return AppendInternal(Patterns.Ampersand(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an ampersand.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotAmpersand()
        {
            return AppendInternal(Patterns.NotAmpersand());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not an ampersand.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotAmpersand(int exactCount)
        {
            return AppendInternal(Patterns.NotAmpersand(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches an apostrophe.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Apostrophe()
        {
            return AppendInternal(Patterns.Apostrophe());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of apostrophes.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Apostrophe(int exactCount)
        {
            return AppendInternal(Patterns.Apostrophe(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an apostrophe.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotApostrophe()
        {
            return AppendInternal(Patterns.NotApostrophe());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not an apostrophe.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotApostrophe(int exactCount)
        {
            return AppendInternal(Patterns.NotApostrophe(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a left parenthesis.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern LeftParenthesis()
        {
            return AppendInternal(Patterns.LeftParenthesis());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of left parentheses.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup LeftParenthesis(int exactCount)
        {
            return AppendInternal(Patterns.LeftParenthesis(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a left parenthesis.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotLeftParenthesis()
        {
            return AppendInternal(Patterns.NotLeftParenthesis());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a left parenthesis.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotLeftParenthesis(int exactCount)
        {
            return AppendInternal(Patterns.NotLeftParenthesis(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a right parenthesis.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern RightParenthesis()
        {
            return AppendInternal(Patterns.RightParenthesis());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of right parentheses.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup RightParenthesis(int exactCount)
        {
            return AppendInternal(Patterns.RightParenthesis(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a right parenthesis.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotRightParenthesis()
        {
            return AppendInternal(Patterns.NotRightParenthesis());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a right parenthesis.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotRightParenthesis(int exactCount)
        {
            return AppendInternal(Patterns.NotRightParenthesis(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches an asterisk.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Asterisk()
        {
            return AppendInternal(Patterns.Asterisk());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of asterisks.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Asterisk(int exactCount)
        {
            return AppendInternal(Patterns.Asterisk(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an asterisk.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotAsterisk()
        {
            return AppendInternal(Patterns.NotAsterisk());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not an asterisk.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotAsterisk(int exactCount)
        {
            return AppendInternal(Patterns.NotAsterisk(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a plus.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Plus()
        {
            return AppendInternal(Patterns.Plus());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of pluses.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Plus(int exactCount)
        {
            return AppendInternal(Patterns.Plus(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a plus.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotPlus()
        {
            return AppendInternal(Patterns.NotPlus());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a plus.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotPlus(int exactCount)
        {
            return AppendInternal(Patterns.NotPlus(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a comma.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Comma()
        {
            return AppendInternal(Patterns.Comma());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of commas.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Comma(int exactCount)
        {
            return AppendInternal(Patterns.Comma(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a comma.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotComma()
        {
            return AppendInternal(Patterns.NotComma());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a comma.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotComma(int exactCount)
        {
            return AppendInternal(Patterns.NotComma(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a hyphen.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Hyphen()
        {
            return AppendInternal(Patterns.Hyphen());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of hyphens.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Hyphen(int exactCount)
        {
            return AppendInternal(Patterns.Hyphen(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a hyphen.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotHyphen()
        {
            return AppendInternal(Patterns.NotHyphen());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a hyphen.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotHyphen(int exactCount)
        {
            return AppendInternal(Patterns.NotHyphen(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a dot.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Dot()
        {
            return AppendInternal(Patterns.Dot());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of dots.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Dot(int exactCount)
        {
            return AppendInternal(Patterns.Dot(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a dot.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotDot()
        {
            return AppendInternal(Patterns.NotDot());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a dot.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotDot(int exactCount)
        {
            return AppendInternal(Patterns.NotDot(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a slash.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Slash()
        {
            return AppendInternal(Patterns.Slash());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of slashes.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Slash(int exactCount)
        {
            return AppendInternal(Patterns.Slash(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a slash.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotSlash()
        {
            return AppendInternal(Patterns.NotSlash());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a slash.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotSlash(int exactCount)
        {
            return AppendInternal(Patterns.NotSlash(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a colon.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Colon()
        {
            return AppendInternal(Patterns.Colon());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of colons.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Colon(int exactCount)
        {
            return AppendInternal(Patterns.Colon(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a colon.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotColon()
        {
            return AppendInternal(Patterns.NotColon());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a colon.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotColon(int exactCount)
        {
            return AppendInternal(Patterns.NotColon(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a semicolon.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Semicolon()
        {
            return AppendInternal(Patterns.Semicolon());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of semicolons.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Semicolon(int exactCount)
        {
            return AppendInternal(Patterns.Semicolon(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a semicolon.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotSemicolon()
        {
            return AppendInternal(Patterns.NotSemicolon());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a semicolon.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotSemicolon(int exactCount)
        {
            return AppendInternal(Patterns.NotSemicolon(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a left angle bracket (less-than sign).
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern LeftAngleBracket()
        {
            return AppendInternal(Patterns.LeftAngleBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of left angle brackets (less-than signs).
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup LeftAngleBracket(int exactCount)
        {
            return AppendInternal(Patterns.LeftAngleBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a left angle bracket (less-than sign).
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotLeftAngleBracket()
        {
            return AppendInternal(Patterns.NotLeftAngleBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a left angle bracket (less-than sign).
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotLeftAngleBracket(int exactCount)
        {
            return AppendInternal(Patterns.NotLeftAngleBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches an equals sign.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern EqualsSign()
        {
            return AppendInternal(Patterns.EqualsSign());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of equals signs.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup EqualsSign(int exactCount)
        {
            return AppendInternal(Patterns.EqualsSign(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an equals sign.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotEqualsSign()
        {
            return AppendInternal(Patterns.NotEqualsSign());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not an equals sign.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotEqualsSign(int exactCount)
        {
            return AppendInternal(Patterns.NotEqualsSign(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a right angle bracket (greater-than sign).
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern RightAngleBracket()
        {
            return AppendInternal(Patterns.RightAngleBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of right angle brackets (greater-than signs).
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup RightAngleBracket(int exactCount)
        {
            return AppendInternal(Patterns.RightAngleBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an right angle bracket (greater-than sign).
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotRightAngleBracket()
        {
            return AppendInternal(Patterns.NotRightAngleBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a right angle bracket (greater-than sign).
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotRightAngleBracket(int exactCount)
        {
            return AppendInternal(Patterns.NotRightAngleBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a question mark.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern QuestionMark()
        {
            return AppendInternal(Patterns.QuestionMark());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of question marks.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup QuestionMark(int exactCount)
        {
            return AppendInternal(Patterns.QuestionMark(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a question mark.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotQuestionMark()
        {
            return AppendInternal(Patterns.NotQuestionMark());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a question mark.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotQuestionMark(int exactCount)
        {
            return AppendInternal(Patterns.NotQuestionMark(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches an at sign.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern AtSign()
        {
            return AppendInternal(Patterns.AtSign());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of at signs.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup AtSign(int exactCount)
        {
            return AppendInternal(Patterns.AtSign(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an at sign.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotAtSign()
        {
            return AppendInternal(Patterns.NotAtSign());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not an at sign.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotAtSign(int exactCount)
        {
            return AppendInternal(Patterns.NotAtSign(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a left square bracket.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern LeftSquareBracket()
        {
            return AppendInternal(Patterns.LeftSquareBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of left square brackets.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup LeftSquareBracket(int exactCount)
        {
            return AppendInternal(Patterns.LeftSquareBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a left square bracket.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotLeftSquareBracket()
        {
            return AppendInternal(Patterns.NotLeftSquareBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a left square bracket.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotLeftSquareBracket(int exactCount)
        {
            return AppendInternal(Patterns.NotLeftSquareBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a backslash.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Backslash()
        {
            return AppendInternal(Patterns.Backslash());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of backslashes.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Backslash(int exactCount)
        {
            return AppendInternal(Patterns.Backslash(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a backslash.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotBackslash()
        {
            return AppendInternal(Patterns.NotBackslash());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a backslash.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotBackslash(int exactCount)
        {
            return AppendInternal(Patterns.NotBackslash(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a right square bracket.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern RightSquareBracket()
        {
            return AppendInternal(Patterns.RightSquareBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of right square brackets.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup RightSquareBracket(int exactCount)
        {
            return AppendInternal(Patterns.RightSquareBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a right square bracket.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotRightSquareBracket()
        {
            return AppendInternal(Patterns.NotRightSquareBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a right square bracket.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotRightSquareBracket(int exactCount)
        {
            return AppendInternal(Patterns.NotRightSquareBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a circumflex accent.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern CircumflexAccent()
        {
            return AppendInternal(Patterns.CircumflexAccent());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of circumflex accents.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup CircumflexAccent(int exactCount)
        {
            return AppendInternal(Patterns.CircumflexAccent(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a circumflex accent.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotCircumflexAccent()
        {
            return AppendInternal(Patterns.NotCircumflexAccent());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a circumflex accent.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotCircumflexAccent(int exactCount)
        {
            return AppendInternal(Patterns.NotCircumflexAccent(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches an underscore.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Underscore()
        {
            return AppendInternal(Patterns.Underscore());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of underscores.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Underscore(int exactCount)
        {
            return AppendInternal(Patterns.Underscore(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not an underscore.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotUnderscore()
        {
            return AppendInternal(Patterns.NotUnderscore());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not an underscore.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotUnderscore(int exactCount)
        {
            return AppendInternal(Patterns.NotUnderscore(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a grave accent.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern GraveAccent()
        {
            return AppendInternal(Patterns.GraveAccent());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of grave accents.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup GraveAccent(int exactCount)
        {
            return AppendInternal(Patterns.GraveAccent(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a grave accent.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotGraveAccent()
        {
            return AppendInternal(Patterns.NotGraveAccent());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a grave accent.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotGraveAccent(int exactCount)
        {
            return AppendInternal(Patterns.NotGraveAccent(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a left curly bracket.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern LeftCurlyBracket()
        {
            return AppendInternal(Patterns.LeftCurlyBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of left curly brackets.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup LeftCurlyBracket(int exactCount)
        {
            return AppendInternal(Patterns.LeftCurlyBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a left curly bracket.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotLeftCurlyBracket()
        {
            return AppendInternal(Patterns.NotLeftCurlyBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a left curly bracket.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotLeftCurlyBracket(int exactCount)
        {
            return AppendInternal(Patterns.NotLeftCurlyBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a vertical bar.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern VerticalBar()
        {
            return AppendInternal(Patterns.VerticalBar());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of vertical bars.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup VerticalBar(int exactCount)
        {
            return AppendInternal(Patterns.VerticalBar(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a vertical bar.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotVerticalBar()
        {
            return AppendInternal(Patterns.NotVerticalBar());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a vertical bar.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotVerticalBar(int exactCount)
        {
            return AppendInternal(Patterns.NotVerticalBar(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a right curly bracket.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern RightCurlyBracket()
        {
            return AppendInternal(Patterns.RightCurlyBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of right curly brackets.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup RightCurlyBracket(int exactCount)
        {
            return AppendInternal(Patterns.RightCurlyBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a right curly bracket.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotRightCurlyBracket()
        {
            return AppendInternal(Patterns.NotRightCurlyBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a right curly bracket.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotRightCurlyBracket(int exactCount)
        {
            return AppendInternal(Patterns.NotRightCurlyBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a tilde.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern Tilde()
        {
            return AppendInternal(Patterns.Tilde());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of tildes.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Tilde(int exactCount)
        {
            return AppendInternal(Patterns.Tilde(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a tilde.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotTilde()
        {
            return AppendInternal(Patterns.NotTilde());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of characters that are not a tilde.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotTilde(int exactCount)
        {
            return AppendInternal(Patterns.NotTilde(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches left or right parenthesis.
        /// </summary>
        /// <returns></returns>
        public CharGroup Parenthesis()
        {
            return AppendInternal(Patterns.Parenthesis());
        }

        /// <summary>
        /// Appends a pattern that matches left or right parenthesis specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Parenthesis(int exactCount)
        {
            return AppendInternal(Patterns.Parenthesis(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is neither left nor right parenthesis.
        /// </summary>
        /// <returns></returns>
        public CharGroup NotParenthesis()
        {
            return AppendInternal(Patterns.NotParenthesis());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is neither left nor right parenthesis specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotParenthesis(int exactCount)
        {
            return AppendInternal(Patterns.NotParenthesis(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches left or right curly bracket.
        /// </summary>
        /// <returns></returns>
        public CharGroup CurlyBracket()
        {
            return AppendInternal(Patterns.CurlyBracket());
        }

        /// <summary>
        /// Appends a pattern that matches left or right curly bracket specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup CurlyBracket(int exactCount)
        {
            return AppendInternal(Patterns.CurlyBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is neither left nor right curly bracket.
        /// </summary>
        /// <returns></returns>
        public CharGroup NotCurlyBracket()
        {
            return AppendInternal(Patterns.NotCurlyBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is neither left nor right curly bracket specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotCurlyBracket(int exactCount)
        {
            return AppendInternal(Patterns.NotCurlyBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches left or right square bracket.
        /// </summary>
        /// <returns></returns>
        public CharGroup SquareBracket()
        {
            return AppendInternal(Patterns.SquareBracket());
        }

        /// <summary>
        /// Appends a pattern that matches left or right square bracket specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup SquareBracket(int exactCount)
        {
            return AppendInternal(Patterns.SquareBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is neither left nor right square bracket.
        /// </summary>
        /// <returns></returns>
        public CharGroup NotSquareBracket()
        {
            return AppendInternal(Patterns.NotSquareBracket());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is neither left nor right square bracket specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotSquareBracket(int exactCount)
        {
            return AppendInternal(Patterns.NotSquareBracket(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches specified content zero or one time.
        /// </summary>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiedGroup Maybe(object content)
        {
            return AppendInternal(Patterns.Maybe(content));
        }

        /// <summary>
        /// Appends a pattern that matches any one specified element zero or one time.
        /// </summary>
        /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
        /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiedGroup Maybe(object first, params object[] others)
        {
            return AppendInternal(Patterns.Maybe(first, others));
        }

        /// <summary>
        /// Appends a pattern that matches specified content zero or more times.
        /// </summary>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiedGroup MaybeMany(object content)
        {
            return AppendInternal(Patterns.MaybeMany(content));
        }

        /// <summary>
        /// Appends a pattern that matches any one specified element zero or more times.
        /// </summary>
        /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
        /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiedGroup MaybeMany(object first, params object[] others)
        {
            return AppendInternal(Patterns.MaybeMany(first, others));
        }

        /// <summary>
        /// Appends a pattern that matches specified content one or more times.
        /// </summary>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiedGroup OneMany(object content)
        {
            return AppendInternal(Patterns.OneMany(content));
        }

        /// <summary>
        /// Appends a pattern that matches any one specified element one or more times.
        /// </summary>
        /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
        /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public QuantifiedGroup OneMany(object first, params object[] others)
        {
            return AppendInternal(Patterns.OneMany(first, others));
        }

        /// <summary>
        /// Appends a pattern that matches specified pattern specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times the pattern has to be matched.</param>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Count(int exactCount, object content)
        {
            return AppendInternal(Patterns.Count(exactCount, content));
        }

        /// <summary>
        /// Appends a pattern that matches any one specified pattern specified number of times.
        /// </summary>
        /// <param name="exactCount">A number of times the pattern has to be matched.</param>
        /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
        /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Count(int exactCount, object first, params object[] others)
        {
            return AppendInternal(Patterns.Count(exactCount, first, others));
        }

        /// <summary>
        /// Appends a pattern that matches specified pattern from minimal to maximum number of times.
        /// </summary>
        /// <param name="minCount">A minimal number of times the pattern must be matched.</param>
        /// <param name="maxCount">A maximum number of times the pattern can be matched.</param>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Count(int minCount, int maxCount, object content)
        {
            return AppendInternal(Patterns.Count(minCount, maxCount, content));
        }

        /// <summary>
        /// Appends a pattern that matches any one specified pattern from minimal to maximum number of times.
        /// </summary>
        /// <param name="minCount">A minimal number of times the pattern must be matched.</param>
        /// <param name="maxCount">A maximum number of times the pattern can be matched.</param>
        /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
        /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup Count(int minCount, int maxCount, object first, params object[] others)
        {
            return AppendInternal(Patterns.Count(minCount, maxCount, first, others));
        }

        /// <summary>
        /// Appends a pattern that matches specified pattern at least specified number of times.
        /// </summary>
        /// <param name="minCount">A minimal number of times the pattern must be matched.</param>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup CountFrom(int minCount, object content)
        {
            return AppendInternal(Patterns.CountFrom(minCount, content));
        }

        /// <summary>
        /// Appends a pattern that matches any one specified pattern at least specified number of times.
        /// </summary>
        /// <param name="minCount">A minimal number of times the pattern must be matched.</param>
        /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
        /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup CountFrom(int minCount, object first, params object[] others)
        {
            return AppendInternal(Patterns.CountFrom(minCount, first, others));
        }

        /// <summary>
        /// Appends a pattern that matches specified pattern at most specified number of times.
        /// </summary>
        /// <param name="maxCount">A maximum number of times the pattern can be matched.</param>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup MaybeCount(int maxCount, object content)
        {
            return AppendInternal(Patterns.MaybeCount(maxCount, content));
        }

        /// <summary>
        /// Appends a pattern that matches any one specified pattern at most specified number of times.
        /// </summary>
        /// <param name="maxCount">A maximum number of times the pattern can be matched.</param>
        /// <param name="first">First element of a sequence that contains patterns any one of which has to be matched.</param>
        /// <param name="others">Other elements of a sequence that contains patterns any one of which has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup MaybeCount(int maxCount, object first, params object[] others)
        {
            return AppendInternal(Patterns.MaybeCount(maxCount, first, others));
        }

        /// <summary>
        /// Appends a pattern that matches previously defined numbered group.
        /// </summary>
        /// <param name="groupNumber">A number of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiablePattern GroupReference(int groupNumber)
        {
            return AppendInternal(Patterns.GroupReference(groupNumber));
        }

        /// <summary>
        /// Appends a pattern that matches previously defined named group.
        /// </summary>
        /// <param name="groupName">A name of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public QuantifiablePattern GroupReference(string groupName)
        {
            return AppendInternal(Patterns.GroupReference(groupName));
        }

        /// <summary>
        /// Appends a pattern that matches a combination of an optional carriage return and a linefeed.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NewLine()
        {
            return AppendInternal(Patterns.NewLine());
        }

        /// <summary>
        /// Appends a pattern that matches a newline character. Newline character is a carriage return or a linefeed.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NewLineChar()
        {
            return AppendInternal(Patterns.NewLineChar());
        }

        /// <summary>
        /// Appends a pattern that matches a specified number of newline characters. Newline character is a carriage return or a linefeed.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NewLineChar(int exactCount)
        {
            return AppendInternal(Patterns.NewLineChar(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a newline character. Newline character is a carriage return or a linefeed.
        /// </summary>
        /// <returns></returns>
        public QuantifiablePattern NotNewLineChar()
        {
            return AppendInternal(Patterns.NotNewLineChar());
        }

        /// <summary>
        /// Appends a pattern that matches a character that is not a newline character specified number of times. Newline character is a carriage return or a linefeed.
        /// </summary>
        /// <param name="exactCount">A number of times a character has to be matched.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public QuantifiedGroup NotNewLineChar(int exactCount)
        {
            return AppendInternal(Patterns.NotNewLineChar(exactCount));
        }

        /// <summary>
        /// Appends a pattern that matches one or many opening characters balanced with one or many closing characters.
        /// Between the characters can be zero or many characters that are neither opening nor closing character.
        /// A name for the group containing opening character is randomly generated and if the characters are balanced, the group has no captures.
        /// </summary>
        /// <param name="openingCharacter">Opening Unicode character to balance.</param>
        /// <param name="closingCharacter">Closing Unicode character to balance.</param>
        /// <param name="groupName">A name of the group that contains balanced content of the opening and closing character.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Pattern Balance(char openingCharacter, char closingCharacter, string groupName)
        {
            return AppendInternal(Patterns.Balance(openingCharacter, closingCharacter, groupName));
        }

        /// <summary>
        /// Appends a pattern that matches one or many opening characters balanced with one or many closing characters.
        /// Between the characters can be zero or many characters that are neither opening nor closing character.
        /// If the characters are balanced, group containing opening character has no captures.
        /// </summary>
        /// <param name="openingCharacter">Opening Unicode character to balance.</param>
        /// <param name="closingCharacter">Closing Unicode character to balance.</param>
        /// <param name="groupName">A name of the group that contains balanced content of the opening and closing character.</param>
        /// <param name="openGroupName">A name of the group that contains opening character.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Pattern Balance(char openingCharacter, char closingCharacter, string groupName, string openGroupName)
        {
            return AppendInternal(Patterns.Balance(openingCharacter, closingCharacter, groupName, openGroupName));
        }

        /// <summary>
        /// Returns a noncapturing group with current instance as a content.
        /// </summary>
        /// <returns></returns>
        internal QuantifiablePattern AsNoncapturingGroup()
        {
            return Patterns.NoncapturingGroup(this);
        }
    }
}
