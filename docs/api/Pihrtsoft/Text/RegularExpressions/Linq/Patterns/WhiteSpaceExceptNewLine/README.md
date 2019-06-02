# Patterns\.WhiteSpaceExceptNewLine Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WhiteSpaceExceptNewLine()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhiteSpaceExceptNewLine) | Returns a pattern that matches a white\-space character except carriage return and linefeed\. |
| [WhiteSpaceExceptNewLine(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhiteSpaceExceptNewLine_System_Int32_) | Returns a pattern that matches a white\-space character except carriage return and linefeed\. The character has to be matched specified number of times\. |

## WhiteSpaceExceptNewLine\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhiteSpaceExceptNewLine"></a>

### Summary

Returns a pattern that matches a white\-space character except carriage return and linefeed\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharSubtraction WhiteSpaceExceptNewLine()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharSubtraction](../../CharSubtraction/README.md)

## WhiteSpaceExceptNewLine\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhiteSpaceExceptNewLine_System_Int32_"></a>

### Summary

Returns a pattern that matches a white\-space character except carriage return and linefeed\. The character has to be matched specified number of times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup WhiteSpaceExceptNewLine(int exactCount)
```

### Parameters

**exactCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

