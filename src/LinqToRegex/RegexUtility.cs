// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using static Pihrtsoft.Text.RegularExpressions.PatternFactory;

namespace Pihrtsoft.Text.RegularExpressions;

/// <summary>
/// Provides static methods for escaping and validating regular expressions elements.
/// </summary>
public static class RegexUtility
{
    internal const RegexOptions InlineOptions = RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.ExplicitCapture | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace;

    private static readonly object _randomLock = new();
    private static Random? _random;
    private static Regex? _validGroupNameRegex;

    internal static Regex ValidGroupNameRegex
    {
        get
        {
            if (_validGroupNameRegex is null)
            {
                Pattern pattern = EntireInput(
                    Group(Range('1', '9') + MaybeMany(ArabicDigit())),
                    (WordChar() - ArabicDigit()) + WhileWordChar()
                );

                _validGroupNameRegex = pattern.ToRegex();
            }

            return _validGroupNameRegex;
        }
    }

    /// <summary>
    /// Gets a value indicating whether the specified group name is a valid name of a regex group.
    /// </summary>
    /// <param name="groupName">A group name to examine.</param>
    public static bool IsValidGroupName(string groupName)
    {
        return IsValidGroupNameInternal(groupName);
    }

    internal static bool IsValidGroupNameInternal(string groupName)
    {
        if (string.IsNullOrEmpty(groupName))
            return false;

        Match match = ValidGroupNameRegex.Match(groupName);

        if (!match.Success)
            return false;

        Group group = match.Groups[1];
        if (group.Success && group.Value.Length > 9)
        {
            return int.TryParse(group.Value, out _);
        }

        return true;
    }

    internal static void CheckGroupName(string groupName)
    {
        CheckGroupName(groupName, nameof(groupName));
    }

    internal static void CheckGroupName(string groupName, string paramName)
    {
        if (groupName is null)
            throw new ArgumentNullException(paramName);

        if (!IsValidGroupNameInternal(groupName))
            throw new ArgumentException("Invalid group name.", paramName);
    }

    /// <summary>
    /// Gets a value indicating whether the <paramref name="options"/> can be expressed as inline char(s).
    /// </summary>
    /// <param name="options">A bitwise combination of the enumeration values.</param>
    public static bool IsValidInlineOptions(RegexOptions options)
    {
        return (options & ~InlineOptions) == RegexOptions.None;
    }

    /// <summary>
    /// Converts a specified character to the <see cref="string"/> object that represents the character as a literal rather than a metacharacter.
    /// The character is considered not to be in the character group.
    /// </summary>
    /// <param name="value">A Unicode character.</param>
    public static string Escape(char value)
    {
        return Escape(value, false);
    }

    /// <summary>
    /// Converts a specified character to the <see cref="string"/> object that represents the character as a literal rather than a metacharacter.
    /// </summary>
    /// <param name="value">A Unicode character.</param>
    /// <param name="inCharGroup">Indicates whether the character is considered to be inside or outside of the character group.</param>
    public static string Escape(char value, bool inCharGroup)
    {
        return EscapeInternal((int)value, inCharGroup);
    }

    internal static string EscapeInternal(int charCode, bool inCharGroup)
    {
        return GetEscapeMode(charCode, inCharGroup) switch
        {
            CharEscapeMode.None => ((char)charCode).ToString(),
            CharEscapeMode.AsciiHexadecimal => Syntax.AsciiHexadecimalStart + charCode.ToString("X2", CultureInfo.InvariantCulture),
            CharEscapeMode.Backslash => @"\" + ((char)charCode).ToString(),
            CharEscapeMode.Bell => Syntax.Bell,
            CharEscapeMode.CarriageReturn => Syntax.CarriageReturn,
            CharEscapeMode.Escape => Syntax.Escape,
            CharEscapeMode.FormFeed => Syntax.FormFeed,
            CharEscapeMode.Linefeed => Syntax.Linefeed,
            CharEscapeMode.Tab => Syntax.Tab,
            CharEscapeMode.VerticalTab => Syntax.VerticalTab,
            _ => throw new InvalidOperationException(),
        };
    }

    /// <summary>
    /// Gets a value indicating how a specified character is represented in the regular expression pattern.
    /// </summary>
    /// <param name="value">A Unicode character.</param>
    public static CharEscapeMode GetEscapeMode(char value)
    {
        return GetEscapeMode(value, false);
    }

    /// <summary>
    /// Gets a value indicating how a specified character is represented in the regular expression pattern, specifying whether the character is inside or outside of the character group.
    /// </summary>
    /// <param name="value">A Unicode character.</param>
    /// <param name="inCharGroup">Indicates whether the character is inside or outside of the character group.</param>
    public static CharEscapeMode GetEscapeMode(char value, bool inCharGroup)
    {
        return GetEscapeMode((int)value, inCharGroup);
    }

