// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

/// <summary>
/// Represents a base class for a substitution in the replacement pattern. This class is abstract.
/// </summary>
[DebuggerDisplay("{DebuggerDisplay,nq}")]
public abstract class Substitution
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Substitution"/> class.
    /// </summary>
    protected Substitution()
    {
    }

    internal Substitution Append(Substitution substitution)
    {
        substitution.Previous = this;
        return substitution;
    }

    /// <summary>
    /// Converts the value of this instance to a <see cref="string"/>.
    /// </summary>
    public override string ToString()
    {
        if (Previous is not null)
        {
            var sb = new StringBuilder();
            var stack = new Stack<Substitution>();

            var item = this;
            do
            {
                stack.Push(item);
                item = item.Previous;
            }
            while (item is not null);

            while (stack.Count > 0)
                stack.Pop().AppendTo(sb);

            return sb.ToString();
        }
        else
        {
            return Value;
        }
    }

    internal virtual void AppendTo(StringBuilder builder) => builder.Append(Value);

    /// <summary>
    /// Appends a substitution pattern that substitutes the last substring matched by the numbered or named group.
    /// </summary>
    /// <param name="groupNumber">A number of the group.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="groupNumber"/> is less than zero.</exception>
    public Substitution Group(int groupNumber) => Append(SubstitutionFactory.Group(groupNumber));

    /// <summary>
    /// Appends a substitution pattern that substitutes the last substring matched by the named group.
    /// </summary>
    /// <param name="groupName">Valid regex group name.</param>
    /// <exception cref="ArgumentNullException"><paramref name="groupName"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="groupName"/> is not a valid regex group name.</exception>
    public Substitution NamedGroup(string groupName) => Append(SubstitutionFactory.NamedGroup(groupName));

    /// <summary>
    /// Appends a substitution pattern that substitutes the last captured group.
    /// </summary>
    public Substitution LastCapturedGroup() => Append(SubstitutionFactory.LastCapturedGroup());

    /// <summary>
    /// Appends a substitution pattern that substitutes the entire input string.
    /// </summary>
    public Substitution EntireInput() => Append(SubstitutionFactory.EntireInput());

    /// <summary>
    /// Appends a substitution pattern that substitutes the entire match.
    /// </summary>
    public Substitution EntireMatch() => Append(SubstitutionFactory.EntireMatch());

    /// <summary>
    /// Appends a substitution pattern that substitutes all the text of the input string after the match.
    /// </summary>
    public Substitution AfterMatch() => Append(SubstitutionFactory.AfterMatch());

    /// <summary>
    /// Appends a substitution pattern that substitutes all the text of the input string before the match.
    /// </summary>
    public Substitution BeforeMatch() => Append(SubstitutionFactory.BeforeMatch());

    /// <summary>
    /// Appends a specified text to the substitution pattern.
    /// </summary>
    /// <param name="value">A text to append.</param>
    public Substitution Text(string value) => Append(SubstitutionFactory.Text(value));

    /// <summary>
    /// Appends a specified character to the substitution pattern.
    /// </summary>
    /// <param name="value">A Unicode character to append.</param>
    public Substitution Text(char value) => Append(SubstitutionFactory.Text(value));

    /// <summary>
    /// Concatenate two elements into a new <see cref="Substitution"/>.
    /// </summary>
    /// <param name="left">The first element to concatenate.</param>
    /// <param name="right">The second element to concatenate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
    public static Substitution operator +(Substitution left, Substitution right)
    {
        if (left is null)
            throw new ArgumentNullException(nameof(left));

        if (right is null)
            throw new ArgumentNullException(nameof(right));

        return left.Append(right);
    }

    /// <summary>
    /// Concatenate two elements into a new <see cref="Substitution"/>.
    /// </summary>
    /// <param name="left">The first element to concatenate.</param>
    /// <param name="right">The second element to concatenate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
    public static Substitution operator +(Substitution left, string right)
    {
        if (left is null)
            throw new ArgumentNullException(nameof(left));

        if (right is null)
            throw new ArgumentNullException(nameof(right));

        return left.Text(right);
    }

    /// <summary>
    /// Concatenate two elements into a new <see cref="Substitution"/>.
    /// </summary>
    /// <param name="left">The first element to concatenate.</param>
    /// <param name="right">The second element to concatenate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is <c>null</c>.</exception>
    public static Substitution operator +(string left, Substitution right)
    {
        if (left is null)
            throw new ArgumentNullException(nameof(left));

        if (right is null)
            throw new ArgumentNullException(nameof(right));

        return SubstitutionFactory.Text(left).Append(right);
    }

    /// <summary>
    /// Concatenate two elements into a new <see cref="Substitution"/>.
    /// </summary>
    /// <param name="left">The first element to concatenate.</param>
    /// <param name="right">The second element to concatenate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="left"/> is <c>null</c>.</exception>
    public static Substitution operator +(Substitution left, char right)
    {
        if (left is null)
            throw new ArgumentNullException(nameof(left));

        return left.Append(SubstitutionFactory.Text(right));
    }

    /// <summary>
    /// Concatenate two elements into a new <see cref="Substitution"/>.
    /// </summary>
    /// <param name="left">The first element to concatenate.</param>
    /// <param name="right">The second element to concatenate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="right"/> is <c>null</c>.</exception>
    public static Substitution operator +(char left, Substitution right)
    {
        if (right is null)
            throw new ArgumentNullException(nameof(right));

        return SubstitutionFactory.Text(left).Append(right);
    }

    internal abstract string Value { get; }

    internal Substitution? Previous { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string DebuggerDisplay => ToString();
}
