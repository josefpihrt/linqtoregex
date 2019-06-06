# Pattern\.NotHexadecimalDigit Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotHexadecimalDigit()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotHexadecimalDigit) | Appends a pattern that matches a character that is not a hexadecimal digit\. |
| [NotHexadecimalDigit(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotHexadecimalDigit_System_Int32_) | Appends a pattern that matches a character that is not a hexadecimal digit specified number of times\. |

## NotHexadecimalDigit\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotHexadecimalDigit"></a>

\
Appends a pattern that matches a character that is not a hexadecimal digit\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotHexadecimalDigit()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotHexadecimalDigit\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotHexadecimalDigit_System_Int32_"></a>

\
Appends a pattern that matches a character that is not a hexadecimal digit specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotHexadecimalDigit(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

