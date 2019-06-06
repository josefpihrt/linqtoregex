# Pattern\.WhiteSpaceExceptNewLine Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WhiteSpaceExceptNewLine()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhiteSpaceExceptNewLine) | Appends a pattern that matches a white\-space character except carriage return and linefeed\. |
| [WhiteSpaceExceptNewLine(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhiteSpaceExceptNewLine_System_Int32_) | Appends a pattern that matches a white\-space character except carriage return and linefeed\. The character has to be matched specified number of times\. |

## WhiteSpaceExceptNewLine\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhiteSpaceExceptNewLine"></a>

\
Appends a pattern that matches a white\-space character except carriage return and linefeed\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern WhiteSpaceExceptNewLine()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## WhiteSpaceExceptNewLine\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhiteSpaceExceptNewLine_System_Int32_"></a>

\
Appends a pattern that matches a white\-space character except carriage return and linefeed\. The character has to be matched specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup WhiteSpaceExceptNewLine(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

