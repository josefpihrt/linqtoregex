# Patterns\.NotAmpersand Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAmpersand()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAmpersand) | Returns a pattern that matches a character that is not an ampersand\. |
| [NotAmpersand(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAmpersand_System_Int32_) | Returns a pattern that matches a specified number of characters that are not an ampersand\. |

## NotAmpersand\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAmpersand"></a>

### Summary

Returns a pattern that matches a character that is not an ampersand\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotAmpersand()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotAmpersand\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAmpersand_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not an ampersand\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotAmpersand(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

