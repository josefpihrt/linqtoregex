# Pattern\.NotTilde Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotTilde()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotTilde) | Appends a pattern that matches a character that is not a tilde\. |
| [NotTilde(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotTilde_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a tilde\. |

## NotTilde\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotTilde"></a>

### Summary

Appends a pattern that matches a character that is not a tilde\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotTilde()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotTilde\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotTilde_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not a tilde\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotTilde(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

