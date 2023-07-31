// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq;

public abstract partial class CharPattern
{
    internal sealed class CharCharPattern : CharPattern
    {
        private readonly char _value;

        internal CharCharPattern(char value)
        {
            _value = value;
        }

        public override CharGroup Negate() => CharGroup.Create(_value, true);

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.Append(_value);
        }

        private protected override void AppendGroupContentTo(PatternBuilder builder)
        {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            builder.Append(_value, true);
        }
    }

    internal sealed class AsciiCharCharPattern : CharPattern
    {
        private readonly AsciiChar _value;

        internal AsciiCharCharPattern(AsciiChar value)
        {
            _value = value;
        }

        public override CharGroup Negate() => CharGroup.Create(_value, true);

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.Append(_value);
        }

        private protected override void AppendGroupContentTo(PatternBuilder builder)
        {
            if (builder is null)
                throw new ArgumentNullException(nameof(builder));

            builder.Append(_value, true);
        }
    }

    internal class GeneralCategoryCharPattern : CharPattern
    {
        private readonly GeneralCategory _category;
        private readonly bool _negative;

        internal GeneralCategoryCharPattern(GeneralCategory category, bool negative)
        {
            _category = category;
            _negative = negative;
        }

        public override CharGroup Negate() => CharGroup.Create(_category, !_negative);

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendGeneralCategory(_category, _negative);
        }
    }

    internal class NamedBlockCharPattern : CharPattern
    {
        private readonly NamedBlock _block;
        private readonly bool _negative;

        internal NamedBlockCharPattern(NamedBlock block, bool negative)
        {
            _block = block;
            _negative = negative;
        }

        public override CharGroup Negate() => CharGroup.Create(_block, !_negative);

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendNamedBlock(_block, _negative);
        }
    }

    internal sealed class CharClassCharPattern : CharPattern
    {
        private readonly CharClass _value;

        public CharClassCharPattern(CharClass value)
        {
            _value = value;
        }

        public override CharGroup Negate()
        {
            return _value switch
            {
                CharClass.Digit => CharGroup.Create(CharClass.NotDigit),
                CharClass.WordChar => CharGroup.Create(CharClass.NotWordChar),
                CharClass.WhiteSpace => CharGroup.Create(CharClass.NotWhiteSpace),
                CharClass.NotDigit => CharGroup.Create(CharClass.Digit),
                CharClass.NotWordChar => CharGroup.Create(CharClass.WordChar),
                CharClass.NotWhiteSpace => CharGroup.Create(CharClass.WhiteSpace),
                _ => throw new InvalidOperationException($"Character class '{_value}' cannot be negated."),
            };
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendCharClass(_value);
        }
    }
}
