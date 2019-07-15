# Pattern\.NotCarriageReturn Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotCarriageReturn()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotCarriageReturn) | Appends a pattern that matches a character that is not a carriage return\. |
| [NotCarriageReturn(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotCarriageReturn_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a carriage return\. |

## NotCarriageReturn\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotCarriageReturn"></a>

\
Appends a pattern that matches a character that is not a carriage return\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotCarriageReturn()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotCarriageReturn\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotCarriageReturn_System_Int32_"></a>

\
Appends a pattern that matches a specified number of characters that are not a carriage return\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotCarriageReturn(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

