# Patterns\.AtSign Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AtSign()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AtSign) | Returns a pattern that matches an at sign\. |
| [AtSign(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AtSign_System_Int32_) | Returns a pattern that matches a specified number of at signs\. |

## AtSign\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AtSign"></a>

### Summary

Returns a pattern that matches an at sign\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern AtSign()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## AtSign\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AtSign_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of at signs\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup AtSign(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

