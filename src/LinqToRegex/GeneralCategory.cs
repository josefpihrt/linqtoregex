// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel;

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
        [Description("All control characters. This includes the Cc, Cf, Cs, Co, and Cn categories.")]
        AllControlCharacters,

        /// <summary>
        /// All diacritic marks. This includes the Mn, Mc, and Me categories.
        /// </summary>
        [Description("All diacritic marks. This includes the Mn, Mc, and Me categories.")]
        AllDiacriticMarks,

        /// <summary>
        /// All letter characters. This includes the Lu, Ll, Lt, Lm, and Lo characters.
        /// </summary>
        [Description("All letter characters. This includes the Lu, Ll, Lt, Lm, and Lo characters.")]
        AllLetterCharacters,

        /// <summary>
        /// All numbers. This includes the Nd, Nl, and No categories.
        /// </summary>
        [Description("All numbers. This includes the Nd, Nl, and No categories.")]
        AllNumbers,

        /// <summary>
        /// All punctuation characters. This includes the Pc, Pd, Ps, Pe, Pi, Pf, and Po categories.
        /// </summary>
        [Description("All punctuation characters. This includes the Pc, Pd, Ps, Pe, Pi, Pf, and Po categories.")]
        AllPunctuationCharacters,

        /// <summary>
        /// All separator characters. This includes the Zs, Zl, and Zp categories.
        /// </summary>
        [Description("All separator characters. This includes the Zs, Zl, and Zp categories.")]
        AllSeparatorCharacters,

        /// <summary>
        /// All symbols. This includes the Sm, Sc, Sk, and So categories.
        /// </summary>
        [Description("All symbols. This includes the Sm, Sc, Sk, and So categories.")]
        AllSymbols,

        /// <summary>
        /// Letter, Lowercase
        /// </summary>
        [Description("Letter, Lowercase")]
        LetterLowercase,

        /// <summary>
        /// Letter, Modifier
        /// </summary>
        [Description("Letter, Modifier")]
        LetterModifier,

        /// <summary>
        /// Letter, Other
        /// </summary>
        [Description("Letter, Other")]
        LetterOther,

        /// <summary>
        /// Letter, Titlecase
        /// </summary>
        [Description("Letter, Titlecase")]
        LetterTitlecase,

        /// <summary>
        /// Letter, Uppercase
        /// </summary>
        [Description("Letter, Uppercase")]
        LetterUppercase,

        /// <summary>
        /// Mark, Enclosing
        /// </summary>
        [Description("Mark, Enclosing")]
        MarkEnclosing,

        /// <summary>
        /// Mark, Nonspacing
        /// </summary>
        [Description("Mark, Nonspacing")]
        MarkNonspacing,

        /// <summary>
        /// Mark, Spacing Combining
        /// </summary>
        [Description("Mark, Spacing Combining")]
        MarkSpacingCombining,

        /// <summary>
        /// Number, Decimal Digit
        /// </summary>
        [Description("Number, Decimal Digit")]
        NumberDecimalDigit,

        /// <summary>
        /// Number, Letter
        /// </summary>
        [Description("Number, Letter")]
        NumberLetter,

        /// <summary>
        /// Number, Other
        /// </summary>
        [Description("Number, Other")]
        NumberOther,

        /// <summary>
        /// Other, Control
        /// </summary>
        [Description("Other, Control")]
        OtherControl,

        /// <summary>
        /// Other, Format
        /// </summary>
        [Description("Other, Format")]
        OtherFormat,

        /// <summary>
        /// Other, Not Assigned (no characters have this property)
        /// </summary>
        [Description("Other, Not Assigned (no characters have this property)")]
        OtherNotAssigned,

        /// <summary>
        /// Other, Private Use
        /// </summary>
        [Description("Other, Private Use")]
        OtherPrivateUse,

        /// <summary>
        /// Other, Surrogate
        /// </summary>
        [Description("Other, Surrogate")]
        OtherSurrogate,

        /// <summary>
        /// Punctuation, Close
        /// </summary>
        [Description("Punctuation, Close")]
        PunctuationClose,

        /// <summary>
        /// Punctuation, Connector
        /// </summary>
        [Description("Punctuation, Connector")]
        PunctuationConnector,

        /// <summary>
        /// Punctuation, Dash
        /// </summary>
        [Description("Punctuation, Dash")]
        PunctuationDash,

        /// <summary>
        /// Punctuation, Final quote (may behave like Ps or Pe depending on usage)
        /// </summary>
        [Description("Punctuation, Final quote (may behave like Ps or Pe depending on usage)")]
        PunctuationFinalQuote,

        /// <summary>
        /// Punctuation, Initial quote (may behave like Ps or Pe depending on usage)
        /// </summary>
        [Description("Punctuation, Initial quote (may behave like Ps or Pe depending on usage)")]
        PunctuationInitialQuote,

        /// <summary>
        /// Punctuation, Open
        /// </summary>
        [Description("Punctuation, Open")]
        PunctuationOpen,

        /// <summary>
        /// Punctuation, Other
        /// </summary>
        [Description("Punctuation, Other")]
        PunctuationOther,

        /// <summary>
        /// Separator, Line
        /// </summary>
        [Description("Separator, Line")]
        SeparatorLine,

        /// <summary>
        /// Separator, Paragraph
        /// </summary>
        [Description("Separator, Paragraph")]
        SeparatorParagraph,

        /// <summary>
        /// Separator, Space
        /// </summary>
        [Description("Separator, Space")]
        SeparatorSpace,

        /// <summary>
        /// Symbol, Currency
        /// </summary>
        [Description("Symbol, Currency")]
        SymbolCurrency,

        /// <summary>
        /// Symbol, Math
        /// </summary>
        [Description("Symbol, Math")]
        SymbolMath,

        /// <summary>
        /// Symbol, Modifier
        /// </summary>
        [Description("Symbol, Modifier")]
        SymbolModifier,

        /// <summary>
        /// Symbol, Other
        /// </summary>
        [Description("Symbol, Other")]
        SymbolOther,
    }
}
