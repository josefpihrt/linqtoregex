# Patterns\.NotRightCurlyBracket Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotRightCurlyBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightCurlyBracket) | Returns a pattern that matches a character that is not a right curly bracket\. |
| [NotRightCurlyBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightCurlyBracket_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a right curly bracket\. |

## NotRightCurlyBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightCurlyBracket"></a>

### Summary

Returns a pattern that matches a character that is not a right curly bracket\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotRightCurlyBracket()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotRightCurlyBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightCurlyBracket_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a right curly bracket\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotRightCurlyBracket(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

