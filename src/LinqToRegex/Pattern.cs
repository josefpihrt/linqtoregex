// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Pihrtsoft.Text.RegularExpressions.Linq.Extensions;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Represents an immutable regular expression pattern. This class is abstract.
    /// </summary>
    public abstract partial class Pattern
    {
        private string _value;

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
        /// <returns></returns>
        public Pattern AppendIf(bool condition, object content)
        {
            return condition
                ? Append(content)
                : this;
        }

        /// <summary>
        /// Appends a pattern that matches a specified content.
        /// </summary>
        /// <param name="content">The content to be matched.</param>
        /// <returns></returns>
        public Pattern Append(object content)
        {
            return AppendInternal(new ContentPattern(content));
        }

        /// <summary>
        /// Appends a pattern that matches a specified text.
        /// </summary>
        /// <param name="value">A text to append.</param>
        /// <returns></returns>
        public Pattern Text(string value)
        {
            return AppendInternal(Patterns.Text(value));
        }

        /// <summary>
        /// Appends a pattern that matches a specified text, ignoring or honoring its case.
        /// </summary>
        /// <param name="value">A text to append.</param>
        /// <param name="ignoreCase">true to ignore case during the matching; otherwise, false.</param>
        /// <returns></returns>
        public QuantifiablePattern Text(string value, bool ignoreCase)
        {
            return AppendInternal(Patterns.Text(value, ignoreCase));
        }

        internal TPattern AppendInternal<TPattern>(TPattern pattern) where TPattern : Pattern
        {
            if (pattern == null)
            {
                throw new ArgumentNullException(nameof(pattern));
            }

            Pattern first = pattern;
            while (first.Previous != null)
            {
                first = first.Previous;
            }
            first.Previous = this;

            return pattern;
        }

        /// <summary>
        /// Compiles a new instance of the <see cref="Regex"/> class for the current instance.
        /// </summary>
        /// <returns></returns>
        public Regex ToRegex()
        {
            return ToRegex(RegexOptions.None);
        }

        /// <summary>
        /// Compiles a new instance of the <see cref="Regex"/> class for the current instance, with options that modify the pattern.
        /// </summary>
        /// <param name="options">A bitwise combination of the enumeration values that modify the regular expression.</param>
        /// <returns></returns>
        public Regex ToRegex(RegexOptions options)
        {
            return new Regex(ToString(), options);
        }

        /// <summary>
        /// Constructs a pattern text that represents the current instance.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ToString(PatternOptions.None);
        }

        /// <summary>
        /// Constructs a pattern text that represents the current instance. with regex options that modify the pattern.
        /// </summary>
        /// <param name="options">A bitwise combination of the enumeration values that modify the pattern.</param>
        /// <returns></returns>
        internal string ToString(RegexOptions options)
        {
            return ToString(new PatternSettings(), options);
        }

        /// <summary>
        /// Constructs a pattern text that represents the current instance. with options that modify the pattern.
        /// </summary>
        /// <param name="options">A bitwise combination of the enumeration values that modify the pattern.</param>
        /// <returns></returns>
        public string ToString(PatternOptions options)
        {
            return ToString(new PatternSettings(options));
        }

        /// <summary>
        /// Constructs a pattern text that represents the current instance. with settings that modify the pattern.
        /// </summary>
        /// <param name="settings">A settings that modify the pattern.</param>
        /// <returns></returns>
        public string ToString(PatternSettings settings)
        {
            return ToString(settings, RegexOptions.None);
        }

        internal string ToString(PatternSettings settings, RegexOptions options)
        {
            var builder = new PatternBuilder(settings, options);
            builder.Append(this);
            return builder.ToString();
        }

        /// <summary>
        /// Searches the specified input string for all matches.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public MatchCollection Matches(string input)
        {
            return Regex.Matches(input, Value);
        }

        /// <summary>
        /// Searches the specified input string for all matches, using the specified matching options.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public MatchCollection Matches(string input, RegexOptions options)
        {
            return Regex.Matches(input, ToString(options), options);
        }

        /// <summary>
        /// Searches the specified input string and returns an enumerable collection of matches.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<Match> EnumerateMatches(string input)
        {
            return EnumerateMatches(input, RegexOptions.None);
        }

        /// <summary>
        /// Searches the specified input string and returns an enumerable collection of matches, using the specified matching options.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
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
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<Group> EnumerateGroups(string input)
        {
            return EnumerateGroups(input, RegexOptions.None);
        }

        /// <summary>
        /// Searches the specified input string and returns an enumerable collection of groups, using the specified matching options.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<Group> EnumerateGroups(string input, RegexOptions options)
        {
            return EnumerateMatches(input, options).EnumerateGroups();
        }

        /// <summary>
        /// Searches the specified input string and returns an enumerable collection of groups with a specified name.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
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
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<Group> EnumerateGroups(string input, string groupName, RegexOptions options)
        {
            return EnumerateMatches(input, options).EnumerateGroups(groupName);
        }

        /// <summary>
        /// Searches the specified input string and returns an enumerable collection of groups with a specified number.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="groupNumber">A valid number of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
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
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public IEnumerable<Group> EnumerateGroups(string input, int groupNumber, RegexOptions options)
        {
            return EnumerateMatches(input, options).EnumerateGroups(groupNumber);
        }

        /// <summary>
        /// Searches the specified input string and returns an enumerable collection of groups that contain at least one capture.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<Group> EnumerateSuccessGroups(string input)
        {
            return EnumerateSuccessGroups(input, RegexOptions.None);
        }

        /// <summary>
        /// Searches the specified input string and returns an enumerable collection of groups that contain at least one capture, using the specified matching options.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<Group> EnumerateSuccessGroups(string input, RegexOptions options)
        {
            return EnumerateMatches(input, options).EnumerateSuccessGroups();
        }

        /// <summary>
        /// Searches the specified input string and returns an enumerable collection of groups that have a specified name and contain at least one capture.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
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
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<Group> EnumerateSuccessGroups(string input, string groupName, RegexOptions options)
        {
            return EnumerateMatches(input, options).EnumerateSuccessGroups(groupName);
        }

        /// <summary>
        /// Searches the specified input string and returns an enumerable collection of groups that have a specified number and contain at least one capture.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="groupNumber">A valid number of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
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
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public IEnumerable<Group> EnumerateSuccessGroups(string input, int groupNumber, RegexOptions options)
        {
            return EnumerateMatches(input, options).EnumerateSuccessGroups(groupNumber);
        }

        /// <summary>
        /// Searches the specified input string and returns an enumerable collection of captures.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<Capture> EnumerateCaptures(string input)
        {
            return EnumerateCaptures(input, RegexOptions.None);
        }

        /// <summary>
        /// Searches the specified input string and returns an enumerable collection of captures, using the specified matching options.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<Capture> EnumerateCaptures(string input, RegexOptions options)
        {
            return EnumerateMatches(input, options).EnumerateCaptures();
        }

        /// <summary>
        /// Searches the specified input string and returns an enumerable collection of captures from groups that have a specified name.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="groupName">A name of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
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
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<Capture> EnumerateCaptures(string input, string groupName, RegexOptions options)
        {
            return EnumerateMatches(input, options).EnumerateCaptures(groupName);
        }

        /// <summary>
        /// Searches the specified input string and returns an enumerable collection of captures from groups that have a specified number.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="groupNumber">A valid number of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
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
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public IEnumerable<Capture> EnumerateCaptures(string input, int groupNumber, RegexOptions options)
        {
            return EnumerateMatches(input, options).EnumerateCaptures(groupNumber);
        }

        /// <summary>
        /// Indicates whether the current instance finds a match in the specified input string.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool IsMatch(string input)
        {
            return Regex.IsMatch(input, Value);
        }

        /// <summary>
        /// Indicates whether the current instance finds a match in the specified input string, using the specified matching options.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool IsMatch(string input, RegexOptions options)
        {
            return Regex.IsMatch(input, ToString(options), options);
        }

        /// <summary>
        /// Searches a specified input string for the first occurrence of the current instance.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Match Match(string input)
        {
            return Regex.Match(input, Value);
        }

        /// <summary>
        /// Searches a specified input string for the first occurrence of the current instance, using the specified matching options.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Match Match(string input, RegexOptions options)
        {
            return Regex.Match(input, ToString(options), options);
        }

        /// <summary>
        /// Within a specified input string, replaces strings that match the current instance with an empty string.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public string Replace(string input)
        {
            return Replace(input, string.Empty);
        }

        /// <summary>
        /// Within a specified input string, replaces all strings that match the current instance with a string returned by a <see cref="MatchEvaluator"/> delegate.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="evaluator">A method that examines each match and returns a replacement string.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public string Replace(string input, MatchEvaluator evaluator)
        {
            return Regex.Replace(input, Value, evaluator);
        }

