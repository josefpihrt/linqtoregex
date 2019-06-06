# PatternBuilder Class

[Home](../../../../../README.md) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Text.RegularExpressions.Linq](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Represents a class that enables to create a text representation of the [Pattern](../Pattern/README.md)\. This class cannot be inherited\.

```csharp
public sealed class PatternBuilder
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; PatternBuilder

## Properties

| Property | Summary |
| -------- | ------- |
| [Settings](Settings/README.md) | Gets the [PatternSettings](../PatternSettings/README.md) object that modifies the pattern\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Append(AsciiChar)](Append/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends specified character to this instance\. |
| [Append(Char)](Append/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_Char_) | Appends specified character to this instance\. |
| [Append(Char\[\])](Append/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_Char___) | Appends specified characters to this instance\. |
| [Append(CharGrouping)](Append/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Appends the text representation of the pattern to this instance\. |
| [Append(Int32)](Append/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_Int32_) | Appends specified character to this instance\. |
| [Append(Object)](Append/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_Object_) | Appends the pattern representation of an object\. The object must be convertible to [Pattern](../Pattern/README.md), [CharGrouping](../CharGrouping/README.md), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char), object array or [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)\. |
| [Append(Pattern)](Append/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_) | Appends the text representation of the pattern to this instance\. |
| [Append(String)](Append/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_String_) | Appends specified text to this instance\. |
| [AppendAnyChar()](AppendAnyChar/README.md) | Appends a pattern that matches any character\. |
| [AppendAnyCharNative()](AppendAnyCharNative/README.md) | Appends a pattern that matches any character except linefeed \(or any character if the [RegexOptions.Singleline](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions.singleline) option is applied\)\. |
| [AppendAssertion(Object)](AppendAssertion/README.md) | Appends a positive lookahead assertion with a specified content\. |
| [AppendBackAssertion(Object)](AppendBackAssertion/README.md) | Appends a positive lookbehind assertion with a specified content\. |
| [AppendBeginningOfInput()](AppendBeginningOfInput/README.md) | Appends a pattern that matches the beginning of the string\. |
| [AppendBeginningOfInputOrLine()](AppendBeginningOfInputOrLine/README.md) | Appends a pattern that matches the beginning of the string \(or line if the [RegexOptions.Multiline](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions.multiline) option is applied\)\. |
| [AppendCount(Int32)](AppendCount/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCount_System_Int32_) | Appends a quantifier that matches previous element specific number of times\. |
| [AppendCount(Int32, Boolean)](AppendCount/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCount_System_Int32_System_Boolean_) | Appends a quantifier that matches previous element specific number of times\. |
| [AppendCount(Int32, Int32)](AppendCount/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCount_System_Int32_System_Int32_) | Appends a quantifier that matches previous element from minimal to maximum times\. |
| [AppendCount(Int32, Int32, Boolean)](AppendCount/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCount_System_Int32_System_Int32_System_Boolean_) | Appends a quantifier that matches previous element from minimal to maximum times\. |
| [AppendCountFrom(Int32)](AppendCountFrom/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCountFrom_System_Int32_) | Appends a quantifier that matches previous element at least specified number of times\. |
| [AppendCountFrom(Int32, Boolean)](AppendCountFrom/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCountFrom_System_Int32_System_Boolean_) | Appends a quantifier that matches previous element at least specified number of times\. |
| [AppendDigit()](AppendDigit/README.md) | Appends a pattern that matches a digit character\. |
| [AppendEndOfInput()](AppendEndOfInput/README.md) | Appends a pattern that matches the end of the string\. |
| [AppendEndOfInputOrBeforeEndingLinefeed()](AppendEndOfInputOrBeforeEndingLinefeed/README.md) | Appends a pattern that is matched at the end of the string or before linefeed at the end of the string\. |
| [AppendEndOfInputOrLine()](AppendEndOfInputOrLine/README.md) | Appends a pattern that is matched at the end of the string \(or line if the [RegexOptions.Multiline](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions.multiline) option is applied\)\. End of line is defined as the position before a linefeed\. |
| [AppendGeneralCategory(GeneralCategory)](AppendGeneralCategory/README.md) | Appends a pattern that matches a character from a specified Unicode category\. |
| [AppendCharGroup(AsciiChar)](AppendCharGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends a pattern that matches a specified character\. |
| [AppendCharGroup(GeneralCategory)](AppendCharGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Appends a pattern that matches a character from a specified Unicode category\. |
| [AppendCharGroup(Char, Char)](AppendCharGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_System_Char_System_Char_) | Appends a pattern that matches a character in the specified range\. |
| [AppendCharGroup(CharGrouping)](AppendCharGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Appends a character group containing specified [CharGrouping](../CharGrouping/README.md)\. |
| [AppendCharGroup(NamedBlock)](AppendCharGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Appends a pattern that matches a character from a specified Unicode block\. |
| [AppendCharGroup(String)](AppendCharGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_System_String_) | Appends a character group containing specified characters\. |
| [AppendIfAssert(Object, Object, Object)](AppendIfAssert/README.md) | Appends an if construct\. |
| [AppendIfGroup(Int32, Object, Object)](AppendIfGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendIfGroup_System_Int32_System_Object_System_Object_) | Appends an if construct\. |
| [AppendIfGroup(String, Object, Object)](AppendIfGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendIfGroup_System_String_System_Object_System_Object_) | Appends an if construct\. |
| [AppendMaybe()](AppendMaybe/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendMaybe) | Appends a quantifier that matches previous element zero or one time\. |
| [AppendMaybe(Boolean)](AppendMaybe/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendMaybe_System_Boolean_) | Appends a quantifier that matches previous element zero or one time\. |
| [AppendMaybeCount(Int32)](AppendMaybeCount/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendMaybeCount_System_Int32_) | Appends a quantifier that matches previous element at most specified number of times\. |
| [AppendMaybeCount(Int32, Boolean)](AppendMaybeCount/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendMaybeCount_System_Int32_System_Boolean_) | Appends a quantifier that matches previous element at most specified number of times\. |
| [AppendMaybeMany()](AppendMaybeMany/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendMaybeMany) | Appends a quantifier that matches previous element zero or more times\. |
| [AppendMaybeMany(Boolean)](AppendMaybeMany/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendMaybeMany_System_Boolean_) | Appends a quantifier that matches previous element zero or more times\. |
| [AppendNamedBlock(NamedBlock)](AppendNamedBlock/README.md) | Appends a pattern that matches a character from a specified Unicode block\. |
| [AppendNamedGroup(String, Object)](AppendNamedGroup/README.md) | Appends a named group with a specified name and content\. |
| [AppendNegativeAssertion(Object)](AppendNegativeAssertion/README.md) | Appends a negative lookahead assertion with a specified content\. |
| [AppendNegativeBackAssertion(Object)](AppendNegativeBackAssertion/README.md) | Appends a negative lookbehind assertion with a specified content\. |
| [AppendNegativeCharGroup(AsciiChar)](AppendNegativeCharGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends a pattern that matches a character that is not a specified character\. |
| [AppendNegativeCharGroup(GeneralCategory)](AppendNegativeCharGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Appends a pattern that matches a character that is not from a specified Unicode category\. |
| [AppendNegativeCharGroup(Char, Char)](AppendNegativeCharGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_System_Char_System_Char_) | Appends a pattern that matches a character that is not in the specified range\. |
| [AppendNegativeCharGroup(CharGrouping)](AppendNegativeCharGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Appends a negative character group containing specified [CharGrouping](../CharGrouping/README.md)\. |
| [AppendNegativeCharGroup(NamedBlock)](AppendNegativeCharGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Appends a pattern that matches a character that is not from a specified Unicode block\. |
| [AppendNegativeCharGroup(String)](AppendNegativeCharGroup/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_System_String_) | Appends a negative character group containing specified characters\. |
| [AppendNegativeWordBoundary()](AppendNegativeWordBoundary/README.md) | Appends a pattern that is not matched on a boundary between a word character and a non\-word character\. |
| [AppendNonbacktrackingGroup(Object)](AppendNonbacktrackingGroup/README.md) | Appends a nonbacktracking group with a specified content\. |
| [AppendNoncapturingGroup(Object)](AppendNoncapturingGroup/README.md) | Appends a noncapturing group with a specified content\. |
| [AppendNotDigit()](AppendNotDigit/README.md) | Appends a pattern that matches a character that is not a digit character\. |
| [AppendNotGeneralCategory(GeneralCategory)](AppendNotGeneralCategory/README.md) | Appends a pattern that matches a character that is not from a specified Unicode category\. |
| [AppendNotNamedBlock(NamedBlock)](AppendNotNamedBlock/README.md) | Appends a pattern that matches a character that is not from a specified Unicode block\. |
| [AppendNotWhiteSpace()](AppendNotWhiteSpace/README.md) | Appends a pattern that matches a character that is not a white\-space character\. |
| [AppendNotWordChar()](AppendNotWordChar/README.md) | Appends a pattern that matches a character that is not a word character\. |
| [AppendNumberedGroup(Object)](AppendNumberedGroup/README.md) | Appends a numbered group with a specified content\. |
| [AppendOneMany()](AppendOneMany/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendOneMany) | Appends a quantifier that matches previous element one or more times\. |
| [AppendOneMany(Boolean)](AppendOneMany/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendOneMany_System_Boolean_) | Appends a quantifier that matches previous element one or more times\. |
| [AppendOptions(RegexOptions)](AppendOptions/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendOptions_System_Text_RegularExpressions_RegexOptions_) | Appends a pattern that applies specified options\. |
| [AppendOptions(RegexOptions, Object)](AppendOptions/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendOptions_System_Text_RegularExpressions_RegexOptions_System_Object_) | Appends a pattern that applies specified options to a specified pattern\. |
| [AppendOptions(RegexOptions, RegexOptions)](AppendOptions/README.md#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendOptions_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_) | Appends a pattern that applies and disables specified options to a specified pattern\. |
| [AppendPreviousMatchEnd()](AppendPreviousMatchEnd/README.md) | Appends a pattern that is matched at the position where the previous match ended\. |
| [AppendSubtraction(IBaseGroup, IExcludedGroup)](AppendSubtraction/README.md) | Appends a pattern that matches a character from a specified base group except characters from a specified excluded group\. |
| [AppendWhiteSpace()](AppendWhiteSpace/README.md) | Appends a pattern that matches a white\-space character\. |
| [AppendWordBoundary()](AppendWordBoundary/README.md) | Appends a pattern that is matched on a boundary between a word character and a non\-word character\. The pattern may be also matched on a word boundary at the beginning or end of the string\. |
| [AppendWordChar()](AppendWordChar/README.md) | Appends a pattern that matches a word character\. |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](ToString/README.md) | Converts the value of this instance to a [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\. \(Overrides [Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring)\) |

