# Patterns\.NotSemicolon Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotSemicolon()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotSemicolon) | Returns a pattern that matches a character that is not a semicolon\. |
| [NotSemicolon(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotSemicolon_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a semicolon\. |

## NotSemicolon\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotSemicolon"></a>

### Summary

Returns a pattern that matches a character that is not a semicolon\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotSemicolon()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotSemicolon\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotSemicolon_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a semicolon\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotSemicolon(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

