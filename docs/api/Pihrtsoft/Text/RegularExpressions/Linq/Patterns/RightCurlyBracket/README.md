# Patterns\.RightCurlyBracket Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [RightCurlyBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_RightCurlyBracket) | Returns a pattern that matches a right curly bracket\. |
| [RightCurlyBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_RightCurlyBracket_System_Int32_) | Returns a pattern that matches a specified number of right curly brackets\. |

## RightCurlyBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_RightCurlyBracket"></a>

### Summary

Returns a pattern that matches a right curly bracket\.

```csharp
public static CharPattern RightCurlyBracket()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## RightCurlyBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_RightCurlyBracket_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of right curly brackets\.

```csharp
public static QuantifiedGroup RightCurlyBracket(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

