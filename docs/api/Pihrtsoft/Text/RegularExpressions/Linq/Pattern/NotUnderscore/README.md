# Pattern\.NotUnderscore Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotUnderscore()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotUnderscore) | Appends a pattern that matches a character that is not an underscore\. |
| [NotUnderscore(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotUnderscore_System_Int32_) | Appends a pattern that matches a specified number of characters that are not an underscore\. |

## NotUnderscore\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotUnderscore"></a>

### Summary

Appends a pattern that matches a character that is not an underscore\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotUnderscore()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotUnderscore\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotUnderscore_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not an underscore\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotUnderscore(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.
