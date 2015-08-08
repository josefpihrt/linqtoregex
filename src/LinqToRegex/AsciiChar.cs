// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Specifies Unicode character from the first block.
    /// </summary>
    public enum AsciiChar
    {
        /// <summary>
        /// Null. The value is 0. The hexadecimal value is 0x00.
        /// </summary>
        Null,

        /// <summary>
        /// Start of Heading. The value is 1. The hexadecimal value is 0x01.
        /// </summary>
        StartOfHeading,

        /// <summary>
        /// Start of Text. The value is 2. The hexadecimal value is 0x02.
        /// </summary>
        StartOfText,

        /// <summary>
        /// End of Text. The value is 3. The hexadecimal value is 0x03.
        /// </summary>
        EndOfText,

        /// <summary>
        /// End of Transmission. The value is 4. The hexadecimal value is 0x04.
        /// </summary>
        EndOfTransmission,

        /// <summary>
        /// Enquiry. The value is 5. The hexadecimal value is 0x05.
        /// </summary>
        Enquiry,

        /// <summary>
        /// Acknowledge. The value is 6. The hexadecimal value is 0x06.
        /// </summary>
        Acknowledge,

        /// <summary>
        /// Bell. The value is 7. The hexadecimal value is 0x07.
        /// </summary>
        Bell,

        /// <summary>
        /// Backspace. The value is 8. The hexadecimal value is 0x08.
        /// </summary>
        Backspace,

        /// <summary>
        /// Tab. The value is 9. The hexadecimal value is 0x09.
        /// </summary>
        Tab,

        /// <summary>
        /// Linefeed. The value is 10. The hexadecimal value is 0x0A.
        /// </summary>
        Linefeed,

        /// <summary>
        /// Vertical Tab. The value is 11. The hexadecimal value is 0x0B.
        /// </summary>
        VerticalTab,

        /// <summary>
        /// Form Feed. The value is 12. The hexadecimal value is 0x0C.
        /// </summary>
        FormFeed,

        /// <summary>
        /// Carriage Return. The value is 13. The hexadecimal value is 0x0D.
        /// </summary>
        CarriageReturn,

        /// <summary>
        /// Shift Out. The value is 14. The hexadecimal value is 0x0E.
        /// </summary>
        ShiftOut,

        /// <summary>
        /// Shift In. The value is 15. The hexadecimal value is 0x0F.
        /// </summary>
        ShiftIn,

        /// <summary>
        /// Data Link Escape. The value is 16. The hexadecimal value is 0x10.
        /// </summary>
        DataLinkEscape,

        /// <summary>
        /// Device Control One. The value is 17. The hexadecimal value is 0x11.
        /// </summary>
        DeviceControlOne,

        /// <summary>
        /// Device Control Two. The value is 18. The hexadecimal value is 0x12.
        /// </summary>
        DeviceControlTwo,

        /// <summary>
        /// Device Control Three. The value is 19. The hexadecimal value is 0x13.
        /// </summary>
        DeviceControlThree,

        /// <summary>
        /// Device Control Four. The value is 20. The hexadecimal value is 0x14.
        /// </summary>
        DeviceControlFour,

        /// <summary>
        /// Negative Acknowledge. The value is 21. The hexadecimal value is 0x15.
        /// </summary>
        NegativeAcknowledge,

        /// <summary>
        /// Synchronous Idle. The value is 22. The hexadecimal value is 0x16.
        /// </summary>
        SynchronousIdle,

        /// <summary>
        /// End of Transmission Block. The value is 23. The hexadecimal value is 0x17.
        /// </summary>
        EndOfTransmissionBlock,

        /// <summary>
        /// Cancel. The value is 24. The hexadecimal value is 0x18.
        /// </summary>
        Cancel,

        /// <summary>
        /// End of Medium. The value is 25. The hexadecimal value is 0x19.
        /// </summary>
        EndOfMedium,

        /// <summary>
        /// Substitute. The value is 26. The hexadecimal value is 0x1A.
        /// </summary>
        Substitute,

        /// <summary>
        /// Escape. The value is 27. The hexadecimal value is 0x1B.
        /// </summary>
        Escape,

        /// <summary>
        /// Information Separator Four. The value is 28. The hexadecimal value is 0x1C.
        /// </summary>
        InformationSeparatorFour,

        /// <summary>
        /// Information Separator Three. The value is 29. The hexadecimal value is 0x1D.
        /// </summary>
        InformationSeparatorThree,

        /// <summary>
        /// Information Separator Two. The value is 30. The hexadecimal value is 0x1E.
        /// </summary>
        InformationSeparatorTwo,

        /// <summary>
        /// Information Separator One. The value is 31. The hexadecimal value is 0x1F.
        /// </summary>
        InformationSeparatorOne,

        /// <summary>
        /// Space. The value is 32. The hexadecimal value is 0x20.
        /// </summary>
        Space,

        /// <summary>
        /// Exclamation Mark. The value is 33. The hexadecimal value is 0x21.
        /// </summary>
        ExclamationMark,

        /// <summary>
        /// Quote Mark. The value is 34. The hexadecimal value is 0x22.
        /// </summary>
        QuoteMark,

        /// <summary>
        /// Number Sign. The value is 35. The hexadecimal value is 0x23.
        /// </summary>
        NumberSign,

        /// <summary>
        /// Dollar. The value is 36. The hexadecimal value is 0x24.
        /// </summary>
        Dollar,

        /// <summary>
        /// Percent. The value is 37. The hexadecimal value is 0x25.
        /// </summary>
        Percent,

        /// <summary>
        /// Ampersand. The value is 38. The hexadecimal value is 0x26.
        /// </summary>
        Ampersand,

        /// <summary>
        /// Apostrophe. The value is 39. The hexadecimal value is 0x27.
        /// </summary>
        Apostrophe,

        /// <summary>
        /// Left Parenthesis. The value is 40. The hexadecimal value is 0x28.
        /// </summary>
        LeftParenthesis,

        /// <summary>
        /// Right Parenthesis. The value is 41. The hexadecimal value is 0x29.
        /// </summary>
        RightParenthesis,

        /// <summary>
        /// Asterisk. The value is 42. The hexadecimal value is 0x2A.
        /// </summary>
        Asterisk,

        /// <summary>
        /// Plus. The value is 43. The hexadecimal value is 0x2B.
        /// </summary>
        Plus,

        /// <summary>
        /// Comma. The value is 44. The hexadecimal value is 0x2C.
        /// </summary>
        Comma,

        /// <summary>
        /// Hyphen. The value is 45. The hexadecimal value is 0x2D.
        /// </summary>
        Hyphen,

        /// <summary>
        /// Dot (Period). The value is 46. The hexadecimal value is 0x2E.
        /// </summary>
        Dot,

        /// <summary>
        /// Slash. The value is 47. The hexadecimal value is 0x2F.
        /// </summary>
        Slash,

        /// <summary>
        /// Digit Zero. The value is 48. The hexadecimal value is 0x30.
        /// </summary>
        DigitZero,

        /// <summary>
        /// Digit One. The value is 49. The hexadecimal value is 0x31.
        /// </summary>
        DigitOne,

        /// <summary>
        /// Digit Two. The value is 50. The hexadecimal value is 0x32.
        /// </summary>
        DigitTwo,

        /// <summary>
        /// Digit Three. The value is 51. The hexadecimal value is 0x33.
        /// </summary>
        DigitThree,

        /// <summary>
        /// Digit Four. The value is 52. The hexadecimal value is 0x34.
        /// </summary>
        DigitFour,

        /// <summary>
        /// Digit Five. The value is 53. The hexadecimal value is 0x35.
        /// </summary>
        DigitFive,

        /// <summary>
        /// Digit Six. The value is 54. The hexadecimal value is 0x36.
        /// </summary>
        DigitSix,

        /// <summary>
        /// Digit Seven. The value is 55. The hexadecimal value is 0x37.
        /// </summary>
        DigitSeven,

        /// <summary>
        /// Digit Eight. The value is 56. The hexadecimal value is 0x38.
        /// </summary>
        DigitEight,

        /// <summary>
        /// Digit Nine. The value is 57. The hexadecimal value is 0x39.
        /// </summary>
        DigitNine,

        /// <summary>
        /// Colon. The value is 58. The hexadecimal value is 0x3A.
        /// </summary>
        Colon,

        /// <summary>
        /// Semicolon. The value is 59. The hexadecimal value is 0x3B.
        /// </summary>
        Semicolon,

        /// <summary>
        /// Left Angle Bracket (Less-Than Sign). The value is 60. The hexadecimal value is 0x3C.
        /// </summary>
        LeftAngleBracket,

        /// <summary>
        /// Equals Sign. The value is 61. The hexadecimal value is 0x3D.
        /// </summary>
        EqualsSign,

        /// <summary>
        /// Right Angle Bracket (Greater-Than Sign). The value is 62. The hexadecimal value is 0x3E.
        /// </summary>
        RightAngleBracket,

        /// <summary>
        /// Question Mark. The value is 63. The hexadecimal value is 0x3F.
        /// </summary>
        QuestionMark,

        /// <summary>
        /// At Sign. The value is 64. The hexadecimal value is 0x40.
        /// </summary>
        AtSign,

        /// <summary>
        /// Capital Letter A. The value is 65. The hexadecimal value is 0x41.
        /// </summary>
        CapitalLetterA,

        /// <summary>
        /// Capital Letter B. The value is 66. The hexadecimal value is 0x42.
        /// </summary>
        CapitalLetterB,

        /// <summary>
        /// Capital Letter C. The value is 67. The hexadecimal value is 0x43.
        /// </summary>
        CapitalLetterC,

        /// <summary>
        /// Capital Letter D. The value is 68. The hexadecimal value is 0x44.
        /// </summary>
        CapitalLetterD,

        /// <summary>
        /// Capital Letter E. The value is 69. The hexadecimal value is 0x45.
        /// </summary>
        CapitalLetterE,

        /// <summary>
        /// Capital Letter F. The value is 70. The hexadecimal value is 0x46.
        /// </summary>
        CapitalLetterF,

        /// <summary>
        /// Capital Letter G. The value is 71. The hexadecimal value is 0x47.
        /// </summary>
        CapitalLetterG,

        /// <summary>
        /// Capital Letter H. The value is 72. The hexadecimal value is 0x48.
        /// </summary>
        CapitalLetterH,

        /// <summary>
        /// Capital Letter I. The value is 73. The hexadecimal value is 0x49.
        /// </summary>
        CapitalLetterI,

        /// <summary>
        /// Capital Letter J. The value is 74. The hexadecimal value is 0x4A.
        /// </summary>
        CapitalLetterJ,

        /// <summary>
        /// Capital Letter K. The value is 75. The hexadecimal value is 0x4B.
        /// </summary>
        CapitalLetterK,

        /// <summary>
        /// Capital Letter L. The value is 76. The hexadecimal value is 0x4C.
        /// </summary>
        CapitalLetterL,

        /// <summary>
        /// Capital Letter M. The value is 77. The hexadecimal value is 0x4D.
        /// </summary>
        CapitalLetterM,

        /// <summary>
        /// Capital Letter N. The value is 78. The hexadecimal value is 0x4E.
        /// </summary>
        CapitalLetterN,

        /// <summary>
        /// Capital Letter O. The value is 79. The hexadecimal value is 0x4F.
        /// </summary>
        CapitalLetterO,

        /// <summary>
        /// Capital Letter P. The value is 80. The hexadecimal value is 0x50.
        /// </summary>
        CapitalLetterP,

        /// <summary>
        /// Capital Letter Q. The value is 81. The hexadecimal value is 0x51.
        /// </summary>
        CapitalLetterQ,

        /// <summary>
        /// Capital Letter R. The value is 82. The hexadecimal value is 0x52.
        /// </summary>
        CapitalLetterR,

        /// <summary>
        /// Capital Letter S. The value is 83. The hexadecimal value is 0x53.
        /// </summary>
        CapitalLetterS,

        /// <summary>
        /// Capital Letter T. The value is 84. The hexadecimal value is 0x54.
        /// </summary>
        CapitalLetterT,

        /// <summary>
        /// Capital Letter U. The value is 85. The hexadecimal value is 0x55.
        /// </summary>
        CapitalLetterU,

        /// <summary>
        /// Capital Letter V. The value is 86. The hexadecimal value is 0x56.
        /// </summary>
        CapitalLetterV,

        /// <summary>
        /// Capital Letter W. The value is 87. The hexadecimal value is 0x57.
        /// </summary>
        CapitalLetterW,

        /// <summary>
        /// Capital Letter X. The value is 88. The hexadecimal value is 0x58.
        /// </summary>
        CapitalLetterX,

        /// <summary>
        /// Capital Letter Y. The value is 89. The hexadecimal value is 0x59.
        /// </summary>
        CapitalLetterY,

        /// <summary>
        /// Capital Letter Z. The value is 90. The hexadecimal value is 0x5A.
        /// </summary>
        CapitalLetterZ,

        /// <summary>
        /// Left Square Bracket. The value is 91. The hexadecimal value is 0x5B.
        /// </summary>
        LeftSquareBracket,

        /// <summary>
        /// Backslash. The value is 92. The hexadecimal value is 0x5C.
        /// </summary>
        Backslash,

        /// <summary>
        /// Right Square Bracket. The value is 93. The hexadecimal value is 0x5D.
        /// </summary>
        RightSquareBracket,

        /// <summary>
        /// Circumflex Accent. The value is 94. The hexadecimal value is 0x5E.
        /// </summary>
        CircumflexAccent,

        /// <summary>
        /// Underscore. The value is 95. The hexadecimal value is 0x5F.
        /// </summary>
        Underscore,

        /// <summary>
        /// Grave Accent. The value is 96. The hexadecimal value is 0x60.
        /// </summary>
        GraveAccent,

        /// <summary>
        /// Small Letter A. The value is 97. The hexadecimal value is 0x61.
        /// </summary>
        SmallLetterA,

        /// <summary>
        /// Small Letter B. The value is 98. The hexadecimal value is 0x62.
        /// </summary>
        SmallLetterB,

        /// <summary>
        /// Small Letter C. The value is 99. The hexadecimal value is 0x63.
        /// </summary>
        SmallLetterC,

        /// <summary>
        /// Small Letter D. The value is 100. The hexadecimal value is 0x64.
        /// </summary>
        SmallLetterD,

        /// <summary>
        /// Small Letter E. The value is 101. The hexadecimal value is 0x65.
        /// </summary>
        SmallLetterE,

        /// <summary>
        /// Small Letter F. The value is 102. The hexadecimal value is 0x66.
        /// </summary>
        SmallLetterF,

        /// <summary>
        /// Small Letter G. The value is 103. The hexadecimal value is 0x67.
        /// </summary>
        SmallLetterG,

        /// <summary>
        /// Small Letter H. The value is 104. The hexadecimal value is 0x68.
        /// </summary>
        SmallLetterH,

        /// <summary>
        /// Small Letter I. The value is 105. The hexadecimal value is 0x69.
        /// </summary>
        SmallLetterI,

        /// <summary>
        /// Small Letter J. The value is 106. The hexadecimal value is 0x6A.
        /// </summary>
        SmallLetterJ,

        /// <summary>
        /// Small Letter K. The value is 107. The hexadecimal value is 0x6B.
        /// </summary>
        SmallLetterK,

        /// <summary>
        /// Small Letter L. The value is 108. The hexadecimal value is 0x6C.
        /// </summary>
        SmallLetterL,

        /// <summary>
        /// Small Letter M. The value is 109. The hexadecimal value is 0x6D.
        /// </summary>
        SmallLetterM,

        /// <summary>
        /// Small Letter N. The value is 110. The hexadecimal value is 0x6E.
        /// </summary>
        SmallLetterN,

        /// <summary>
        /// Small Letter O. The value is 111. The hexadecimal value is 0x6F.
        /// </summary>
        SmallLetterO,

        /// <summary>
        /// Small Letter P. The value is 112. The hexadecimal value is 0x70.
        /// </summary>
        SmallLetterP,

        /// <summary>
        /// Small Letter Q. The value is 113. The hexadecimal value is 0x71.
        /// </summary>
        SmallLetterQ,

        /// <summary>
        /// Small Letter R. The value is 114. The hexadecimal value is 0x72.
        /// </summary>
        SmallLetterR,

        /// <summary>
        /// Small Letter S. The value is 115. The hexadecimal value is 0x73.
        /// </summary>
        SmallLetterS,

        /// <summary>
        /// Small Letter T. The value is 116. The hexadecimal value is 0x74.
        /// </summary>
        SmallLetterT,

        /// <summary>
        /// Small Letter U. The value is 117. The hexadecimal value is 0x75.
        /// </summary>
        SmallLetterU,

        /// <summary>
        /// Small Letter V. The value is 118. The hexadecimal value is 0x76.
        /// </summary>
        SmallLetterV,

        /// <summary>
        /// Small Letter W. The value is 119. The hexadecimal value is 0x77.
        /// </summary>
        SmallLetterW,

        /// <summary>
        /// Small Letter X. The value is 120. The hexadecimal value is 0x78.
        /// </summary>
        SmallLetterX,

        /// <summary>
        /// Small Letter Y. The value is 121. The hexadecimal value is 0x79.
        /// </summary>
        SmallLetterY,

        /// <summary>
        /// Small Letter Z. The value is 122. The hexadecimal value is 0x7A.
        /// </summary>
        SmallLetterZ,

        /// <summary>
        /// Left Curly Bracket. The value is 123. The hexadecimal value is 0x7B.
        /// </summary>
        LeftCurlyBracket,

        /// <summary>
        /// Vertical Bar. The value is 124. The hexadecimal value is 0x7C.
        /// </summary>
        VerticalBar,

        /// <summary>
        /// Right Curly Bracket. The value is 125. The hexadecimal value is 0x7D.
        /// </summary>
        RightCurlyBracket,

        /// <summary>
        /// Tilde. The value is 126. The hexadecimal value is 0x7E.
        /// </summary>
        Tilde,

        /// <summary>
        /// Delete. The value is 127. The hexadecimal value is 0x7F.
        /// </summary>
        Delete,
    }
}
