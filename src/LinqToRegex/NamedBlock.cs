// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq;

/// <summary>
/// Specifies the Unicode named block. The set of supported named blocks is based on Unicode 4.0.
/// </summary>
public enum NamedBlock
{
    /// <summary>
    /// Pattern is \p{IsAlphabeticPresentationForms}, code point range is FB00 - FB4F.
    /// </summary>
    AlphabeticPresentationForms = 0,

    /// <summary>
    /// Pattern is \p{IsArabic}, code point range is 0600 - 06FF.
    /// </summary>
    Arabic = 1,

    /// <summary>
    /// Pattern is \p{IsArabicPresentationForms-A}, code point range is FB50 - FDFF.
    /// </summary>
    ArabicPresentationFormsA = 2,

    /// <summary>
    /// Pattern is \p{IsArabicPresentationForms-B}, code point range is FE70 - FEFF.
    /// </summary>
    ArabicPresentationFormsB = 3,

    /// <summary>
    /// Pattern is \p{IsArmenian}, code point range is 0530 - 058F.
    /// </summary>
    Armenian = 4,

    /// <summary>
    /// Pattern is \p{IsArrows}, code point range is 2190 - 21FF.
    /// </summary>
    Arrows = 5,

    /// <summary>
    /// Pattern is \p{IsBasicLatin}, code point range is 0000 - 007F.
    /// </summary>
    BasicLatin = 6,

    /// <summary>
    /// Pattern is \p{IsBengali}, code point range is 0980 - 09FF.
    /// </summary>
    Bengali = 7,

    /// <summary>
    /// Pattern is \p{IsBlockElements}, code point range is 2580 - 259F.
    /// </summary>
    BlockElements = 8,

    /// <summary>
    /// Pattern is \p{IsBopomofo}, code point range is 3100 - 312F.
    /// </summary>
    Bopomofo = 9,

    /// <summary>
    /// Pattern is \p{IsBopomofoExtended}, code point range is 31A0 - 31BF.
    /// </summary>
    BopomofoExtended = 10,

    /// <summary>
    /// Pattern is \p{IsBoxDrawing}, code point range is 2500 - 257F.
    /// </summary>
    BoxDrawing = 11,

    /// <summary>
    /// Pattern is \p{IsBraillePatterns}, code point range is 2800 - 28FF.
    /// </summary>
    BraillePatterns = 12,

    /// <summary>
    /// Pattern is \p{IsBuhid}, code point range is 1740 - 175F.
    /// </summary>
    Buhid = 13,

    /// <summary>
    /// Pattern is \p{IsCJKCompatibility}, code point range is 3300 - 33FF.
    /// </summary>
    CJKCompatibility = 14,

    /// <summary>
    /// Pattern is \p{IsCJKCompatibilityForms}, code point range is FE30 - FE4F.
    /// </summary>
    CJKCompatibilityForms = 15,

    /// <summary>
    /// Pattern is \p{IsCJKCompatibilityIdeographs}, code point range is F900 - FAFF.
    /// </summary>
    CJKCompatibilityIdeographs = 16,

    /// <summary>
    /// Pattern is \p{IsCJKRadicalsSupplement}, code point range is 2E80 - 2EFF.
    /// </summary>
    CJKRadicalsSupplement = 17,

    /// <summary>
    /// Pattern is \p{IsCJKSymbolsandPunctuation}, code point range is 3000 - 303F.
    /// </summary>
    CJKSymbolsAndPunctuation = 18,

    /// <summary>
    /// Pattern is \p{IsCJKUnifiedIdeographs}, code point range is 4E00 - 9FFF.
    /// </summary>
    CJKUnifiedIdeographs = 19,

    /// <summary>
    /// Pattern is \p{IsCJKUnifiedIdeographsExtensionA}, code point range is 3400 - 4DBF.
    /// </summary>
    CJKUnifiedIdeographsExtensionA = 20,

    /// <summary>
    /// Pattern is \p{IsCombiningDiacriticalMarks}, code point range is 0300 - 036F.
    /// </summary>
    CombiningDiacriticalMarks = 21,

    /// <summary>
    /// Pattern is \p{IsCombiningDiacriticalMarksforSymbols}, code point range is 20D0 - 20FF.
    /// </summary>
    CombiningDiacriticalMarksForSymbols = 22,

    /// <summary>
    /// Pattern is \p{IsCombiningHalfMarks}, code point range is FE20 - FE2F.
    /// </summary>
    CombiningHalfMarks = 23,

    /// <summary>
    /// Pattern is \p{IsCombiningMarksforSymbols}, code point range is 20D0 - 20FF.
    /// </summary>
    CombiningMarksForSymbols = 24,

