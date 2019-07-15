# Pattern\.NotSemicolon Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotSemicolon()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSemicolon) | Appends a pattern that matches a character that is not a semicolon\. |
| [NotSemicolon(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSemicolon_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a semicolon\. |

## NotSemicolon\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSemicolon"></a>

\
Appends a pattern that matches a character that is not a semicolon\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotSemicolon()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotSemicolon\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSemicolon_System_Int32_"></a>

\
Appends a pattern that matches a specified number of characters that are not a semicolon\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotSemicolon(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

