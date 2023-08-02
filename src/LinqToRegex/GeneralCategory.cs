// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions;

/// <summary>
/// Specifies Unicode general category.
/// </summary>
public enum GeneralCategory
{
    /// <summary>
    /// All control characters. This includes the Cc, Cf, Cs, Co, and Cn categories.
    /// </summary>
    AllControlCharacters = 0,

    /// <summary>
    /// All diacritic marks. This includes the Mn, Mc, and Me categories.
    /// </summary>
    AllDiacriticMarks = 1,

    /// <summary>
    /// All letter characters. This includes the Lu, Ll, Lt, Lm, and Lo characters.
    /// </summary>
    AllLetterCharacters = 2,

    /// <summary>
    /// All numbers. This includes the Nd, Nl, and No categories.
    /// </summary>
    AllNumbers = 3,

    /// <summary>
    /// All punctuation characters. This includes the Pc, Pd, Ps, Pe, Pi, Pf, and Po categories.
    /// </summary>
    AllPunctuationCharacters = 4,

    /// <summary>
    /// All separator characters. This includes the Zs, Zl, and Zp categories.
    /// </summary>
    AllSeparatorCharacters = 5,

    /// <summary>
    /// All symbols. This includes the Sm, Sc, Sk, and So categories.
    /// </summary>
    AllSymbols = 6,

    /// <summary>
    /// Letter, Lowercase
    /// </summary>
    LetterLowercase = 7,

    /// <summary>
    /// Letter, Modifier
    /// </summary>
    LetterModifier = 8,

    /// <summary>
    /// Letter, Other
    /// </summary>
    LetterOther = 9,

    /// <summary>
    /// Letter, Titlecase
    /// </summary>
    LetterTitlecase = 10,

    /// <summary>
    /// Letter, Uppercase
    /// </summary>
    LetterUppercase = 11,

    /// <summary>
    /// Mark, Enclosing
    /// </summary>
    MarkEnclosing = 12,

    /// <summary>
    /// Mark, Nonspacing
    /// </summary>
    MarkNonspacing = 13,

    /// <summary>
    /// Mark, Spacing Combining
    /// </summary>
    MarkSpacingCombining = 14,

    /// <summary>
    /// Number, Decimal Digit
    /// </summary>
    NumberDecimalDigit = 15,

    /// <summary>
    /// Number, Letter
    /// </summary>
    NumberLetter = 16,

    /// <summary>
    /// Number, Other
    /// </summary>
    NumberOther = 17,

    /// <summary>
    /// Other, Control
    /// </summary>
    OtherControl = 18,

    /// <summary>
    /// Other, Format
    /// </summary>
    OtherFormat = 19,

    /// <summary>
    /// Other, Not Assigned (no characters have this property)
    /// </summary>
    OtherNotAssigned = 20,

    /// <summary>
    /// Other, Private Use
    /// </summary>
    OtherPrivateUse = 21,

    /// <summary>
    /// Other, Surrogate
    /// </summary>
    OtherSurrogate = 22,

    /// <summary>
    /// Punctuation, Close
    /// </summary>
    PunctuationClose = 23,

    /// <summary>
    /// Punctuation, Connector
    /// </summary>
    PunctuationConnector = 24,

    /// <summary>
    /// Punctuation, Dash
    /// </summary>
    PunctuationDash = 25,

    /// <summary>
    /// Punctuation, Final quote (may behave like Ps or Pe depending on usage)
    /// </summary>
    PunctuationFinalQuote = 26,

    /// <summary>
    /// Punctuation, Initial quote (may behave like Ps or Pe depending on usage)
    /// </summary>
    PunctuationInitialQuote = 27,

    /// <summary>
    /// Punctuation, Open
    /// </summary>
    PunctuationOpen = 28,

    /// <summary>
    /// Punctuation, Other
    /// </summary>
    PunctuationOther = 29,

    /// <summary>
    /// Separator, Line
    /// </summary>
    SeparatorLine = 30,

    /// <summary>
    /// Separator, Paragraph
    /// </summary>
    SeparatorParagraph = 31,

    /// <summary>
    /// Separator, Space
    /// </summary>
    SeparatorSpace = 32,

    /// <summary>
    /// Symbol, Currency
    /// </summary>
    SymbolCurrency = 33,

    /// <summary>
    /// Symbol, Math
    /// </summary>
    SymbolMath = 34,

    /// <summary>
    /// Symbol, Modifier
    /// </summary>
    SymbolModifier = 35,

    /// <summary>
    /// Symbol, Other
    /// </summary>
    SymbolOther = 36,
}
