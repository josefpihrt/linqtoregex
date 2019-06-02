# Patterns\.NotAlphanumericLower Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAlphanumericLower()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAlphanumericLower) | Returns a pattern that matches a character that is not a lower\-case alphanumeric character\. Alphanumeric character is a latin alphabet lower\-case letter or an arabic digit\. |
| [NotAlphanumericLower(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAlphanumericLower_System_Int32_) | Returns a pattern that matches a character that is not a lower\-case alphanumeric character specified number of times\. Alphanumeric character is a latin alphabet lower\-case letter or an arabic digit\. |

## NotAlphanumericLower\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAlphanumericLower"></a>

### Summary

Returns a pattern that matches a character that is not a lower\-case alphanumeric character\. Alphanumeric character is a latin alphabet lower\-case letter or an arabic digit\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotAlphanumericLower()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotAlphanumericLower\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAlphanumericLower_System_Int32_"></a>

### Summary

Returns a pattern that matches a character that is not a lower\-case alphanumeric character specified number of times\. Alphanumeric character is a latin alphabet lower\-case letter or an arabic digit\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotAlphanumericLower(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

