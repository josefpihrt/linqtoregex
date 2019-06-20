# Patterns\.NewLineChar Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NewLineChar()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NewLineChar) | Returns a pattern that matches a newline character\. Newline character is a carriage return or a linefeed\. |
| [NewLineChar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NewLineChar_System_Int32_) | Returns a pattern that matches a specified number of newline characters\. Newline character is a carriage return or a linefeed\. |

## NewLineChar\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NewLineChar"></a>

\
Returns a pattern that matches a newline character\. Newline character is a carriage return or a linefeed\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup NewLineChar()
```

### Returns

[CharGroup](../../CharGroup/README.md)

## NewLineChar\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NewLineChar_System_Int32_"></a>

\
Returns a pattern that matches a specified number of newline characters\. Newline character is a carriage return or a linefeed\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NewLineChar(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

