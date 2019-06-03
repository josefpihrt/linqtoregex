# Pattern\.NotSlash Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotSlash()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSlash) | Appends a pattern that matches a character that is not a slash\. |
| [NotSlash(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSlash_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a slash\. |

## NotSlash\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSlash"></a>

### Summary

Appends a pattern that matches a character that is not a slash\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotSlash()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotSlash\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSlash_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not a slash\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotSlash(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

