// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    public abstract partial class CharGroup
    {
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
                if (builder == null)
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
                if (builder == null)
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
                if (characters == null)
                    throw new ArgumentNullException(nameof(characters));

                if (characters.Length == 0)
                    throw new ArgumentException(ExceptionHelper.CharGroupCannotBeEmpty, nameof(characters));

                _characters = characters;
                Negative = negative;
            }

            internal override void AppendContentTo(PatternBuilder builder)
            {
                if (builder == null)
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
                if (characters == null)
                    throw new ArgumentNullException(nameof(characters));

                if (characters.Length == 0)
                    throw new ArgumentException(ExceptionHelper.CharGroupCannotBeEmpty, nameof(characters));

                _characters = characters;
                Negative = negative;
            }

            internal override void AppendContentTo(PatternBuilder builder)
            {
                if (builder == null)
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
                if (builder == null)
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
}
