// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;

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
        [Display(Description = "All control characters. This includes the Cc, Cf, Cs, Co, and Cn categories.")]
        AllControlCharacters,

        /// <summary>
        /// All diacritic marks. This includes the Mn, Mc, and Me categories.
        /// </summary>
        [Display(Description = "All diacritic marks. This includes the Mn, Mc, and Me categories.")]
        AllDiacriticMarks,

        /// <summary>
        /// All letter characters. This includes the Lu, Ll, Lt, Lm, and Lo characters.
        /// </summary>
        [Display(Description = "All letter characters. This includes the Lu, Ll, Lt, Lm, and Lo characters.")]
        AllLetterCharacters,

        /// <summary>
        /// All numbers. This includes the Nd, Nl, and No categories.
        /// </summary>
        [Display(Description = "All numbers. This includes the Nd, Nl, and No categories.")]
        AllNumbers,

        /// <summary>
        /// All punctuation characters. This includes the Pc, Pd, Ps, Pe, Pi, Pf, and Po categories.
        /// </summary>
        [Display(Description = "All punctuation characters. This includes the Pc, Pd, Ps, Pe, Pi, Pf, and Po categories.")]
        AllPunctuationCharacters,

        /// <summary>
        /// All separator characters. This includes the Zs, Zl, and Zp categories.
        /// </summary>
        [Display(Description = "All separator characters. This includes the Zs, Zl, and Zp categories.")]
        AllSeparatorCharacters,

        /// <summary>
        /// All symbols. This includes the Sm, Sc, Sk, and So categories.
        /// </summary>
        [Display(Description = "All symbols. This includes the Sm, Sc, Sk, and So categories.")]
        AllSymbols,

        /// <summary>
        /// Letter, Lowercase
        /// </summary>
        [Display(Description = "Letter, Lowercase")]
        LetterLowercase,

        /// <summary>
        /// Letter, Modifier
        /// </summary>
        [Display(Description = "Letter, Modifier")]
        LetterModifier,

        /// <summary>
        /// Letter, Other
        /// </summary>
        [Display(Description = "Letter, Other")]
        LetterOther,

        /// <summary>
        /// Letter, Titlecase
        /// </summary>
        [Display(Description = "Letter, Titlecase")]
        LetterTitlecase,

        /// <summary>
        /// Letter, Uppercase
        /// </summary>
        [Display(Description = "Letter, Uppercase")]
        LetterUppercase,

        /// <summary>
        /// Mark, Enclosing
        /// </summary>
        [Display(Description = "Mark, Enclosing")]
        MarkEnclosing,

        /// <summary>
        /// Mark, Nonspacing
        /// </summary>
        [Display(Description = "Mark, Nonspacing")]
        MarkNonspacing,

        /// <summary>
        /// Mark, Spacing Combining
        /// </summary>
        [Display(Description = "Mark, Spacing Combining")]
        MarkSpacingCombining,

        /// <summary>
        /// Number, Decimal Digit
        /// </summary>
        [Display(Description = "Number, Decimal Digit")]
        NumberDecimalDigit,

        /// <summary>
        /// Number, Letter
        /// </summary>
        [Display(Description = "Number, Letter")]
        NumberLetter,

        /// <summary>
        /// Number, Other
        /// </summary>
        [Display(Description = "Number, Other")]
        NumberOther,

        /// <summary>
        /// Other, Control
        /// </summary>
        [Display(Description = "Other, Control")]
        OtherControl,

        /// <summary>
        /// Other, Format
        /// </summary>
        [Display(Description = "Other, Format")]
        OtherFormat,

        /// <summary>
        /// Other, Not Assigned (no characters have this property)
        /// </summary>
        [Display(Description = "Other, Not Assigned (no characters have this property)")]
        OtherNotAssigned,

        /// <summary>
        /// Other, Private Use
        /// </summary>
        [Display(Description = "Other, Private Use")]
        OtherPrivateUse,

        /// <summary>
        /// Other, Surrogate
        /// </summary>
        [Display(Description = "Other, Surrogate")]
        OtherSurrogate,

        /// <summary>
        /// Punctuation, Close
        /// </summary>
        [Display(Description = "Punctuation, Close")]
        PunctuationClose,

        /// <summary>
        /// Punctuation, Connector
        /// </summary>
        [Display(Description = "Punctuation, Connector")]
        PunctuationConnector,

        /// <summary>
        /// Punctuation, Dash
        /// </summary>
        [Display(Description = "Punctuation, Dash")]
        PunctuationDash,

        /// <summary>
        /// Punctuation, Final quote (may behave like Ps or Pe depending on usage)
        /// </summary>
        [Display(Description = "Punctuation, Final quote (may behave like Ps or Pe depending on usage)")]
        PunctuationFinalQuote,

        /// <summary>
        /// Punctuation, Initial quote (may behave like Ps or Pe depending on usage)
        /// </summary>
        [Display(Description = "Punctuation, Initial quote (may behave like Ps or Pe depending on usage)")]
        PunctuationInitialQuote,

        /// <summary>
        /// Punctuation, Open
        /// </summary>
        [Display(Description = "Punctuation, Open")]
        PunctuationOpen,

        /// <summary>
        /// Punctuation, Other
        /// </summary>
        [Display(Description = "Punctuation, Other")]
        PunctuationOther,

        /// <summary>
        /// Separator, Line
        /// </summary>
        [Display(Description = "Separator, Line")]
        SeparatorLine,

        /// <summary>
        /// Separator, Paragraph
        /// </summary>
        [Display(Description = "Separator, Paragraph")]
        SeparatorParagraph,

        /// <summary>
        /// Separator, Space
        /// </summary>
        [Display(Description = "Separator, Space")]
        SeparatorSpace,

        /// <summary>
        /// Symbol, Currency
        /// </summary>
        [Display(Description = "Symbol, Currency")]
        SymbolCurrency,

        /// <summary>
        /// Symbol, Math
        /// </summary>
        [Display(Description = "Symbol, Math")]
        SymbolMath,

        /// <summary>
        /// Symbol, Modifier
        /// </summary>
        [Display(Description = "Symbol, Modifier")]
        SymbolModifier,

        /// <summary>
        /// Symbol, Other
        /// </summary>
        [Display(Description = "Symbol, Other")]
        SymbolOther,
    }
}