    /// <summary>
    /// Pattern is \p{IsControlPictures}, code point range is 2400 - 243F.
    /// </summary>
    ControlPictures = 25,

    /// <summary>
    /// Pattern is \p{IsCurrencySymbols}, code point range is 20A0 - 20CF.
    /// </summary>
    CurrencySymbols = 26,

    /// <summary>
    /// Pattern is \p{IsCyrillic}, code point range is 0400 - 04FF.
    /// </summary>
    Cyrillic = 27,

    /// <summary>
    /// Pattern is \p{IsCyrillicSupplement}, code point range is 0500 - 052F.
    /// </summary>
    CyrillicSupplement = 28,

    /// <summary>
    /// Pattern is \p{IsDevanagari}, code point range is 0900 - 097F.
    /// </summary>
    Devanagari = 29,

    /// <summary>
    /// Pattern is \p{IsDingbats}, code point range is 2700 - 27BF.
    /// </summary>
    Dingbats = 30,

    /// <summary>
    /// Pattern is \p{IsEnclosedAlphanumerics}, code point range is 2460 - 24FF.
    /// </summary>
    EnclosedAlphanumerics = 31,

    /// <summary>
    /// Pattern is \p{IsEnclosedCJKLettersandMonths}, code point range is 3200 - 32FF.
    /// </summary>
    EnclosedCJKLettersAndMonths = 32,

    /// <summary>
    /// Pattern is \p{IsEthiopic}, code point range is 1200 - 137F.
    /// </summary>
    Ethiopic = 33,

    /// <summary>
    /// Pattern is \p{IsGeneralPunctuation}, code point range is 2000 - 206F.
    /// </summary>
    GeneralPunctuation = 34,

    /// <summary>
    /// Pattern is \p{IsGeometricShapes}, code point range is 25A0 - 25FF.
    /// </summary>
    GeometricShapes = 35,

    /// <summary>
    /// Pattern is \p{IsGeorgian}, code point range is 10A0 - 10FF.
    /// </summary>
    Georgian = 36,

    /// <summary>
    /// Pattern is \p{IsGreek}, code point range is 0370 - 03FF.
    /// </summary>
    Greek = 37,

    /// <summary>
    /// Pattern is \p{IsGreekandCoptic}, code point range is 0370 - 03FF.
    /// </summary>
    GreekAndCoptic = 38,

    /// <summary>
    /// Pattern is \p{IsGreekExtended}, code point range is 1F00 - 1FFF.
    /// </summary>
    GreekExtended = 39,

    /// <summary>
    /// Pattern is \p{IsGujarati}, code point range is 0A80 - 0AFF.
    /// </summary>
    Gujarati = 40,

    /// <summary>
    /// Pattern is \p{IsGurmukhi}, code point range is 0A00 - 0A7F.
    /// </summary>
    Gurmukhi = 41,

    /// <summary>
    /// Pattern is \p{IsHalfwidthandFullwidthForms}, code point range is FF00 - FFEF.
    /// </summary>
    HalfWidthAndFullWidthForms = 42,

    /// <summary>
    /// Pattern is \p{IsHangulCompatibilityJamo}, code point range is 3130 - 318F.
    /// </summary>
    HangulCompatibilityJamo = 43,

    /// <summary>
    /// Pattern is \p{IsHangulJamo}, code point range is 1100 - 11FF.
    /// </summary>
    HangulJamo = 44,

    /// <summary>
    /// Pattern is \p{IsHangulSyllables}, code point range is AC00 - D7AF.
    /// </summary>
    HangulSyllables = 45,

    /// <summary>
    /// Pattern is \p{IsHanunoo}, code point range is 1720 - 173F.
    /// </summary>
    Hanunoo = 46,

    /// <summary>
    /// Pattern is \p{IsHebrew}, code point range is 0590 - 05FF.
    /// </summary>
    Hebrew = 47,

    /// <summary>
    /// Pattern is \p{IsHighPrivateUseSurrogates}, code point range is DB80 - DBFF.
    /// </summary>
    HighPrivateUseSurrogates = 48,

    /// <summary>
    /// Pattern is \p{IsHighSurrogates}, code point range is D800 - DB7F.
    /// </summary>
    HighSurrogates = 49,

    /// <summary>
    /// Pattern is \p{IsHiragana}, code point range is 3040 - 309F.
    /// </summary>
    Hiragana = 50,

    /// <summary>
    /// Pattern is \p{IsCherokee}, code point range is 13A0 - 13FF.
    /// </summary>
    Cherokee = 51,

    /// <summary>
    /// Pattern is \p{IsIdeographicDescriptionCharacters}, code point range is 2FF0 - 2FFF.
    /// </summary>
    IdeographicDescriptionCharacters = 52,

