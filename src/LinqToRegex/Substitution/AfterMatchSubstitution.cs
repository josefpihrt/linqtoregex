// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class AfterMatchSubstitution : Substitution
    {
        internal AfterMatchSubstitution()
        {
        }

        internal override string Value => "$'";
    }
}