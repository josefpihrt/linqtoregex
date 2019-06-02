# Patterns\.EqualsSign Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EqualsSign()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_EqualsSign) | Returns a pattern that matches an equals sign\. |
| [EqualsSign(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_EqualsSign_System_Int32_) | Returns a pattern that matches a specified number of equals signs\. |

## EqualsSign\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_EqualsSign"></a>

### Summary

Returns a pattern that matches an equals sign\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern EqualsSign()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## EqualsSign\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_EqualsSign_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of equals signs\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup EqualsSign(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

