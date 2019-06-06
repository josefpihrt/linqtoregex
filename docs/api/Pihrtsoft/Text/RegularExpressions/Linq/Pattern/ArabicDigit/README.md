# Pattern\.ArabicDigit Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ArabicDigit()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_ArabicDigit) | Appends a pattern that matches an arabic digit\. |
| [ArabicDigit(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_ArabicDigit_System_Int32_) | Appends a pattern that matches a specified number of arabic digits\. |

## ArabicDigit\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_ArabicDigit"></a>

\
Appends a pattern that matches an arabic digit\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern ArabicDigit()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## ArabicDigit\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_ArabicDigit_System_Int32_"></a>

\
Appends a pattern that matches a specified number of arabic digits\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup ArabicDigit(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

