# Patterns\.NotDollar Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotDollar()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDollar) | Returns a pattern that matches a character that is not a dollar\. |
| [NotDollar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDollar_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a dollar\. |

## NotDollar\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDollar"></a>

### Summary

Returns a pattern that matches a character that is not a dollar\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotDollar()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotDollar\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDollar_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a dollar\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotDollar(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

