// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

/// <summary>
/// Represents a pattern that matches a single character. This includes Unicode category, Unicode block or character class ((non-)digit, (non-)white-space, (non-)word). This class is abstract.
/// </summary>
public abstract partial class CharPattern : QuantifiablePattern, IBaseGroup, IExcludedGroup, INegateable<CharGroup>
{
    internal CharPattern()
    {
    }

    internal static CharPattern Create(char value)
    {
        return new CharCharPattern(value);
    }

    internal static CharPattern Create(AsciiChar value)
    {
        return new AsciiCharCharPattern(value);
    }

    internal static CharPattern Create(CharClass value)
    {
        return new CharClassCharPattern(value);
    }

    internal static CharPattern Create(GeneralCategory category, bool negative)
    {
        return new GeneralCategoryCharPattern(category, negative);
    }

    internal static CharPattern Create(NamedBlock block, bool negative)
    {
        return new NamedBlockCharPattern(block, negative);
    }

    /// <summary>
    /// Returns a patterns that matches what is not matched by the current instance.
    /// </summary>
    public abstract CharGroup Negate();

    /// <summary>
    /// Appends the current instance to a specified <see cref="PatternBuilder"/>. The current instance is interpreted as a part of the character group.
    /// </summary>
    /// <param name="builder">The builder to use for appending the text.</param>
    /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <c>null</c>.</exception>
    protected virtual void AppendGroupContentTo(PatternBuilder builder)
    {
        if (builder is null)
            throw new ArgumentNullException(nameof(builder));

        AppendTo(builder);
    }

    /// <summary>
    /// Appends the text representation of the current instance of the character pattern to the specified <see cref="PatternBuilder"/>.
    /// </summary>
    /// <param name="builder">The builder to use for appending the text.</param>
    /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <c>null</c>.</exception>
    public void AppendBaseGroupTo(PatternBuilder builder)
    {
        if (builder is null)
            throw new ArgumentNullException(nameof(builder));

        AppendGroupContentTo(builder);
    }

    /// <summary>
    /// Appends the text representation of the character group containing the current instance to the specified <see cref="PatternBuilder"/>.
    /// </summary>
    /// <param name="builder">The builder to use for appending the text.</param>
    /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <c>null</c>.</exception>
    public void AppendExcludedGroupTo(PatternBuilder builder)
    {
        if (builder is null)
            throw new ArgumentNullException(nameof(builder));

        builder.AppendCharGroupStart();
        AppendGroupContentTo(builder);
        builder.AppendCharGroupEnd();
    }

    /// <summary>
    /// Returns a patterns that matches what is not matched by the current instance.
    /// </summary>
    /// <param name="value">A value to negate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public static CharGroup operator !(CharPattern value)
    {
        if (value is null)
            throw new ArgumentNullException(nameof(value));

        return value.Negate();
    }

    /// <summary>
    /// Returns a pattern that matches a character from a specified base group except characters from a specified excluded group.
    /// </summary>
    /// <param name="baseGroup">A base group.</param>
    /// <param name="excludedGroup">An excluded group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="baseGroup"/> or <paramref name="excludedGroup"/> is <c>null</c>.</exception>
    public static CharSubtraction operator -(CharPattern baseGroup, CharPattern excludedGroup)
    {
        return new CharSubtraction(baseGroup, excludedGroup);
    }

    /// <summary>
    /// Returns a pattern that matches a character from a specified base group except characters from a specified excluded group.
    /// </summary>
    /// <param name="baseGroup">A base group.</param>
    /// <param name="excludedGroup">An excluded group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="baseGroup"/> or <paramref name="excludedGroup"/> is <c>null</c>.</exception>
    public static CharSubtraction operator -(CharPattern baseGroup, CharGroup excludedGroup)
    {
        return new CharSubtraction(baseGroup, excludedGroup);
    }

    /// <summary>
    /// Returns a pattern that matches a character from a specified base group except characters from a specified excluded group.
    /// </summary>
    /// <param name="baseGroup">A base group.</param>
    /// <param name="excludedGroup">An excluded group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="baseGroup"/> or <paramref name="excludedGroup"/> is <c>null</c>.</exception>
    public static CharSubtraction operator -(CharPattern baseGroup, CharGrouping excludedGroup)
    {
        return new CharSubtraction(baseGroup, excludedGroup);
    }
}
