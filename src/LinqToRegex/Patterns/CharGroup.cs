// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Pihrtsoft.Text.RegularExpressions.Rendering;

namespace Pihrtsoft.Text.RegularExpressions;

/// <summary>
/// Represents a positive or a negative character group pattern. This class is abstract.
/// </summary>
public abstract class CharGroup : QuantifiablePattern, IBaseGroup, IExcludedGroup, INegateable<CharGroup>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CharGroup"/> class.
    /// </summary>
    protected CharGroup()
    {
    }

    internal static CharGroup Create(char value, bool negative)
    {
        return new CharCharGroup(value, negative);
    }

    internal static CharGroup Create(AsciiChar value, bool negative)
    {
        return new AsciiCharCharGroup(value, negative);
    }

    internal static CharGroup Create(string characters, bool negative)
    {
        return new TextCharGroup(characters, negative);
    }

    internal static CharGroup Create(char[] characters, bool negative)
    {
        return new CharactersCharGroup(characters, negative);
    }

    internal static CharGroup Create(char firstChar, char lastChar, bool negative)
    {
        return new CharRangeCharGroup(firstChar, lastChar, negative);
    }

    internal static CharGroup Create(GeneralCategory category, bool negative)
    {
        return new GeneralCategoryCharGroup(category, negative);
    }

    internal static CharGroup Create(NamedBlock block, bool negative)
    {
        return new NamedBlockCharGroup(block, negative);
    }

    internal static CharGroup Create(CharClass value)
    {
        return new CharClassCharGroup(value);
    }

    internal static CharGroup Create(CharGrouping value, bool negative)
    {
        return new CharGroupingCharGroup(value, negative);
    }

    internal static CharGroup Create(CharGroup value, bool negative)
    {
        return new CharGroupCharGroup(value, negative);
    }

    internal abstract void AppendContentTo(PatternBuilder builder);

    /// <summary>
    /// Appends the text representation of the content of the current instance to the specified <see cref="PatternBuilder"/>.
    /// </summary>
    /// <param name="builder">The builder to use for appending the text.</param>
    /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <c>null</c>.</exception>
    void IBaseGroup.AppendBaseGroupTo(PatternBuilder builder)
    {
        if (builder is null)
            throw new ArgumentNullException(nameof(builder));

        if (Negative)
            builder.AppendDirect('^');

        AppendContentTo(builder);
    }

    /// <summary>
    /// Appends the text representation of the current instance to the specified <see cref="PatternBuilder"/>.
    /// </summary>
    /// <param name="builder">The builder to use for appending the text.</param>
    /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <c>null</c>.</exception>
    void IExcludedGroup.AppendExcludedGroupTo(PatternBuilder builder)
    {
        if (builder is null)
            throw new ArgumentNullException(nameof(builder));

        AppendTo(builder);
    }

    /// <summary>
    /// If the current instance is a positive character group, it returns a negative character group. Otherwise, it returns a positive character group. Newly created group has the same content as the current instance.
    /// </summary>
    public CharGroup Negate() => Create(this, !Negative);

    public CharSubtraction Subtract(CharGroup excludedGroup) => new(this, excludedGroup);

    public CharSubtraction Subtract(CharGrouping excludedGroup) => new(this, excludedGroup);

    public CharSubtraction Subtract(CharPattern excludedGroup) => new(this, excludedGroup);

    /// <summary>
    /// If the current instance is a positive character group, it returns a negative character group. Otherwise, it returns a positive character group. Newly created group has the same content as the current instance.
    /// </summary>
    /// <param name="value">A value to negate.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public static CharGroup operator !(CharGroup value)
    {
        if (value is null)
            throw new ArgumentNullException(nameof(value));

        return value.Negate();
    }

    /// <summary>
    /// Converts specified characters to an instance of the <see cref="CharGroup"/> class.
    /// </summary>
    /// <param name="characters">A set of Unicode characters.</param>
    /// <exception cref="ArgumentNullException"><paramref name="characters"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException"><paramref name="characters"/> length is equal to zero.</exception>
    public static explicit operator CharGroup(string characters)
    {
        return Create(characters, false);
    }

    /// <summary>
    /// Converts specified <see cref="CharGrouping"/> to an instance of the <see cref="CharGroup"/> class.
    /// </summary>
    /// <param name="value">An instance of the <see cref="CharGrouping"/> class.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public static explicit operator CharGroup(CharGrouping value)
    {
        return Create(value, false);
    }

    /// <summary>
    /// Returns a pattern that matches a character from a specified base group except characters from a specified excluded group.
    /// </summary>
    /// <param name="baseGroup">A base group.</param>
    /// <param name="excludedGroup">An excluded group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="baseGroup"/> or <paramref name="excludedGroup"/> is <c>null</c>.</exception>
    public static CharSubtraction operator -(CharGroup baseGroup, CharGroup excludedGroup)
    {
        return new CharSubtraction(baseGroup, excludedGroup);
    }

    /// <summary>
    /// Returns a pattern that matches a character from a specified base group except characters from a specified excluded group.
    /// </summary>
    /// <param name="baseGroup">A base group.</param>
    /// <param name="excludedGroup">An excluded group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="baseGroup"/> or <paramref name="excludedGroup"/> is <c>null</c>.</exception>
    public static CharSubtraction operator -(CharGroup baseGroup, CharGrouping excludedGroup)
    {
        return new CharSubtraction(baseGroup, excludedGroup);
    }

    /// <summary>
    /// Returns a pattern that matches a character from a specified base group except characters from a specified excluded group.
    /// </summary>
    /// <param name="baseGroup">A base group.</param>
    /// <param name="excludedGroup">An excluded group.</param>
    /// <exception cref="ArgumentNullException"><paramref name="baseGroup"/> or <paramref name="excludedGroup"/> is <c>null</c>.</exception>
    public static CharSubtraction operator -(CharGroup baseGroup, CharPattern excludedGroup)
    {
        return new CharSubtraction(baseGroup, excludedGroup);
    }

    /// <summary>
    /// Gets a value that indicates whether the current instance is a positive or a negative character group.
    /// </summary>
    public virtual bool Negative => false;

    internal sealed class CharCharGroup : CharGroup
    {
        private readonly char _value;

        public CharCharGroup(char value, bool negative)
        {
            _value = value;
            Negative = negative;
        }

        internal override void AppendContentTo(PatternBuilder builder)
        {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            builder.Append(_value, true);
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendCharGroup(_value, Negative);
        }

        public override bool Negative { get; }
    }

    internal sealed class AsciiCharCharGroup : CharGroup
    {
        private readonly AsciiChar _value;

        public AsciiCharCharGroup(AsciiChar value, bool negative)
        {
            _value = value;
            Negative = negative;
        }

        internal override void AppendContentTo(PatternBuilder builder)
        {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            builder.Append(_value, true);
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendCharGroup(_value, Negative);
        }

        public override bool Negative { get; }
    }

    internal sealed class TextCharGroup : CharGroup
    {
        private readonly string _characters;

        public TextCharGroup(string characters, bool negative)
        {
            if (characters is null)
                throw new ArgumentNullException(nameof(characters));

            if (characters.Length == 0)
                throw new ArgumentException(ExceptionMessages.CharGroupCannotBeEmpty, nameof(characters));

            _characters = characters;
            Negative = negative;
        }

        internal override void AppendContentTo(PatternBuilder builder)
        {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            builder.Append(_characters, true);
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendCharGroup(_characters, Negative);
        }

        public override bool Negative { get; }
    }

    internal sealed class CharactersCharGroup : CharGroup
    {
        private readonly char[] _characters;

        public CharactersCharGroup(char[] characters, bool negative)
        {
            if (characters is null)
                throw new ArgumentNullException(nameof(characters));

            if (characters.Length == 0)
                throw new ArgumentException(ExceptionMessages.CharGroupCannotBeEmpty, nameof(characters));

            _characters = characters;
            Negative = negative;
        }

        internal override void AppendContentTo(PatternBuilder builder)
        {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            builder.Append(_characters, true);
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendCharGroup(_characters, Negative);
        }

        public override bool Negative { get; }
    }

    internal sealed class CharRangeCharGroup : CharGroup
    {
        private readonly char _firstChar;
        private readonly char _lastChar;

        public CharRangeCharGroup(char firstChar, char lastChar, bool negative)
        {
            if (lastChar < firstChar)
                throw new ArgumentOutOfRangeException(nameof(lastChar));

            _firstChar = firstChar;
            _lastChar = lastChar;
            Negative = negative;
        }

        internal override void AppendContentTo(PatternBuilder builder)
        {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            builder.AppendCharRange(_firstChar, _lastChar);
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendCharGroup(_firstChar, _lastChar, Negative);
        }

        public override bool Negative { get; }
    }

    internal sealed class GeneralCategoryCharGroup : CharGroup
    {
        private readonly GeneralCategory _category;

        public GeneralCategoryCharGroup(GeneralCategory category, bool negative)
        {
            _category = category;
            Negative = negative;
        }

        internal override void AppendContentTo(PatternBuilder builder)
        {
            builder.AppendGeneralCategory(_category, Negative);
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendCharGroup(_category, Negative);
        }

        public override bool Negative { get; }
    }

    internal sealed class NamedBlockCharGroup : CharGroup
    {
        private readonly NamedBlock _block;

        public NamedBlockCharGroup(NamedBlock block, bool negative)
        {
            _block = block;
            Negative = negative;
        }

        internal override void AppendContentTo(PatternBuilder builder)
        {
            builder.AppendNamedBlock(_block, Negative);
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendCharGroup(_block, Negative);
        }

        public override bool Negative { get; }
    }

    internal sealed class CharClassCharGroup : CharGroup
    {
        private readonly CharClass _value;

        public CharClassCharGroup(CharClass value)
        {
            _value = value;
        }

        internal override void AppendContentTo(PatternBuilder builder)
        {
            builder.AppendCharClass(_value);
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendCharGroup(_value);
        }
    }

    internal sealed class CharGroupingCharGroup : CharGroup
    {
        private readonly CharGrouping _item;

        public CharGroupingCharGroup(CharGrouping value, bool negative)
        {
            _item = value ?? throw new ArgumentNullException(nameof(value));
            Negative = negative;
        }

        internal override void AppendContentTo(PatternBuilder builder)
        {
            _item.AppendContentTo(builder);
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendCharGroup(_item, Negative);
        }

        public override bool Negative { get; }
    }

    internal sealed class CharGroupCharGroup : CharGroup
    {
        private readonly CharGroup _group;

        internal CharGroupCharGroup(CharGroup group, bool negative)
        {
            _group = group ?? throw new ArgumentNullException(nameof(group));
            Negative = negative;
        }

        internal override void AppendContentTo(PatternBuilder builder)
        {
            _group.AppendContentTo(builder);
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendCharGroupStart(Negative);
            _group.AppendContentTo(builder);
            builder.AppendCharGroupEnd();
        }

        public override bool Negative { get; }
    }
}
