# Patterns\.Hyphen Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Hyphen()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Hyphen) | Returns a pattern that matches a hyphen\. |
| [Hyphen(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Hyphen_System_Int32_) | Returns a pattern that matches a specified number of hyphens\. |

## Hyphen\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Hyphen"></a>

### Summary

Returns a pattern that matches a hyphen\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Hyphen()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Hyphen\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Hyphen_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of hyphens\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Hyphen(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

