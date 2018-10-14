# Patterns\.NotNumberSign Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotNumberSign()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotNumberSign) | Returns a pattern that matches a character that is not a number sign\. |
| [NotNumberSign(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotNumberSign_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a number sign\. |

## NotNumberSign\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotNumberSign"></a>

### Summary

Returns a pattern that matches a character that is not a number sign\.

```csharp
public static QuantifiablePattern NotNumberSign()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotNumberSign\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotNumberSign_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a number sign\.

```csharp
public static QuantifiedGroup NotNumberSign(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

