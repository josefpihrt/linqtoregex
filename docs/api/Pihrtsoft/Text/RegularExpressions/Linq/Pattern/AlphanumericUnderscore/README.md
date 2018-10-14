# Pattern\.AlphanumericUnderscore Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AlphanumericUnderscore()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AlphanumericUnderscore) | Appends a pattern that matches an alphanumeric character or an underscore\. Alphanumeric character is a latin alphabet letter or an arabic digit\. |
| [AlphanumericUnderscore(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AlphanumericUnderscore_System_Int32_) | Appends a pattern that matches an alphanumeric character or an underscore specified number of times\. Alphanumeric character is a latin alphabet letter or an arabic digit\. |

## AlphanumericUnderscore\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AlphanumericUnderscore"></a>

### Summary

Appends a pattern that matches an alphanumeric character or an underscore\. Alphanumeric character is a latin alphabet letter or an arabic digit\.

```csharp
public CharGroup AlphanumericUnderscore()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## AlphanumericUnderscore\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AlphanumericUnderscore_System_Int32_"></a>

### Summary

Appends a pattern that matches an alphanumeric character or an underscore specified number of times\. Alphanumeric character is a latin alphabet letter or an arabic digit\.

```csharp
public QuantifiedGroup AlphanumericUnderscore(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

