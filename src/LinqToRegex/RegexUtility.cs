// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using static Pihrtsoft.Text.RegularExpressions.Linq.Patterns;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Provides static methods for escaping and validating regular expressions elements.
    /// </summary>
    public static class RegexUtility
    {
        internal static readonly RegexOptions InlineOptions = RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.ExplicitCapture | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace;
        internal static Regex ValidGroupNameRegex;
        private static readonly object _randomLock = new object();
        private static Random _random;

        /// <summary>
        /// Gets a value indicating whether the specified group name is a valid name of a regex group.
        /// </summary>
        /// <param name="groupName">A group name to examine.</param>
        /// <returns></returns>
        public static bool IsValidGroupName(string groupName)
        {
            return IsValidGroupNameInternal(groupName);
        }

        internal static bool IsValidGroupNameInternal(string groupName)
        {
            if (!string.IsNullOrEmpty(groupName))
            {
                if (ValidGroupNameRegex == null)
                {
                    ValidGroupNameRegex = EntireInput(
                        Group(Range('1', '9') + MaybeMany(ArabicDigit())),
                        (WordChar() - ArabicDigit()) + WhileWordChar()
                    ).ToRegex();
                }

                Match match = ValidGroupNameRegex.Match(groupName);
                if (match.Success)
                {
                    Group g = match.Groups[1];
                    if (g.Success && g.Value.Length > 9)
                    {
                        int result;
                        return int.TryParse(g.Value, out result);
                    }

                    return true;
                }
            }

            return false;
        }

        internal static void CheckGroupName(string groupName)
        {
            CheckGroupName(groupName, nameof(groupName));
        }

        internal static void CheckGroupName(string groupName, string paramName)
        {
            if (groupName == null)
                throw new ArgumentNullException(paramName);

            if (!IsValidGroupNameInternal(groupName))
                throw new ArgumentException("Invalid group name.", paramName);
        }

        /// <summary>
        /// Gets a value indicating whether the <paramref name="options"/> can be expressed as inline char(s).
        /// </summary>
        /// <param name="options">A bitwise combination of the enumeration values.</param>
        /// <returns></returns>
        public static bool IsValidInlineOptions(RegexOptions options)
        {
            return (options & ~InlineOptions) == RegexOptions.None;
        }

        /// <summary>
        /// Converts a specified character to the <see cref="string"/> object that represents the character as a literal rather than a metacharacter.
        /// The character is considered not to be in the character group.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        /// <returns></returns>
        public static string Escape(char value)
        {
            return Escape(value, false);
        }

        /// <summary>
        /// Converts a specified character to the <see cref="string"/> object that represents the character as a literal rather than a metacharacter.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        /// <param name="inCharGroup">Indicates whether the character is considered to be inside or outside of the character group.</param>
        /// <returns></returns>
        public static string Escape(char value, bool inCharGroup)
        {
            return EscapeInternal((int)value, inCharGroup);
        }

        internal static string EscapeInternal(int charCode, bool inCharGroup)
        {
            switch (GetEscapeModeInternal(charCode, inCharGroup))
            {
                case CharEscapeMode.None:
                    return ((char)charCode).ToString();
                case CharEscapeMode.AsciiHexadecimal:
                    return Syntax.AsciiHexadecimalStart + charCode.ToString("X2", CultureInfo.InvariantCulture);
                case CharEscapeMode.Backslash:
                    return @"\" + ((char)charCode).ToString();
                case CharEscapeMode.Bell:
                    return Syntax.Bell;
                case CharEscapeMode.CarriageReturn:
                    return Syntax.CarriageReturn;
                case CharEscapeMode.Escape:
                    return Syntax.Escape;
                case CharEscapeMode.FormFeed:
                    return Syntax.FormFeed;
                case CharEscapeMode.Linefeed:
                    return Syntax.Linefeed;
                case CharEscapeMode.Tab:
                    return Syntax.Tab;
                case CharEscapeMode.VerticalTab:
                    return Syntax.VerticalTab;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Gets a value indicating how a specified character is represented in the regular expression pattern.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        /// <returns></returns>
        public static CharEscapeMode GetEscapeMode(char value)
        {
            return GetEscapeMode(value, false);
        }

        /// <summary>
        /// Gets a value indicating how a specified character is represented in the regular expression pattern, specifying whether the character is inside or outside of the character group.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        /// <param name="inCharGroup">Indicates whether the character is inside or outside of the character group.</param>
        /// <returns></returns>
        public static CharEscapeMode GetEscapeMode(char value, bool inCharGroup)
        {
            return GetEscapeMode((int)value, inCharGroup);
        }

        internal static CharEscapeMode GetEscapeMode(int charCode, bool inCharGroup)
        {
            if (charCode <= 0xFF)
            {
                return inCharGroup
                    ? _charGroupEscapeModes[charCode]
                    : _escapeModes[charCode];
            }

            return CharEscapeMode.None;
        }

        internal static CharEscapeMode GetEscapeModeInternal(int charCode, bool inCharGroup)
        {
            if (charCode <= 0xFF)
            {
                return inCharGroup
                    ? _charGroupEscapeModes[charCode]
                    : _escapeModes[charCode];
            }

            return CharEscapeMode.None;
        }

        /// <summary>
        /// Converts a specified text to the <see cref="string"/> object that represents each character as a literal rather than a metacharacter.
        /// The text is considered not to be in the character group.
        /// </summary>
        /// <param name="input">The text to be converted.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
        public static string Escape(string input)
        {
            return Escape(input, false);
        }

        /// <summary>
        /// Converts a specified input to the <see cref="string"/> object that represents each character as a literal rather than a metacharacter.
        /// </summary>
        /// <param name="input">The text to be converted.</param>
        /// <param name="inCharGroup">Indicates whether the text is considered to be inside or outside of the character group.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
        public static string Escape(string input, bool inCharGroup)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var mode = CharEscapeMode.None;

            for (int i = 0; i < input.Length; i++)
            {
                mode = GetEscapeModeInternal((int)input[i], inCharGroup);
                if (mode != CharEscapeMode.None)
                {
                    var sb = new StringBuilder();
                    char ch = input[i];
                    int lastPos;
                    sb.Append(input, 0, i);

                    do
                    {
                        switch (mode)
                        {
                            case CharEscapeMode.AsciiHexadecimal:
                                sb.Append(Syntax.AsciiHexadecimalStart);
                                sb.Append(((int)ch).ToString("X2", CultureInfo.InvariantCulture));
                                break;
                            case CharEscapeMode.Backslash:
                                sb.Append('\\');
                                sb.Append(ch);
                                break;
                            case CharEscapeMode.Bell:
                                sb.Append(Syntax.Bell);
                                break;
                            case CharEscapeMode.CarriageReturn:
                                sb.Append(Syntax.CarriageReturn);
                                break;
                            case CharEscapeMode.Escape:
                                sb.Append(Syntax.Escape);
                                break;
                            case CharEscapeMode.FormFeed:
                                sb.Append(Syntax.FormFeed);
                                break;
                            case CharEscapeMode.Linefeed:
                                sb.Append(Syntax.Linefeed);
                                break;
                            case CharEscapeMode.VerticalTab:
                                sb.Append(Syntax.VerticalTab);
                                break;
                            case CharEscapeMode.Tab:
                                sb.Append(Syntax.Tab);
                                break;
                        }

                        i++;
                        lastPos = i;

                        while (i < input.Length)
                        {
                            ch = input[i];
                            mode = GetEscapeModeInternal((int)input[i], inCharGroup);

                            if (mode != CharEscapeMode.None)
                                break;

                            i++;
                        }

                        sb.Append(input, lastPos, i - lastPos);
                    } while (i < input.Length);

                    return sb.ToString();
                }
            }

            return input;
        }

        /// <summary>
        /// Escapes all dollar signs by doubling them.
        /// </summary>
        /// <param name="input">The substitution pattern to be escaped.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
        public static string EscapeSubstitution(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '$')
                {
                    var sb = new StringBuilder();
                    EscapeSubstitution(input, i, sb);
                    return sb.ToString();
                }
            }

            return input;
        }

        internal static void EscapeSubstitution(string input, int i, StringBuilder sb)
        {
            char ch = input[i];
            int lastPos;
            sb.Append(input, 0, i);

            do
            {
                sb.Append("$$");
                i++;
                lastPos = i;

                while (i < input.Length)
                {
                    ch = input[i];

                    if (ch == '$')
                        break;

                    i++;
                }

                sb.Append(input, lastPos, i - lastPos);
            } while (i < input.Length);
        }

        /// <summary>
        /// Returns randomly generated group name.
        /// </summary>
        /// <returns></returns>
        public static string GetRandomGroupName()
        {
            return GetRandomGroupName(8);
        }

        /// <summary>
        /// Returns randomly generated group name with a specified length.
        /// </summary>
        /// <param name="length">Length of a group name.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="length"/> is less than one.</exception>
        public static string GetRandomGroupName(int length)
        {
            if (length < 1)
                throw new ArgumentOutOfRangeException(nameof(length));

            var sb = new StringBuilder(length);

            if (_random == null)
            {
                lock (_randomLock)
                {
                    if (_random == null)
                        _random = new Random();
                }
            }

            for (int i = 0; i < length; i++)
                sb.Append((char)_random.Next(97, 122));

            return sb.ToString();
        }

        /// <summary>
        /// Gets a designation of the specified Unicode category.
        /// </summary>
        /// <param name="category">An enumerated constant that identifies Unicode category.</param>
        /// <returns></returns>
        public static string GetCategoryDesignation(GeneralCategory category) => CategoryDesignations[(int)category];

        /// <summary>
        /// Gets a designation of the specified Unicode block.
        /// </summary>
        /// <param name="block">An enumerated constant that identifies Unicode block.</param>
        /// <returns></returns>
        public static string GetBlockDesignation(NamedBlock block) => BlockDesignations[(int)block];

        /// <summary>
        /// Gets a description of the specified Unicode category.
        /// </summary>
        /// <param name="category">An enumerated constant that identifies Unicode category.</param>
        /// <returns></returns>
        public static string GetCategoryDescription(GeneralCategory category)
        {
            switch (category)
            {
                case GeneralCategory.AllControlCharacters:
                    return "All control characters. This includes the Cc, Cf, Cs, Co, and Cn categories.";
                case GeneralCategory.AllDiacriticMarks:
                    return "All diacritic marks. This includes the Mn, Mc, and Me categories.";
                case GeneralCategory.AllLetterCharacters:
                    return "All letter characters. This includes the Lu, Ll, Lt, Lm, and Lo characters.";
                case GeneralCategory.AllNumbers:
                    return "All numbers. This includes the Nd, Nl, and No categories.";
                case GeneralCategory.AllPunctuationCharacters:
                    return "All punctuation characters. This includes the Pc, Pd, Ps, Pe, Pi, Pf, and Po categories.";
                case GeneralCategory.AllSeparatorCharacters:
                    return "All separator characters. This includes the Zs, Zl, and Zp categories.";
                case GeneralCategory.AllSymbols:
                    return "All symbols. This includes the Sm, Sc, Sk, and So categories.";
                case GeneralCategory.LetterLowercase:
                    return "Letter, Lowercase";
                case GeneralCategory.LetterModifier:
                    return "Letter, Modifier";
                case GeneralCategory.LetterOther:
                    return "Letter, Other";
                case GeneralCategory.LetterTitlecase:
                    return "Letter, Titlecase";
                case GeneralCategory.LetterUppercase:
                    return "Letter, Uppercase";
                case GeneralCategory.MarkEnclosing:
                    return "Mark, Enclosing";
                case GeneralCategory.MarkNonspacing:
                    return "Mark, Nonspacing";
                case GeneralCategory.MarkSpacingCombining:
                    return "Mark, Spacing Combining";
                case GeneralCategory.NumberDecimalDigit:
                    return "Number, Decimal Digit";
                case GeneralCategory.NumberLetter:
                    return "Number, Letter";
                case GeneralCategory.NumberOther:
                    return "Number, Other";
                case GeneralCategory.OtherControl:
                    return "Other, Control";
                case GeneralCategory.OtherFormat:
                    return "Other, Format";
                case GeneralCategory.OtherNotAssigned:
                    return "Other, Not Assigned (no characters have this property)";
                case GeneralCategory.OtherPrivateUse:
                    return "Other, Private Use";
                case GeneralCategory.OtherSurrogate:
                    return "Other, Surrogate";
                case GeneralCategory.PunctuationClose:
                    return "Punctuation, Close";
                case GeneralCategory.PunctuationConnector:
                    return "Punctuation, Connector";
                case GeneralCategory.PunctuationDash:
                    return "Punctuation, Dash";
                case GeneralCategory.PunctuationFinalQuote:
                    return "Punctuation, Final quote (may behave like Ps or Pe depending on usage)";
                case GeneralCategory.PunctuationInitialQuote:
                    return "Punctuation, Initial quote (may behave like Ps or Pe depending on usage)";
                case GeneralCategory.PunctuationOpen:
                    return "Punctuation, Open";
                case GeneralCategory.PunctuationOther:
                    return "Punctuation, Other";
                case GeneralCategory.SeparatorLine:
                    return "Separator, Line";
                case GeneralCategory.SeparatorParagraph:
                    return "Separator, Paragraph";
                case GeneralCategory.SeparatorSpace:
                    return "Separator, Space";
                case GeneralCategory.SymbolCurrency:
                    return "Symbol, Currency";
                case GeneralCategory.SymbolMath:
                    return "Symbol, Math";
                case GeneralCategory.SymbolModifier:
                    return "Symbol, Modifier";
                case GeneralCategory.SymbolOther:
                    return "Symbol, Other";
                default:
                    Debug.Assert(false, category.ToString());
                    return "";
            }
        }

        /// <summary>
        /// Gets a description of the specified Unicode block.
        /// </summary>
        /// <param name="block">An enumerated constant that identifies Unicode block.</param>
        /// <returns></returns>
        public static string GetBlockDescription(NamedBlock block)
        {
            switch (block)
            {
                case NamedBlock.AlphabeticPresentationForms:
                    return "FB00 - FB4F";
                case NamedBlock.Arabic:
                    return "0600 - 06FF";
                case NamedBlock.ArabicPresentationFormsA:
                    return "FB50 - FDFF";
                case NamedBlock.ArabicPresentationFormsB:
                    return "FE70 - FEFF";
                case NamedBlock.Armenian:
                    return "0530 - 058F";
                case NamedBlock.Arrows:
                    return "2190 - 21FF";
                case NamedBlock.BasicLatin:
                    return "0000 - 007F";
                case NamedBlock.Bengali:
                    return "0980 - 09FF";
                case NamedBlock.BlockElements:
                    return "2580 - 259F";
                case NamedBlock.Bopomofo:
                    return "3100 - 312F";
                case NamedBlock.BopomofoExtended:
                    return "31A0 - 31BF";
                case NamedBlock.BoxDrawing:
                    return "2500 - 257F";
                case NamedBlock.BraillePatterns:
                    return "2800 - 28FF";
                case NamedBlock.Buhid:
                    return "1740 - 175F";
                case NamedBlock.CJKCompatibility:
                    return "3300 - 33FF";
                case NamedBlock.CJKCompatibilityForms:
                    return "FE30 - FE4F";
                case NamedBlock.CJKCompatibilityIdeographs:
                    return "F900 - FAFF";
                case NamedBlock.CJKRadicalsSupplement:
                    return "2E80 - 2EFF";
                case NamedBlock.CJKSymbolsAndPunctuation:
                    return "3000 - 303F";
                case NamedBlock.CJKUnifiedIdeographs:
                    return "4E00 - 9FFF";
                case NamedBlock.CJKUnifiedIdeographsExtensionA:
                    return "3400 - 4DBF";
                case NamedBlock.CombiningDiacriticalMarks:
                    return "0300 - 036F";
                case NamedBlock.CombiningDiacriticalMarksForSymbols:
                    return "20D0 - 20FF";
                case NamedBlock.CombiningHalfMarks:
                    return "FE20 - FE2F";
                case NamedBlock.CombiningMarksForSymbols:
                    return "20D0 - 20FF";
                case NamedBlock.ControlPictures:
                    return "2400 - 243F";
                case NamedBlock.CurrencySymbols:
                    return "20A0 - 20CF";
                case NamedBlock.Cyrillic:
                    return "0400 - 04FF";
                case NamedBlock.CyrillicSupplement:
                    return "0500 - 052F";
                case NamedBlock.Devanagari:
                    return "0900 - 097F";
                case NamedBlock.Dingbats:
                    return "2700 - 27BF";
                case NamedBlock.EnclosedAlphanumerics:
                    return "2460 - 24FF";
                case NamedBlock.EnclosedCJKLettersAndMonths:
                    return "3200 - 32FF";
                case NamedBlock.Ethiopic:
                    return "1200 - 137F";
                case NamedBlock.GeneralPunctuation:
                    return "2000 - 206F";
                case NamedBlock.GeometricShapes:
                    return "25A0 - 25FF";
                case NamedBlock.Georgian:
                    return "10A0 - 10FF";
                case NamedBlock.Greek:
                    return "0370 - 03FF";
                case NamedBlock.GreekAndCoptic:
                    return "0370 - 03FF";
                case NamedBlock.GreekExtended:
                    return "1F00 - 1FFF";
                case NamedBlock.Gujarati:
                    return "0A80 - 0AFF";
                case NamedBlock.Gurmukhi:
                    return "0A00 - 0A7F";
                case NamedBlock.HalfWidthAndFullWidthForms:
                    return "FF00 - FFEF";
                case NamedBlock.HangulCompatibilityJamo:
                    return "3130 - 318F";
                case NamedBlock.HangulJamo:
                    return "1100 - 11FF";
                case NamedBlock.HangulSyllables:
                    return "AC00 - D7AF";
                case NamedBlock.Hanunoo:
                    return "1720 - 173F";
                case NamedBlock.Hebrew:
                    return "0590 - 05FF";
                case NamedBlock.HighPrivateUseSurrogates:
                    return "DB80 - DBFF";
                case NamedBlock.HighSurrogates:
                    return "D800 - DB7F";
                case NamedBlock.Hiragana:
                    return "3040 - 309F";
                case NamedBlock.Cherokee:
                    return "13A0 - 13FF";
                case NamedBlock.IdeographicDescriptionCharacters:
                    return "2FF0 - 2FFF";
                case NamedBlock.IPAExtensions:
                    return "0250 - 02AF";
                case NamedBlock.Kanbun:
                    return "3190 - 319F";
                case NamedBlock.KangxiRadicals:
                    return "2F00 - 2FDF";
                case NamedBlock.Kannada:
                    return "0C80 - 0CFF";
                case NamedBlock.Katakana:
                    return "30A0 - 30FF";
                case NamedBlock.KatakanaPhoneticExtensions:
                    return "31F0 - 31FF";
                case NamedBlock.Khmer:
                    return "1780 - 17FF";
                case NamedBlock.KhmerSymbols:
                    return "19E0 - 19FF";
                case NamedBlock.Lao:
                    return "0E80 - 0EFF";
                case NamedBlock.Latin1Supplement:
                    return "0080 - 00FF";
                case NamedBlock.LatinExtendedA:
                    return "0100 - 017F";
                case NamedBlock.LatinExtendedAdditional:
                    return "1E00 - 1EFF";
                case NamedBlock.LatinExtendedB:
                    return "0180 - 024F";
                case NamedBlock.LetterLikeSymbols:
                    return "2100 - 214F";
                case NamedBlock.Limbu:
                    return "1900 - 194F";
                case NamedBlock.LowSurrogates:
                    return "DC00 - DFFF";
                case NamedBlock.Malayalam:
                    return "0D00 - 0D7F";
                case NamedBlock.MathematicalOperators:
                    return "2200 - 22FF";
                case NamedBlock.MiscellaneousMathematicalSymbolsA:
                    return "27C0 - 27EF";
                case NamedBlock.MiscellaneousMathematicalSymbolsB:
                    return "2980 - 29FF";
                case NamedBlock.MiscellaneousSymbols:
                    return "2600 - 26FF";
                case NamedBlock.MiscellaneousSymbolsAndArrows:
                    return "2B00 - 2BFF";
                case NamedBlock.MiscellaneousTechnical:
                    return "2300 - 23FF";
                case NamedBlock.Mongolian:
                    return "1800 - 18AF";
                case NamedBlock.Myanmar:
                    return "1000 - 109F";
                case NamedBlock.NumberForms:
                    return "2150 - 218F";
                case NamedBlock.Ogham:
                    return "1680 - 169F";
                case NamedBlock.OpticalCharacterRecognition:
                    return "2440 - 245F";
                case NamedBlock.Oriya:
                    return "0B00 - 0B7F";
                case NamedBlock.PhoneticExtensions:
                    return "1D00 - 1D7F";
                case NamedBlock.PrivateUse:
                    return "E000 - F8FF";
                case NamedBlock.PrivateUseArea:
                    return "E000 - F8FF";
                case NamedBlock.Runic:
                    return "16A0 - 16FF";
                case NamedBlock.Sinhala:
                    return "0D80 - 0DFF";
                case NamedBlock.SmallFormVariants:
                    return "FE50 - FE6F";
                case NamedBlock.SpacingModifierLetters:
                    return "02B0 - 02FF";
                case NamedBlock.Specials:
                    return "FFF0 - FFFF";
                case NamedBlock.SuperscriptsAndSubscripts:
                    return "2070 - 209F";
                case NamedBlock.SupplementalArrowsA:
                    return "27F0 - 27FF";
                case NamedBlock.SupplementalArrowsB:
                    return "2900 - 297F";
                case NamedBlock.SupplementalMathematicalOperators:
                    return "2A00 - 2AFF";
                case NamedBlock.Syriac:
                    return "0700 - 074F";
                case NamedBlock.Tagalog:
                    return "1700 - 171F";
                case NamedBlock.Tagbanwa:
                    return "1760 - 177F";
                case NamedBlock.TaiLe:
                    return "1950 - 197F";
                case NamedBlock.Tamil:
                    return "0B80 - 0BFF";
                case NamedBlock.Telugu:
                    return "0C00 - 0C7F";
                case NamedBlock.Thaana:
                    return "0780 - 07BF";
                case NamedBlock.Thai:
                    return "0E00 - 0E7F";
                case NamedBlock.Tibetan:
                    return "0F00 - 0FFF";
                case NamedBlock.UnifiedCanadianAboriginalSyllabics:
                    return "1400 - 167F";
                case NamedBlock.VariationSelectors:
                    return "FE00 - FE0F";
                case NamedBlock.YijingHexagramSymbols:
                    return "4DC0 - 4DFF";
                case NamedBlock.YiRadicals:
                    return "A490 - A4CF";
                case NamedBlock.YiSyllables:
                    return "A000 - A48F";
                default:
                    Debug.Assert(false, block.ToString());
                    return "";
            }
        }

        private static readonly CharEscapeMode[] _escapeModes = new CharEscapeMode[] {
            // 0 0x00
            CharEscapeMode.AsciiHexadecimal,
            // 1 0x01
            CharEscapeMode.AsciiHexadecimal,
            // 2 0x02
            CharEscapeMode.AsciiHexadecimal,
            // 3 0x03
            CharEscapeMode.AsciiHexadecimal,
            // 4 0x04
            CharEscapeMode.AsciiHexadecimal,
            // 5 0x05
            CharEscapeMode.AsciiHexadecimal,
            // 6 0x06
            CharEscapeMode.AsciiHexadecimal,
            // 7 0x07
            CharEscapeMode.Bell,
            // 8 0x08
            CharEscapeMode.AsciiHexadecimal,
            // 9 0x09
            CharEscapeMode.Tab,
            // 10 0x0A
            CharEscapeMode.Linefeed,
            // 11 0x0B
            CharEscapeMode.VerticalTab,
            // 12 0x0C
            CharEscapeMode.FormFeed,
            // 13 0x0D
            CharEscapeMode.CarriageReturn,
            // 14 0x0E
            CharEscapeMode.AsciiHexadecimal,
            // 15 0x0F
            CharEscapeMode.AsciiHexadecimal,
            // 16 0x10
            CharEscapeMode.AsciiHexadecimal,
            // 17 0x11
            CharEscapeMode.AsciiHexadecimal,
            // 18 0x12
            CharEscapeMode.AsciiHexadecimal,
            // 19 0x13
            CharEscapeMode.AsciiHexadecimal,
            // 20 0x14
            CharEscapeMode.AsciiHexadecimal,
            // 21 0x15
            CharEscapeMode.AsciiHexadecimal,
            // 22 0x16
            CharEscapeMode.AsciiHexadecimal,
            // 23 0x17
            CharEscapeMode.AsciiHexadecimal,
            // 24 0x18
            CharEscapeMode.AsciiHexadecimal,
            // 25 0x19
            CharEscapeMode.AsciiHexadecimal,
            // 26 0x1A
            CharEscapeMode.AsciiHexadecimal,
            // 27 0x1B
            CharEscapeMode.Escape,
            // 28 0x1C
            CharEscapeMode.AsciiHexadecimal,
            // 29 0x1D
            CharEscapeMode.AsciiHexadecimal,
            // 30 0x1E
            CharEscapeMode.AsciiHexadecimal,
            // 31 0x1F
            CharEscapeMode.AsciiHexadecimal,
            // 32 0x20
            CharEscapeMode.Backslash,
            // 33 0x21 !
            CharEscapeMode.None,
            // 34 0x22 "
            CharEscapeMode.None,
            // 35 0x23 #
            CharEscapeMode.Backslash,
            // 36 0x24 $
            CharEscapeMode.Backslash,
            // 37 0x25 %
            CharEscapeMode.None,
            // 38 0x26 &
            CharEscapeMode.None,
            // 39 0x27 '
            CharEscapeMode.None,
            // 40 0x28 (
            CharEscapeMode.Backslash,
            // 41 0x29 )
            CharEscapeMode.Backslash,
            // 42 0x2A *
            CharEscapeMode.Backslash,
            // 43 0x2B +
            CharEscapeMode.Backslash,
            // 44 0x2C ,
            CharEscapeMode.None,
            // 45 0x2D -
            CharEscapeMode.None,
            // 46 0x2E .
            CharEscapeMode.Backslash,
            // 47 0x2F /
            CharEscapeMode.None,
            // 48 0x30 0
            CharEscapeMode.None,
            // 49 0x31 1
            CharEscapeMode.None,
            // 50 0x32 2
            CharEscapeMode.None,
            // 51 0x33 3
            CharEscapeMode.None,
            // 52 0x34 4
            CharEscapeMode.None,
            // 53 0x35 5
            CharEscapeMode.None,
            // 54 0x36 6
            CharEscapeMode.None,
            // 55 0x37 7
            CharEscapeMode.None,
            // 56 0x38 8
            CharEscapeMode.None,
            // 57 0x39 9
            CharEscapeMode.None,
            // 58 0x3A :
            CharEscapeMode.None,
            // 59 0x3B ;
            CharEscapeMode.None,
            // 60 0x3C <
            CharEscapeMode.None,
            // 61 0x3D =
            CharEscapeMode.None,
            // 62 0x3E >
            CharEscapeMode.None,
            // 63 0x3F ?
            CharEscapeMode.Backslash,
            // 64 0x40 @
            CharEscapeMode.None,
            // 65 0x41 A
            CharEscapeMode.None,
            // 66 0x42 B
            CharEscapeMode.None,
            // 67 0x43 C
            CharEscapeMode.None,
            // 68 0x44 D
            CharEscapeMode.None,
            // 69 0x45 E
            CharEscapeMode.None,
            // 70 0x46 F
            CharEscapeMode.None,
            // 71 0x47 G
            CharEscapeMode.None,
            // 72 0x48 H
            CharEscapeMode.None,
            // 73 0x49 I
            CharEscapeMode.None,
            // 74 0x4A J
            CharEscapeMode.None,
            // 75 0x4B K
            CharEscapeMode.None,
            // 76 0x4C L
            CharEscapeMode.None,
            // 77 0x4D M
            CharEscapeMode.None,
            // 78 0x4E N
            CharEscapeMode.None,
            // 79 0x4F O
            CharEscapeMode.None,
            // 80 0x50 P
            CharEscapeMode.None,
            // 81 0x51 Q
            CharEscapeMode.None,
            // 82 0x52 R
            CharEscapeMode.None,
            // 83 0x53 S
            CharEscapeMode.None,
            // 84 0x54 T
            CharEscapeMode.None,
            // 85 0x55 U
            CharEscapeMode.None,
            // 86 0x56 V
            CharEscapeMode.None,
            // 87 0x57 W
            CharEscapeMode.None,
            // 88 0x58 X
            CharEscapeMode.None,
            // 89 0x59 Y
            CharEscapeMode.None,
            // 90 0x5A Z
            CharEscapeMode.None,
            // 91 0x5B [
            CharEscapeMode.Backslash,
            // 92 0x5C \
            CharEscapeMode.Backslash,
            // 93 0x5D ]
            CharEscapeMode.None,
            // 94 0x5E ^
            CharEscapeMode.Backslash,
            // 95 0x5F _
            CharEscapeMode.None,
            // 96 0x60 `
            CharEscapeMode.None,
            // 97 0x61 a
            CharEscapeMode.None,
            // 98 0x62 b
            CharEscapeMode.None,
            // 99 0x63 c
            CharEscapeMode.None,
            // 100 0x64 d
            CharEscapeMode.None,
            // 101 0x65 e
            CharEscapeMode.None,
            // 102 0x66 f
            CharEscapeMode.None,
            // 103 0x67 g
            CharEscapeMode.None,
            // 104 0x68 h
            CharEscapeMode.None,
            // 105 0x69 i
            CharEscapeMode.None,
            // 106 0x6A j
            CharEscapeMode.None,
            // 107 0x6B k
            CharEscapeMode.None,
            // 108 0x6C l
            CharEscapeMode.None,
            // 109 0x6D m
            CharEscapeMode.None,
            // 110 0x6E n
            CharEscapeMode.None,
            // 111 0x6F o
            CharEscapeMode.None,
            // 112 0x70 p
            CharEscapeMode.None,
            // 113 0x71 q
            CharEscapeMode.None,
            // 114 0x72 r
            CharEscapeMode.None,
            // 115 0x73 s
            CharEscapeMode.None,
            // 116 0x74 t
            CharEscapeMode.None,
            // 117 0x75 u
            CharEscapeMode.None,
            // 118 0x76 v
            CharEscapeMode.None,
            // 119 0x77 w
            CharEscapeMode.None,
            // 120 0x78 x
            CharEscapeMode.None,
            // 121 0x79 y
            CharEscapeMode.None,
            // 122 0x7A z
            CharEscapeMode.None,
            // 123 0x7B {
            CharEscapeMode.Backslash,
            // 124 0x7C |
            CharEscapeMode.Backslash,
            // 125 0x7D }
            CharEscapeMode.None,
            // 126 0x7E ~
            CharEscapeMode.None,
            // 127 0x7F
            CharEscapeMode.AsciiHexadecimal,
            // 128 0x80
            CharEscapeMode.AsciiHexadecimal,
            // 129 0x81
            CharEscapeMode.AsciiHexadecimal,
            // 130 0x82
            CharEscapeMode.AsciiHexadecimal,
            // 131 0x83
            CharEscapeMode.AsciiHexadecimal,
            // 132 0x84
            CharEscapeMode.AsciiHexadecimal,
            // 133 0x85
            CharEscapeMode.AsciiHexadecimal,
            // 134 0x86
            CharEscapeMode.AsciiHexadecimal,
            // 135 0x87
            CharEscapeMode.AsciiHexadecimal,
            // 136 0x88
            CharEscapeMode.AsciiHexadecimal,
            // 137 0x89
            CharEscapeMode.AsciiHexadecimal,
            // 138 0x8A
            CharEscapeMode.AsciiHexadecimal,
            // 139 0x8B
            CharEscapeMode.AsciiHexadecimal,
            // 140 0x8C
            CharEscapeMode.AsciiHexadecimal,
            // 141 0x8D
            CharEscapeMode.AsciiHexadecimal,
            // 142 0x8E
            CharEscapeMode.AsciiHexadecimal,
            // 143 0x8F
            CharEscapeMode.AsciiHexadecimal,
            // 144 0x90
            CharEscapeMode.AsciiHexadecimal,
            // 145 0x91
            CharEscapeMode.AsciiHexadecimal,
            // 146 0x92
            CharEscapeMode.AsciiHexadecimal,
            // 147 0x93
            CharEscapeMode.AsciiHexadecimal,
            // 148 0x94
            CharEscapeMode.AsciiHexadecimal,
            // 149 0x95
            CharEscapeMode.AsciiHexadecimal,
            // 150 0x96
            CharEscapeMode.AsciiHexadecimal,
            // 151 0x97
            CharEscapeMode.AsciiHexadecimal,
            // 152 0x98
            CharEscapeMode.AsciiHexadecimal,
            // 153 0x99
            CharEscapeMode.AsciiHexadecimal,
            // 154 0x9A
            CharEscapeMode.AsciiHexadecimal,
            // 155 0x9B
            CharEscapeMode.AsciiHexadecimal,
            // 156 0x9C
            CharEscapeMode.AsciiHexadecimal,
            // 157 0x9D
            CharEscapeMode.AsciiHexadecimal,
            // 158 0x9E
            CharEscapeMode.AsciiHexadecimal,
            // 159 0x9F
            CharEscapeMode.AsciiHexadecimal,
            // 160 0xA0
            CharEscapeMode.None,
            // 161 0xA1 ¡
            CharEscapeMode.None,
            // 162 0xA2 ¢
            CharEscapeMode.None,
            // 163 0xA3 £
            CharEscapeMode.None,
            // 164 0xA4 ¤
            CharEscapeMode.None,
            // 165 0xA5 ¥
            CharEscapeMode.None,
            // 166 0xA6 ¦
            CharEscapeMode.None,
            // 167 0xA7 §
            CharEscapeMode.None,
            // 168 0xA8 ¨
            CharEscapeMode.None,
            // 169 0xA9 ©
            CharEscapeMode.None,
            // 170 0xAA ª
            CharEscapeMode.None,
            // 171 0xAB «
            CharEscapeMode.None,
            // 172 0xAC ¬
            CharEscapeMode.None,
            // 173 0xAD ­
            CharEscapeMode.None,
            // 174 0xAE ®
            CharEscapeMode.None,
            // 175 0xAF ¯
            CharEscapeMode.None,
            // 176 0xB0 °
            CharEscapeMode.None,
            // 177 0xB1 ±
            CharEscapeMode.None,
            // 178 0xB2 ²
            CharEscapeMode.None,
            // 179 0xB3 ³
            CharEscapeMode.None,
            // 180 0xB4 ´
            CharEscapeMode.None,
            // 181 0xB5 µ
            CharEscapeMode.None,
            // 182 0xB6 ¶
            CharEscapeMode.None,
            // 183 0xB7 ·
            CharEscapeMode.None,
            // 184 0xB8 ¸
            CharEscapeMode.None,
            // 185 0xB9 ¹
            CharEscapeMode.None,
            // 186 0xBA º
            CharEscapeMode.None,
            // 187 0xBB »
            CharEscapeMode.None,
            // 188 0xBC ¼
            CharEscapeMode.None,
            // 189 0xBD ½
            CharEscapeMode.None,
            // 190 0xBE ¾
            CharEscapeMode.None,
            // 191 0xBF ¿
            CharEscapeMode.None,
            // 192 0xC0 À
            CharEscapeMode.None,
            // 193 0xC1 Á
            CharEscapeMode.None,
            // 194 0xC2 Â
            CharEscapeMode.None,
            // 195 0xC3 Ã
            CharEscapeMode.None,
            // 196 0xC4 Ä
            CharEscapeMode.None,
            // 197 0xC5 Å
            CharEscapeMode.None,
            // 198 0xC6 Æ
            CharEscapeMode.None,
            // 199 0xC7 Ç
            CharEscapeMode.None,
            // 200 0xC8 È
            CharEscapeMode.None,
            // 201 0xC9 É
            CharEscapeMode.None,
            // 202 0xCA Ê
            CharEscapeMode.None,
            // 203 0xCB Ë
            CharEscapeMode.None,
            // 204 0xCC Ì
            CharEscapeMode.None,
            // 205 0xCD Í
            CharEscapeMode.None,
            // 206 0xCE Î
            CharEscapeMode.None,
            // 207 0xCF Ï
            CharEscapeMode.None,
            // 208 0xD0 Ð
            CharEscapeMode.None,
            // 209 0xD1 Ñ
            CharEscapeMode.None,
            // 210 0xD2 Ò
            CharEscapeMode.None,
            // 211 0xD3 Ó
            CharEscapeMode.None,
            // 212 0xD4 Ô
            CharEscapeMode.None,
            // 213 0xD5 Õ
            CharEscapeMode.None,
            // 214 0xD6 Ö
            CharEscapeMode.None,
            // 215 0xD7 ×
            CharEscapeMode.None,
            // 216 0xD8 Ø
            CharEscapeMode.None,
            // 217 0xD9 Ù
            CharEscapeMode.None,
            // 218 0xDA Ú
            CharEscapeMode.None,
            // 219 0xDB Û
            CharEscapeMode.None,
            // 220 0xDC Ü
            CharEscapeMode.None,
            // 221 0xDD Ý
            CharEscapeMode.None,
            // 222 0xDE Þ
            CharEscapeMode.None,
            // 223 0xDF ß
            CharEscapeMode.None,
            // 224 0xE0 à
            CharEscapeMode.None,
            // 225 0xE1 á
            CharEscapeMode.None,
            // 226 0xE2 â
            CharEscapeMode.None,
            // 227 0xE3 ã
            CharEscapeMode.None,
            // 228 0xE4 ä
            CharEscapeMode.None,
            // 229 0xE5 å
            CharEscapeMode.None,
            // 230 0xE6 æ
            CharEscapeMode.None,
            // 231 0xE7 ç
            CharEscapeMode.None,
            // 232 0xE8 è
            CharEscapeMode.None,
            // 233 0xE9 é
            CharEscapeMode.None,
            // 234 0xEA ê
            CharEscapeMode.None,
            // 235 0xEB ë
            CharEscapeMode.None,
            // 236 0xEC ì
            CharEscapeMode.None,
            // 237 0xED í
            CharEscapeMode.None,
            // 238 0xEE î
            CharEscapeMode.None,
            // 239 0xEF ï
            CharEscapeMode.None,
            // 240 0xF0 ð
            CharEscapeMode.None,
            // 241 0xF1 ñ
            CharEscapeMode.None,
            // 242 0xF2 ò
            CharEscapeMode.None,
            // 243 0xF3 ó
            CharEscapeMode.None,
            // 244 0xF4 ô
            CharEscapeMode.None,
            // 245 0xF5 õ
            CharEscapeMode.None,
            // 246 0xF6 ö
            CharEscapeMode.None,
            // 247 0xF7 ÷
            CharEscapeMode.None,
            // 248 0xF8 ø
            CharEscapeMode.None,
            // 249 0xF9 ù
            CharEscapeMode.None,
            // 250 0xFA ú
            CharEscapeMode.None,
            // 251 0xFB û
            CharEscapeMode.None,
            // 252 0xFC ü
            CharEscapeMode.None,
            // 253 0xFD ý
            CharEscapeMode.None,
            // 254 0xFE þ
            CharEscapeMode.None,
            // 255 0xFF ÿ
            CharEscapeMode.None,
        };

        private static readonly CharEscapeMode[] _charGroupEscapeModes = new CharEscapeMode[] {
            // 0 0x00
            CharEscapeMode.AsciiHexadecimal,
            // 1 0x01
            CharEscapeMode.AsciiHexadecimal,
            // 2 0x02
            CharEscapeMode.AsciiHexadecimal,
            // 3 0x03
            CharEscapeMode.AsciiHexadecimal,
            // 4 0x04
            CharEscapeMode.AsciiHexadecimal,
            // 5 0x05
            CharEscapeMode.AsciiHexadecimal,
            // 6 0x06
            CharEscapeMode.AsciiHexadecimal,
            // 7 0x07
            CharEscapeMode.Bell,
            // 8 0x08
            CharEscapeMode.AsciiHexadecimal,
            // 9 0x09
            CharEscapeMode.Tab,
            // 10 0x0A
            CharEscapeMode.Linefeed,
            // 11 0x0B
            CharEscapeMode.VerticalTab,
            // 12 0x0C
            CharEscapeMode.FormFeed,
            // 13 0x0D
            CharEscapeMode.CarriageReturn,
            // 14 0x0E
            CharEscapeMode.AsciiHexadecimal,
            // 15 0x0F
            CharEscapeMode.AsciiHexadecimal,
            // 16 0x10
            CharEscapeMode.AsciiHexadecimal,
            // 17 0x11
            CharEscapeMode.AsciiHexadecimal,
            // 18 0x12
            CharEscapeMode.AsciiHexadecimal,
            // 19 0x13
            CharEscapeMode.AsciiHexadecimal,
            // 20 0x14
            CharEscapeMode.AsciiHexadecimal,
            // 21 0x15
            CharEscapeMode.AsciiHexadecimal,
            // 22 0x16
            CharEscapeMode.AsciiHexadecimal,
            // 23 0x17
            CharEscapeMode.AsciiHexadecimal,
            // 24 0x18
            CharEscapeMode.AsciiHexadecimal,
            // 25 0x19
            CharEscapeMode.AsciiHexadecimal,
            // 26 0x1A
            CharEscapeMode.AsciiHexadecimal,
            // 27 0x1B
            CharEscapeMode.Escape,
            // 28 0x1C
            CharEscapeMode.AsciiHexadecimal,
            // 29 0x1D
            CharEscapeMode.AsciiHexadecimal,
            // 30 0x1E
            CharEscapeMode.AsciiHexadecimal,
            // 31 0x1F
            CharEscapeMode.AsciiHexadecimal,
            // 32 0x20
            CharEscapeMode.None,
            // 33 0x21 !
            CharEscapeMode.None,
            // 34 0x22 "
            CharEscapeMode.None,
            // 35 0x23 #
            CharEscapeMode.None,
            // 36 0x24 $
            CharEscapeMode.None,
            // 37 0x25 %
            CharEscapeMode.None,
            // 38 0x26 &
            CharEscapeMode.None,
            // 39 0x27 '
            CharEscapeMode.None,
            // 40 0x28 (
            CharEscapeMode.None,
            // 41 0x29 )
            CharEscapeMode.None,
            // 42 0x2A *
            CharEscapeMode.None,
            // 43 0x2B +
            CharEscapeMode.None,
            // 44 0x2C ,
            CharEscapeMode.None,
            // 45 0x2D -
            CharEscapeMode.Backslash,
            // 46 0x2E .
            CharEscapeMode.None,
            // 47 0x2F /
            CharEscapeMode.None,
            // 48 0x30 0
            CharEscapeMode.None,
            // 49 0x31 1
            CharEscapeMode.None,
            // 50 0x32 2
            CharEscapeMode.None,
            // 51 0x33 3
            CharEscapeMode.None,
            // 52 0x34 4
            CharEscapeMode.None,
            // 53 0x35 5
            CharEscapeMode.None,
            // 54 0x36 6
            CharEscapeMode.None,
            // 55 0x37 7
            CharEscapeMode.None,
            // 56 0x38 8
            CharEscapeMode.None,
            // 57 0x39 9
            CharEscapeMode.None,
            // 58 0x3A :
            CharEscapeMode.None,
            // 59 0x3B ;
            CharEscapeMode.None,
            // 60 0x3C <
            CharEscapeMode.None,
            // 61 0x3D =
            CharEscapeMode.None,
            // 62 0x3E >
            CharEscapeMode.None,
            // 63 0x3F ?
            CharEscapeMode.None,
            // 64 0x40 @
            CharEscapeMode.None,
            // 65 0x41 A
            CharEscapeMode.None,
            // 66 0x42 B
            CharEscapeMode.None,
            // 67 0x43 C
            CharEscapeMode.None,
            // 68 0x44 D
            CharEscapeMode.None,
            // 69 0x45 E
            CharEscapeMode.None,
            // 70 0x46 F
            CharEscapeMode.None,
            // 71 0x47 G
            CharEscapeMode.None,
            // 72 0x48 H
            CharEscapeMode.None,
            // 73 0x49 I
            CharEscapeMode.None,
            // 74 0x4A J
            CharEscapeMode.None,
            // 75 0x4B K
            CharEscapeMode.None,
            // 76 0x4C L
            CharEscapeMode.None,
            // 77 0x4D M
            CharEscapeMode.None,
            // 78 0x4E N
            CharEscapeMode.None,
            // 79 0x4F O
            CharEscapeMode.None,
            // 80 0x50 P
            CharEscapeMode.None,
            // 81 0x51 Q
            CharEscapeMode.None,
            // 82 0x52 R
            CharEscapeMode.None,
            // 83 0x53 S
            CharEscapeMode.None,
            // 84 0x54 T
            CharEscapeMode.None,
            // 85 0x55 U
            CharEscapeMode.None,
            // 86 0x56 V
            CharEscapeMode.None,
            // 87 0x57 W
            CharEscapeMode.None,
            // 88 0x58 X
            CharEscapeMode.None,
            // 89 0x59 Y
            CharEscapeMode.None,
            // 90 0x5A Z
            CharEscapeMode.None,
            // 91 0x5B [
            CharEscapeMode.None,
            // 92 0x5C \
            CharEscapeMode.Backslash,
            // 93 0x5D ]
            CharEscapeMode.Backslash,
            // 94 0x5E ^
            CharEscapeMode.None,
            // 95 0x5F _
            CharEscapeMode.None,
            // 96 0x60 `
            CharEscapeMode.None,
            // 97 0x61 a
            CharEscapeMode.None,
            // 98 0x62 b
            CharEscapeMode.None,
            // 99 0x63 c
            CharEscapeMode.None,
            // 100 0x64 d
            CharEscapeMode.None,
            // 101 0x65 e
            CharEscapeMode.None,
            // 102 0x66 f
            CharEscapeMode.None,
            // 103 0x67 g
            CharEscapeMode.None,
            // 104 0x68 h
            CharEscapeMode.None,
            // 105 0x69 i
            CharEscapeMode.None,
            // 106 0x6A j
            CharEscapeMode.None,
            // 107 0x6B k
            CharEscapeMode.None,
            // 108 0x6C l
            CharEscapeMode.None,
            // 109 0x6D m
            CharEscapeMode.None,
            // 110 0x6E n
            CharEscapeMode.None,
            // 111 0x6F o
            CharEscapeMode.None,
            // 112 0x70 p
            CharEscapeMode.None,
            // 113 0x71 q
            CharEscapeMode.None,
            // 114 0x72 r
            CharEscapeMode.None,
            // 115 0x73 s
            CharEscapeMode.None,
            // 116 0x74 t
            CharEscapeMode.None,
            // 117 0x75 u
            CharEscapeMode.None,
            // 118 0x76 v
            CharEscapeMode.None,
            // 119 0x77 w
            CharEscapeMode.None,
            // 120 0x78 x
            CharEscapeMode.None,
            // 121 0x79 y
            CharEscapeMode.None,
            // 122 0x7A z
            CharEscapeMode.None,
            // 123 0x7B {
            CharEscapeMode.None,
            // 124 0x7C |
            CharEscapeMode.None,
            // 125 0x7D }
            CharEscapeMode.None,
            // 126 0x7E ~
            CharEscapeMode.None,
            // 127 0x7F
            CharEscapeMode.AsciiHexadecimal,
            // 128 0x80
            CharEscapeMode.AsciiHexadecimal,
            // 129 0x81
            CharEscapeMode.AsciiHexadecimal,
            // 130 0x82
            CharEscapeMode.AsciiHexadecimal,
            // 131 0x83
            CharEscapeMode.AsciiHexadecimal,
            // 132 0x84
            CharEscapeMode.AsciiHexadecimal,
            // 133 0x85
            CharEscapeMode.AsciiHexadecimal,
            // 134 0x86
            CharEscapeMode.AsciiHexadecimal,
            // 135 0x87
            CharEscapeMode.AsciiHexadecimal,
            // 136 0x88
            CharEscapeMode.AsciiHexadecimal,
            // 137 0x89
            CharEscapeMode.AsciiHexadecimal,
            // 138 0x8A
            CharEscapeMode.AsciiHexadecimal,
            // 139 0x8B
            CharEscapeMode.AsciiHexadecimal,
            // 140 0x8C
            CharEscapeMode.AsciiHexadecimal,
            // 141 0x8D
            CharEscapeMode.AsciiHexadecimal,
            // 142 0x8E
            CharEscapeMode.AsciiHexadecimal,
            // 143 0x8F
            CharEscapeMode.AsciiHexadecimal,
            // 144 0x90
            CharEscapeMode.AsciiHexadecimal,
            // 145 0x91
            CharEscapeMode.AsciiHexadecimal,
            // 146 0x92
            CharEscapeMode.AsciiHexadecimal,
            // 147 0x93
            CharEscapeMode.AsciiHexadecimal,
            // 148 0x94
            CharEscapeMode.AsciiHexadecimal,
            // 149 0x95
            CharEscapeMode.AsciiHexadecimal,
            // 150 0x96
            CharEscapeMode.AsciiHexadecimal,
            // 151 0x97
            CharEscapeMode.AsciiHexadecimal,
            // 152 0x98
            CharEscapeMode.AsciiHexadecimal,
            // 153 0x99
            CharEscapeMode.AsciiHexadecimal,
            // 154 0x9A
            CharEscapeMode.AsciiHexadecimal,
            // 155 0x9B
            CharEscapeMode.AsciiHexadecimal,
            // 156 0x9C
            CharEscapeMode.AsciiHexadecimal,
            // 157 0x9D
            CharEscapeMode.AsciiHexadecimal,
            // 158 0x9E
            CharEscapeMode.AsciiHexadecimal,
            // 159 0x9F
            CharEscapeMode.AsciiHexadecimal,
            // 160 0xA0
            CharEscapeMode.None,
            // 161 0xA1 ¡
            CharEscapeMode.None,
            // 162 0xA2 ¢
            CharEscapeMode.None,
            // 163 0xA3 £
            CharEscapeMode.None,
            // 164 0xA4 ¤
            CharEscapeMode.None,
            // 165 0xA5 ¥
            CharEscapeMode.None,
            // 166 0xA6 ¦
            CharEscapeMode.None,
            // 167 0xA7 §
            CharEscapeMode.None,
            // 168 0xA8 ¨
            CharEscapeMode.None,
            // 169 0xA9 ©
            CharEscapeMode.None,
            // 170 0xAA ª
            CharEscapeMode.None,
            // 171 0xAB «
            CharEscapeMode.None,
            // 172 0xAC ¬
            CharEscapeMode.None,
            // 173 0xAD ­
            CharEscapeMode.None,
            // 174 0xAE ®
            CharEscapeMode.None,
            // 175 0xAF ¯
            CharEscapeMode.None,
            // 176 0xB0 °
            CharEscapeMode.None,
            // 177 0xB1 ±
            CharEscapeMode.None,
            // 178 0xB2 ²
            CharEscapeMode.None,
            // 179 0xB3 ³
            CharEscapeMode.None,
            // 180 0xB4 ´
            CharEscapeMode.None,
            // 181 0xB5 µ
            CharEscapeMode.None,
            // 182 0xB6 ¶
            CharEscapeMode.None,
            // 183 0xB7 ·
            CharEscapeMode.None,
            // 184 0xB8 ¸
            CharEscapeMode.None,
            // 185 0xB9 ¹
            CharEscapeMode.None,
            // 186 0xBA º
            CharEscapeMode.None,
            // 187 0xBB »
            CharEscapeMode.None,
            // 188 0xBC ¼
            CharEscapeMode.None,
            // 189 0xBD ½
            CharEscapeMode.None,
            // 190 0xBE ¾
            CharEscapeMode.None,
            // 191 0xBF ¿
            CharEscapeMode.None,
            // 192 0xC0 À
            CharEscapeMode.None,
            // 193 0xC1 Á
            CharEscapeMode.None,
            // 194 0xC2 Â
            CharEscapeMode.None,
            // 195 0xC3 Ã
            CharEscapeMode.None,
            // 196 0xC4 Ä
            CharEscapeMode.None,
            // 197 0xC5 Å
            CharEscapeMode.None,
            // 198 0xC6 Æ
            CharEscapeMode.None,
            // 199 0xC7 Ç
            CharEscapeMode.None,
            // 200 0xC8 È
            CharEscapeMode.None,
            // 201 0xC9 É
            CharEscapeMode.None,
            // 202 0xCA Ê
            CharEscapeMode.None,
            // 203 0xCB Ë
            CharEscapeMode.None,
            // 204 0xCC Ì
            CharEscapeMode.None,
            // 205 0xCD Í
            CharEscapeMode.None,
            // 206 0xCE Î
            CharEscapeMode.None,
            // 207 0xCF Ï
            CharEscapeMode.None,
            // 208 0xD0 Ð
            CharEscapeMode.None,
            // 209 0xD1 Ñ
            CharEscapeMode.None,
            // 210 0xD2 Ò
            CharEscapeMode.None,
            // 211 0xD3 Ó
            CharEscapeMode.None,
            // 212 0xD4 Ô
            CharEscapeMode.None,
            // 213 0xD5 Õ
            CharEscapeMode.None,
            // 214 0xD6 Ö
            CharEscapeMode.None,
            // 215 0xD7 ×
            CharEscapeMode.None,
            // 216 0xD8 Ø
            CharEscapeMode.None,
            // 217 0xD9 Ù
            CharEscapeMode.None,
            // 218 0xDA Ú
            CharEscapeMode.None,
            // 219 0xDB Û
            CharEscapeMode.None,
            // 220 0xDC Ü
            CharEscapeMode.None,
            // 221 0xDD Ý
            CharEscapeMode.None,
            // 222 0xDE Þ
            CharEscapeMode.None,
            // 223 0xDF ß
            CharEscapeMode.None,
            // 224 0xE0 à
            CharEscapeMode.None,
            // 225 0xE1 á
            CharEscapeMode.None,
            // 226 0xE2 â
            CharEscapeMode.None,
            // 227 0xE3 ã
            CharEscapeMode.None,
            // 228 0xE4 ä
            CharEscapeMode.None,
            // 229 0xE5 å
            CharEscapeMode.None,
            // 230 0xE6 æ
            CharEscapeMode.None,
            // 231 0xE7 ç
            CharEscapeMode.None,
            // 232 0xE8 è
            CharEscapeMode.None,
            // 233 0xE9 é
            CharEscapeMode.None,
            // 234 0xEA ê
            CharEscapeMode.None,
            // 235 0xEB ë
            CharEscapeMode.None,
            // 236 0xEC ì
            CharEscapeMode.None,
            // 237 0xED í
            CharEscapeMode.None,
            // 238 0xEE î
            CharEscapeMode.None,
            // 239 0xEF ï
            CharEscapeMode.None,
            // 240 0xF0 ð
            CharEscapeMode.None,
            // 241 0xF1 ñ
            CharEscapeMode.None,
            // 242 0xF2 ò
            CharEscapeMode.None,
            // 243 0xF3 ó
            CharEscapeMode.None,
            // 244 0xF4 ô
            CharEscapeMode.None,
            // 245 0xF5 õ
            CharEscapeMode.None,
            // 246 0xF6 ö
            CharEscapeMode.None,
            // 247 0xF7 ÷
            CharEscapeMode.None,
            // 248 0xF8 ø
            CharEscapeMode.None,
            // 249 0xF9 ù
            CharEscapeMode.None,
            // 250 0xFA ú
            CharEscapeMode.None,
            // 251 0xFB û
            CharEscapeMode.None,
            // 252 0xFC ü
            CharEscapeMode.None,
            // 253 0xFD ý
            CharEscapeMode.None,
            // 254 0xFE þ
            CharEscapeMode.None,
            // 255 0xFF ÿ
            CharEscapeMode.None,
        };

        internal static readonly string[] CategoryDesignations = new string[]
        {
            "C",
            "M",
            "L",
            "N",
            "P",
            "Z",
            "S",
            "Ll",
            "Lm",
            "Lo",
            "Lt",
            "Lu",
            "Me",
            "Mn",
            "Mc",
            "Nd",
            "Nl",
            "No",
            "Cc",
            "Cf",
            "Cn",
            "Co",
            "Cs",
            "Pe",
            "Pc",
            "Pd",
            "Pf",
            "Pi",
            "Ps",
            "Po",
            "Zl",
            "Zp",
            "Zs",
            "Sc",
            "Sm",
            "Sk",
            "So"
        };

        internal static readonly string[] BlockDesignations = new string[]
        {
            "IsAlphabeticPresentationForms",
            "IsArabic",
            "IsArabicPresentationForms-A",
            "IsArabicPresentationForms-B",
            "IsArmenian",
            "IsArrows",
            "IsBasicLatin",
            "IsBengali",
            "IsBlockElements",
            "IsBopomofo",
            "IsBopomofoExtended",
            "IsBoxDrawing",
            "IsBraillePatterns",
            "IsBuhid",
            "IsCJKCompatibility",
            "IsCJKCompatibilityForms",
            "IsCJKCompatibilityIdeographs",
            "IsCJKRadicalsSupplement",
            "IsCJKSymbolsandPunctuation",
            "IsCJKUnifiedIdeographs",
            "IsCJKUnifiedIdeographsExtensionA",
            "IsCombiningDiacriticalMarks",
            "IsCombiningDiacriticalMarksforSymbols",
            "IsCombiningHalfMarks",
            "IsCombiningMarksforSymbols",
            "IsControlPictures",
            "IsCurrencySymbols",
            "IsCyrillic",
            "IsCyrillicSupplement",
            "IsDevanagari",
            "IsDingbats",
            "IsEnclosedAlphanumerics",
            "IsEnclosedCJKLettersandMonths",
            "IsEthiopic",
            "IsGeneralPunctuation",
            "IsGeometricShapes",
            "IsGeorgian",
            "IsGreek",
            "IsGreekandCoptic",
            "IsGreekExtended",
            "IsGujarati",
            "IsGurmukhi",
            "IsHalfwidthandFullwidthForms",
            "IsHangulCompatibilityJamo",
            "IsHangulJamo",
            "IsHangulSyllables",
            "IsHanunoo",
            "IsHebrew",
            "IsHighPrivateUseSurrogates",
            "IsHighSurrogates",
            "IsHiragana",
            "IsCherokee",
            "IsIdeographicDescriptionCharacters",
            "IsIPAExtensions",
            "IsKanbun",
            "IsKangxiRadicals",
            "IsKannada",
            "IsKatakana",
            "IsKatakanaPhoneticExtensions",
            "IsKhmer",
            "IsKhmerSymbols",
            "IsLao",
            "IsLatin-1Supplement",
            "IsLatinExtended-A",
            "IsLatinExtendedAdditional",
            "IsLatinExtended-B",
            "IsLetterlikeSymbols",
            "IsLimbu",
            "IsLowSurrogates",
            "IsMalayalam",
            "IsMathematicalOperators",
            "IsMiscellaneousMathematicalSymbols-A",
            "IsMiscellaneousMathematicalSymbols-B",
            "IsMiscellaneousSymbols",
            "IsMiscellaneousSymbolsandArrows",
            "IsMiscellaneousTechnical",
            "IsMongolian",
            "IsMyanmar",
            "IsNumberForms",
            "IsOgham",
            "IsOpticalCharacterRecognition",
            "IsOriya",
            "IsPhoneticExtensions",
            "IsPrivateUse",
            "IsPrivateUseArea",
            "IsRunic",
            "IsSinhala",
            "IsSmallFormVariants",
            "IsSpacingModifierLetters",
            "IsSpecials",
            "IsSuperscriptsandSubscripts",
            "IsSupplementalArrows-A",
            "IsSupplementalArrows-B",
            "IsSupplementalMathematicalOperators",
            "IsSyriac",
            "IsTagalog",
            "IsTagbanwa",
            "IsTaiLe",
            "IsTamil",
            "IsTelugu",
            "IsThaana",
            "IsThai",
            "IsTibetan",
            "IsUnifiedCanadianAboriginalSyllabics",
            "IsVariationSelectors",
            "IsYijingHexagramSymbols",
            "IsYiRadicals",
            "IsYiSyllables"
        };
    }
}
