// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Specifies Unicode character from the first block.
    /// </summary>
    public enum AsciiChar
    {
        /// <summary>
        /// Null. The value of 0. The hexadecimal value of 0x00.
        /// </summary>
        Null,

        /// <summary>
        /// Start of Heading. The value of 1. The hexadecimal value of 0x01.
        /// </summary>
        StartOfHeading,

        /// <summary>
        /// Start of Text. The value of 2. The hexadecimal value of 0x02.
        /// </summary>
        StartOfText,

        /// <summary>
        /// End of Text. The value of 3. The hexadecimal value of 0x03.
        /// </summary>
        EndOfText,

        /// <summary>
        /// End of Transmission. The value of 4. The hexadecimal value of 0x04.
        /// </summary>
        EndOfTransmission,

        /// <summary>
        /// Enquiry. The value of 5. The hexadecimal value of 0x05.
        /// </summary>
        Enquiry,

        /// <summary>
        /// Acknowledge. The value of 6. The hexadecimal value of 0x06.
        /// </summary>
        Acknowledge,

        /// <summary>
        /// Bell. The value of 7. The hexadecimal value of 0x07.
        /// </summary>
        Bell,

        /// <summary>
        /// Backspace. The value of 8. The hexadecimal value of 0x08.
        /// </summary>
        Backspace,

        /// <summary>
        /// Tab. The value of 9. The hexadecimal value of 0x09.
        /// </summary>
        Tab,

        /// <summary>
        /// Linefeed. The value of 10. The hexadecimal value of 0x0A.
        /// </summary>
        Linefeed,

        /// <summary>
        /// Vertical Tab. The value of 11. The hexadecimal value of 0x0B.
        /// </summary>
        VerticalTab,

        /// <summary>
        /// Form Feed. The value of 12. The hexadecimal value of 0x0C.
        /// </summary>
        FormFeed,

        /// <summary>
        /// Carriage Return. The value of 13. The hexadecimal value of 0x0D.
        /// </summary>
        CarriageReturn,

        /// <summary>
        /// Shift Out. The value of 14. The hexadecimal value of 0x0E.
        /// </summary>
        ShiftOut,

        /// <summary>
        /// Shift In. The value of 15. The hexadecimal value of 0x0F.
        /// </summary>
        ShiftIn,

        /// <summary>
        /// Data Link Escape. The value of 16. The hexadecimal value of 0x10.
        /// </summary>
        DataLinkEscape,

        /// <summary>
        /// Device Control One. The value of 17. The hexadecimal value of 0x11.
        /// </summary>
        DeviceControlOne,

        /// <summary>
        /// Device Control Two. The value of 18. The hexadecimal value of 0x12.
        /// </summary>
        DeviceControlTwo,

        /// <summary>
        /// Device Control Three. The value of 19. The hexadecimal value of 0x13.
        /// </summary>
        DeviceControlThree,

        /// <summary>
        /// Device Control Four. The value of 20. The hexadecimal value of 0x14.
        /// </summary>
        DeviceControlFour,

        /// <summary>
        /// Negative Acknowledge. The value of 21. The hexadecimal value of 0x15.
        /// </summary>
        NegativeAcknowledge,

        /// <summary>
        /// Synchronous Idle. The value of 22. The hexadecimal value of 0x16.
        /// </summary>
        SynchronousIdle,

        /// <summary>
        /// End of Transmission Block. The value of 23. The hexadecimal value of 0x17.
        /// </summary>
        EndOfTransmissionBlock,

        /// <summary>
        /// Cancel. The value of 24. The hexadecimal value of 0x18.
        /// </summary>
        Cancel,

        /// <summary>
        /// End of Medium. The value of 25. The hexadecimal value of 0x19.
        /// </summary>
        EndOfMedium,

        /// <summary>
        /// Substitute. The value of 26. The hexadecimal value of 0x1A.
        /// </summary>
        Substitute,

        /// <summary>
        /// Escape. The value of 27. The hexadecimal value of 0x1B.
        /// </summary>
        Escape,

        /// <summary>
        /// Information Separator Four. The value of 28. The hexadecimal value of 0x1C.
        /// </summary>
        InformationSeparatorFour,

        /// <summary>
        /// Information Separator Three. The value of 29. The hexadecimal value of 0x1D.
        /// </summary>
        InformationSeparatorThree,

        /// <summary>
        /// Information Separator Two. The value of 30. The hexadecimal value of 0x1E.
        /// </summary>
        InformationSeparatorTwo,

        /// <summary>
        /// Information Separator One. The value of 31. The hexadecimal value of 0x1F.
        /// </summary>
        InformationSeparatorOne,

        /// <summary>
        /// Space. The value of 32. The hexadecimal value of 0x20.
        /// </summary>
        Space,

        /// <summary>
        /// Exclamation Mark. The value of 33. The hexadecimal value of 0x21.
        /// </summary>
        ExclamationMark,

        /// <summary>
        /// Quote Mark. The value of 34. The hexadecimal value of 0x22.
        /// </summary>
        QuoteMark,

        /// <summary>
        /// Number Sign. The value of 35. The hexadecimal value of 0x23.
        /// </summary>
        NumberSign,

        /// <summary>
        /// Dollar. The value of 36. The hexadecimal value of 0x24.
        /// </summary>
        Dollar,

        /// <summary>
        /// Percent. The value of 37. The hexadecimal value of 0x25.
        /// </summary>
        Percent,

        /// <summary>
        /// Ampersand. The value of 38. The hexadecimal value of 0x26.
        /// </summary>
        Ampersand,

        /// <summary>
        /// Apostrophe. The value of 39. The hexadecimal value of 0x27.
        /// </summary>
        Apostrophe,

        /// <summary>
        /// Left Parenthesis. The value of 40. The hexadecimal value of 0x28.
        /// </summary>
        LeftParenthesis,

        /// <summary>
        /// Right Parenthesis. The value of 41. The hexadecimal value of 0x29.
        /// </summary>
        RightParenthesis,

        /// <summary>
        /// Asterisk. The value of 42. The hexadecimal value of 0x2A.
        /// </summary>
        Asterisk,

        /// <summary>
        /// Plus. The value of 43. The hexadecimal value of 0x2B.
        /// </summary>
        Plus,

        /// <summary>
        /// Comma. The value of 44. The hexadecimal value of 0x2C.
        /// </summary>
        Comma,

        /// <summary>
        /// Hyphen. The value of 45. The hexadecimal value of 0x2D.
        /// </summary>
        Hyphen,

        /// <summary>
        /// Dot (Period). The value of 46. The hexadecimal value of 0x2E.
        /// </summary>
        Dot,

        /// <summary>
        /// Slash. The value of 47. The hexadecimal value of 0x2F.
        /// </summary>
        Slash,

        /// <summary>
        /// Digit Zero. The value of 48. The hexadecimal value of 0x30.
        /// </summary>
        DigitZero,

        /// <summary>
        /// Digit One. The value of 49. The hexadecimal value of 0x31.
        /// </summary>
        DigitOne,

        /// <summary>
        /// Digit Two. The value of 50. The hexadecimal value of 0x32.
        /// </summary>
        DigitTwo,

        /// <summary>
        /// Digit Three. The value of 51. The hexadecimal value of 0x33.
        /// </summary>
        DigitThree,

        /// <summary>
        /// Digit Four. The value of 52. The hexadecimal value of 0x34.
        /// </summary>
        DigitFour,

        /// <summary>
        /// Digit Five. The value of 53. The hexadecimal value of 0x35.
        /// </summary>
        DigitFive,

        /// <summary>
        /// Digit Six. The value of 54. The hexadecimal value of 0x36.
        /// </summary>
        DigitSix,

        /// <summary>
        /// Digit Seven. The value of 55. The hexadecimal value of 0x37.
        /// </summary>
        DigitSeven,

        /// <summary>
        /// Digit Eight. The value of 56. The hexadecimal value of 0x38.
        /// </summary>
        DigitEight,

        /// <summary>
        /// Digit Nine. The value of 57. The hexadecimal value of 0x39.
        /// </summary>
        DigitNine,

        /// <summary>
        /// Colon. The value of 58. The hexadecimal value of 0x3A.
        /// </summary>
        Colon,

        /// <summary>
        /// Semicolon. The value of 59. The hexadecimal value of 0x3B.
        /// </summary>
        Semicolon,

        /// <summary>
        /// Left Angle Bracket (Less-Than Sign). The value of 60. The hexadecimal value of 0x3C.
        /// </summary>
        LeftAngleBracket,

        /// <summary>
        /// Equals Sign. The value of 61. The hexadecimal value of 0x3D.
        /// </summary>
        EqualsSign,

        /// <summary>
        /// Right Angle Bracket (Greater-Than Sign). The value of 62. The hexadecimal value of 0x3E.
        /// </summary>
        RightAngleBracket,

        /// <summary>
        /// Question Mark. The value of 63. The hexadecimal value of 0x3F.
        /// </summary>
        QuestionMark,

        /// <summary>
        /// At Sign. The value of 64. The hexadecimal value of 0x40.
        /// </summary>
        AtSign,

        /// <summary>
        /// Capital Letter A. The value of 65. The hexadecimal value of 0x41.
        /// </summary>
        CapitalLetterA,

        /// <summary>
        /// Capital Letter B. The value of 66. The hexadecimal value of 0x42.
        /// </summary>
        CapitalLetterB,

        /// <summary>
        /// Capital Letter C. The value of 67. The hexadecimal value of 0x43.
        /// </summary>
        CapitalLetterC,

        /// <summary>
        /// Capital Letter D. The value of 68. The hexadecimal value of 0x44.
        /// </summary>
        CapitalLetterD,

        /// <summary>
        /// Capital Letter E. The value of 69. The hexadecimal value of 0x45.
        /// </summary>
        CapitalLetterE,

        /// <summary>
        /// Capital Letter F. The value of 70. The hexadecimal value of 0x46.
        /// </summary>
        CapitalLetterF,

        /// <summary>
        /// Capital Letter G. The value of 71. The hexadecimal value of 0x47.
        /// </summary>
        CapitalLetterG,

        /// <summary>
        /// Capital Letter H. The value of 72. The hexadecimal value of 0x48.
        /// </summary>
        CapitalLetterH,

        /// <summary>
        /// Capital Letter I. The value of 73. The hexadecimal value of 0x49.
        /// </summary>
        CapitalLetterI,

        /// <summary>
        /// Capital Letter J. The value of 74. The hexadecimal value of 0x4A.
        /// </summary>
        CapitalLetterJ,

        /// <summary>
        /// Capital Letter K. The value of 75. The hexadecimal value of 0x4B.
        /// </summary>
        CapitalLetterK,

        /// <summary>
        /// Capital Letter L. The value of 76. The hexadecimal value of 0x4C.
        /// </summary>
        CapitalLetterL,

        /// <summary>
        /// Capital Letter M. The value of 77. The hexadecimal value of 0x4D.
        /// </summary>
        CapitalLetterM,

        /// <summary>
        /// Capital Letter N. The value of 78. The hexadecimal value of 0x4E.
        /// </summary>
        CapitalLetterN,

        /// <summary>
        /// Capital Letter O. The value of 79. The hexadecimal value of 0x4F.
        /// </summary>
        CapitalLetterO,

        /// <summary>
        /// Capital Letter P. The value of 80. The hexadecimal value of 0x50.
        /// </summary>
        CapitalLetterP,

        /// <summary>
        /// Capital Letter Q. The value of 81. The hexadecimal value of 0x51.
        /// </summary>
        CapitalLetterQ,

        /// <summary>
        /// Capital Letter R. The value of 82. The hexadecimal value of 0x52.
        /// </summary>
        CapitalLetterR,

        /// <summary>
        /// Capital Letter S. The value of 83. The hexadecimal value of 0x53.
        /// </summary>
        CapitalLetterS,

        /// <summary>
        /// Capital Letter T. The value of 84. The hexadecimal value of 0x54.
        /// </summary>
        CapitalLetterT,

        /// <summary>
        /// Capital Letter U. The value of 85. The hexadecimal value of 0x55.
        /// </summary>
        CapitalLetterU,

        /// <summary>
        /// Capital Letter V. The value of 86. The hexadecimal value of 0x56.
        /// </summary>
        CapitalLetterV,

        /// <summary>
        /// Capital Letter W. The value of 87. The hexadecimal value of 0x57.
        /// </summary>
        CapitalLetterW,

        /// <summary>
        /// Capital Letter X. The value of 88. The hexadecimal value of 0x58.
        /// </summary>
        CapitalLetterX,

        /// <summary>
        /// Capital Letter Y. The value of 89. The hexadecimal value of 0x59.
        /// </summary>
        CapitalLetterY,

        /// <summary>
        /// Capital Letter Z. The value of 90. The hexadecimal value of 0x5A.
        /// </summary>
        CapitalLetterZ,

        /// <summary>
        /// Left Square Bracket. The value of 91. The hexadecimal value of 0x5B.
        /// </summary>
        LeftSquareBracket,

        /// <summary>
        /// Backslash. The value of 92. The hexadecimal value of 0x5C.
        /// </summary>
        Backslash,

        /// <summary>
        /// Right Square Bracket. The value of 93. The hexadecimal value of 0x5D.
        /// </summary>
        RightSquareBracket,

        /// <summary>
        /// Circumflex Accent. The value of 94. The hexadecimal value of 0x5E.
        /// </summary>
        CircumflexAccent,

        /// <summary>
        /// Underscore. The value of 95. The hexadecimal value of 0x5F.
        /// </summary>
        Underscore,

        /// <summary>
        /// Grave Accent. The value of 96. The hexadecimal value of 0x60.
        /// </summary>
        GraveAccent,

        /// <summary>
        /// Small Letter A. The value of 97. The hexadecimal value of 0x61.
        /// </summary>
        SmallLetterA,

        /// <summary>
        /// Small Letter B. The value of 98. The hexadecimal value of 0x62.
        /// </summary>
        SmallLetterB,

        /// <summary>
        /// Small Letter C. The value of 99. The hexadecimal value of 0x63.
        /// </summary>
        SmallLetterC,

        /// <summary>
        /// Small Letter D. The value of 100. The hexadecimal value of 0x64.
        /// </summary>
        SmallLetterD,

        /// <summary>
        /// Small Letter E. The value of 101. The hexadecimal value of 0x65.
        /// </summary>
        SmallLetterE,

        /// <summary>
        /// Small Letter F. The value of 102. The hexadecimal value of 0x66.
        /// </summary>
        SmallLetterF,

        /// <summary>
        /// Small Letter G. The value of 103. The hexadecimal value of 0x67.
        /// </summary>
        SmallLetterG,

        /// <summary>
        /// Small Letter H. The value of 104. The hexadecimal value of 0x68.
        /// </summary>
        SmallLetterH,

        /// <summary>
        /// Small Letter I. The value of 105. The hexadecimal value of 0x69.
        /// </summary>
        SmallLetterI,

        /// <summary>
        /// Small Letter J. The value of 106. The hexadecimal value of 0x6A.
        /// </summary>
        SmallLetterJ,

        /// <summary>
        /// Small Letter K. The value of 107. The hexadecimal value of 0x6B.
        /// </summary>
        SmallLetterK,

        /// <summary>
        /// Small Letter L. The value of 108. The hexadecimal value of 0x6C.
        /// </summary>
        SmallLetterL,

        /// <summary>
        /// Small Letter M. The value of 109. The hexadecimal value of 0x6D.
        /// </summary>
        SmallLetterM,

        /// <summary>
        /// Small Letter N. The value of 110. The hexadecimal value of 0x6E.
        /// </summary>
        SmallLetterN,

        /// <summary>
        /// Small Letter O. The value of 111. The hexadecimal value of 0x6F.
        /// </summary>
        SmallLetterO,

        /// <summary>
        /// Small Letter P. The value of 112. The hexadecimal value of 0x70.
        /// </summary>
        SmallLetterP,

        /// <summary>
        /// Small Letter Q. The value of 113. The hexadecimal value of 0x71.
        /// </summary>
        SmallLetterQ,

        /// <summary>
        /// Small Letter R. The value of 114. The hexadecimal value of 0x72.
        /// </summary>
        SmallLetterR,

        /// <summary>
        /// Small Letter S. The value of 115. The hexadecimal value of 0x73.
        /// </summary>
        SmallLetterS,

        /// <summary>
        /// Small Letter T. The value of 116. The hexadecimal value of 0x74.
        /// </summary>
        SmallLetterT,

        /// <summary>
        /// Small Letter U. The value of 117. The hexadecimal value of 0x75.
        /// </summary>
        SmallLetterU,

        /// <summary>
        /// Small Letter V. The value of 118. The hexadecimal value of 0x76.
        /// </summary>
        SmallLetterV,

        /// <summary>
        /// Small Letter W. The value of 119. The hexadecimal value of 0x77.
        /// </summary>
        SmallLetterW,

        /// <summary>
        /// Small Letter X. The value of 120. The hexadecimal value of 0x78.
        /// </summary>
        SmallLetterX,

        /// <summary>
        /// Small Letter Y. The value of 121. The hexadecimal value of 0x79.
        /// </summary>
        SmallLetterY,

        /// <summary>
        /// Small Letter Z. The value of 122. The hexadecimal value of 0x7A.
        /// </summary>
        SmallLetterZ,

        /// <summary>
        /// Left Curly Bracket. The value of 123. The hexadecimal value of 0x7B.
        /// </summary>
        LeftCurlyBracket,

        /// <summary>
        /// Vertical Bar. The value of 124. The hexadecimal value of 0x7C.
        /// </summary>
        VerticalBar,

        /// <summary>
        /// Right Curly Bracket. The value of 125. The hexadecimal value of 0x7D.
        /// </summary>
        RightCurlyBracket,

        /// <summary>
        /// Tilde. The value of 126. The hexadecimal value of 0x7E.
        /// </summary>
        Tilde,

        /// <summary>
        /// Delete. The value of 127. The hexadecimal value of 0x7F.
        /// </summary>
        Delete,
    }
}
