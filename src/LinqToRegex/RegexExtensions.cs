// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions;

/// <summary>
/// Provides a set of static methods that extends the <see cref="Regex"/> class.
/// </summary>
public static class RegexExtensions
{
    #region Regex Extensions
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
    /// Within a specified input string, replaces all groups with the specified name that match the regular expression with a string where each character is replaced with the specified character.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="evaluator">The delegate to be executed on each group.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static string ReplaceGroups(this Regex regex, string input, GroupEvaluator evaluator, string groupName)
    {
        int groupNumber = regex.GroupNumberFromName(groupName);

        if (groupNumber == -1)
            throw new ArgumentException("Group name does not exist.", nameof(groupName));

        return ReplaceGroups(regex, input, evaluator, groupNumber);
    }

    /// <summary>
    /// Within a specified input string, replaces all groups with the specified number that match the regular expression with a string where each character is replaced with the specified character.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="evaluator">The delegate to be executed on each group.</param>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static string ReplaceGroups(this Regex regex, string input, GroupEvaluator evaluator, int groupNumber)
    {
        if (regex is null)
            throw new ArgumentNullException(nameof(regex));

        if (input is null)
            throw new ArgumentNullException(nameof(input));

        if (evaluator is null)
            throw new ArgumentNullException(nameof(evaluator));

        var sb = new StringBuilder();

        if (regex.RightToLeft)
        {
            int index = sb.Length - 1;

            Match match = regex.Match(input);
            while (match.Success)
            {
                Group group = match.Groups[groupNumber];
                if (group.Success)
                {
                    int endIndex = group.Index + group.Length;

                    for (int i = index; i >= endIndex; i--)
                        sb.Append(input[i]);

                    string replacement = evaluator(group);

                    for (int i = replacement.Length - 1; i >= 0; i--)
                        sb.Append(replacement[i]);

                    index = group.Index - 1;
                }

                match = match.NextMatch();
            }

            sb.Append(input, 0, index);

            char tmp;
            int start = 0;
            int end = sb.Length - 1;

            while (end - start > 0)
            {
                tmp = sb[end];
                sb[end] = sb[start];
                sb[start] = tmp;
                start++;
                end--;
            }
        }
        else
        {
            int index = 0;

            Match match = regex.Match(input);
            while (match.Success)
            {
                foreach (Group group in match.Groups)
                {
                    if (group.Success)
                    {
                        sb.Append(input, index, group.Index - index);
                        sb.Append(evaluator(group));
                        index = group.Index + group.Length;
                    }
                }

                match = match.NextMatch();
            }

            sb.Append(input, index, input.Length - index);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Splits the specified input string at the positions defined by the regular expression into an enumerable collection of strings.
    /// </summary>
    /// <param name="regex">The regular expression to be matched.</param>
    /// <param name="input">The string to split.</param>
    /// <exception cref="ArgumentNullException"><paramref name="regex"/> or <paramref name="input"/> is <c>null</c>.</exception>
    public static IEnumerable<string> EnumerateSplit(this Regex regex, string input)
    {
        return EnumerateSplit(regex, input, SplitOptions.None);
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
        return EnumerateSplit(regex, input, 0, splitOptions);
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
        return EnumerateSplit(regex, input, count, SplitOptions.None);
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
        return EnumerateSplit(regex, input, count, (regex.RightToLeft) ? input.Length : 0, splitOptions);
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
        return EnumerateSplit(regex, input, count, startAt, SplitOptions.None);
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
        if (regex is null)
            throw new ArgumentNullException(nameof(regex));

        if (input is null)
            throw new ArgumentNullException(nameof(input));

        if (count < 0)
            throw new ArgumentOutOfRangeException(nameof(count));

        if (startAt < 0 || startAt > input.Length)
            throw new ArgumentOutOfRangeException(nameof(startAt));

        return EnumerateSplit();

        IEnumerable<string> EnumerateSplit()
        {
            if (count == 1)
            {
                yield return input;
                yield break;
            }

            Match firstMatch = regex.Match(input, startAt);

            if (!firstMatch.Success)
            {
                yield return input;
                yield break;
            }

            bool omitGroupValues = (splitOptions & SplitOptions.OmitGroupValues) != 0;
            bool omitEmptyValues = (splitOptions & SplitOptions.OmitEmptyValues) != 0;
            int prevIndex = 0;

            count--;

            foreach (Match match in (regex.RightToLeft) ? EnumerateMatchesRightToLeft(firstMatch, count) : EnumerateMatches(firstMatch, count))
            {
                if (!omitEmptyValues || ((match.Index - prevIndex) > 0))
                    yield return input.Substring(prevIndex, match.Index - prevIndex);

                prevIndex = match.Index + match.Length;

                if (!omitGroupValues)
                {
                    foreach (Group group in (regex.RightToLeft) ? EnumerateGroupsRightToLeft(match) : EnumerateGroups(match))
                    {
                        if (group.Success && (!omitEmptyValues || group.Length > 0))
                            yield return group.Value;
                    }
                }
            }

            yield return input.Substring(prevIndex, input.Length - prevIndex);
        }

        static IEnumerable<Group> EnumerateGroups(Match match)
        {
            for (int i = 1; i < match.Groups.Count; i++)
                yield return match.Groups[i];
        }

        static IEnumerable<Group> EnumerateGroupsRightToLeft(Match match)
        {
            for (int i = match.Groups.Count - 1; i >= 1; i--)
                yield return match.Groups[i];
        }

        static IEnumerable<Match> EnumerateMatches(Match match, int count)
        {
            while (match.Success)
            {
                yield return match;

                count--;

                if (count == 0)
                    yield break;

                match = match.NextMatch();
            }
        }

        static IEnumerable<Match> EnumerateMatchesRightToLeft(Match match, int count)
        {
            var matches = new List<Match>();

            while (match.Success)
            {
                matches.Add(match);

                count--;

                if (count == 0)
                    break;

                match = match.NextMatch();
            }

            for (int i = matches.Count - 1; i >= 0; i--)
                yield return matches[i];
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
    #endregion Regex Extensions

    #region Match Extensions
    /// <summary>
    /// Returns a group that has a specified name and it is contained in a specified match.
    /// </summary>
    /// <param name="match">A regular expression match.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="match"/> is <c>null</c>.</exception>
    public static Group Group(this Match match, string groupName)
    {
        if (match is null)
            throw new ArgumentNullException(nameof(match));

        return match.Groups[groupName];
    }

    /// <summary>
    /// Returns a group that has a specified number and it is contained in a specified match.
    /// </summary>
    /// <param name="match">A regular expression match.</param>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="match"/> is <c>null</c>.</exception>
    public static Group Group(this Match match, int groupNumber)
    {
        if (match is null)
            throw new ArgumentNullException(nameof(match));

        return match.Groups[groupNumber];
    }

    /// <summary>
    /// Returns enumerable collection of group of a specified match.
    /// </summary>
    /// <param name="match">A regular expression match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="match"/> is <c>null</c>.</exception>
    public static IEnumerable<Group> EnumerateGroups(this Match match)
    {
        if (match is null)
            throw new ArgumentNullException(nameof(match));

        return EnumerateGroups();

        IEnumerable<Group> EnumerateGroups()
        {
            for (int i = 0; i < match.Groups.Count; i++)
                yield return match.Groups[i];
        }
    }

    /// <summary>
    /// Enumerates through groups of a specified match and returns each capture from each group.
    /// </summary>
    /// <param name="match">A regular expression match.</param>
    /// <exception cref="ArgumentNullException"><paramref name="match"/> is <c>null</c>.</exception>
    public static IEnumerable<Capture> EnumerateCaptures(this Match match)
    {
        if (match is null)
            throw new ArgumentNullException(nameof(match));

        return EnumerateCaptures();

        IEnumerable<Capture> EnumerateCaptures()
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
    /// Returns an enumerable collection of captures of a group with a specified name that is from a specified match.
    /// </summary>
    /// <param name="match">A regular expression match.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="match"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
    public static IEnumerable<Capture> EnumerateCaptures(this Match match, string groupName)
    {
        if (match is null)
            throw new ArgumentNullException(nameof(match));

        return EnumerateCaptures();

        IEnumerable<Capture> EnumerateCaptures()
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
    /// Returns an enumerable collection of captures of a group with a specified number that is from a specified match.
    /// </summary>
    /// <param name="match">A regular expression match.</param>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="match"/> is <c>null</c>.</exception>
    public static IEnumerable<Capture> EnumerateCaptures(this Match match, int groupNumber)
    {
        if (match is null)
            throw new ArgumentNullException(nameof(match));

        return EnumerateCaptures();

        IEnumerable<Capture> EnumerateCaptures()
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
    /// Returns an enumerable collection of groups.
    /// </summary>
    /// <param name="matches">The sequence to enumerate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="matches"/> is <c>null</c>.</exception>
    public static IEnumerable<Group> EnumerateGroups(this IEnumerable<Match> matches)
    {
        if (matches is null)
            throw new ArgumentNullException(nameof(matches));

        return EnumerateGroups();

        IEnumerable<Group> EnumerateGroups()
        {
            foreach (Match match in matches)
            {
                for (int i = 0; i < match.Groups.Count; i++)
                    yield return match.Groups[i];
            }
        }
    }

    /// <summary>
    /// Returns an enumerable collection of groups with a specified name.
    /// </summary>
    /// <param name="matches">The sequence to enumerate.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="matches"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
    public static IEnumerable<Group> EnumerateGroups(this IEnumerable<Match> matches, string groupName)
    {
        if (matches is null)
            throw new ArgumentNullException(nameof(matches));

        if (groupName is null)
            throw new ArgumentNullException(nameof(groupName));

        return EnumerateGroups();

        IEnumerable<Group> EnumerateGroups()
        {
            foreach (Match match in matches)
                yield return match.Groups[groupName];
        }
    }

    /// <summary>
    /// Returns an enumerable collection of groups with a specified number.
    /// </summary>
    /// <param name="matches">The sequence to enumerate.</param>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="matches"/> is <c>null</c>.</exception>
    public static IEnumerable<Group> EnumerateGroups(this IEnumerable<Match> matches, int groupNumber)
    {
        if (matches is null)
            throw new ArgumentNullException(nameof(matches));

        return EnumerateGroups();

        IEnumerable<Group> EnumerateGroups()
        {
            foreach (Match match in matches)
                yield return match.Groups[groupNumber];
        }
    }

    /// <summary>
    /// Returns an enumerable collection of groups that have at least one capture.
    /// </summary>
    /// <param name="matches">The sequence to enumerate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="matches"/> is <c>null</c>.</exception>
    public static IEnumerable<Group> EnumerateSuccessGroups(this IEnumerable<Match> matches)
    {
        foreach (Match match in matches)
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
    /// Returns an enumerable collection of groups thas have a specified name and have at least one capture.
    /// </summary>
    /// <param name="matches">The sequence to enumerate.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="matches"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
    public static IEnumerable<Group> EnumerateSuccessGroups(this IEnumerable<Match> matches, string groupName)
    {
        foreach (Match match in matches)
        {
            Group group = match.Groups[groupName];

            if (group.Success)
                yield return group;
        }
    }

    /// <summary>
    /// Returns an enumerable collection of groups that have a specified name and have at least one capture.
    /// </summary>
    /// <param name="matches">The sequence to enumerate.</param>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="matches"/> is <c>null</c>.</exception>
    public static IEnumerable<Group> EnumerateSuccessGroups(this IEnumerable<Match> matches, int groupNumber)
    {
        foreach (Match match in matches)
        {
            Group group = match.Groups[groupNumber];

            if (group.Success)
                yield return group;
        }
    }

    /// <summary>
    /// Returns an enumerable collection of captures.
    /// </summary>
    /// <param name="matches">The sequence to enumerate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="matches"/> is <c>null</c>.</exception>
    public static IEnumerable<Capture> EnumerateCaptures(this IEnumerable<Match> matches)
    {
        foreach (Match match in matches)
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
    /// Returns an enumerable collection of captures from groups thas have a specified name.
    /// </summary>
    /// <param name="matches">The sequence to enumerate.</param>
    /// <param name="groupName">A name of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="matches"/> or <paramref name="groupName"/> is <c>null</c>.</exception>
    public static IEnumerable<Capture> EnumerateCaptures(this IEnumerable<Match> matches, string groupName)
    {
        foreach (Match match in matches)
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
    /// Returns an enumerable collection of captures from groups that have a specified number.
    /// </summary>
    /// <param name="matches">The sequence to enumerate.</param>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="matches"/> is <c>null</c>.</exception>
    public static IEnumerable<Capture> EnumerateCaptures(this IEnumerable<Match> matches, int groupNumber)
    {
        foreach (Match match in matches)
        {
            Group group = match.Groups[groupNumber];
            if (group.Success)
            {
                for (int i = 0; i < group.Captures.Count; i++)
                    yield return group.Captures[i];
            }
        }
    }
    #endregion Match Extensions

    #region GroupExtensions
    /// <summary>
    /// Returns enumerable collection of captures of a specified group.
    /// </summary>
    /// <param name="group">A regular expression group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="group"/> is <c>null</c>.</exception>
    public static IEnumerable<Capture> EnumerateCaptures(this Group group)
    {
        if (group is null)
            throw new ArgumentNullException(nameof(group));

        return EnumerateCaptures();

        IEnumerable<Capture> EnumerateCaptures()
        {
            for (int i = 0; i < group.Captures.Count; i++)
                yield return group.Captures[i];
        }
    }

    /// <summary>
    /// Returns an enumerable collection of captures.
    /// </summary>
    /// <param name="groups">The sequence to enumerate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="groups"/> is <c>null</c>.</exception>
    public static IEnumerable<Capture> EnumerateCaptures(this IEnumerable<Group> groups)
    {
        if (groups is null)
            throw new ArgumentNullException(nameof(groups));

        return EnumerateCaptures();

        IEnumerable<Capture> EnumerateCaptures()
        {
            foreach (Group group in groups)
            {
                for (int i = 0; i < group.Captures.Count; i++)
                    yield return group.Captures[i];
            }
        }
    }
    #endregion GroupExtensions

    #region Capture Extensions
    /// <summary>
    /// Returns a sum of index and length of a specified <paramref name="capture"/>.
    /// </summary>
    /// <param name="capture">A regular expression capture.</param>
    /// <exception cref="ArgumentNullException"><paramref name="capture"/> is <c>null</c>.</exception>
    public static int EndIndex(this Capture capture)
    {
        if (capture is null)
            throw new ArgumentNullException(nameof(capture));

        return capture.Index + capture.Length;
    }

    /// <summary>
    /// Returns enumerable collection of captures values.
    /// </summary>
    /// <param name="captures">The sequence to enumerate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="captures"/> is <c>null</c>.</exception>
    public static IEnumerable<string> EnumerateValues(this IEnumerable<Capture> captures)
    {
        if (captures is null)
            throw new ArgumentNullException(nameof(captures));

        return EnumerateValues();

        IEnumerable<string> EnumerateValues()
        {
            foreach (Capture capture in captures)
                yield return capture.Value;
        }
    }
    #endregion Capture Extensions

    #region RegexOptions Extensions
    internal static bool IsNone(this RegexOptions options) => options == RegexOptions.None;

    internal static bool HasIgnoreCase(this RegexOptions options) => (options & RegexOptions.IgnoreCase) != 0;

    internal static bool HasMultiline(this RegexOptions options) => (options & RegexOptions.Multiline) != 0;

    internal static bool HasExplicitCapture(this RegexOptions options) => (options & RegexOptions.ExplicitCapture) != 0;

    internal static bool HasSingleline(this RegexOptions options) => (options & RegexOptions.Singleline) != 0;

    internal static bool HasIgnorePatternWhitespace(this RegexOptions options) => (options & RegexOptions.IgnorePatternWhitespace) != 0;
    #endregion RegexOptions Extensions
}
