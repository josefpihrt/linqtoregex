# Patterns\.LeftParenthesis Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LeftParenthesis()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftParenthesis) | Returns a pattern that matches a left parenthesis\. |
| [LeftParenthesis(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftParenthesis_System_Int32_) | Returns a pattern that matches a specified number of left parentheses\. |

## LeftParenthesis\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftParenthesis"></a>

\
Returns a pattern that matches a left parenthesis\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern LeftParenthesis()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## LeftParenthesis\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftParenthesis_System_Int32_"></a>

\
Returns a pattern that matches a specified number of left parentheses\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LeftParenthesis(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

