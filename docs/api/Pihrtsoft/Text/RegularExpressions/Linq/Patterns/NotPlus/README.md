# Patterns\.NotPlus Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotPlus()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPlus) | Returns a pattern that matches a character that is not a plus\. |
| [NotPlus(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPlus_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a plus\. |

## NotPlus\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPlus"></a>

### Summary

Returns a pattern that matches a character that is not a plus\.

```csharp
public static QuantifiablePattern NotPlus()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotPlus\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPlus_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a plus\.

```csharp
public static QuantifiedGroup NotPlus(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

