# Patterns\.Alphanumeric Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Alphanumeric()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Alphanumeric) | Returns a pattern that matches an alphanumeric character\. Alphanumeric character is a latin alphabet letter or an arabic digit\. |
| [Alphanumeric(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Alphanumeric_System_Int32_) | Returns a pattern that matches a specified number of alphanumeric characters\. Alphanumeric character is a latin alphabet letter or an arabic digit\. |

## Alphanumeric\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Alphanumeric"></a>

### Summary

Returns a pattern that matches an alphanumeric character\. Alphanumeric character is a latin alphabet letter or an arabic digit\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup Alphanumeric()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## Alphanumeric\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Alphanumeric_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of alphanumeric characters\. Alphanumeric character is a latin alphabet letter or an arabic digit\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Alphanumeric(int exactCount)
```

### Parameters

**exactCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

