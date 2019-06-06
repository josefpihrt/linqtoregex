# Pattern\.NotWordChar Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotWordChar()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotWordChar) | Appends a pattern that matches a character that is not a word character\. |
| [NotWordChar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotWordChar_System_Int32_) | Appends a pattern that matches a character that is not a word character specified number of times\. |

## NotWordChar\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotWordChar"></a>

\
Appends a pattern that matches a character that is not a word character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotWordChar()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotWordChar\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotWordChar_System_Int32_"></a>

\
Appends a pattern that matches a character that is not a word character specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotWordChar(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

