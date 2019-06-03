# Patterns\.AlphanumericLower Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AlphanumericLower()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AlphanumericLower) | Returns a pattern that matches a lower\-case alphanumeric character\. Alphanumeric character is a latin alphabet lower\-case letter or an arabic digit\. |
| [AlphanumericLower(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AlphanumericLower_System_Int32_) | Returns a pattern that matches a specified number of lower\-case alphanumeric characters\. Alphanumeric character is a latin alphabet lower\-case letter or an arabic digit\. |

## AlphanumericLower\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AlphanumericLower"></a>

### Summary

Returns a pattern that matches a lower\-case alphanumeric character\. Alphanumeric character is a latin alphabet lower\-case letter or an arabic digit\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern AlphanumericLower()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## AlphanumericLower\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AlphanumericLower_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of lower\-case alphanumeric characters\. Alphanumeric character is a latin alphabet lower\-case letter or an arabic digit\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup AlphanumericLower(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