    /// <summary>
    /// Pattern is \p{IsIPAExtensions}, code point range is 0250 - 02AF.
    /// </summary>
    IPAExtensions = 53,

    /// <summary>
    /// Pattern is \p{IsKanbun}, code point range is 3190 - 319F.
    /// </summary>
    Kanbun = 54,

    /// <summary>
    /// Pattern is \p{IsKangxiRadicals}, code point range is 2F00 - 2FDF.
    /// </summary>
    KangxiRadicals = 55,

    /// <summary>
    /// Pattern is \p{IsKannada}, code point range is 0C80 - 0CFF.
    /// </summary>
    Kannada = 56,

    /// <summary>
    /// Pattern is \p{IsKatakana}, code point range is 30A0 - 30FF.
    /// </summary>
    Katakana = 57,

    /// <summary>
    /// Pattern is \p{IsKatakanaPhoneticExtensions}, code point range is 31F0 - 31FF.
    /// </summary>
    KatakanaPhoneticExtensions = 58,

    /// <summary>
    /// Pattern is \p{IsKhmer}, code point range is 1780 - 17FF.
    /// </summary>
    Khmer = 59,

    /// <summary>
    /// Pattern is \p{IsKhmerSymbols}, code point range is 19E0 - 19FF.
    /// </summary>
    KhmerSymbols = 60,

    /// <summary>
    /// Pattern is \p{IsLao}, code point range is 0E80 - 0EFF.
    /// </summary>
    Lao = 61,

    /// <summary>
    /// Pattern is \p{IsLatin-1Supplement}, code point range is 0080 - 00FF.
    /// </summary>
    Latin1Supplement = 62,

    /// <summary>
    /// Pattern is \p{IsLatinExtended-A}, code point range is 0100 - 017F.
    /// </summary>
    LatinExtendedA = 63,

    /// <summary>
    /// Pattern is \p{IsLatinExtendedAdditional}, code point range is 1E00 - 1EFF.
    /// </summary>
    LatinExtendedAdditional = 64,

    /// <summary>
    /// Pattern is \p{IsLatinExtended-B}, code point range is 0180 - 024F.
    /// </summary>
    LatinExtendedB = 65,

    /// <summary>
    /// Pattern is \p{IsLetterlikeSymbols}, code point range is 2100 - 214F.
    /// </summary>
    LetterLikeSymbols = 66,

    /// <summary>
    /// Pattern is \p{IsLimbu}, code point range is 1900 - 194F.
    /// </summary>
    Limbu = 67,

    /// <summary>
    /// Pattern is \p{IsLowSurrogates}, code point range is DC00 - DFFF.
    /// </summary>
    LowSurrogates = 68,

    /// <summary>
    /// Pattern is \p{IsMalayalam}, code point range is 0D00 - 0D7F.
    /// </summary>
    Malayalam = 69,

    /// <summary>
    /// Pattern is \p{IsMathematicalOperators}, code point range is 2200 - 22FF.
    /// </summary>
    MathematicalOperators = 70,

    /// <summary>
    /// Pattern is \p{IsMiscellaneousMathematicalSymbols-A}, code point range is 27C0 - 27EF.
    /// </summary>
    MiscellaneousMathematicalSymbolsA = 71,

    /// <summary>
    /// Pattern is \p{IsMiscellaneousMathematicalSymbols-B}, code point range is 2980 - 29FF.
    /// </summary>
    MiscellaneousMathematicalSymbolsB = 72,

    /// <summary>
    /// Pattern is \p{IsMiscellaneousSymbols}, code point range is 2600 - 26FF.
    /// </summary>
    MiscellaneousSymbols = 73,

    /// <summary>
    /// Pattern is \p{IsMiscellaneousSymbolsandArrows}, code point range is 2B00 - 2BFF.
    /// </summary>
    MiscellaneousSymbolsAndArrows = 74,

    /// <summary>
    /// Pattern is \p{IsMiscellaneousTechnical}, code point range is 2300 - 23FF.
    /// </summary>
    MiscellaneousTechnical = 75,

    /// <summary>
    /// Pattern is \p{IsMongolian}, code point range is 1800 - 18AF.
    /// </summary>
    Mongolian = 76,

    /// <summary>
    /// Pattern is \p{IsMyanmar}, code point range is 1000 - 109F.
    /// </summary>
    Myanmar = 77,

    /// <summary>
    /// Pattern is \p{IsNumberForms}, code point range is 2150 - 218F.
    /// </summary>
    NumberForms = 78,

    /// <summary>
    /// Pattern is \p{IsOgham}, code point range is 1680 - 169F.
    /// </summary>
    Ogham = 79,