    internal static CharEscapeMode GetEscapeMode(int charCode, bool inCharGroup)
    {
        if (charCode <= 0xFF)
        {
            return (inCharGroup)
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
    /// <exception cref="ArgumentNullException"><paramref name="input"/> is <c>null</c>.</exception>
    public static string Escape(string input, bool inCharGroup)
    {
        if (input is null)
            throw new ArgumentNullException(nameof(input));

        for (int i = 0; i < input.Length; i++)
        {
            CharEscapeMode mode = GetEscapeMode((int)input[i], inCharGroup);
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
                        mode = GetEscapeMode((int)input[i], inCharGroup);

                        if (mode != CharEscapeMode.None)
                            break;

                        i++;
                    }

                    sb.Append(input, lastPos, i - lastPos);
                }
                while (i < input.Length);

                return sb.ToString();
            }
        }

        return input;
    }

    /// <summary>
    /// Escapes all dollar signs by doubling them.
    /// </summary>
    /// <param name="value">The substitution pattern to be escaped.</param>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public static string EscapeSubstitution(string value)
    {
        if (value is null)
            throw new ArgumentNullException(nameof(value));

        for (int i = 0; i < value.Length; i++)
        {
            if (value[i] == '$')
            {
                var sb = new StringBuilder();
                EscapeSubstitution(value, i, sb);
                return sb.ToString();
            }
        }

        return value;
    }

    internal static void EscapeSubstitution(string input, int i, StringBuilder sb)
    {
        char ch;
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
        }
        while (i < input.Length);
    }

    /// <summary>
    /// Returns randomly generated group name.
    /// </summary>
    internal static string GetRandomGroupName() => GetRandomGroupName(8);

    /// <summary>
    /// Returns randomly generated group name with a specified length.
    /// </summary>
    /// <param name="length">Length of a group name.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="length"/> is less than one.</exception>
    internal static string GetRandomGroupName(int length)
    {
        if (length < 1)
            throw new ArgumentOutOfRangeException(nameof(length));

        var sb = new StringBuilder(length);

        if (_random is null)
        {
            lock (_randomLock)
            {
                if (_random is null)
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
    public static string GetCategoryDesignation(GeneralCategory category) => CategoryDesignations[(int)category];

    /// <summary>
    /// Gets a designation of the specified Unicode block.
    /// </summary>
    /// <param name="block">An enumerated constant that identifies Unicode block.</param>
    public static string GetBlockDesignation(NamedBlock block) => BlockDesignations[(int)block];

    /// <summary>
    /// Gets a description of the specified Unicode category.
    /// </summary>
    /// <param name="category">An enumerated constant that identifies Unicode category.</param>
    internal static string GetCategoryDescription(GeneralCategory category)
    {
        return category switch
        {
            GeneralCategory.AllControlCharacters => "All control characters. This includes the Cc, Cf, Cs, Co, and Cn categories.",
            GeneralCategory.AllDiacriticMarks => "All diacritic marks. This includes the Mn, Mc, and Me categories.",
            GeneralCategory.AllLetterCharacters => "All letter characters. This includes the Lu, Ll, Lt, Lm, and Lo characters.",
            GeneralCategory.AllNumbers => "All numbers. This includes the Nd, Nl, and No categories.",
            GeneralCategory.AllPunctuationCharacters => "All punctuation characters. This includes the Pc, Pd, Ps, Pe, Pi, Pf, and Po categories.",
            GeneralCategory.AllSeparatorCharacters => "All separator characters. This includes the Zs, Zl, and Zp categories.",
            GeneralCategory.AllSymbols => "All symbols. This includes the Sm, Sc, Sk, and So categories.",
            GeneralCategory.LetterLowercase => "Letter, Lowercase",
            GeneralCategory.LetterModifier => "Letter, Modifier",
            GeneralCategory.LetterOther => "Letter, Other",
            GeneralCategory.LetterTitlecase => "Letter, Titlecase",
            GeneralCategory.LetterUppercase => "Letter, Uppercase",
            GeneralCategory.MarkEnclosing => "Mark, Enclosing",
            GeneralCategory.MarkNonspacing => "Mark, Nonspacing",
            GeneralCategory.MarkSpacingCombining => "Mark, Spacing Combining",
            GeneralCategory.NumberDecimalDigit => "Number, Decimal Digit",
            GeneralCategory.NumberLetter => "Number, Letter",
            GeneralCategory.NumberOther => "Number, Other",
            GeneralCategory.OtherControl => "Other, Control",
            GeneralCategory.OtherFormat => "Other, Format",
            GeneralCategory.OtherNotAssigned => "Other, Not Assigned (no characters have this property)",
            GeneralCategory.OtherPrivateUse => "Other, Private Use",
            GeneralCategory.OtherSurrogate => "Other, Surrogate",
            GeneralCategory.PunctuationClose => "Punctuation, Close",
            GeneralCategory.PunctuationConnector => "Punctuation, Connector",
            GeneralCategory.PunctuationDash => "Punctuation, Dash",
            GeneralCategory.PunctuationFinalQuote => "Punctuation, Final quote (may behave like Ps or Pe depending on usage)",
            GeneralCategory.PunctuationInitialQuote => "Punctuation, Initial quote (may behave like Ps or Pe depending on usage)",
            GeneralCategory.PunctuationOpen => "Punctuation, Open",
            GeneralCategory.PunctuationOther => "Punctuation, Other",
            GeneralCategory.SeparatorLine => "Separator, Line",
            GeneralCategory.SeparatorParagraph => "Separator, Paragraph",
            GeneralCategory.SeparatorSpace => "Separator, Space",
            GeneralCategory.SymbolCurrency => "Symbol, Currency",
            GeneralCategory.SymbolMath => "Symbol, Math",
            GeneralCategory.SymbolModifier => "Symbol, Modifier",
            GeneralCategory.SymbolOther => "Symbol, Other",
            _ => "",
        };
    }

    /// <summary>
    /// Gets a description of the specified Unicode block.
    /// </summary>
    /// <param name="block">An enumerated constant that identifies Unicode block.</param>
    internal static string GetBlockDescription(NamedBlock block)
    {
        return block switch
        {
            NamedBlock.AlphabeticPresentationForms => "FB00 - FB4F",
            NamedBlock.Arabic => "0600 - 06FF",
            NamedBlock.ArabicPresentationFormsA => "FB50 - FDFF",
            NamedBlock.ArabicPresentationFormsB => "FE70 - FEFF",
            NamedBlock.Armenian => "0530 - 058F",
            NamedBlock.Arrows => "2190 - 21FF",
            NamedBlock.BasicLatin => "0000 - 007F",
            NamedBlock.Bengali => "0980 - 09FF",
            NamedBlock.BlockElements => "2580 - 259F",
            NamedBlock.Bopomofo => "3100 - 312F",
            NamedBlock.BopomofoExtended => "31A0 - 31BF",
            NamedBlock.BoxDrawing => "2500 - 257F",
            NamedBlock.BraillePatterns => "2800 - 28FF",
            NamedBlock.Buhid => "1740 - 175F",
            NamedBlock.CJKCompatibility => "3300 - 33FF",
            NamedBlock.CJKCompatibilityForms => "FE30 - FE4F",
            NamedBlock.CJKCompatibilityIdeographs => "F900 - FAFF",
            NamedBlock.CJKRadicalsSupplement => "2E80 - 2EFF",
            NamedBlock.CJKSymbolsAndPunctuation => "3000 - 303F",
            NamedBlock.CJKUnifiedIdeographs => "4E00 - 9FFF",
            NamedBlock.CJKUnifiedIdeographsExtensionA => "3400 - 4DBF",
            NamedBlock.CombiningDiacriticalMarks => "0300 - 036F",
            NamedBlock.CombiningDiacriticalMarksForSymbols => "20D0 - 20FF",
            NamedBlock.CombiningHalfMarks => "FE20 - FE2F",
            NamedBlock.CombiningMarksForSymbols => "20D0 - 20FF",
            NamedBlock.ControlPictures => "2400 - 243F",
            NamedBlock.CurrencySymbols => "20A0 - 20CF",
            NamedBlock.Cyrillic => "0400 - 04FF",
            NamedBlock.CyrillicSupplement => "0500 - 052F",
            NamedBlock.Devanagari => "0900 - 097F",
            NamedBlock.Dingbats => "2700 - 27BF",
            NamedBlock.EnclosedAlphanumerics => "2460 - 24FF",
            NamedBlock.EnclosedCJKLettersAndMonths => "3200 - 32FF",
            NamedBlock.Ethiopic => "1200 - 137F",
            NamedBlock.GeneralPunctuation => "2000 - 206F",
            NamedBlock.GeometricShapes => "25A0 - 25FF",
            NamedBlock.Georgian => "10A0 - 10FF",
            NamedBlock.Greek or NamedBlock.GreekAndCoptic => "0370 - 03FF",
            NamedBlock.GreekExtended => "1F00 - 1FFF",
            NamedBlock.Gujarati => "0A80 - 0AFF",
            NamedBlock.Gurmukhi => "0A00 - 0A7F",
            NamedBlock.HalfWidthAndFullWidthForms => "FF00 - FFEF",
            NamedBlock.HangulCompatibilityJamo => "3130 - 318F",
            NamedBlock.HangulJamo => "1100 - 11FF",
            NamedBlock.HangulSyllables => "AC00 - D7AF",
            NamedBlock.Hanunoo => "1720 - 173F",
            NamedBlock.Hebrew => "0590 - 05FF",
            NamedBlock.HighPrivateUseSurrogates => "DB80 - DBFF",
            NamedBlock.HighSurrogates => "D800 - DB7F",
            NamedBlock.Hiragana => "3040 - 309F",
            NamedBlock.Cherokee => "13A0 - 13FF",
            NamedBlock.IdeographicDescriptionCharacters => "2FF0 - 2FFF",
            NamedBlock.IPAExtensions => "0250 - 02AF",
            NamedBlock.Kanbun => "3190 - 319F",
            NamedBlock.KangxiRadicals => "2F00 - 2FDF",
            NamedBlock.Kannada => "0C80 - 0CFF",
            NamedBlock.Katakana => "30A0 - 30FF",
            NamedBlock.KatakanaPhoneticExtensions => "31F0 - 31FF",
            NamedBlock.Khmer => "1780 - 17FF",
            NamedBlock.KhmerSymbols => "19E0 - 19FF",
            NamedBlock.Lao => "0E80 - 0EFF",
            NamedBlock.Latin1Supplement => "0080 - 00FF",
            NamedBlock.LatinExtendedA => "0100 - 017F",
            NamedBlock.LatinExtendedAdditional => "1E00 - 1EFF",
            NamedBlock.LatinExtendedB => "0180 - 024F",
            NamedBlock.LetterLikeSymbols => "2100 - 214F",
            NamedBlock.Limbu => "1900 - 194F",
            NamedBlock.LowSurrogates => "DC00 - DFFF",
            NamedBlock.Malayalam => "0D00 - 0D7F",
            NamedBlock.MathematicalOperators => "2200 - 22FF",
            NamedBlock.MiscellaneousMathematicalSymbolsA => "27C0 - 27EF",
            NamedBlock.MiscellaneousMathematicalSymbolsB => "2980 - 29FF",
            NamedBlock.MiscellaneousSymbols => "2600 - 26FF",
            NamedBlock.MiscellaneousSymbolsAndArrows => "2B00 - 2BFF",
            NamedBlock.MiscellaneousTechnical => "2300 - 23FF",
            NamedBlock.Mongolian => "1800 - 18AF",
            NamedBlock.Myanmar => "1000 - 109F",
            NamedBlock.NumberForms => "2150 - 218F",
            NamedBlock.Ogham => "1680 - 169F",
            NamedBlock.OpticalCharacterRecognition => "2440 - 245F",
            NamedBlock.Oriya => "0B00 - 0B7F",
            NamedBlock.PhoneticExtensions => "1D00 - 1D7F",
            NamedBlock.PrivateUse or NamedBlock.PrivateUseArea => "E000 - F8FF",
            NamedBlock.Runic => "16A0 - 16FF",
            NamedBlock.Sinhala => "0D80 - 0DFF",
            NamedBlock.SmallFormVariants => "FE50 - FE6F",
            NamedBlock.SpacingModifierLetters => "02B0 - 02FF",
            NamedBlock.Specials => "FFF0 - FFFF",
            NamedBlock.SuperscriptsAndSubscripts => "2070 - 209F",
            NamedBlock.SupplementalArrowsA => "27F0 - 27FF",
            NamedBlock.SupplementalArrowsB => "2900 - 297F",
            NamedBlock.SupplementalMathematicalOperators => "2A00 - 2AFF",
            NamedBlock.Syriac => "0700 - 074F",
            NamedBlock.Tagalog => "1700 - 171F",
            NamedBlock.Tagbanwa => "1760 - 177F",
            NamedBlock.TaiLe => "1950 - 197F",
            NamedBlock.Tamil => "0B80 - 0BFF",
            NamedBlock.Telugu => "0C00 - 0C7F",
            NamedBlock.Thaana => "0780 - 07BF",
            NamedBlock.Thai => "0E00 - 0E7F",
            NamedBlock.Tibetan => "0F00 - 0FFF",
            NamedBlock.UnifiedCanadianAboriginalSyllabics => "1400 - 167F",
            NamedBlock.VariationSelectors => "FE00 - FE0F",
            NamedBlock.YijingHexagramSymbols => "4DC0 - 4DFF",
            NamedBlock.YiRadicals => "A490 - A4CF",
            NamedBlock.YiSyllables => "A000 - A48F",
            _ => "",
        };
    }

    private static readonly CharEscapeMode[] _escapeModes = new[] {
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
        CharEscapeMode.None
    };

    private static readonly CharEscapeMode[] _charGroupEscapeModes = new[] {
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
        CharEscapeMode.None
    };

    internal static readonly string[] CategoryDesignations = new[]
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

    internal static readonly string[] BlockDesignations = new[]
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
