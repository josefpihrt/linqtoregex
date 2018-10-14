# Patterns\.NotLatinLetterLower Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotLatinLetterLower()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLatinLetterLower) | Returns a pattern that matches a character that is not a latin alphabet lower\-case letter\. |
| [NotLatinLetterLower(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLatinLetterLower_System_Int32_) | Returns a pattern that matches a character that is not a latin alphabet lower\-case letter specified number of times\. |

## NotLatinLetterLower\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLatinLetterLower"></a>

### Summary

Returns a pattern that matches a character that is not a latin alphabet lower\-case letter\.

```csharp
public static QuantifiablePattern NotLatinLetterLower()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotLatinLetterLower\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLatinLetterLower_System_Int32_"></a>

### Summary

Returns a pattern that matches a character that is not a latin alphabet lower\-case letter specified number of times\.

```csharp
public static QuantifiedGroup NotLatinLetterLower(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

