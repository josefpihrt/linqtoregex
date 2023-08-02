// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Pihrtsoft.Text.RegularExpressions.Rendering;

namespace Pihrtsoft.Text.RegularExpressions;

/// <summary>
/// Represents an immutable regular expression pattern. This class is abstract.
/// </summary>
[DebuggerDisplay("{DebuggerDisplay,nq}")]
public abstract partial class Pattern
{
    /// <summary>
    /// Creates and returns a new instance of the <see cref="Pattern"/> class.
    /// </summary>
    protected Pattern()
    {
    }

    internal abstract void AppendTo(PatternBuilder builder);

    /// <summary>
    /// If a condition is true, appends a pattern that matches a specified content.
    /// </summary>
    /// <param name="condition">The condition expression to evaluate.</param>
    /// <param name="content">The content to be matched.</param>
    public Pattern AppendIf(bool condition, object content)
    {
        return (condition)
            ? Append(content)
            : this;
    }

    /// <summary>
    /// Appends a pattern that matches a specified content.
    /// </summary>
    /// <param name="content">The content to be matched.</param>
    public Pattern Append(object content)
    {
        return AppendInternal(new ContentPattern(content));
    }

    /// <summary>
    /// Appends a pattern that matches a specified text.
    /// </summary>
    /// <param name="value">A text to append.</param>
    public Pattern Text(string value)
    {
        return AppendInternal(PatternFactory.Text(value));
    }

    /// <summary>
    /// Appends a pattern that matches a specified text, ignoring or honoring its case.
    /// </summary>
    /// <param name="value">A text to append.</param>
    /// <param name="ignoreCase">true to ignore case during the matching; otherwise, false.</param>
    public QuantifiablePattern Text(string value, bool ignoreCase)
    {
        return AppendInternal(PatternFactory.Text(value, ignoreCase));
    }

    internal TPattern AppendInternal<TPattern>(TPattern pattern) where TPattern : Pattern
    {
        if (pattern is null)
            throw new ArgumentNullException(nameof(pattern));

        Pattern first = pattern;

        while (first.Previous is not null)
            first = first.Previous;

        first.Previous = this;

        return pattern;
    }

    /// <summary>
    /// Compiles a new instance of the <see cref="Regex"/> class for the current instance.
    /// </summary>
    public Regex ToRegex()
    {
        return ToRegex(RegexOptions.None);
    }

    /// <summary>
    /// Compiles a new instance of the <see cref="Regex"/> class for the current instance, with options that modify the pattern.
    /// </summary>
    /// <param name="options">A bitwise combination of the enumeration values that modify the regular expression.</param>
    public Regex ToRegex(RegexOptions options)
    {
        return new Regex(ToString(), options);
    }

    /// <summary>
    /// Constructs a pattern text that represents the current instance.
    /// </summary>
    public override string ToString()
    {
        return ToString(RegexOptions.None);
    }

    /// <summary>
    /// Constructs a pattern text that represents the current instance with regex options that modify the pattern.
    /// </summary>
    /// <param name="options">A bitwise combination of the enumeration values that modify the pattern.</param>
    internal string ToString(RegexOptions options)
    {
        return ToString(new PatternOptions(), options);
    }

    /// <summary>
    /// Constructs a pattern text that represents the current instance with options that modify the pattern.
    /// </summary>
    /// <param name="options">Options that modify the pattern.</param>
    public string ToString(PatternOptions options)
    {
        return ToString(options, RegexOptions.None);
    }

    internal string ToString(PatternOptions options, RegexOptions regexOptions)
    {
        var builder = new PatternBuilder(options, regexOptions);
        builder.Append(this);
        return builder.ToString();
    }

    /// <summary>
    /// Searches the specified input string for all matches.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public MatchCollection Matches(string input)
    {
        return Regex.Matches(input, ToString());
    }

