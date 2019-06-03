# Pattern\.SquareBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

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

[CharGroup](../../CharGroup/README.md)

## SquareBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SquareBracket_System_Int32_"></a>

### Summary

Appends a pattern that matches left or right square bracket specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup SquareBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

