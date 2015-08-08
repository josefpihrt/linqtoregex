// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Represents a base class for a substitution in the replacement pattern. This class is abstract.
    /// </summary>
    public abstract partial class Substitution
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Substitution"/> class.
        /// </summary>
        protected Substitution()
        {
        }

        /// <summary>
        /// Creates and returns a new instance of the <see cref="Substitution"/> class.
        /// </summary>
        /// <param name="value">A content of the substitution pattern.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        internal static Substitution Create(string value) => new TextSubstitution(value);

        internal Substitution Append(Substitution substitution)
        {
            substitution.Previous = this;
            return substitution;
        }

        /// <summary>
        /// Converts the value of this instance to a <see cref="string"/>.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Previous != null)
            {
                var sb = new StringBuilder();
                var stack = new Stack<Substitution>();

                Substitution item = this;
                do
                {
                    stack.Push(item);
                    item = item.Previous;
                } while (item != null);

                while (stack.Count > 0)
                {
                    sb.Append(stack.Pop().Value);
                }

                return sb.ToString();
            }
            else
            {
                return Value;
            }
        }

        /// <summary>
        /// Appends a substitution pattern that substitutes the last substring matched by the named group.
        /// </summary>
        /// <param name="groupName">Valid regex group name.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Substitution NamedGroup(string groupName) => Append(Substitutions.NamedGroup(groupName));

        /// <summary>
        /// Appends a substitution pattern that substitutes the last captured group.
        /// </summary>
        /// <returns></returns>
        public Substitution LastCapturedGroup() => Append(Substitutions.LastCapturedGroup());

        /// <summary>
        /// Appends a substitution pattern that substitutes the entire input string.
        /// </summary>
        /// <returns></returns>
        public Substitution EntireInput() => Append(Substitutions.EntireInput());

        /// <summary>
        /// Appends a substitution pattern that substitutes the entire match.
        /// </summary>
        /// <returns></returns>
        public Substitution EntireMatch() => Append(Substitutions.EntireMatch());

        /// <summary>
        /// Appends a substitution pattern that substitutes all the text of the input string after the match.
        /// </summary>
        /// <returns></returns>
        public Substitution AfterMatch() => Append(Substitutions.AfterMatch());

        /// <summary>
        /// Appends a substitution pattern that substitutes all the text of the input string before the match.
        /// </summary>
        /// <returns></returns>
        public Substitution BeforeMatch() => Append(Substitutions.BeforeMatch());

        /// <summary>
        /// Appends a specified text to the substitution pattern.
        /// </summary>
        /// <param name="value">A text to append.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Substitution Text(string value) => Append(Create(value));

        internal virtual string Value => null;

        internal Substitution Previous { get; set; }
    }
}