# Patterns\.LeftSquareBracket Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LeftSquareBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftSquareBracket) | Returns a pattern that matches a left square bracket\. |
| [LeftSquareBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftSquareBracket_System_Int32_) | Returns a pattern that matches a specified number of left square brackets\. |

## LeftSquareBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftSquareBracket"></a>

### Summary

Returns a pattern that matches a left square bracket\.

```csharp
public static CharPattern LeftSquareBracket()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## LeftSquareBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftSquareBracket_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of left square brackets\.

```csharp
public static QuantifiedGroup LeftSquareBracket(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

