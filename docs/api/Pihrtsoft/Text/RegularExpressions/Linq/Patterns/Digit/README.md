# Patterns\.Digit Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Digit()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Digit) | Returns a pattern that matches a digit character\. |
| [Digit(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Digit_System_Int32_) | Returns a pattern that matches a specified number of digit characters\. |

## Digit\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Digit"></a>

### Summary

Returns a pattern that matches a digit character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Digit()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Digit\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Digit_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of digit characters\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Digit(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

