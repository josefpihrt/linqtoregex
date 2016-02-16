// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;

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
        [Display(Description = "FB00 - FB4F")]
        AlphabeticPresentationForms,

        /// <summary>
        /// Pattern is \p{IsArabic}, code point range is 0600 - 06FF.
        /// </summary>
        [Display(Description = "0600 - 06FF")]
        Arabic,

        /// <summary>
        /// Pattern is \p{IsArabicPresentationForms-A}, code point range is FB50 - FDFF.
        /// </summary>
        [Display(Description = "FB50 - FDFF")]
        ArabicPresentationFormsA,

        /// <summary>
        /// Pattern is \p{IsArabicPresentationForms-B}, code point range is FE70 - FEFF.
        /// </summary>
        [Display(Description = "FE70 - FEFF")]
        ArabicPresentationFormsB,

        /// <summary>
        /// Pattern is \p{IsArmenian}, code point range is 0530 - 058F.
        /// </summary>
        [Display(Description = "0530 - 058F")]
        Armenian,

        /// <summary>
        /// Pattern is \p{IsArrows}, code point range is 2190 - 21FF.
        /// </summary>
        [Display(Description = "2190 - 21FF")]
        Arrows,

        /// <summary>
        /// Pattern is \p{IsBasicLatin}, code point range is 0000 - 007F.
        /// </summary>
        [Display(Description = "0000 - 007F")]
        BasicLatin,

        /// <summary>
        /// Pattern is \p{IsBengali}, code point range is 0980 - 09FF.
        /// </summary>
        [Display(Description = "0980 - 09FF")]
        Bengali,

        /// <summary>
        /// Pattern is \p{IsBlockElements}, code point range is 2580 - 259F.
        /// </summary>
        [Display(Description = "2580 - 259F")]
        BlockElements,

        /// <summary>
        /// Pattern is \p{IsBopomofo}, code point range is 3100 - 312F.
        /// </summary>
        [Display(Description = "3100 - 312F")]
        Bopomofo,

        /// <summary>
        /// Pattern is \p{IsBopomofoExtended}, code point range is 31A0 - 31BF.
        /// </summary>
        [Display(Description = "31A0 - 31BF")]
        BopomofoExtended,

        /// <summary>
        /// Pattern is \p{IsBoxDrawing}, code point range is 2500 - 257F.
        /// </summary>
        [Display(Description = "2500 - 257F")]
        BoxDrawing,

        /// <summary>
        /// Pattern is \p{IsBraillePatterns}, code point range is 2800 - 28FF.
        /// </summary>
        [Display(Description = "2800 - 28FF")]
        BraillePatterns,

        /// <summary>
        /// Pattern is \p{IsBuhid}, code point range is 1740 - 175F.
        /// </summary>
        [Display(Description = "1740 - 175F")]
        Buhid,

        /// <summary>
        /// Pattern is \p{IsCJKCompatibility}, code point range is 3300 - 33FF.
        /// </summary>
        [Display(Description = "3300 - 33FF")]
        CJKCompatibility,

        /// <summary>
        /// Pattern is \p{IsCJKCompatibilityForms}, code point range is FE30 - FE4F.
        /// </summary>
        [Display(Description = "FE30 - FE4F")]
        CJKCompatibilityForms,

        /// <summary>
        /// Pattern is \p{IsCJKCompatibilityIdeographs}, code point range is F900 - FAFF.
        /// </summary>
        [Display(Description = "F900 - FAFF")]
        CJKCompatibilityIdeographs,

        /// <summary>
        /// Pattern is \p{IsCJKRadicalsSupplement}, code point range is 2E80 - 2EFF.
        /// </summary>
        [Display(Description = "2E80 - 2EFF")]
        CJKRadicalsSupplement,

        /// <summary>
        /// Pattern is \p{IsCJKSymbolsandPunctuation}, code point range is 3000 - 303F.
        /// </summary>
        [Display(Description = "3000 - 303F")]
        CJKSymbolsAndPunctuation,

        /// <summary>
        /// Pattern is \p{IsCJKUnifiedIdeographs}, code point range is 4E00 - 9FFF.
        /// </summary>
        [Display(Description = "4E00 - 9FFF")]
        CJKUnifiedIdeographs,

        /// <summary>
        /// Pattern is \p{IsCJKUnifiedIdeographsExtensionA}, code point range is 3400 - 4DBF.
        /// </summary>
        [Display(Description = "3400 - 4DBF")]
        CJKUnifiedIdeographsExtensionA,

        /// <summary>
        /// Pattern is \p{IsCombiningDiacriticalMarks}, code point range is 0300 - 036F.
        /// </summary>
        [Display(Description = "0300 - 036F")]
        CombiningDiacriticalMarks,

        /// <summary>
        /// Pattern is \p{IsCombiningDiacriticalMarksforSymbols}, code point range is 20D0 - 20FF.
        /// </summary>
        [Display(Description = "20D0 - 20FF")]
        CombiningDiacriticalMarksForSymbols,

        /// <summary>
        /// Pattern is \p{IsCombiningHalfMarks}, code point range is FE20 - FE2F.
        /// </summary>
        [Display(Description = "FE20 - FE2F")]
        CombiningHalfMarks,

        /// <summary>
        /// Pattern is \p{IsCombiningMarksforSymbols}, code point range is 20D0 - 20FF.
        /// </summary>
        [Display(Description = "20D0 - 20FF")]
        CombiningMarksForSymbols,

        /// <summary>
        /// Pattern is \p{IsControlPictures}, code point range is 2400 - 243F.
        /// </summary>
        [Display(Description = "2400 - 243F")]
        ControlPictures,

        /// <summary>
        /// Pattern is \p{IsCurrencySymbols}, code point range is 20A0 - 20CF.
        /// </summary>
        [Display(Description = "20A0 - 20CF")]
        CurrencySymbols,

        /// <summary>
        /// Pattern is \p{IsCyrillic}, code point range is 0400 - 04FF.
        /// </summary>
        [Display(Description = "0400 - 04FF")]
        Cyrillic,

        /// <summary>
        /// Pattern is \p{IsCyrillicSupplement}, code point range is 0500 - 052F.
        /// </summary>
        [Display(Description = "0500 - 052F")]
        CyrillicSupplement,

        /// <summary>
        /// Pattern is \p{IsDevanagari}, code point range is 0900 - 097F.
        /// </summary>
        [Display(Description = "0900 - 097F")]
        Devanagari,

        /// <summary>
        /// Pattern is \p{IsDingbats}, code point range is 2700 - 27BF.
        /// </summary>
        [Display(Description = "2700 - 27BF")]
        Dingbats,

        /// <summary>
        /// Pattern is \p{IsEnclosedAlphanumerics}, code point range is 2460 - 24FF.
        /// </summary>
        [Display(Description = "2460 - 24FF")]
        EnclosedAlphanumerics,

        /// <summary>
        /// Pattern is \p{IsEnclosedCJKLettersandMonths}, code point range is 3200 - 32FF.
        /// </summary>
        [Display(Description = "3200 - 32FF")]
        EnclosedCJKLettersAndMonths,

        /// <summary>
        /// Pattern is \p{IsEthiopic}, code point range is 1200 - 137F.
        /// </summary>
        [Display(Description = "1200 - 137F")]
        Ethiopic,

        /// <summary>
        /// Pattern is \p{IsGeneralPunctuation}, code point range is 2000 - 206F.
        /// </summary>
        [Display(Description = "2000 - 206F")]
        GeneralPunctuation,

        /// <summary>
        /// Pattern is \p{IsGeometricShapes}, code point range is 25A0 - 25FF.
        /// </summary>
        [Display(Description = "25A0 - 25FF")]
        GeometricShapes,

        /// <summary>
        /// Pattern is \p{IsGeorgian}, code point range is 10A0 - 10FF.
        /// </summary>
        [Display(Description = "10A0 - 10FF")]
        Georgian,

        /// <summary>
        /// Pattern is \p{IsGreek}, code point range is 0370 - 03FF.
        /// </summary>
        [Display(Description = "0370 - 03FF")]
        Greek,

        /// <summary>
        /// Pattern is \p{IsGreekandCoptic}, code point range is 0370 - 03FF.
        /// </summary>
        [Display(Description = "0370 - 03FF")]
        GreekAndCoptic,

        /// <summary>
        /// Pattern is \p{IsGreekExtended}, code point range is 1F00 - 1FFF.
        /// </summary>
        [Display(Description = "1F00 - 1FFF")]
        GreekExtended,

        /// <summary>
        /// Pattern is \p{IsGujarati}, code point range is 0A80 - 0AFF.
        /// </summary>
        [Display(Description = "0A80 - 0AFF")]
        Gujarati,

        /// <summary>
        /// Pattern is \p{IsGurmukhi}, code point range is 0A00 - 0A7F.
        /// </summary>
        [Display(Description = "0A00 - 0A7F")]
        Gurmukhi,

        /// <summary>
        /// Pattern is \p{IsHalfwidthandFullwidthForms}, code point range is FF00 - FFEF.
        /// </summary>
        [Display(Description = "FF00 - FFEF")]
        HalfWidthAndFullWidthForms,

        /// <summary>
        /// Pattern is \p{IsHangulCompatibilityJamo}, code point range is 3130 - 318F.
        /// </summary>
        [Display(Description = "3130 - 318F")]
        HangulCompatibilityJamo,

        /// <summary>
        /// Pattern is \p{IsHangulJamo}, code point range is 1100 - 11FF.
        /// </summary>
        [Display(Description = "1100 - 11FF")]
        HangulJamo,

        /// <summary>
        /// Pattern is \p{IsHangulSyllables}, code point range is AC00 - D7AF.
        /// </summary>
        [Display(Description = "AC00 - D7AF")]
        HangulSyllables,

        /// <summary>
        /// Pattern is \p{IsHanunoo}, code point range is 1720 - 173F.
        /// </summary>
        [Display(Description = "1720 - 173F")]
        Hanunoo,

        /// <summary>
        /// Pattern is \p{IsHebrew}, code point range is 0590 - 05FF.
        /// </summary>
        [Display(Description = "0590 - 05FF")]
        Hebrew,

        /// <summary>
        /// Pattern is \p{IsHighPrivateUseSurrogates}, code point range is DB80 - DBFF.
        /// </summary>
        [Display(Description = "DB80 - DBFF")]
        HighPrivateUseSurrogates,

        /// <summary>
        /// Pattern is \p{IsHighSurrogates}, code point range is D800 - DB7F.
        /// </summary>
        [Display(Description = "D800 - DB7F")]
        HighSurrogates,

        /// <summary>
        /// Pattern is \p{IsHiragana}, code point range is 3040 - 309F.
        /// </summary>
        [Display(Description = "3040 - 309F")]
        Hiragana,

        /// <summary>
        /// Pattern is \p{IsCherokee}, code point range is 13A0 - 13FF.
        /// </summary>
        [Display(Description = "13A0 - 13FF")]
        Cherokee,

        /// <summary>
        /// Pattern is \p{IsIdeographicDescriptionCharacters}, code point range is 2FF0 - 2FFF.
        /// </summary>
        [Display(Description = "2FF0 - 2FFF")]
        IdeographicDescriptionCharacters,

        /// <summary>
        /// Pattern is \p{IsIPAExtensions}, code point range is 0250 - 02AF.
        /// </summary>
        [Display(Description = "0250 - 02AF")]
        IPAExtensions,

        /// <summary>
        /// Pattern is \p{IsKanbun}, code point range is 3190 - 319F.
        /// </summary>
        [Display(Description = "3190 - 319F")]
        Kanbun,

        /// <summary>
        /// Pattern is \p{IsKangxiRadicals}, code point range is 2F00 - 2FDF.
        /// </summary>
        [Display(Description = "2F00 - 2FDF")]
        KangxiRadicals,

        /// <summary>
        /// Pattern is \p{IsKannada}, code point range is 0C80 - 0CFF.
        /// </summary>
        [Display(Description = "0C80 - 0CFF")]
        Kannada,

        /// <summary>
        /// Pattern is \p{IsKatakana}, code point range is 30A0 - 30FF.
        /// </summary>
        [Display(Description = "30A0 - 30FF")]
        Katakana,

        /// <summary>
        /// Pattern is \p{IsKatakanaPhoneticExtensions}, code point range is 31F0 - 31FF.
        /// </summary>
        [Display(Description = "31F0 - 31FF")]
        KatakanaPhoneticExtensions,

        /// <summary>
        /// Pattern is \p{IsKhmer}, code point range is 1780 - 17FF.
        /// </summary>
        [Display(Description = "1780 - 17FF")]
        Khmer,

        /// <summary>
        /// Pattern is \p{IsKhmerSymbols}, code point range is 19E0 - 19FF.
        /// </summary>
        [Display(Description = "19E0 - 19FF")]
        KhmerSymbols,

        /// <summary>
        /// Pattern is \p{IsLao}, code point range is 0E80 - 0EFF.
        /// </summary>
        [Display(Description = "0E80 - 0EFF")]
        Lao,

        /// <summary>
        /// Pattern is \p{IsLatin-1Supplement}, code point range is 0080 - 00FF.
        /// </summary>
        [Display(Description = "0080 - 00FF")]
        Latin1Supplement,

        /// <summary>
        /// Pattern is \p{IsLatinExtended-A}, code point range is 0100 - 017F.
        /// </summary>
        [Display(Description = "0100 - 017F")]
        LatinExtendedA,

        /// <summary>
        /// Pattern is \p{IsLatinExtendedAdditional}, code point range is 1E00 - 1EFF.
        /// </summary>
        [Display(Description = "1E00 - 1EFF")]
        LatinExtendedAdditional,

        /// <summary>
        /// Pattern is \p{IsLatinExtended-B}, code point range is 0180 - 024F.
        /// </summary>
        [Display(Description = "0180 - 024F")]
        LatinExtendedB,

        /// <summary>
        /// Pattern is \p{IsLetterlikeSymbols}, code point range is 2100 - 214F.
        /// </summary>
        [Display(Description = "2100 - 214F")]
        LetterLikeSymbols,

        /// <summary>
        /// Pattern is \p{IsLimbu}, code point range is 1900 - 194F.
        /// </summary>
        [Display(Description = "1900 - 194F")]
        Limbu,

        /// <summary>
        /// Pattern is \p{IsLowSurrogates}, code point range is DC00 - DFFF.
        /// </summary>
        [Display(Description = "DC00 - DFFF")]
        LowSurrogates,

        /// <summary>
        /// Pattern is \p{IsMalayalam}, code point range is 0D00 - 0D7F.
        /// </summary>
        [Display(Description = "0D00 - 0D7F")]
        Malayalam,

        /// <summary>
        /// Pattern is \p{IsMathematicalOperators}, code point range is 2200 - 22FF.
        /// </summary>
        [Display(Description = "2200 - 22FF")]
        MathematicalOperators,

        /// <summary>
        /// Pattern is \p{IsMiscellaneousMathematicalSymbols-A}, code point range is 27C0 - 27EF.
        /// </summary>
        [Display(Description = "27C0 - 27EF")]
        MiscellaneousMathematicalSymbolsA,

        /// <summary>
        /// Pattern is \p{IsMiscellaneousMathematicalSymbols-B}, code point range is 2980 - 29FF.
        /// </summary>
        [Display(Description = "2980 - 29FF")]
        MiscellaneousMathematicalSymbolsB,

        /// <summary>
        /// Pattern is \p{IsMiscellaneousSymbols}, code point range is 2600 - 26FF.
        /// </summary>
        [Display(Description = "2600 - 26FF")]
        MiscellaneousSymbols,

        /// <summary>
        /// Pattern is \p{IsMiscellaneousSymbolsandArrows}, code point range is 2B00 - 2BFF.
        /// </summary>
        [Display(Description = "2B00 - 2BFF")]
        MiscellaneousSymbolsAndArrows,

        /// <summary>
        /// Pattern is \p{IsMiscellaneousTechnical}, code point range is 2300 - 23FF.
        /// </summary>
        [Display(Description = "2300 - 23FF")]
        MiscellaneousTechnical,

        /// <summary>
        /// Pattern is \p{IsMongolian}, code point range is 1800 - 18AF.
        /// </summary>
        [Display(Description = "1800 - 18AF")]
        Mongolian,

        /// <summary>
        /// Pattern is \p{IsMyanmar}, code point range is 1000 - 109F.
        /// </summary>
        [Display(Description = "1000 - 109F")]
        Myanmar,

        /// <summary>
        /// Pattern is \p{IsNumberForms}, code point range is 2150 - 218F.
        /// </summary>
        [Display(Description = "2150 - 218F")]
        NumberForms,

        /// <summary>
        /// Pattern is \p{IsOgham}, code point range is 1680 - 169F.
        /// </summary>
        [Display(Description = "1680 - 169F")]
        Ogham,

        /// <summary>
        /// Pattern is \p{IsOpticalCharacterRecognition}, code point range is 2440 - 245F.
        /// </summary>
        [Display(Description = "2440 - 245F")]
        OpticalCharacterRecognition,

        /// <summary>
        /// Pattern is \p{IsOriya}, code point range is 0B00 - 0B7F.
        /// </summary>
        [Display(Description = "0B00 - 0B7F")]
        Oriya,

        /// <summary>
        /// Pattern is \p{IsPhoneticExtensions}, code point range is 1D00 - 1D7F.
        /// </summary>
        [Display(Description = "1D00 - 1D7F")]
        PhoneticExtensions,

        /// <summary>
        /// Pattern is \p{IsPrivateUse}, code point range is E000 - F8FF.
        /// </summary>
        [Display(Description = "E000 - F8FF")]
        PrivateUse,

        /// <summary>
        /// Pattern is \p{IsPrivateUseArea}, code point range is E000 - F8FF.
        /// </summary>
        [Display(Description = "E000 - F8FF")]
        PrivateUseArea,

        /// <summary>
        /// Pattern is \p{IsRunic}, code point range is 16A0 - 16FF.
        /// </summary>
        [Display(Description = "16A0 - 16FF")]
        Runic,

        /// <summary>
        /// Pattern is \p{IsSinhala}, code point range is 0D80 - 0DFF.
        /// </summary>
        [Display(Description = "0D80 - 0DFF")]
        Sinhala,

        /// <summary>
        /// Pattern is \p{IsSmallFormVariants}, code point range is FE50 - FE6F.
        /// </summary>
        [Display(Description = "FE50 - FE6F")]
        SmallFormVariants,

        /// <summary>
        /// Pattern is \p{IsSpacingModifierLetters}, code point range is 02B0 - 02FF.
        /// </summary>
        [Display(Description = "02B0 - 02FF")]
        SpacingModifierLetters,

        /// <summary>
        /// Pattern is \p{IsSpecials}, code point range is FFF0 - FFFF.
        /// </summary>
        [Display(Description = "FFF0 - FFFF")]
        Specials,

        /// <summary>
        /// Pattern is \p{IsSuperscriptsandSubscripts}, code point range is 2070 - 209F.
        /// </summary>
        [Display(Description = "2070 - 209F")]
        SuperscriptsAndSubscripts,

        /// <summary>
        /// Pattern is \p{IsSupplementalArrows-A}, code point range is 27F0 - 27FF.
        /// </summary>
        [Display(Description = "27F0 - 27FF")]
        SupplementalArrowsA,

        /// <summary>
        /// Pattern is \p{IsSupplementalArrows-B}, code point range is 2900 - 297F.
        /// </summary>
        [Display(Description = "2900 - 297F")]
        SupplementalArrowsB,

        /// <summary>
        /// Pattern is \p{IsSupplementalMathematicalOperators}, code point range is 2A00 - 2AFF.
        /// </summary>
        [Display(Description = "2A00 - 2AFF")]
        SupplementalMathematicalOperators,

        /// <summary>
        /// Pattern is \p{IsSyriac}, code point range is 0700 - 074F.
        /// </summary>
        [Display(Description = "0700 - 074F")]
        Syriac,

        /// <summary>
        /// Pattern is \p{IsTagalog}, code point range is 1700 - 171F.
        /// </summary>
        [Display(Description = "1700 - 171F")]
        Tagalog,

        /// <summary>
        /// Pattern is \p{IsTagbanwa}, code point range is 1760 - 177F.
        /// </summary>
        [Display(Description = "1760 - 177F")]
        Tagbanwa,

        /// <summary>
        /// Pattern is \p{IsTaiLe}, code point range is 1950 - 197F.
        /// </summary>
        [Display(Description = "1950 - 197F")]
        TaiLe,

        /// <summary>
        /// Pattern is \p{IsTamil}, code point range is 0B80 - 0BFF.
        /// </summary>
        [Display(Description = "0B80 - 0BFF")]
        Tamil,

        /// <summary>
        /// Pattern is \p{IsTelugu}, code point range is 0C00 - 0C7F.
        /// </summary>
        [Display(Description = "0C00 - 0C7F")]
        Telugu,

        /// <summary>
        /// Pattern is \p{IsThaana}, code point range is 0780 - 07BF.
        /// </summary>
        [Display(Description = "0780 - 07BF")]
        Thaana,

        /// <summary>
        /// Pattern is \p{IsThai}, code point range is 0E00 - 0E7F.
        /// </summary>
        [Display(Description = "0E00 - 0E7F")]
        Thai,

        /// <summary>
        /// Pattern is \p{IsTibetan}, code point range is 0F00 - 0FFF.
        /// </summary>
        [Display(Description = "0F00 - 0FFF")]
        Tibetan,

        /// <summary>
        /// Pattern is \p{IsUnifiedCanadianAboriginalSyllabics}, code point range is 1400 - 167F.
        /// </summary>
        [Display(Description = "1400 - 167F")]
        UnifiedCanadianAboriginalSyllabics,

        /// <summary>
        /// Pattern is \p{IsVariationSelectors}, code point range is FE00 - FE0F.
        /// </summary>
        [Display(Description = "FE00 - FE0F")]
        VariationSelectors,

        /// <summary>
        /// Pattern is \p{IsYijingHexagramSymbols}, code point range is 4DC0 - 4DFF.
        /// </summary>
        [Display(Description = "4DC0 - 4DFF")]
        YijingHexagramSymbols,

        /// <summary>
        /// Pattern is \p{IsYiRadicals}, code point range is A490 - A4CF.
        /// </summary>
        [Display(Description = "A490 - A4CF")]
        YiRadicals,

        /// <summary>
        /// Pattern is \p{IsYiSyllables}, code point range is A000 - A48F.
        /// </summary>
        [Display(Description = "A000 - A48F")]
        YiSyllables,
    }
}
