# Pattern\.LatinLetter Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LatinLetter()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LatinLetter) | Appends a pattern that matches a latin alphabet letter\. |
| [LatinLetter(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LatinLetter_System_Int32_) | Appends a pattern that matches a specified number of latin alphabet letters\. |

## LatinLetter\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LatinLetter"></a>

\
Appends a pattern that matches a latin alphabet letter\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGroup LatinLetter()
```

### Returns

[CharGroup](../../CharGroup/README.md)

## LatinLetter\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LatinLetter_System_Int32_"></a>

\
Appends a pattern that matches a specified number of latin alphabet letters\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LatinLetter(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

