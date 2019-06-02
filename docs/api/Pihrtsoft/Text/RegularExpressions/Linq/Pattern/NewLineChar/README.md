# Pattern\.NewLineChar Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NewLineChar()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NewLineChar) | Appends a pattern that matches a newline character\. Newline character is a carriage return or a linefeed\. |
| [NewLineChar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NewLineChar_System_Int32_) | Appends a pattern that matches a specified number of newline characters\. Newline character is a carriage return or a linefeed\. |

## NewLineChar\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NewLineChar"></a>

### Summary

Appends a pattern that matches a newline character\. Newline character is a carriage return or a linefeed\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NewLineChar()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NewLineChar\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NewLineChar_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of newline characters\. Newline character is a carriage return or a linefeed\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NewLineChar(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

