# Pattern\.NotQuestionMark Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotQuestionMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotQuestionMark) | Appends a pattern that matches a character that is not a question mark\. |
| [NotQuestionMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotQuestionMark_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a question mark\. |

## NotQuestionMark\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotQuestionMark"></a>

\
Appends a pattern that matches a character that is not a question mark\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotQuestionMark()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotQuestionMark\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotQuestionMark_System_Int32_"></a>

\
Appends a pattern that matches a specified number of characters that are not a question mark\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotQuestionMark(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

