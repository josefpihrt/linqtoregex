// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions;

internal static class ExceptionMessages
{
    public static readonly string CharGroupCannotBeEmpty = "Character group cannot be empty.";
    public static readonly string RegexOptionsNotConvertibleToInlineChars = "RegexOptions value cannot be expressed as a combination of inline characters.";
    public static readonly string InvalidPatternOptions = $"'{nameof(PatternOptions.CSharpLiteral)}' and '{nameof(PatternOptions.VisualBasicLiteral)}' cannot be set both at the same time.";
}
