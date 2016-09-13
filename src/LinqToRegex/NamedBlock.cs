// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Specifies the Unicode named block. The set of supported named blocks is based on Unicode 4.0.
    /// </summary>
    public enum NamedBlock
    {
        /// <summary>
        /// Pattern is \p{IsAlphabeticPresentationForms}, code point range is FB00 - FB4F.
        /// </summary>
        AlphabeticPresentationForms,

        /// <summary>
        /// Pattern is \p{IsArabic}, code point range is 0600 - 06FF.
        /// </summary>
        Arabic,

        /// <summary>
        /// Pattern is \p{IsArabicPresentationForms-A}, code point range is FB50 - FDFF.
        /// </summary>
        ArabicPresentationFormsA,

        /// <summary>
        /// Pattern is \p{IsArabicPresentationForms-B}, code point range is FE70 - FEFF.
        /// </summary>
        ArabicPresentationFormsB,

        /// <summary>
        /// Pattern is \p{IsArmenian}, code point range is 0530 - 058F.
        /// </summary>
        Armenian,

        /// <summary>
        /// Pattern is \p{IsArrows}, code point range is 2190 - 21FF.
        /// </summary>
        Arrows,

        /// <summary>
        /// Pattern is \p{IsBasicLatin}, code point range is 0000 - 007F.
        /// </summary>
        BasicLatin,

        /// <summary>
        /// Pattern is \p{IsBengali}, code point range is 0980 - 09FF.
        /// </summary>
        Bengali,

        /// <summary>
        /// Pattern is \p{IsBlockElements}, code point range is 2580 - 259F.
        /// </summary>
        BlockElements,

        /// <summary>
        /// Pattern is \p{IsBopomofo}, code point range is 3100 - 312F.
        /// </summary>
        Bopomofo,

        /// <summary>
        /// Pattern is \p{IsBopomofoExtended}, code point range is 31A0 - 31BF.
        /// </summary>
        BopomofoExtended,

        /// <summary>
        /// Pattern is \p{IsBoxDrawing}, code point range is 2500 - 257F.
        /// </summary>
        BoxDrawing,

        /// <summary>
        /// Pattern is \p{IsBraillePatterns}, code point range is 2800 - 28FF.
        /// </summary>
        BraillePatterns,

        /// <summary>
        /// Pattern is \p{IsBuhid}, code point range is 1740 - 175F.
        /// </summary>
        Buhid,

        /// <summary>
        /// Pattern is \p{IsCJKCompatibility}, code point range is 3300 - 33FF.
        /// </summary>
        CJKCompatibility,

        /// <summary>
        /// Pattern is \p{IsCJKCompatibilityForms}, code point range is FE30 - FE4F.
        /// </summary>
        CJKCompatibilityForms,

        /// <summary>
        /// Pattern is \p{IsCJKCompatibilityIdeographs}, code point range is F900 - FAFF.
        /// </summary>
        CJKCompatibilityIdeographs,

        /// <summary>
        /// Pattern is \p{IsCJKRadicalsSupplement}, code point range is 2E80 - 2EFF.
        /// </summary>
        CJKRadicalsSupplement,

        /// <summary>
        /// Pattern is \p{IsCJKSymbolsandPunctuation}, code point range is 3000 - 303F.
        /// </summary>
        CJKSymbolsAndPunctuation,

        /// <summary>
        /// Pattern is \p{IsCJKUnifiedIdeographs}, code point range is 4E00 - 9FFF.
        /// </summary>
        CJKUnifiedIdeographs,

        /// <summary>
        /// Pattern is \p{IsCJKUnifiedIdeographsExtensionA}, code point range is 3400 - 4DBF.
        /// </summary>
        CJKUnifiedIdeographsExtensionA,

        /// <summary>
        /// Pattern is \p{IsCombiningDiacriticalMarks}, code point range is 0300 - 036F.
        /// </summary>
        CombiningDiacriticalMarks,

        /// <summary>
        /// Pattern is \p{IsCombiningDiacriticalMarksforSymbols}, code point range is 20D0 - 20FF.
        /// </summary>
        CombiningDiacriticalMarksForSymbols,

        /// <summary>
        /// Pattern is \p{IsCombiningHalfMarks}, code point range is FE20 - FE2F.
        /// </summary>
        CombiningHalfMarks,

        /// <summary>
        /// Pattern is \p{IsCombiningMarksforSymbols}, code point range is 20D0 - 20FF.
        /// </summary>
        CombiningMarksForSymbols,

        /// <summary>
        /// Pattern is \p{IsControlPictures}, code point range is 2400 - 243F.
        /// </summary>
        ControlPictures,

        /// <summary>
        /// Pattern is \p{IsCurrencySymbols}, code point range is 20A0 - 20CF.
        /// </summary>
        CurrencySymbols,

        /// <summary>
        /// Pattern is \p{IsCyrillic}, code point range is 0400 - 04FF.
        /// </summary>
        Cyrillic,

        /// <summary>
        /// Pattern is \p{IsCyrillicSupplement}, code point range is 0500 - 052F.
        /// </summary>
        CyrillicSupplement,

        /// <summary>
        /// Pattern is \p{IsDevanagari}, code point range is 0900 - 097F.
        /// </summary>
        Devanagari,

        /// <summary>
        /// Pattern is \p{IsDingbats}, code point range is 2700 - 27BF.
        /// </summary>
        Dingbats,

        /// <summary>
        /// Pattern is \p{IsEnclosedAlphanumerics}, code point range is 2460 - 24FF.
        /// </summary>
        EnclosedAlphanumerics,

        /// <summary>
        /// Pattern is \p{IsEnclosedCJKLettersandMonths}, code point range is 3200 - 32FF.
        /// </summary>
        EnclosedCJKLettersAndMonths,

        /// <summary>
        /// Pattern is \p{IsEthiopic}, code point range is 1200 - 137F.
        /// </summary>
        Ethiopic,

        /// <summary>
        /// Pattern is \p{IsGeneralPunctuation}, code point range is 2000 - 206F.
        /// </summary>
        GeneralPunctuation,

        /// <summary>
        /// Pattern is \p{IsGeometricShapes}, code point range is 25A0 - 25FF.
        /// </summary>
        GeometricShapes,

        /// <summary>
        /// Pattern is \p{IsGeorgian}, code point range is 10A0 - 10FF.
        /// </summary>
        Georgian,

        /// <summary>
        /// Pattern is \p{IsGreek}, code point range is 0370 - 03FF.
        /// </summary>
        Greek,

        /// <summary>
        /// Pattern is \p{IsGreekandCoptic}, code point range is 0370 - 03FF.
        /// </summary>
        GreekAndCoptic,

        /// <summary>
        /// Pattern is \p{IsGreekExtended}, code point range is 1F00 - 1FFF.
        /// </summary>
        GreekExtended,

        /// <summary>
        /// Pattern is \p{IsGujarati}, code point range is 0A80 - 0AFF.
        /// </summary>
        Gujarati,

        /// <summary>
        /// Pattern is \p{IsGurmukhi}, code point range is 0A00 - 0A7F.
        /// </summary>
        Gurmukhi,

        /// <summary>
        /// Pattern is \p{IsHalfwidthandFullwidthForms}, code point range is FF00 - FFEF.
        /// </summary>
        HalfWidthAndFullWidthForms,

        /// <summary>
        /// Pattern is \p{IsHangulCompatibilityJamo}, code point range is 3130 - 318F.
        /// </summary>
        HangulCompatibilityJamo,

        /// <summary>
        /// Pattern is \p{IsHangulJamo}, code point range is 1100 - 11FF.
        /// </summary>
        HangulJamo,

        /// <summary>
        /// Pattern is \p{IsHangulSyllables}, code point range is AC00 - D7AF.
        /// </summary>
        HangulSyllables,

        /// <summary>
        /// Pattern is \p{IsHanunoo}, code point range is 1720 - 173F.
        /// </summary>
        Hanunoo,

        /// <summary>
        /// Pattern is \p{IsHebrew}, code point range is 0590 - 05FF.
        /// </summary>
        Hebrew,

        /// <summary>
        /// Pattern is \p{IsHighPrivateUseSurrogates}, code point range is DB80 - DBFF.
        /// </summary>
        HighPrivateUseSurrogates,

        /// <summary>
        /// Pattern is \p{IsHighSurrogates}, code point range is D800 - DB7F.
        /// </summary>
        HighSurrogates,

        /// <summary>
        /// Pattern is \p{IsHiragana}, code point range is 3040 - 309F.
        /// </summary>
        Hiragana,

        /// <summary>
        /// Pattern is \p{IsCherokee}, code point range is 13A0 - 13FF.
        /// </summary>
        Cherokee,

        /// <summary>
        /// Pattern is \p{IsIdeographicDescriptionCharacters}, code point range is 2FF0 - 2FFF.
        /// </summary>
        IdeographicDescriptionCharacters,

        /// <summary>
        /// Pattern is \p{IsIPAExtensions}, code point range is 0250 - 02AF.
        /// </summary>
        IPAExtensions,

        /// <summary>
        /// Pattern is \p{IsKanbun}, code point range is 3190 - 319F.
        /// </summary>
        Kanbun,

        /// <summary>
        /// Pattern is \p{IsKangxiRadicals}, code point range is 2F00 - 2FDF.
        /// </summary>
        KangxiRadicals,

        /// <summary>
        /// Pattern is \p{IsKannada}, code point range is 0C80 - 0CFF.
        /// </summary>
        Kannada,

        /// <summary>
        /// Pattern is \p{IsKatakana}, code point range is 30A0 - 30FF.
        /// </summary>
        Katakana,

        /// <summary>
        /// Pattern is \p{IsKatakanaPhoneticExtensions}, code point range is 31F0 - 31FF.
        /// </summary>
        KatakanaPhoneticExtensions,

        /// <summary>
        /// Pattern is \p{IsKhmer}, code point range is 1780 - 17FF.
        /// </summary>
        Khmer,

        /// <summary>
        /// Pattern is \p{IsKhmerSymbols}, code point range is 19E0 - 19FF.
        /// </summary>
        KhmerSymbols,

        /// <summary>
        /// Pattern is \p{IsLao}, code point range is 0E80 - 0EFF.
        /// </summary>
        Lao,

        /// <summary>
        /// Pattern is \p{IsLatin-1Supplement}, code point range is 0080 - 00FF.
        /// </summary>
        Latin1Supplement,

        /// <summary>
        /// Pattern is \p{IsLatinExtended-A}, code point range is 0100 - 017F.
        /// </summary>
        LatinExtendedA,

        /// <summary>
        /// Pattern is \p{IsLatinExtendedAdditional}, code point range is 1E00 - 1EFF.
        /// </summary>
        LatinExtendedAdditional,

        /// <summary>
        /// Pattern is \p{IsLatinExtended-B}, code point range is 0180 - 024F.
        /// </summary>
        LatinExtendedB,

        /// <summary>
        /// Pattern is \p{IsLetterlikeSymbols}, code point range is 2100 - 214F.
        /// </summary>
        LetterLikeSymbols,

        /// <summary>
        /// Pattern is \p{IsLimbu}, code point range is 1900 - 194F.
        /// </summary>
        Limbu,

        /// <summary>
        /// Pattern is \p{IsLowSurrogates}, code point range is DC00 - DFFF.
        /// </summary>
        LowSurrogates,

        /// <summary>
        /// Pattern is \p{IsMalayalam}, code point range is 0D00 - 0D7F.
        /// </summary>
        Malayalam,

        /// <summary>
        /// Pattern is \p{IsMathematicalOperators}, code point range is 2200 - 22FF.
        /// </summary>
        MathematicalOperators,

        /// <summary>
        /// Pattern is \p{IsMiscellaneousMathematicalSymbols-A}, code point range is 27C0 - 27EF.
        /// </summary>
        MiscellaneousMathematicalSymbolsA,

        /// <summary>
        /// Pattern is \p{IsMiscellaneousMathematicalSymbols-B}, code point range is 2980 - 29FF.
        /// </summary>
        MiscellaneousMathematicalSymbolsB,

        /// <summary>
        /// Pattern is \p{IsMiscellaneousSymbols}, code point range is 2600 - 26FF.
        /// </summary>
        MiscellaneousSymbols,

        /// <summary>
        /// Pattern is \p{IsMiscellaneousSymbolsandArrows}, code point range is 2B00 - 2BFF.
        /// </summary>
        MiscellaneousSymbolsAndArrows,

        /// <summary>
        /// Pattern is \p{IsMiscellaneousTechnical}, code point range is 2300 - 23FF.
        /// </summary>
        MiscellaneousTechnical,

        /// <summary>
        /// Pattern is \p{IsMongolian}, code point range is 1800 - 18AF.
        /// </summary>
        Mongolian,

        /// <summary>
        /// Pattern is \p{IsMyanmar}, code point range is 1000 - 109F.
        /// </summary>
        Myanmar,

        /// <summary>
        /// Pattern is \p{IsNumberForms}, code point range is 2150 - 218F.
        /// </summary>
        NumberForms,

        /// <summary>
        /// Pattern is \p{IsOgham}, code point range is 1680 - 169F.
        /// </summary>
        Ogham,

        /// <summary>
        /// Pattern is \p{IsOpticalCharacterRecognition}, code point range is 2440 - 245F.
        /// </summary>
        OpticalCharacterRecognition,

        /// <summary>
        /// Pattern is \p{IsOriya}, code point range is 0B00 - 0B7F.
        /// </summary>
        Oriya,

        /// <summary>
        /// Pattern is \p{IsPhoneticExtensions}, code point range is 1D00 - 1D7F.
        /// </summary>
        PhoneticExtensions,

        /// <summary>
        /// Pattern is \p{IsPrivateUse}, code point range is E000 - F8FF.
        /// </summary>
        PrivateUse,

        /// <summary>
        /// Pattern is \p{IsPrivateUseArea}, code point range is E000 - F8FF.
        /// </summary>
        PrivateUseArea,

        /// <summary>
        /// Pattern is \p{IsRunic}, code point range is 16A0 - 16FF.
        /// </summary>
        Runic,

        /// <summary>
        /// Pattern is \p{IsSinhala}, code point range is 0D80 - 0DFF.
        /// </summary>
        Sinhala,

        /// <summary>
        /// Pattern is \p{IsSmallFormVariants}, code point range is FE50 - FE6F.
        /// </summary>
        SmallFormVariants,

        /// <summary>
        /// Pattern is \p{IsSpacingModifierLetters}, code point range is 02B0 - 02FF.
        /// </summary>
        SpacingModifierLetters,

        /// <summary>
        /// Pattern is \p{IsSpecials}, code point range is FFF0 - FFFF.
        /// </summary>
        Specials,

        /// <summary>
        /// Pattern is \p{IsSuperscriptsandSubscripts}, code point range is 2070 - 209F.
        /// </summary>
        SuperscriptsAndSubscripts,

        /// <summary>
        /// Pattern is \p{IsSupplementalArrows-A}, code point range is 27F0 - 27FF.
        /// </summary>
        SupplementalArrowsA,

        /// <summary>
        /// Pattern is \p{IsSupplementalArrows-B}, code point range is 2900 - 297F.
        /// </summary>
        SupplementalArrowsB,

        /// <summary>
        /// Pattern is \p{IsSupplementalMathematicalOperators}, code point range is 2A00 - 2AFF.
        /// </summary>
        SupplementalMathematicalOperators,

        /// <summary>
        /// Pattern is \p{IsSyriac}, code point range is 0700 - 074F.
        /// </summary>
        Syriac,

        /// <summary>
        /// Pattern is \p{IsTagalog}, code point range is 1700 - 171F.
        /// </summary>
        Tagalog,

        /// <summary>
        /// Pattern is \p{IsTagbanwa}, code point range is 1760 - 177F.
        /// </summary>
        Tagbanwa,

        /// <summary>
        /// Pattern is \p{IsTaiLe}, code point range is 1950 - 197F.
        /// </summary>
        TaiLe,

        /// <summary>
        /// Pattern is \p{IsTamil}, code point range is 0B80 - 0BFF.
        /// </summary>
        Tamil,

        /// <summary>
        /// Pattern is \p{IsTelugu}, code point range is 0C00 - 0C7F.
        /// </summary>
        Telugu,

        /// <summary>
        /// Pattern is \p{IsThaana}, code point range is 0780 - 07BF.
        /// </summary>
        Thaana,

        /// <summary>
        /// Pattern is \p{IsThai}, code point range is 0E00 - 0E7F.
        /// </summary>
        Thai,

        /// <summary>
        /// Pattern is \p{IsTibetan}, code point range is 0F00 - 0FFF.
        /// </summary>
        Tibetan,

        /// <summary>
        /// Pattern is \p{IsUnifiedCanadianAboriginalSyllabics}, code point range is 1400 - 167F.
        /// </summary>
        UnifiedCanadianAboriginalSyllabics,

        /// <summary>
        /// Pattern is \p{IsVariationSelectors}, code point range is FE00 - FE0F.
        /// </summary>
        VariationSelectors,

        /// <summary>
        /// Pattern is \p{IsYijingHexagramSymbols}, code point range is 4DC0 - 4DFF.
        /// </summary>
        YijingHexagramSymbols,

        /// <summary>
        /// Pattern is \p{IsYiRadicals}, code point range is A490 - A4CF.
        /// </summary>
        YiRadicals,

        /// <summary>
        /// Pattern is \p{IsYiSyllables}, code point range is A000 - A48F.
        /// </summary>
        YiSyllables,
    }
}
