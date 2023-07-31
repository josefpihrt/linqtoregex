// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

/// <summary>
/// Provides a set of static methods that extends the <see cref="Regex"/> class.
/// </summary>
public static class RegexExtensions
{
    /// <summary>
    /// Searches the specified input string and returns enumerable collection of regular expression matches.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static IEnumerable<Match> EnumerateMatches(this Regex regex, string input)
    {
        if (regex is null)
            throw new ArgumentNullException(nameof(regex));

        if (input is null)
            throw new ArgumentNullException(nameof(input));

        return EnumerateMatches();

        IEnumerable<Match> EnumerateMatches()
        {
            Match match = regex.Match(input);
            while (match.Success)
            {
                yield return match;
                match = match.NextMatch();
            }
        }
    }

    /// <summary>
    /// Searches the specified input string beginning at the specified position and returns enumerable collection of regular expression matches.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="startAt">The position at which to start the search.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="startAt"/> is less than zero or greater that the length of <paramref name="input"/>.</exception>
    public static IEnumerable<Match> EnumerateMatches(this Regex regex, string input, int startAt)
    {
        if (regex is null)
            throw new ArgumentNullException(nameof(regex));

        if (input is null)
            throw new ArgumentNullException(nameof(input));

        return EnumerateMatches();

        IEnumerable<Match> EnumerateMatches()
        {
            Match match = regex.Match(input, startAt);
            while (match.Success)
            {
                yield return match;
                match = match.NextMatch();
            }
        }
    }

    /// <summary>
    /// Searches the specified input string beginning at the specified position and searching only the specified number of characters and returns enumerable collection of regular expression matches.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="beginning">The position at which to start the search.</param>
    /// <param name="length">A number of characters to be searched.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="beginning"/> is less than zero or greater than the length of input.
    /// <para><paramref name="length"/> is less than zero or greater then the length of input.</para>
    /// <para><paramref name="beginning"/> + <paramref name="length"/> - 1 is outside the range of input.</para>
    /// </exception>
    public static IEnumerable<Match> EnumerateMatches(this Regex regex, string input, int beginning, int length)
    {
        if (regex is null)
            throw new ArgumentNullException(nameof(regex));

        if (input is null)
            throw new ArgumentNullException(nameof(input));

        return EnumerateMatches();

        IEnumerable<Match> EnumerateMatches()
        {
            Match match = regex.Match(input, beginning, length);
            while (match.Success)
            {
                yield return match;
                match = match.NextMatch();
            }
        }
    }

    /// <summary>
    /// Searches the specified input string and returns enumerable collection of groups.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static IEnumerable<Group> EnumerateGroups(this Regex regex, string input)
    {
        foreach (Match match in EnumerateMatches(regex, input))
        {
            for (int i = 0; i < match.Groups.Count; i++)
                yield return match.Groups[i];
        }
    }

    /// <summary>
    /// Searches the specified input string and returns enumerable collection of groups with a specified name.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
    public static IEnumerable<Group> EnumerateGroups(this Regex regex, string input, string groupName)
    {
        foreach (Match match in EnumerateMatches(regex, input))
            yield return match.Groups[groupName];
    }

    /// <summary>
    /// Searches the specified input string and returns enumerable collection of groups that have a specified number.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static IEnumerable<Group> EnumerateGroups(this Regex regex, string input, int groupNumber)
    {
        foreach (Match match in EnumerateMatches(regex, input))
            yield return match.Groups[groupNumber];
    }

    /// <summary>
    /// Searches the specified input string and returns enumerable collection of groups that have at least one capture.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static IEnumerable<Group> EnumerateSuccessGroups(this Regex regex, string input)
    {
        foreach (Match match in EnumerateMatches(regex, input))
        {
            for (int i = 0; i < match.Groups.Count; i++)
            {
                Group group = match.Groups[i];

                if (group.Success)
                    yield return group;
            }
        }
    }

