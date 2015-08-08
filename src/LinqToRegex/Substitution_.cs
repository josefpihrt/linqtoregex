// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    public abstract partial class Substitution
    {
        internal sealed class NamedGroupSubstitution
            : Substitution
        {
            internal NamedGroupSubstitution(string groupName)
            {
                RegexUtility.CheckGroupName(groupName);

                GroupName = groupName;
            }

            internal override string Value => Syntax.SubstituteNamedGroupStart + GroupName + Syntax.SubstituteNamedGroupEnd;

            public string GroupName { get; }
        }

        internal sealed class EntireMatchSubstitution
            : Substitution
        {
            internal EntireMatchSubstitution()
            {
            }

            internal override string Value => Syntax.SubstituteEntireMatch;
        }

        internal sealed class BeforeMatchSubstitution
            : Substitution
        {
            internal BeforeMatchSubstitution()
            {
            }

            internal override string Value => Syntax.SubstituteBeforeMatch;
        }

        internal sealed class AfterMatchSubstitution
            : Substitution
        {
            internal AfterMatchSubstitution()
            {
            }

            internal override string Value => Syntax.SubstituteAfterMatch;
        }

        internal sealed class LastCapturedGroupSubstitution
            : Substitution
        {
            internal LastCapturedGroupSubstitution()
            {
            }

            internal override string Value => Syntax.SubstituteLastCapturedGroup;
        }

        internal sealed class EntireInputSubstitution
            : Substitution
        {
            internal EntireInputSubstitution()
            {
            }

            internal override string Value => Syntax.SubstituteEntireInput;
        }

        internal sealed class TextSubstitution
            : Substitution
        {
            private readonly string _text;

            internal TextSubstitution(string text)
            {
                if (text == null)
                {
                    throw new ArgumentNullException(nameof(text));
                }

                _text = text;
            }

            internal override string Value => RegexUtility.EscapeSubstitution(_text);
        }
    }
}