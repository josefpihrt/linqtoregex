// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    [Flags]
    public enum SplitOptions
    {
        None = 0,
        OmitGroupValues = 1,
        OmitEmptyValues = 2
    }
}
