# Patterns\.NotDot Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotDot()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDot) | Returns a pattern that matches a character that is not a dot\. |
| [NotDot(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDot_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a dot\. |

## NotDot\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDot"></a>

### Summary

Returns a pattern that matches a character that is not a dot\.

```csharp
public static QuantifiablePattern NotDot()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotDot\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDot_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a dot\.

```csharp
public static QuantifiedGroup NotDot(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

