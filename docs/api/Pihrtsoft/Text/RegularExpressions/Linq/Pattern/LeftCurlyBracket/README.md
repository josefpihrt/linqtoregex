# Pattern\.LeftCurlyBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LeftCurlyBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftCurlyBracket) | Appends a pattern that matches a left curly bracket\. |
| [LeftCurlyBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftCurlyBracket_System_Int32_) | Appends a pattern that matches a specified number of left curly brackets\. |

## LeftCurlyBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftCurlyBracket"></a>

\
Appends a pattern that matches a left curly bracket\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern LeftCurlyBracket()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## LeftCurlyBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftCurlyBracket_System_Int32_"></a>

\
Appends a pattern that matches a specified number of left curly brackets\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LeftCurlyBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

