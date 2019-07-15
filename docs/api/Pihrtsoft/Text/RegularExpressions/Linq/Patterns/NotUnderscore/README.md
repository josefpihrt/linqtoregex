# Patterns\.NotUnderscore Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotUnderscore()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotUnderscore) | Returns a pattern that matches a character that is not an underscore\. |
| [NotUnderscore(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotUnderscore_System_Int32_) | Returns a pattern that matches a specified number of characters that are not an underscore\. |

## NotUnderscore\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotUnderscore"></a>

\
Returns a pattern that matches a character that is not an underscore\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotUnderscore()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotUnderscore\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotUnderscore_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not an underscore\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotUnderscore(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

