# Patterns\.NotTilde Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotTilde()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotTilde) | Returns a pattern that matches a character that is not a tilde\. |
| [NotTilde(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotTilde_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a tilde\. |

## NotTilde\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotTilde"></a>

### Summary

Returns a pattern that matches a character that is not a tilde\.

```csharp
public static QuantifiablePattern NotTilde()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotTilde\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotTilde_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a tilde\.

```csharp
public static QuantifiedGroup NotTilde(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

