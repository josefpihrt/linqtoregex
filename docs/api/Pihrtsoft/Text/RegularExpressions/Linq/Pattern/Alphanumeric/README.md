# Pattern\.Alphanumeric Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Alphanumeric()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Alphanumeric) | Appends a pattern that matches an alphanumeric character\. Alphanumeric character is a latin alphabet letter or an arabic digit\. |
| [Alphanumeric(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Alphanumeric_System_Int32_) | Appends a pattern that matches a specified number of alphanumeric characters\. Alphanumeric character is a latin alphabet letter or an arabic digit\. |

## Alphanumeric\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Alphanumeric"></a>

### Summary

Appends a pattern that matches an alphanumeric character\. Alphanumeric character is a latin alphabet letter or an arabic digit\.

```csharp
public CharGroup Alphanumeric()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## Alphanumeric\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Alphanumeric_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of alphanumeric characters\. Alphanumeric character is a latin alphabet letter or an arabic digit\.

```csharp
public QuantifiedGroup Alphanumeric(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

