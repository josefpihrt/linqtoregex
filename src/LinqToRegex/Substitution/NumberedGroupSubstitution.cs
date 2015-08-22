// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Globalization;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class NumberedGroupSubstitution
        : Substitution
    {
        internal NumberedGroupSubstitution(int groupNumber)
        {
            if (groupNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(groupNumber));
            }

            GroupNumber = groupNumber;
        }

        internal override string Value => "${" + GroupNumber.ToString(CultureInfo.InvariantCulture) + "}";

        public int GroupNumber { get; }
    }
}