    /// <summary>
    /// Searches the specified input string for all matches, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public MatchCollection Matches(string input, RegexOptions options)
    {
        return Regex.Matches(input, ToString(options), options);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of matches.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Match> EnumerateMatches(string input)
    {
        return EnumerateMatches(input, RegexOptions.None);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of matches, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Match> EnumerateMatches(string input, RegexOptions options)
    {
        Match match = Regex.Match(input, ToString(options), options);
        while (match.Success)
        {
            yield return match;
            match = match.NextMatch();
        }
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of groups.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Group> EnumerateGroups(string input)
    {
        return EnumerateGroups(input, RegexOptions.None);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of groups, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Group> EnumerateGroups(string input, RegexOptions options)
    {
        return EnumerateMatches(input, options).EnumerateGroups();
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of groups with a specified name.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
    public IEnumerable<Group> EnumerateGroups(string input, string groupName)
    {
        return EnumerateGroups(input, groupName, RegexOptions.None);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of groups with a specified name, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
    public IEnumerable<Group> EnumerateGroups(string input, string groupName, RegexOptions options)
    {
        return EnumerateMatches(input, options).EnumerateGroups(groupName);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of groups with a specified number.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupNumber">A valid number of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Group> EnumerateGroups(string input, int groupNumber)
    {
        return EnumerateGroups(input, groupNumber, RegexOptions.None);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of groups with a specified number, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupNumber">A valid number of the group.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Group> EnumerateGroups(string input, int groupNumber, RegexOptions options)
    {
        return EnumerateMatches(input, options).EnumerateGroups(groupNumber);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of groups that contain at least one capture.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Group> EnumerateSuccessGroups(string input)
    {
        return EnumerateSuccessGroups(input, RegexOptions.None);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of groups that contain at least one capture, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Group> EnumerateSuccessGroups(string input, RegexOptions options)
    {
        return EnumerateMatches(input, options).EnumerateSuccessGroups();
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of groups that have a specified name and contain at least one capture.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
    public IEnumerable<Group> EnumerateSuccessGroups(string input, string groupName)
    {
        return EnumerateSuccessGroups(input, groupName, RegexOptions.None);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of groups that have a specified name and contain at least one capture, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
    public IEnumerable<Group> EnumerateSuccessGroups(string input, string groupName, RegexOptions options)
    {
        return EnumerateMatches(input, options).EnumerateSuccessGroups(groupName);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of groups that have a specified number and contain at least one capture.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupNumber">A valid number of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Group> EnumerateSuccessGroups(string input, int groupNumber)
    {
        return EnumerateSuccessGroups(input, groupNumber, RegexOptions.None);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of groups that have a specified number and contain at least one capture, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupNumber">A valid number of the group.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Group> EnumerateSuccessGroups(string input, int groupNumber, RegexOptions options)
    {
        return EnumerateMatches(input, options).EnumerateSuccessGroups(groupNumber);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of captures.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Capture> EnumerateCaptures(string input)
    {
        return EnumerateCaptures(input, RegexOptions.None);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of captures, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Capture> EnumerateCaptures(string input, RegexOptions options)
    {
        return EnumerateMatches(input, options).EnumerateCaptures();
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of captures from groups that have a specified name.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
    public IEnumerable<Capture> EnumerateCaptures(string input, string groupName)
    {
        return EnumerateCaptures(input, groupName, RegexOptions.None);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of captures from groups that have a specified name, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
    public IEnumerable<Capture> EnumerateCaptures(string input, string groupName, RegexOptions options)
    {
        return EnumerateMatches(input, options).EnumerateCaptures(groupName);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of captures from groups that have a specified number.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupNumber">A valid number of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Capture> EnumerateCaptures(string input, int groupNumber)
    {
        return EnumerateCaptures(input, groupNumber, RegexOptions.None);
    }

    /// <summary>
    /// Searches the specified input string and returns an enumerable collection of captures from groups that have a specified number, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupNumber">A valid number of the group.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public IEnumerable<Capture> EnumerateCaptures(string input, int groupNumber, RegexOptions options)
    {
        return EnumerateMatches(input, options).EnumerateCaptures(groupNumber);
    }

    /// <summary>
    /// Indicates whether the current instance finds a match in the specified input string.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public bool IsMatch(string input)
    {
        return Regex.IsMatch(input, ToString());
    }

    /// <summary>
    /// Indicates whether the current instance finds a match in the specified input string, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public bool IsMatch(string input, RegexOptions options)
    {
        return Regex.IsMatch(input, ToString(options), options);
    }

    /// <summary>
    /// Searches a specified input string for the first occurrence of the current instance.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public Match Match(string input)
    {
        return Regex.Match(input, ToString());
    }

    /// <summary>
    /// Searches a specified input string for the first occurrence of the current instance, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public Match Match(string input, RegexOptions options)
    {
        return Regex.Match(input, ToString(options), options);
    }

    /// <summary>
    /// Within a specified input string, replaces strings that match the current instance with an empty string.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public string Replace(string input)
    {
        return Replace(input, "");
    }

    /// <summary>
    /// Within a specified input string, replaces all strings that match the current instance with a string returned by a <see cref="MatchEvaluator"/> delegate.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="evaluator">A method that examines each match and returns a replacement string.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> or <paramref name="evaluator"/> is <c>null</c>.</exception>
    public string Replace(string input, MatchEvaluator evaluator)
    {
        return Regex.Replace(input, ToString(), evaluator);
    }

    /// <summary>
    /// Within a specified input string, replaces all strings that match the current instance with a string returned by a <see cref="MatchEvaluator"/> delegate. Specified options modify the matching operation.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="evaluator">A method that examines each match and returns a replacement string.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <exception cref="ArgumentNullException"><paramref name="input"/> or <paramref name="evaluator"/> is <c>null</c>.</exception>
    public string Replace(string input, MatchEvaluator evaluator, RegexOptions options)
    {
        return Regex.Replace(input, ToString(options), evaluator, options);
    }

    /// <summary>
    /// Within a specified input string, replaces all strings that match the current instance with a specified replacement string.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="replacement">The replacement string.</param>
    public string Replace(string input, string replacement)
    {
        return Regex.Replace(input, ToString(), replacement);
    }

    /// <summary>
    /// Within a specified input string, replaces all strings that match the current instance with a specified replacement string. Specified options modify the matching operation.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="replacement">The replacement string.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    public string Replace(string input, string replacement, RegexOptions options)
    {
        return Regex.Replace(input, ToString(options), replacement, options);
    }

    /// <summary>
    /// Splits the specified input string at the positions defined by the current instance.
    /// </summary>
    /// <param name="input">The string to split.</param>
    public string[] Split(string input)
    {
        return Regex.Split(input, ToString());
    }

    /// <summary>
    /// Splits the specified input string at the positions defined by the current instance, using the specified matching options.
    /// </summary>
    /// <param name="input">The string to split.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    public string[] Split(string input, RegexOptions options)
    {
        return Regex.Split(input, ToString(options), options);
    }

    /// <summary>
    /// Concatenate two elements into a new <see cref="Pattern"/>.
    /// </summary>
    /// <param name="left">The first element to concatenate.</param>
    /// <param name="right">The second element to concatenate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
    public static Pattern operator +(Pattern left, Pattern right)
    {
        if (left is null)
            throw new ArgumentNullException(nameof(left));

        if (right is null)
            throw new ArgumentNullException(nameof(right));

        return left.Append(right);
    }

    /// <summary>
    /// Concatenate two elements into a new <see cref="Pattern"/>.
    /// </summary>
    /// <param name="left">The first element to concatenate.</param>
    /// <param name="right">The second element to concatenate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
    public static Pattern operator +(Pattern left, string right)
    {
        if (left is null)
            throw new ArgumentNullException(nameof(left));

        if (right is null)
            throw new ArgumentNullException(nameof(right));

        return left.Text(right);
    }

    /// <summary>
    /// Concatenate two elements into a new <see cref="Pattern"/>.
    /// </summary>
    /// <param name="left">The first element to concatenate.</param>
    /// <param name="right">The second element to concatenate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
    public static Pattern operator +(string left, Pattern right)
    {
        if (left is null)
            throw new ArgumentNullException(nameof(left));

        if (right is null)
            throw new ArgumentNullException(nameof(right));

        return PatternFactory.Text(left).Append(right);
    }

    /// <summary>
    /// Concatenate two elements into a new <see cref="Pattern"/>.
    /// </summary>
    /// <param name="left">The first element to concatenate.</param>
    /// <param name="right">The second element to concatenate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> is <c>null</c>.</exception>
    public static Pattern operator +(Pattern left, char right)
    {
        if (left is null)
            throw new ArgumentNullException(nameof(left));

        return left.Append(PatternFactory.Character(right));
    }

    /// <summary>
    /// Concatenate two elements into a new <see cref="Pattern"/>.
    /// </summary>
    /// <param name="left">The first element to concatenate.</param>
    /// <param name="right">The second element to concatenate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="right"/> is <c>null</c>.</exception>
    public static Pattern operator +(char left, Pattern right)
    {
        if (right is null)
            throw new ArgumentNullException(nameof(right));

        return PatternFactory.Character(left).Append(right);
    }

    /// <summary>
    /// Creates a pattern that matches any one of the specified elements.
    /// </summary>
    /// <param name="left">The first element to match.</param>
    /// <param name="right">The second element to match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
    public static QuantifiablePattern operator |(Pattern left, Pattern right)
    {
        return PatternFactory.Or(left, right);
    }

    /// <summary>
    /// Creates a pattern that matches any one of the specified elements.
    /// </summary>
    /// <param name="left">The first element to match.</param>
    /// <param name="right">The second element to match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
    public static QuantifiablePattern operator |(Pattern left, string right)
    {
        return PatternFactory.Or(left, right);
    }

    /// <summary>
    /// Creates a pattern that matches any one of the specified elements.
    /// </summary>
    /// <param name="left">The first element to match.</param>
    /// <param name="right">The second element to match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
    public static QuantifiablePattern operator |(string left, Pattern right)
    {
        return PatternFactory.Or(left, right);
    }

    /// <summary>
    /// Creates a pattern that matches any one of the specified elements.
    /// </summary>
    /// <param name="left">The first element to match.</param>
    /// <param name="right">The second element to match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
    public static QuantifiablePattern operator |(Pattern left, CharGrouping right)
    {
        return PatternFactory.Or(left, right);
    }

    /// <summary>
    /// Creates a pattern that matches any one of the specified elements.
    /// </summary>
    /// <param name="left">The first element to match.</param>
    /// <param name="right">The second element to match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
    public static QuantifiablePattern operator |(CharGrouping left, Pattern right)
    {
        return PatternFactory.Or(left, right);
    }

    /// <summary>
    /// Creates a pattern that matches any one of the specified elements.
    /// </summary>
    /// <param name="left">The first element to match.</param>
    /// <param name="right">The second element to match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> is <c>null</c>.</exception>
    public static QuantifiablePattern operator |(Pattern left, char right)
    {
        return PatternFactory.Or(left, right);
    }

    /// <summary>
    /// Creates a pattern that matches any one of the specified elements.
    /// </summary>
    /// <param name="left">The first element to match.</param>
    /// <param name="right">The second element to match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="right"/> is <c>null</c>.</exception>
    public static QuantifiablePattern operator |(char left, Pattern right)
    {
        return PatternFactory.Or(left, right);
    }

    /// <summary>
    /// Converts specified text to a pattern.
    /// </summary>
    /// <param name="text">A text to convert.</param>
    public static explicit operator Pattern(string text) => new TextPattern(text);

    /// <summary>
    /// Converts specified character to a pattern.
    /// </summary>
    /// <param name="value">The Unicode character to convert.</param>
    public static explicit operator Pattern(char value) => CharPattern.Create(value);

    internal Pattern? Previous { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string DebuggerDisplay => ToString();
}