#if DEBUG
        public string ReplaceCapture(string input, string groupName, CaptureEvaluator evaluator)
        {
            return ReplaceCapture(input, groupName, evaluator, RegexOptions.None);
        }

        public string ReplaceCapture(string input, string groupName, CaptureEvaluator evaluator, RegexOptions options)
        {
            return ReplaceCapture(input, evaluator, EnumerateCaptures(input, groupName).OrderBy(c => c.Index));
        }

        public string ReplaceCapture(string input, int groupNumber, CaptureEvaluator evaluator)
        {
            return ReplaceCapture(input, groupNumber, evaluator, RegexOptions.None);
        }

        public string ReplaceCapture(string input, int groupNumber, CaptureEvaluator evaluator, RegexOptions options)
        {
            return ReplaceCapture(input, evaluator, EnumerateCaptures(input, groupNumber).OrderBy(c => c.Index));
        }

        private static string ReplaceCapture(string input, CaptureEvaluator evaluator, IEnumerable<Capture> captures)
        {
            var sb = new StringBuilder();
            int index = 0;

            foreach (Capture capture in captures)
            {
                sb.Append(input, index, capture.Index - index);
                sb.Append(evaluator(capture));
                index = capture.Index + capture.Length;
            }

            sb.Append(input, index, input.Length - index);

            return sb.ToString();
        }