    /// <summary>
    /// Searches the specified input string and returns enumerable collection of groups that have a specified name and have at least one capture.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
    public static IEnumerable<Group> EnumerateSuccessGroups(this Regex regex, string input, string groupName)
    {
        foreach (Match match in EnumerateMatches(regex, input))
        {
            Group group = match.Groups[groupName];

            if (group.Success)
                yield return group;
        }
    }

    /// <summary>
    /// Searches the specified input string and returns enumerable collection of groups that have a specified number and have at least one capture.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static IEnumerable<Group> EnumerateSuccessGroups(this Regex regex, string input, int groupNumber)
    {
        foreach (Match match in EnumerateMatches(regex, input))
        {
            Group group = match.Groups[groupNumber];

            if (group.Success)
                yield return group;
        }
    }

    /// <summary>
    /// Searches the specified input string and returns enumerable collection of captures.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static IEnumerable<Capture> EnumerateCaptures(this Regex regex, string input)
    {
        foreach (Match match in EnumerateMatches(regex, input))
        {
            for (int i = 0; i < match.Groups.Count; i++)
            {
                Group group = match.Groups[i];
                if (group.Success)
                {
                    for (int j = 0; j < group.Captures.Count; j++)
                        yield return group.Captures[j];
                }
            }
        }
    }

    /// <summary>
    /// Searches the specified input string and returns enumerable collection of captures from groups that have a specified name.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
    public static IEnumerable<Capture> EnumerateCaptures(this Regex regex, string input, string groupName)
    {
        foreach (Match match in EnumerateMatches(regex, input))
        {
            Group group = match.Groups[groupName];
            if (group.Success)
            {
                for (int i = 0; i < group.Captures.Count; i++)
                    yield return group.Captures[i];
            }
        }
    }

    /// <summary>
    /// Searches the specified input string and returns enumerable collection of captures from groups that have a specified number.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static IEnumerable<Capture> EnumerateCaptures(this Regex regex, string input, int groupNumber)
    {
        foreach (Match match in EnumerateMatches(regex, input))
        {
            Group group = match.Groups[groupNumber];
            if (group.Success)
            {
                for (int i = 0; i < group.Captures.Count; i++)
                    yield return group.Captures[i];
            }
        }
    }

    /// <summary>
    /// Within a specified input string, replaces all strings that match the regular expression with a string where each character is replaced with the specified character.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="replacementChar">The replacement char.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static string ReplaceMatchChar(this Regex regex, string input, char replacementChar)
    {
        if (regex is null)
            throw new ArgumentNullException(nameof(regex));

        return regex.Replace(input, match => new string(replacementChar, match.Length));
    }

    /// <summary>
    /// Within a specified input string, replaces all groups with the specified name that match the regular expression with a string where each character is replaced with the specified character.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="replacementChar">The replacement char.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static string ReplaceGroupChar(this Regex regex, string input, char replacementChar, string groupName)
    {
        if (regex is null)
            throw new ArgumentNullException(nameof(regex));

        if (input is null)
            throw new ArgumentNullException(nameof(input));

        return RegexReplace.ReplaceGroups(regex, input, groupName, group => new string(replacementChar, group.Length));
    }

    /// <summary>
    /// Within a specified input string, replaces all groups with the specified number that match the regular expression with a string where each character is replaced with the specified character.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="replacementChar">The replacement char.</param>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static string ReplaceGroupChar(this Regex regex, string input, char replacementChar, int groupNumber)
    {
        if (regex is null)
            throw new ArgumentNullException(nameof(regex));

        if (input is null)
            throw new ArgumentNullException(nameof(input));

        return RegexReplace.ReplaceGroups(regex, input, groupNumber, group => new string(replacementChar, group.Length));
    }

    /// <summary>
    /// Splits the specified input string at the positions defined by the regular expression into an enumerable collection of strings.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to split.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static IEnumerable<string> EnumerateSplit(this Regex regex, string input)
    {
        return RegexSplit.EnumerateValues(regex, input);
    }

