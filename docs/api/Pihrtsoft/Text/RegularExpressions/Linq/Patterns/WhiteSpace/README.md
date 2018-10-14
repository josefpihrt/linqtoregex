# Patterns\.WhiteSpace Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WhiteSpace()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhiteSpace) | Returns a pattern that matches a white\-space character\. |
| [WhiteSpace(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhiteSpace_System_Int32_) | Returns a pattern that matches a specified number of white\-space characters\. |

## WhiteSpace\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhiteSpace"></a>

### Summary

Returns a pattern that matches a white\-space character\.

```csharp
public static CharPattern WhiteSpace()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## WhiteSpace\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhiteSpace_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of white\-space characters\.

```csharp
public static QuantifiedGroup WhiteSpace(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

