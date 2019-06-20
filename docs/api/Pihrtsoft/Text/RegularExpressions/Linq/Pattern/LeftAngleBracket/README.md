# Pattern\.LeftAngleBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LeftAngleBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftAngleBracket) | Appends a pattern that matches a left angle bracket \(less\-than sign\)\. |
| [LeftAngleBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftAngleBracket_System_Int32_) | Appends a pattern that matches a specified number of left angle brackets \(less\-than signs\)\. |

## LeftAngleBracket\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftAngleBracket"></a>

\
Appends a pattern that matches a left angle bracket \(less\-than sign\)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern LeftAngleBracket()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## LeftAngleBracket\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftAngleBracket_System_Int32_"></a>

\
Appends a pattern that matches a specified number of left angle brackets \(less\-than signs\)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LeftAngleBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

