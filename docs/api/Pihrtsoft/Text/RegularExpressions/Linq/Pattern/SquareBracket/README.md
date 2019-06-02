# Pattern\.SquareBracket Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SquareBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SquareBracket) | Appends a pattern that matches left or right square bracket\. |
| [SquareBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SquareBracket_System_Int32_) | Appends a pattern that matches left or right square bracket specified number of times\. |

## SquareBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SquareBracket"></a>

### Summary

Appends a pattern that matches left or right square bracket\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGroup SquareBracket()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## SquareBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SquareBracket_System_Int32_"></a>

### Summary

Appends a pattern that matches left or right square bracket specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup SquareBracket(int exactCount)
```

### Parameters

**exactCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

