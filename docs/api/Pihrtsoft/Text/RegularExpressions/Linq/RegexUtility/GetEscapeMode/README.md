# RegexUtility\.GetEscapeMode Method

[Home](../../../../../../README.md)

**Containing Type**: [RegexUtility](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [GetEscapeMode(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_GetEscapeMode_System_Char_) | Gets a value indicating how a specified character is represented in the regular expression pattern\. |
| [GetEscapeMode(Char, Boolean)](#Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_GetEscapeMode_System_Char_System_Boolean_) | Gets a value indicating how a specified character is represented in the regular expression pattern, specifying whether the character is inside or outside of the character group\. |

## GetEscapeMode\(Char\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_GetEscapeMode_System_Char_"></a>

\
Gets a value indicating how a specified character is represented in the regular expression pattern\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharEscapeMode GetEscapeMode(char value)
```

### Parameters

**value** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

### Returns

[CharEscapeMode](../../CharEscapeMode/README.md)

## GetEscapeMode\(Char, Boolean\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_GetEscapeMode_System_Char_System_Boolean_"></a>

\
Gets a value indicating how a specified character is represented in the regular expression pattern, specifying whether the character is inside or outside of the character group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharEscapeMode GetEscapeMode(char value, bool inCharGroup)
```

### Parameters

**value** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

**inCharGroup** &ensp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

Indicates whether the character is inside or outside of the character group\.

### Returns

[CharEscapeMode](../../CharEscapeMode/README.md)

