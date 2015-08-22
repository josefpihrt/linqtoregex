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
        /// <returns></returns>
        public static Substitution Text(string value) => new TextSubstitution(value);

        /// <summary>
        /// Returns a substitution pattern that substitutes the last substring matched by the numbered or named group.
        /// </summary>
        /// <param name="groupNumber">A number of the group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Substitution Group(int groupNumber) => new NumberedGroupSubstitution(groupNumber);

        /// <summary>
        /// Returns a substitution pattern that substitutes the last substring matched by the named group.
        /// </summary>
        /// <param name="groupName">Valid regex group name.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static Substitution NamedGroup(string groupName) => new NamedGroupSubstitution(groupName);

        /// <summary>
        /// Returns a substitution pattern that substitutes the last captured group.
        /// </summary>
        /// <returns></returns>
        public static Substitution LastCapturedGroup() => new LastCapturedGroupSubstitution();

        /// <summary>
        /// Returns a substitution pattern that substitutes the entire input string.
        /// </summary>
        /// <returns></returns>
        public static Substitution EntireInput() => new EntireInputSubstitution();

        /// <summary>
        /// Returns a substitution pattern that substitutes the entire match.
        /// </summary>
        /// <returns></returns>
        public static Substitution EntireMatch() => new EntireMatchSubstitution();

        /// <summary>
        /// Returns a substitution pattern that substitutes all the text of the input string after the match.
        /// </summary>
        /// <returns></returns>
        public static Substitution AfterMatch() => new AfterMatchSubstitution();

        /// <summary>
        /// Returns a substitution pattern that substitutes all the text of the input string before the match.
        /// </summary>
        /// <returns></returns>
        public static Substitution BeforeMatch() => new BeforeMatchSubstitution();
    }
}