    /// <summary>
    /// Pattern is \p{IsOpticalCharacterRecognition}, code point range is 2440 - 245F.
    /// </summary>
    OpticalCharacterRecognition = 80,

    /// <summary>
    /// Pattern is \p{IsOriya}, code point range is 0B00 - 0B7F.
    /// </summary>
    Oriya = 81,

    /// <summary>
    /// Pattern is \p{IsPhoneticExtensions}, code point range is 1D00 - 1D7F.
    /// </summary>
    PhoneticExtensions = 82,

    /// <summary>
    /// Pattern is \p{IsPrivateUse}, code point range is E000 - F8FF.
    /// </summary>
    PrivateUse = 83,

    /// <summary>
    /// Pattern is \p{IsPrivateUseArea}, code point range is E000 - F8FF.
    /// </summary>
    PrivateUseArea = 84,

    /// <summary>
    /// Pattern is \p{IsRunic}, code point range is 16A0 - 16FF.
    /// </summary>
    Runic = 85,

    /// <summary>
    /// Pattern is \p{IsSinhala}, code point range is 0D80 - 0DFF.
    /// </summary>
    Sinhala = 86,

    /// <summary>
    /// Pattern is \p{IsSmallFormVariants}, code point range is FE50 - FE6F.
    /// </summary>
    SmallFormVariants = 87,

    /// <summary>
    /// Pattern is \p{IsSpacingModifierLetters}, code point range is 02B0 - 02FF.
    /// </summary>
    SpacingModifierLetters = 88,

    /// <summary>
    /// Pattern is \p{IsSpecials}, code point range is FFF0 - FFFF.
    /// </summary>
    Specials = 89,

    /// <summary>
    /// Pattern is \p{IsSuperscriptsandSubscripts}, code point range is 2070 - 209F.
    /// </summary>
    SuperscriptsAndSubscripts = 90,

    /// <summary>
    /// Pattern is \p{IsSupplementalArrows-A}, code point range is 27F0 - 27FF.
    /// </summary>
    SupplementalArrowsA = 91,

    /// <summary>
    /// Pattern is \p{IsSupplementalArrows-B}, code point range is 2900 - 297F.
    /// </summary>
    SupplementalArrowsB = 92,

    /// <summary>
    /// Pattern is \p{IsSupplementalMathematicalOperators}, code point range is 2A00 - 2AFF.
    /// </summary>
    SupplementalMathematicalOperators = 93,

    /// <summary>
    /// Pattern is \p{IsSyriac}, code point range is 0700 - 074F.
    /// </summary>
    Syriac = 94,

    /// <summary>
    /// Pattern is \p{IsTagalog}, code point range is 1700 - 171F.
    /// </summary>
    Tagalog = 95,

    /// <summary>
    /// Pattern is \p{IsTagbanwa}, code point range is 1760 - 177F.
    /// </summary>
    Tagbanwa = 96,

    /// <summary>
    /// Pattern is \p{IsTaiLe}, code point range is 1950 - 197F.
    /// </summary>
    TaiLe = 97,

    /// <summary>
    /// Pattern is \p{IsTamil}, code point range is 0B80 - 0BFF.
    /// </summary>
    Tamil = 98,

    /// <summary>
    /// Pattern is \p{IsTelugu}, code point range is 0C00 - 0C7F.
    /// </summary>
    Telugu = 99,

    /// <summary>
    /// Pattern is \p{IsThaana}, code point range is 0780 - 07BF.
    /// </summary>
    Thaana = 100,

    /// <summary>
    /// Pattern is \p{IsThai}, code point range is 0E00 - 0E7F.
    /// </summary>
    Thai = 101,

    /// <summary>
    /// Pattern is \p{IsTibetan}, code point range is 0F00 - 0FFF.
    /// </summary>
    Tibetan = 102,

    /// <summary>
    /// Pattern is \p{IsUnifiedCanadianAboriginalSyllabics}, code point range is 1400 - 167F.
    /// </summary>
    UnifiedCanadianAboriginalSyllabics = 103,

    /// <summary>
    /// Pattern is \p{IsVariationSelectors}, code point range is FE00 - FE0F.
    /// </summary>
    VariationSelectors = 104,

    /// <summary>
    /// Pattern is \p{IsYijingHexagramSymbols}, code point range is 4DC0 - 4DFF.
    /// </summary>
    YijingHexagramSymbols = 105,

    /// <summary>
    /// Pattern is \p{IsYiRadicals}, code point range is A490 - A4CF.
    /// </summary>
    YiRadicals = 106,

    /// <summary>
    /// Pattern is \p{IsYiSyllables}, code point range is A000 - A48F.
    /// </summary>
    YiSyllables = 107,
}
