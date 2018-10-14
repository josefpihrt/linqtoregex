# Patterns\.HexadecimalDigit Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [HexadecimalDigit()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_HexadecimalDigit) | Returns a pattern that matches a hexadecimal digit\. |
| [HexadecimalDigit(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_HexadecimalDigit_System_Int32_) | Returns a pattern that matches a specified number of hexadecimal digits\. |

## HexadecimalDigit\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_HexadecimalDigit"></a>

### Summary

Returns a pattern that matches a hexadecimal digit\.

```csharp
public static CharGroup HexadecimalDigit()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## HexadecimalDigit\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_HexadecimalDigit_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of hexadecimal digits\.

```csharp
public static QuantifiedGroup HexadecimalDigit(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

