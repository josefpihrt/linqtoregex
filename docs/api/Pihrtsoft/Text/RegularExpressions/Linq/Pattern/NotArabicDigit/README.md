# Pattern\.NotArabicDigit Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotArabicDigit()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotArabicDigit) | Appends a pattern that matches a character that is not an arabic digit\. |
| [NotArabicDigit(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotArabicDigit_System_Int32_) | Appends a pattern that matches a character that is not an arabic digit specified number of times\. |

## NotArabicDigit\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotArabicDigit"></a>

\
Appends a pattern that matches a character that is not an arabic digit\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotArabicDigit()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotArabicDigit\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotArabicDigit_System_Int32_"></a>

\
Appends a pattern that matches a character that is not an arabic digit specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotArabicDigit(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

