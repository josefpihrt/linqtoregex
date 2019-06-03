# Patterns\.NotQuoteMark Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotQuoteMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotQuoteMark) | Returns a pattern that matches a character that is not a quote mark\. |
| [NotQuoteMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotQuoteMark_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a quote mark\. |

## NotQuoteMark\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotQuoteMark"></a>

### Summary

Returns a pattern that matches a character that is not a quote mark\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotQuoteMark()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotQuoteMark\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotQuoteMark_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a quote mark\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotQuoteMark(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

