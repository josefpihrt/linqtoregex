# Patterns\.NotPercent Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotPercent()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPercent) | Returns a pattern that matches a character that is not a percent\. |
| [NotPercent(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPercent_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a percent\. |

## NotPercent\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPercent"></a>

### Summary

Returns a pattern that matches a character that is not a percent\.

```csharp
public static QuantifiablePattern NotPercent()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotPercent\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPercent_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a percent\.

```csharp
public static QuantifiedGroup NotPercent(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

