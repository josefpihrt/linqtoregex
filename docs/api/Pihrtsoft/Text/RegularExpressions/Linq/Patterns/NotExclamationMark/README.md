# Patterns\.NotExclamationMark Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotExclamationMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotExclamationMark) | Returns a pattern that matches a character that is not an exclamation mark\. |
| [NotExclamationMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotExclamationMark_System_Int32_) | Returns a pattern that matches a specified number of characters that are not an exclamation mark\. |

## NotExclamationMark\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotExclamationMark"></a>

### Summary

Returns a pattern that matches a character that is not an exclamation mark\.

```csharp
public static QuantifiablePattern NotExclamationMark()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotExclamationMark\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotExclamationMark_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not an exclamation mark\.

```csharp
public static QuantifiedGroup NotExclamationMark(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

