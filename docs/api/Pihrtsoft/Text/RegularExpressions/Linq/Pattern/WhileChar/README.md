# Pattern\.WhileChar Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WhileChar(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends a pattern that matches a specified character zero or more times\. |
| [WhileChar(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileChar_System_Char_) | Appends a pattern that matches a specified character zero or more times\. |
| [WhileChar(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Appends a pattern that matches a specified character zero or more times\. |

## WhileChar\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

### Summary

Appends a pattern that matches a specified character zero or more times\.

```csharp
public Pattern WhileChar(AsciiChar value)
```

### Parameters

**value**

An enumerated constant that identifies ASCII character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

## WhileChar\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileChar_System_Char_"></a>

### Summary

Appends a pattern that matches a specified character zero or more times\.

```csharp
public Pattern WhileChar(char value)
```

### Parameters

**value**

A Unicode character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

## WhileChar\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

### Summary

Appends a pattern that matches a specified character zero or more times\.

```csharp
public Pattern WhileChar(CharGrouping value)
```

### Parameters

**value**

A set of Unicode characters\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

