# Pattern\.NotPlus Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotPlus()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotPlus) | Appends a pattern that matches a character that is not a plus\. |
| [NotPlus(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotPlus_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a plus\. |

## NotPlus\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotPlus"></a>

\
Appends a pattern that matches a character that is not a plus\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotPlus()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotPlus\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotPlus_System_Int32_"></a>

\
Appends a pattern that matches a specified number of characters that are not a plus\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotPlus(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

