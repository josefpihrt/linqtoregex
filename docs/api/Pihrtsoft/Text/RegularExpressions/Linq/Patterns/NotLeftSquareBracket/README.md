# Patterns\.NotLeftSquareBracket Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotLeftSquareBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLeftSquareBracket) | Returns a pattern that matches a character that is not a left square bracket\. |
| [NotLeftSquareBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLeftSquareBracket_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a left square bracket\. |

## NotLeftSquareBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLeftSquareBracket"></a>

### Summary

Returns a pattern that matches a character that is not a left square bracket\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotLeftSquareBracket()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotLeftSquareBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLeftSquareBracket_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a left square bracket\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotLeftSquareBracket(int exactCount)
```

### Parameters

**exactCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

