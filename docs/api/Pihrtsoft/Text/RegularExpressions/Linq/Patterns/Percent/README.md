# Patterns\.Percent Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Percent()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Percent) | Returns a pattern that matches a percent\. |
| [Percent(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Percent_System_Int32_) | Returns a pattern that matches a specified number of percents\. |

## Percent\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Percent"></a>

### Summary

Returns a pattern that matches a percent\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Percent()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Percent\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Percent_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of percents\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Percent(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

