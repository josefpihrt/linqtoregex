# Patterns\.LeftCurlyBracket Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LeftCurlyBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftCurlyBracket) | Returns a pattern that matches a left curly bracket\. |
| [LeftCurlyBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftCurlyBracket_System_Int32_) | Returns a pattern that matches a specified number of left curly brackets\. |

## LeftCurlyBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftCurlyBracket"></a>

### Summary

Returns a pattern that matches a left curly bracket\.

```csharp
public static CharPattern LeftCurlyBracket()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## LeftCurlyBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftCurlyBracket_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of left curly brackets\.

```csharp
public static QuantifiedGroup LeftCurlyBracket(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

