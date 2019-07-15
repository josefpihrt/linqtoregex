# Pattern\.LeftSquareBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LeftSquareBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftSquareBracket) | Appends a pattern that matches a left square bracket\. |
| [LeftSquareBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftSquareBracket_System_Int32_) | Appends a pattern that matches a specified number of left square brackets\. |

## LeftSquareBracket\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftSquareBracket"></a>

\
Appends a pattern that matches a left square bracket\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern LeftSquareBracket()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## LeftSquareBracket\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftSquareBracket_System_Int32_"></a>

\
Appends a pattern that matches a specified number of left square brackets\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LeftSquareBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

