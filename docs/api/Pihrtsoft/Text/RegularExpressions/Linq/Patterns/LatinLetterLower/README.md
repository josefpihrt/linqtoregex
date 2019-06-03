# Patterns\.LatinLetterLower Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LatinLetterLower()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LatinLetterLower) | Returns a pattern that matches a latin alphabet lower\-case letter\. |
| [LatinLetterLower(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LatinLetterLower_System_Int32_) | Returns a pattern that matches a specified number of latin alphabet lower\-case letters\. |

## LatinLetterLower\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LatinLetterLower"></a>

### Summary

Returns a pattern that matches a latin alphabet lower\-case letter\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern LatinLetterLower()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## LatinLetterLower\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LatinLetterLower_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of latin alphabet lower\-case letters\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LatinLetterLower(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