    /// <summary>
    /// Splits the specified input string at the positions defined by the regular expression into an enumerable collection of strings, using the specified split options.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to split.</param>
    /// <param name="splitOptions">A bitwise combination of the enumeration values that specify options.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static IEnumerable<string> EnumerateSplit(this Regex regex, string input, SplitOptions splitOptions)
    {
        return RegexSplit.EnumerateValues(regex, input, splitOptions);
    }

    /// <summary>
    /// Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to split.</param>
    /// <param name="count">The maximum number of times the input can be split.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="count"/> is less than zero.</exception>
    public static IEnumerable<string> EnumerateSplit(this Regex regex, string input, int count)
    {
        return RegexSplit.EnumerateValues(regex, input, count);
    }

    /// <summary>
    /// Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings, using the specified split options.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to split.</param>
    /// <param name="count">The maximum number of times the input can be split.</param>
    /// <param name="splitOptions">A bitwise combination of the enumeration values that specify options.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="count"/> is less than zero.</exception>
    public static IEnumerable<string> EnumerateSplit(this Regex regex, string input, int count, SplitOptions splitOptions)
    {
        return RegexSplit.EnumerateValues(regex, input, count, splitOptions);
    }

    /// <summary>
    /// Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings.
    /// The search starts at a specified position in the input string.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to split.</param>
    /// <param name="count">The maximum number of times the input can be split.</param>
    /// <param name="startAt">The position in the input string where the search starts.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="count"/> is less than zero.
    /// <para><paramref name="startAt"/> is less than zero or greater than the length of <paramref name="input"/>.</para>
    /// </exception>
    public static IEnumerable<string> EnumerateSplit(this Regex regex, string input, int count, int startAt)
    {
        return RegexSplit.EnumerateValues(regex, input, count, startAt);
    }

    /// <summary>
    /// Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings, using the specified split options.
    /// The search starts at a specified position in the input string.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to split.</param>
    /// <param name="count">The maximum number of times the input can be split.</param>
    /// <param name="startAt">The position in the input string where the search starts.</param>
    /// <param name="splitOptions">A bitwise combination of the enumeration values that specify options.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="count"/> is less than zero.
    /// <para><paramref name="startAt"/> is less than zero or greater than the length of <paramref name="input"/>.</para>
    /// </exception>
    public static IEnumerable<string> EnumerateSplit(this Regex regex, string input, int count, int startAt, SplitOptions splitOptions)
    {
        return RegexSplit.EnumerateValues(regex, input, count, startAt, splitOptions);
    }

    /// <summary>
    /// Searches the specified input string for occurrence of the specified regular expression and returns an enumerable collection of matches indexes.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static IEnumerable<int> EnumerateIndexes(this Regex regex, string input)
    {
        if (regex is null)
            throw new ArgumentNullException(nameof(regex));

        return EnumerateIndexes();

        IEnumerable<int> EnumerateIndexes()
        {
            foreach (Match match in regex.EnumerateMatches(input))
                yield return match.Index;
        }
    }

    /// <summary>
    /// Searches the specified input string for occurrence of the specified regular expression and returns an enumerable collection of matches lengths.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static IEnumerable<int> EnumerateLengths(this Regex regex, string input)
    {
        if (regex is null)
            throw new ArgumentNullException(nameof(regex));

        return EnumerateLengths();

        IEnumerable<int> EnumerateLengths()
        {
            foreach (Match match in regex.EnumerateMatches(input))
                yield return match.Length;
        }
    }

    /// <summary>
    /// Searches the specified input string for occurrence of the specified regular expression and returns an enumerable collection of matches values.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static IEnumerable<string> EnumerateValues(this Regex regex, string input)
    {
        if (regex is null)
            throw new ArgumentNullException(nameof(regex));

        return EnumerateValues();

        IEnumerable<string> EnumerateValues()
        {
            foreach (Match match in regex.EnumerateMatches(input))
                yield return match.Value;
        }
    }
}
