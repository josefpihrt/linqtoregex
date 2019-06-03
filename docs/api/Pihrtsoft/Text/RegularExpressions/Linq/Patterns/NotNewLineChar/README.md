# Patterns\.NotNewLineChar Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotNewLineChar()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotNewLineChar) | Returns a pattern that matches a character that is not a newline character\. Newline character is a carriage return or a linefeed\. |
| [NotNewLineChar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotNewLineChar_System_Int32_) | Returns a pattern that matches a character that is not a newline character specified number of times\. Newline character is a carriage return or a linefeed\. |

## NotNewLineChar\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotNewLineChar"></a>

### Summary

Returns a pattern that matches a character that is not a newline character\. Newline character is a carriage return or a linefeed\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup NotNewLineChar()
```

### Returns

[CharGroup](../../CharGroup/README.md)

## NotNewLineChar\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotNewLineChar_System_Int32_"></a>

### Summary

Returns a pattern that matches a character that is not a newline character specified number of times\. Newline character is a carriage return or a linefeed\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotNewLineChar(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

