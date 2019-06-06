# RegexExtensions\.ReplaceGroupChar Method

[Home](../../../../../../../README.md)

**Containing Type**: [RegexExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ReplaceGroupChar(Regex, String, Char, Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_ReplaceGroupChar_System_Text_RegularExpressions_Regex_System_String_System_Char_System_Int32_) | Within a specified input string, replaces all groups with the specified number that match the regular expression with a string where each character is replaced with the specified character\. |
| [ReplaceGroupChar(Regex, String, Char, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_ReplaceGroupChar_System_Text_RegularExpressions_Regex_System_String_System_Char_System_String_) | Within a specified input string, replaces all groups with the specified name that match the regular expression with a string where each character is replaced with the specified character\. |

## ReplaceGroupChar\(Regex, String, Char, Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_ReplaceGroupChar_System_Text_RegularExpressions_Regex_System_String_System_Char_System_Int32_"></a>

\
Within a specified input string, replaces all groups with the specified number that match the regular expression with a string where each character is replaced with the specified character\.

```csharp
public static string ReplaceGroupChar(this System.Text.RegularExpressions.Regex regex, string input, char replacementChar, int groupNumber)
```

### Parameters

**regex** &ensp; [Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex)

The regular expression to be matched\.

**input** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**replacementChar** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The replacement char\.

**groupNumber** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of the group\.

### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**regex** or **input** is `null`\.

## ReplaceGroupChar\(Regex, String, Char, String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_ReplaceGroupChar_System_Text_RegularExpressions_Regex_System_String_System_Char_System_String_"></a>

\
Within a specified input string, replaces all groups with the specified name that match the regular expression with a string where each character is replaced with the specified character\.

```csharp
public static string ReplaceGroupChar(this System.Text.RegularExpressions.Regex regex, string input, char replacementChar, string groupName)
```

### Parameters

**regex** &ensp; [Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex)

The regular expression to be matched\.

**input** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**replacementChar** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The replacement char\.

**groupName** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group\.

### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**regex** or **input** is `null`\.

