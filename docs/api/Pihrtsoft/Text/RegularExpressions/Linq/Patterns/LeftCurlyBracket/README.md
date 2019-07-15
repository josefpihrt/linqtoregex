# Patterns\.LeftCurlyBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LeftCurlyBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftCurlyBracket) | Returns a pattern that matches a left curly bracket\. |
| [LeftCurlyBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftCurlyBracket_System_Int32_) | Returns a pattern that matches a specified number of left curly brackets\. |

## LeftCurlyBracket\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftCurlyBracket"></a>

\
Returns a pattern that matches a left curly bracket\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern LeftCurlyBracket()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## LeftCurlyBracket\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftCurlyBracket_System_Int32_"></a>

\
Returns a pattern that matches a specified number of left curly brackets\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LeftCurlyBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

