// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions;

/// <summary>
/// Provides enumerated values to use when splitting a text.
/// </summary>
[Flags]
public enum SplitOptions
{
    /// <summary>
    /// Specifies that no options are set.
    /// </summary>
    None = 0,

    /// <summary>
    /// Specifies that group values will be omitted from the result.
    /// </summary>
    OmitGroupValues = 1,

    /// <summary>
    /// Specifies that empty values will be omitted from the result.
    /// </summary>
    OmitEmptyValues = 1 << 1,
}
