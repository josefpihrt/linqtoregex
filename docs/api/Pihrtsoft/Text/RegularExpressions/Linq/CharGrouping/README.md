# CharGrouping Class

[Home](../../../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Methods](#methods) &#x2022; [Operators](#operators)

**Namespace**: [Pihrtsoft.Text.RegularExpressions.Linq](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Represents an immutable content of the character group\. Content can be a base group or an excluded group\. This class is abstract\.

```csharp
public abstract class CharGrouping : Pihrtsoft.Text.RegularExpressions.Linq.IBaseGroup,
    Pihrtsoft.Text.RegularExpressions.Linq.IExcludedGroup
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; CharGrouping

### Implements

* [IBaseGroup](../IBaseGroup/README.md)
* [IExcludedGroup](../IExcludedGroup/README.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [CharGrouping()](-ctor/README.md) | Creates and returns a new instance of the [CharGrouping](./README.md) class\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Alphanumeric()](Alphanumeric/README.md) | Appends a pattern that matches a latin alphabet letter or an arabic digit\. |
| [AlphanumericUnderscore()](AlphanumericUnderscore/README.md) | Appends a pattern that matches a latin alphabet letter, an arabic digit or an underscore\. |
| [Ampersand()](Ampersand/README.md) | Matches an ampersand\. |
| [Apostrophe()](Apostrophe/README.md) | Appends a pattern that matches an apostrophe\. |
| [Append(AsciiChar)](Append/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends a pattern that matches specified Unicode character\. |
| [Append(GeneralCategory)](Append/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Appends a pattern that matches a character from the specified Unicode category\. |
| [Append(Char)](Append/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_System_Char_) | Appends a pattern that matches specified Unicode character\. |
| [Append(NamedBlock)](Append/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Appends a pattern that matches a character from the specified Unicode block\. |
| [Append(String)](Append/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_System_String_) | Appends a pattern that matches any one of the specified characters\. |
| [AppendBaseGroupTo(PatternBuilder)](AppendBaseGroupTo/README.md) | Appends the text representation of the current instance of the character grouping to the specified [PatternBuilder](../PatternBuilder/README.md)\. \(Implements [IBaseGroup.AppendBaseGroupTo](../IBaseGroup/AppendBaseGroupTo/README.md)\) |
| [AppendExcludedGroupTo(PatternBuilder)](AppendExcludedGroupTo/README.md) | Appends the text representation of the character group containing the current instance to the specified [PatternBuilder](../PatternBuilder/README.md)\. \(Implements [IExcludedGroup.AppendExcludedGroupTo](../IExcludedGroup/AppendExcludedGroupTo/README.md)\) |
| [AppendItemContentTo(PatternBuilder)](AppendItemContentTo/README.md) | Appends a core content of the current instance to a specified [PatternBuilder](../PatternBuilder/README.md)\. |
| [ArabicDigit()](ArabicDigit/README.md) | Matches an arabic digit\. |
| [Asterisk()](Asterisk/README.md) | Appends a pattern that matches an asterisk\. |
| [AtSign()](AtSign/README.md) | Appends a pattern that matches an at sign\. |
| [Backslash()](Backslash/README.md) | Appends a pattern that matches a backslash\. |
| [CarriageReturn()](CarriageReturn/README.md) | Appends a pattern that matches a carriage return\. |
| [CircumflexAccent()](CircumflexAccent/README.md) | Appends a pattern that matches a circumflex accent\. |
| [Colon()](Colon/README.md) | Appends a pattern that matches a colon\. |
| [Comma()](Comma/README.md) | Appends a pattern that matches a comma\. |
| [CurlyBracket()](CurlyBracket/README.md) | Appends a pattern that matches left or right curly bracket\. |
| [Digit()](Digit/README.md) | Appends a pattern that matches a character from the digit character class\. |
| [Dollar()](Dollar/README.md) | Appends a pattern that matches a dollar character\. |
| [Dot()](Dot/README.md) | Appends a pattern that matches a period\. |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [EqualsSign()](EqualsSign/README.md) | Appends a pattern that matches an equals sign\. |
| [ExclamationMark()](ExclamationMark/README.md) | Appends a pattern that matches an exclamation mark\. |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GraveAccent()](GraveAccent/README.md) | Appends a pattern that matches a grave accent\. |
| [Hyphen()](Hyphen/README.md) | Appends a pattern that matches a hyphen\. |
| [Character(AsciiChar)](Character/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends a pattern that matches specified Unicode character\. |
| [Character(GeneralCategory)](Character/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Appends a pattern that matches a character from the specified Unicode category\. |
| [Character(Char)](Character/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_System_Char_) | Appends a pattern that matches specified Unicode character\. |
| [Character(NamedBlock)](Character/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Appends a pattern that matches a character from the specified Unicode block\. |
| [Character(String)](Character/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_System_String_) | Appends a pattern that matches any one of the specified characters\. |
| [LatinLetter()](LatinLetter/README.md) | Appends a pattern that matches a latin alphabet letter\. |
| [LeftAngleBracket()](LeftAngleBracket/README.md) | Appends a pattern that matches a left angle bracket \(less\-than sign\)\. |
| [LeftCurlyBracket()](LeftCurlyBracket/README.md) | Appends a pattern that matches left curly bracket\. |
| [LeftParenthesis()](LeftParenthesis/README.md) | Appends a pattern that matches left parenthesis\. |
| [LeftSquareBracket()](LeftSquareBracket/README.md) | Appends a pattern that matches left square bracket\. |
| [Linefeed()](Linefeed/README.md) | Appends a pattern that matches a linefeed\. |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [NewLineChar()](NewLineChar/README.md) | Appends a pattern that matches a new line character, i\.e\. a linefeed character or a carriage return character\. |
| [Not(GeneralCategory)](Not/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Not_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Appends a pattern that matches a character that is not from the specified Unicode category\. |
| [Not(NamedBlock)](Not/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Not_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Appends a pattern that matches a character that is not from the specified Unicode block\. |
| [NotDigit()](NotDigit/README.md) | Appends a pattern that matches a character that is not from the digit character class\. |
| [NotWhiteSpace()](NotWhiteSpace/README.md) | Appends a pattern that matches a character that is not from the white\-space character class\. |
| [NotWordChar()](NotWordChar/README.md) | Appends a pattern that matches a character that is not from the word character class\. |
| [NumberSign()](NumberSign/README.md) | Appends a pattern that matches a number sign\. |
| [Parenthesis()](Parenthesis/README.md) | Appends a pattern that matches left or right parenthesis\. |
| [Percent()](Percent/README.md) | Appends a pattern that matches a percent sign\. |
| [Plus()](Plus/README.md) | Appends a pattern that matches a plus sign\. |
| [QuestionMark()](QuestionMark/README.md) | Appends a pattern that matches a question mark\. |
| [QuoteMark()](QuoteMark/README.md) | Appends a pattern that matches a quotation mark\. |
| [Range(Char, Char)](Range/README.md) | Appends a pattern that matches any one character from the specified range\. |
| [RightAngleBracket()](RightAngleBracket/README.md) | Appends a pattern that matches a right angle bracket \(greater\-than sign\)\. |
| [RightCurlyBracket()](RightCurlyBracket/README.md) | Appends a pattern that matches right curly bracket\. |
| [RightParenthesis()](RightParenthesis/README.md) | Appends a pattern that matches right parenthesis\. |
| [RightSquareBracket()](RightSquareBracket/README.md) | Appends a pattern that matches right square bracket\. |
| [Semicolon()](Semicolon/README.md) | Appends a pattern that matches a semicolon\. |
| [Slash()](Slash/README.md) | Appends a pattern that matches a slash\. |
| [SlashOrBackslash()](SlashOrBackslash/README.md) | Appends a pattern that matches slash or backslash\. |
| [Space()](Space/README.md) | Appends a pattern that matches a space character\. |
| [SquareBracket()](SquareBracket/README.md) | Appends a pattern that matches left or right square bracket\. |
| [Tab()](Tab/README.md) | Appends a pattern that matches a tab\. |
| [Tilde()](Tilde/README.md) | Appends a pattern that matches a tilde\. |
| [ToGroup()](ToGroup/README.md) | Converts the current instance of the [CharGrouping](./README.md) to the positive character group\. |
| [ToNegativeGroup()](ToNegativeGroup/README.md) | Converts the current instance of the [CharGrouping](./README.md) to the negative character group\. |
| [ToString()](ToString/README.md) | Returns the text representation of this instance\. \(Overrides [Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring)\) |
| [Underscore()](Underscore/README.md) | Appends a pattern that matches an underscore\. |
| [VerticalBar()](VerticalBar/README.md) | Appends a pattern that matches a vertical bar\. |
| [WhiteSpace()](WhiteSpace/README.md) | Appends a pattern that matches a character from the white\-space character class\. |
| [WordChar()](WordChar/README.md) | Appends a pattern that matches a character from the word character class\. |

## Operators

| Operator | Summary |
| -------- | ------- |
| [Addition(Char, CharGrouping)](op_Addition/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Addition_System_Char_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Concatenate two elements into a new [CharGrouping](./README.md)\. |
| [Addition(CharGrouping, Char)](op_Addition/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_System_Char_) | Concatenate two elements into a new [CharGrouping](./README.md)\. |
| [Addition(CharGrouping, CharGrouping)](op_Addition/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Concatenate two elements into a new [CharGrouping](./README.md)\. |
| [Addition(CharGrouping, String)](op_Addition/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_System_String_) | Concatenate two elements into a new [CharGrouping](./README.md)\. |
| [Addition(String, CharGrouping)](op_Addition/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Addition_System_String_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Concatenate two elements into a new [CharGrouping](./README.md)\. |
| [Explicit(Char to CharGrouping)](op_Explicit/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Explicit_System_Char__Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping) | Converts specified character to an instance of the [CharGrouping](./README.md) class\. |
| [Explicit(String to CharGrouping)](op_Explicit/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Explicit_System_String__Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping) | Converts specified characters to an instance of the [CharGrouping](./README.md) class\. |
| [LogicalNot(CharGrouping)](op_LogicalNot/README.md) | Converts the current instance to the negative character group\. |
| [Subtraction(CharGrouping, CharGroup)](op_Subtraction/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |
| [Subtraction(CharGrouping, CharGrouping)](op_Subtraction/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |
| [Subtraction(CharGrouping, CharPattern)](op_Subtraction/README.md#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |

