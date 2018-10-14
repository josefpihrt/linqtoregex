# Patterns\.NotVerticalBar Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotVerticalBar()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotVerticalBar) | Returns a pattern that matches a character that is not a vertical bar\. |
| [NotVerticalBar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotVerticalBar_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a vertical bar\. |

## NotVerticalBar\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotVerticalBar"></a>

### Summary

Returns a pattern that matches a character that is not a vertical bar\.

```csharp
public static QuantifiablePattern NotVerticalBar()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotVerticalBar\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotVerticalBar_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a vertical bar\.

```csharp
public static QuantifiedGroup NotVerticalBar(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

