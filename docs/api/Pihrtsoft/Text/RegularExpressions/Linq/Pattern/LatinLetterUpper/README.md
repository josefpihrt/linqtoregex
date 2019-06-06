# Pattern\.LatinLetterUpper Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LatinLetterUpper()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LatinLetterUpper) | Appends a pattern that matches a latin alphabet upper\-case letter\. |
| [LatinLetterUpper(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LatinLetterUpper_System_Int32_) | Appends a pattern that matches a specified number of latin alphabet upper\-case letters\. |

## LatinLetterUpper\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LatinLetterUpper"></a>

\
Appends a pattern that matches a latin alphabet upper\-case letter\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern LatinLetterUpper()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## LatinLetterUpper\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LatinLetterUpper_System_Int32_"></a>

\
Appends a pattern that matches a specified number of latin alphabet upper\-case letters\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LatinLetterUpper(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

