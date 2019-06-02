# Pattern\.NotNewLineChar Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotNewLineChar()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotNewLineChar) | Appends a pattern that matches a character that is not a newline character\. Newline character is a carriage return or a linefeed\. |
| [NotNewLineChar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotNewLineChar_System_Int32_) | Appends a pattern that matches a character that is not a newline character specified number of times\. Newline character is a carriage return or a linefeed\. |

## NotNewLineChar\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotNewLineChar"></a>

### Summary

Appends a pattern that matches a character that is not a newline character\. Newline character is a carriage return or a linefeed\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotNewLineChar()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotNewLineChar\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotNewLineChar_System_Int32_"></a>

### Summary

Appends a pattern that matches a character that is not a newline character specified number of times\. Newline character is a carriage return or a linefeed\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotNewLineChar(int exactCount)
```

### Parameters

**exactCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

