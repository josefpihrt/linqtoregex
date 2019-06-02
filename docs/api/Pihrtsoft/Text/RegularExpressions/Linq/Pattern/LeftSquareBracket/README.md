# Pattern\.LeftSquareBracket Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LeftSquareBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftSquareBracket) | Appends a pattern that matches a left square bracket\. |
| [LeftSquareBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftSquareBracket_System_Int32_) | Appends a pattern that matches a specified number of left square brackets\. |

## LeftSquareBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftSquareBracket"></a>

### Summary

Appends a pattern that matches a left square bracket\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern LeftSquareBracket()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## LeftSquareBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftSquareBracket_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of left square brackets\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LeftSquareBracket(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