#endif

        /// <summary>
        /// Within a specified input string, replaces all strings that match the current instance with a string returned by a <see cref="MatchEvaluator"/> delegate. Specified options modify the matching operation.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="evaluator">A method that examines each match and returns a replacement string.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public string Replace(string input, MatchEvaluator evaluator, RegexOptions options)
        {
            return Regex.Replace(input, ToString(options), evaluator, options);
        }

        /// <summary>
        /// Within a specified input string, replaces all strings that match the current instance with a specified replacement string.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="replacement">The replacement string.</param>
        /// <returns></returns>
        public string Replace(string input, string replacement)
        {
            return Regex.Replace(input, Value, replacement);
        }

        /// <summary>
        /// Within a specified input string, replaces all strings that match the current instance with a specified replacement string. Specified options modify the matching operation.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="replacement">The replacement string.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <returns></returns>
        public string Replace(string input, string replacement, RegexOptions options)
        {
            return Regex.Replace(input, ToString(options), replacement, options);
        }

        /// <summary>
        /// Splits the specified input string at the positions defined by the current instance.
        /// </summary>
        /// <param name="input">The string to split.</param>
        /// <returns></returns>
        public string[] Split(string input)
        {
            return Regex.Split(input, Value);
        }

        /// <summary>
        /// Splits the specified input string at the positions defined by the current instance, using the specified matching options.
        /// </summary>
        /// <param name="input">The string to split.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <returns></returns>
        public string[] Split(string input, RegexOptions options)
        {
            return Regex.Split(input, ToString(options), options);
        }

        /// <summary>
        /// Concatenate two elements into a new <see cref="Pattern"/>.
        /// </summary>
        /// <param name="left">The first element to concatenate.</param>
        /// <param name="right">The second element to concatenate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Pattern operator +(Pattern left, Pattern right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(nameof(left));
            }

            if (right == null)
            {
                throw new ArgumentNullException(nameof(right));
            }

            return left.Append(right);
        }

        /// <summary>
        /// Concatenate two elements into a new <see cref="Pattern"/>.
        /// </summary>
        /// <param name="left">The first element to concatenate.</param>
        /// <param name="right">The second element to concatenate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Pattern operator +(Pattern left, string right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(nameof(left));
            }

            if (right == null)
            {
                throw new ArgumentNullException(nameof(right));
            }

            return left.Text(right);
        }

        /// <summary>
        /// Concatenate two elements into a new <see cref="Pattern"/>.
        /// </summary>
        /// <param name="left">The first element to concatenate.</param>
        /// <param name="right">The second element to concatenate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Pattern operator +(string left, Pattern right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(nameof(left));
            }

            if (right == null)
            {
                throw new ArgumentNullException(nameof(right));
            }

            return Patterns.Text(left).Append(right);
        }

        /// <summary>
        /// Concatenate two elements into a new <see cref="Pattern"/>.
        /// </summary>
        /// <param name="left">The first element to concatenate.</param>
        /// <param name="right">The second element to concatenate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Pattern operator +(Pattern left, char right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(nameof(left));
            }

            return left.Append(Patterns.Character(right));
        }

        /// <summary>
        /// Concatenate two elements into a new <see cref="Pattern"/>.
        /// </summary>
        /// <param name="left">The first element to concatenate.</param>
        /// <param name="right">The second element to concatenate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Pattern operator +(char left, Pattern right)
        {
            if (right == null)
            {
                throw new ArgumentNullException(nameof(right));
            }

            return Patterns.Character(left).Append(right);
        }

        /// <summary>
        /// Creates a pattern that matches any one of the specified elements.
        /// </summary>
        /// <param name="left">The first element to match.</param>
        /// <param name="right">The second element to match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static QuantifiablePattern operator |(Pattern left, Pattern right)
        {
            return Patterns.Or(left, right);
        }

        /// <summary>
        /// Creates a pattern that matches any one of the specified elements.
        /// </summary>
        /// <param name="left">The first element to match.</param>
        /// <param name="right">The second element to match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static QuantifiablePattern operator |(Pattern left, string right)
        {
            return Patterns.Or(left, right);
        }

        /// <summary>
        /// Creates a pattern that matches any one of the specified elements.
        /// </summary>
        /// <param name="left">The first element to match.</param>
        /// <param name="right">The second element to match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static QuantifiablePattern operator |(string left, Pattern right)
        {
            return Patterns.Or(left, right);
        }

        /// <summary>
        /// Creates a pattern that matches any one of the specified elements.
        /// </summary>
        /// <param name="left">The first element to match.</param>
        /// <param name="right">The second element to match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static QuantifiablePattern operator |(Pattern left, CharGrouping right)
        {
            return Patterns.Or(left, right);
        }

        /// <summary>
        /// Creates a pattern that matches any one of the specified elements.
        /// </summary>
        /// <param name="left">The first element to match.</param>
        /// <param name="right">The second element to match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static QuantifiablePattern operator |(CharGrouping left, Pattern right)
        {
            return Patterns.Or(left, right);
        }

        /// <summary>
        /// Creates a pattern that matches any one of the specified elements.
        /// </summary>
        /// <param name="left">The first element to match.</param>
        /// <param name="right">The second element to match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static QuantifiablePattern operator |(Pattern left, char right)
        {
            return Patterns.Or(left, right.ToString());
        }

        /// <summary>
        /// Creates a pattern that matches any one of the specified elements.
        /// </summary>
        /// <param name="left">The first element to match.</param>
        /// <param name="right">The second element to match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static QuantifiablePattern operator |(char left, Pattern right)
        {
            return Patterns.Or(left.ToString(), right);
        }

        /// <summary>
        /// Converts specified text to a pattern.
        /// </summary>
        /// <param name="text">A text to convert.</param>
        /// <returns></returns>
        public static explicit operator Pattern(string text) => new TextPattern(text);

        /// <summary>
        /// Converts specified character to a pattern.
        /// </summary>
        /// <param name="value">The Unicode character to convert.</param>
        /// <returns></returns>
        public static explicit operator Pattern(char value) => CharPattern.Create(value);

        private string Value
        {
            get
            {
                if (_value == null)
                {
                    _value = ToString();
                }

                return _value;
            }
        }

        internal Pattern Previous { get; set; }
    }
}