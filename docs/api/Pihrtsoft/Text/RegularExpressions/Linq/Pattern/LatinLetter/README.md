# Pattern\.LatinLetter Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LatinLetter()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LatinLetter) | Appends a pattern that matches a latin alphabet letter\. |
| [LatinLetter(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LatinLetter_System_Int32_) | Appends a pattern that matches a specified number of latin alphabet letters\. |

## LatinLetter\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LatinLetter"></a>

### Summary

Appends a pattern that matches a latin alphabet letter\.

```csharp
public CharGroup LatinLetter()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## LatinLetter\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LatinLetter_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of latin alphabet letters\.

```csharp
public QuantifiedGroup LatinLetter(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

