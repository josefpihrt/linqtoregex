# Pattern\.LeftParenthesis Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LeftParenthesis()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftParenthesis) | Appends a pattern that matches a left parenthesis\. |
| [LeftParenthesis(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftParenthesis_System_Int32_) | Appends a pattern that matches a specified number of left parentheses\. |

## LeftParenthesis\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftParenthesis"></a>

\
Appends a pattern that matches a left parenthesis\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern LeftParenthesis()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## LeftParenthesis\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LeftParenthesis_System_Int32_"></a>

\
Appends a pattern that matches a specified number of left parentheses\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LeftParenthesis(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

