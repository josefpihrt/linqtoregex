// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Specifies Unicode general category.
    /// </summary>
    public enum GeneralCategory
    {
        /// <summary>
        /// All control characters. This includes the Cc, Cf, Cs, Co, and Cn categories.
        /// </summary>
        AllControlCharacters,

        /// <summary>
        /// All diacritic marks. This includes the Mn, Mc, and Me categories.
        /// </summary>
        AllDiacriticMarks,

        /// <summary>
        /// All letter characters. This includes the Lu, Ll, Lt, Lm, and Lo characters.
        /// </summary>
        AllLetterCharacters,

        /// <summary>
        /// All numbers. This includes the Nd, Nl, and No categories.
        /// </summary>
        AllNumbers,

        /// <summary>
        /// All punctuation characters. This includes the Pc, Pd, Ps, Pe, Pi, Pf, and Po categories.
        /// </summary>
        AllPunctuationCharacters,

        /// <summary>
        /// All separator characters. This includes the Zs, Zl, and Zp categories.
        /// </summary>
        AllSeparatorCharacters,

        /// <summary>
        /// All symbols. This includes the Sm, Sc, Sk, and So categories.
        /// </summary>
        AllSymbols,

        /// <summary>
        /// Letter, Lowercase
        /// </summary>
        LetterLowercase,

        /// <summary>
        /// Letter, Modifier
        /// </summary>
        LetterModifier,

        /// <summary>
        /// Letter, Other
        /// </summary>
        LetterOther,

        /// <summary>
        /// Letter, Titlecase
        /// </summary>
        LetterTitlecase,

        /// <summary>
        /// Letter, Uppercase
        /// </summary>
        LetterUppercase,

        /// <summary>
        /// Mark, Enclosing
        /// </summary>
        MarkEnclosing,

        /// <summary>
        /// Mark, Nonspacing
        /// </summary>
        MarkNonspacing,

        /// <summary>
        /// Mark, Spacing Combining
        /// </summary>
        MarkSpacingCombining,

        /// <summary>
        /// Number, Decimal Digit
        /// </summary>
        NumberDecimalDigit,

        /// <summary>
        /// Number, Letter
        /// </summary>
        NumberLetter,

        /// <summary>
        /// Number, Other
        /// </summary>
        NumberOther,

        /// <summary>
        /// Other, Control
        /// </summary>
        OtherControl,

        /// <summary>
        /// Other, Format
        /// </summary>
        OtherFormat,

        /// <summary>
        /// Other, Not Assigned (no characters have this property)
        /// </summary>
        OtherNotAssigned,

        /// <summary>
        /// Other, Private Use
        /// </summary>
        OtherPrivateUse,

        /// <summary>
        /// Other, Surrogate
        /// </summary>
        OtherSurrogate,

        /// <summary>
        /// Punctuation, Close
        /// </summary>
        PunctuationClose,

        /// <summary>
        /// Punctuation, Connector
        /// </summary>
        PunctuationConnector,

        /// <summary>
        /// Punctuation, Dash
        /// </summary>
        PunctuationDash,

        /// <summary>
        /// Punctuation, Final quote (may behave like Ps or Pe depending on usage)
        /// </summary>
        PunctuationFinalQuote,

        /// <summary>
        /// Punctuation, Initial quote (may behave like Ps or Pe depending on usage)
        /// </summary>
        PunctuationInitialQuote,

        /// <summary>
        /// Punctuation, Open
        /// </summary>
        PunctuationOpen,

        /// <summary>
        /// Punctuation, Other
        /// </summary>
        PunctuationOther,

        /// <summary>
        /// Separator, Line
        /// </summary>
        SeparatorLine,

        /// <summary>
        /// Separator, Paragraph
        /// </summary>
        SeparatorParagraph,

        /// <summary>
        /// Separator, Space
        /// </summary>
        SeparatorSpace,

        /// <summary>
        /// Symbol, Currency
        /// </summary>
        SymbolCurrency,

        /// <summary>
        /// Symbol, Math
        /// </summary>
        SymbolMath,

        /// <summary>
        /// Symbol, Modifier
        /// </summary>
        SymbolModifier,

        /// <summary>
        /// Symbol, Other
        /// </summary>
        SymbolOther,
    }
}
