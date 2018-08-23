// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Provides static methods for obtaining substitutions for a replacement pattern.
    /// </summary>
    public static class Substitutions
    {
        /// <summary>
        /// Returns a substitution pattern with a specified text.
        /// </summary>
        /// <param name="value">A content of the substitution pattern.</param>
        public static Substitution Text(string value) => new TextSubstitution(value);

        /// <summary>
        /// Returns a substitution pattern with a specified character.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        public static Substitution Text(char value) => new CharSubstitution(value);

        /// <summary>
        /// Returns a substitution pattern that substitutes the last substring matched by the numbered or named group.
        /// </summary>
        /// <param name="groupNumber">A number of the group.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="groupNumber"/> is less than zero.</exception>
        public static Substitution Group(int groupNumber) => new NumberedGroupSubstitution(groupNumber);

        /// <summary>
        /// Returns a substitution pattern that substitutes the last substring matched by the named group.
        /// </summary>
        /// <param name="groupName">Valid regex group name.</param>
        /// <exception cref="ArgumentNullException"><paramref name="groupName"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException"><paramref name="groupName"/> is not a valid regex group name.</exception>
        public static Substitution NamedGroup(string groupName) => new NamedGroupSubstitution(groupName);

        /// <summary>
        /// Returns a substitution pattern that substitutes the last captured group.
        /// </summary>
        public static Substitution LastCapturedGroup() => new LastCapturedGroupSubstitution();

        /// <summary>
        /// Returns a substitution pattern that substitutes the entire input string.
        /// </summary>
        public static Substitution EntireInput() => new EntireInputSubstitution();

        /// <summary>
        /// Returns a substitution pattern that substitutes the entire match.
        /// </summary>
        public static Substitution EntireMatch() => new EntireMatchSubstitution();

        /// <summary>
        /// Returns a substitution pattern that substitutes all the text of the input string after the match.
        /// </summary>
        public static Substitution AfterMatch() => new AfterMatchSubstitution();

        /// <summary>
        /// Returns a substitution pattern that substitutes all the text of the input string before the match.
        /// </summary>
        public static Substitution BeforeMatch() => new BeforeMatchSubstitution();
    }
}
