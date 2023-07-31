// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq;

internal enum QuantifierKind
{
    None = 0,
    Maybe = 1,
    MaybeMany = 2,
    OneMany = 3,
    Count = 4,
    CountRange = 5,
    CountFrom = 6,
    MaybeCount = 7,
}
