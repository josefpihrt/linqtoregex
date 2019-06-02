# Patterns\.NotAlphanumericUnderscore Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAlphanumericUnderscore()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAlphanumericUnderscore) | Returns a pattern that matches a character that is neither alphanumeric character nor underscore\. Alphanumeric character is a latin alphabet letter or an arabic digit\. |
| [NotAlphanumericUnderscore(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAlphanumericUnderscore_System_Int32_) | Returns a pattern that matches a character that is neither alphanumeric character nor underscore specified number of times\. Alphanumeric character is a latin alphabet letter or an arabic digit\. |

## NotAlphanumericUnderscore\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAlphanumericUnderscore"></a>

### Summary

Returns a pattern that matches a character that is neither alphanumeric character nor underscore\. Alphanumeric character is a latin alphabet letter or an arabic digit\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup NotAlphanumericUnderscore()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## NotAlphanumericUnderscore\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAlphanumericUnderscore_System_Int32_"></a>

### Summary

Returns a pattern that matches a character that is neither alphanumeric character nor underscore specified number of times\. Alphanumeric character is a latin alphabet letter or an arabic digit\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotAlphanumericUnderscore(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

