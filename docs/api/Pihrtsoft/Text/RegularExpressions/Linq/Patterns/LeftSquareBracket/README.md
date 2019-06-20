# Patterns\.LeftSquareBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LeftSquareBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftSquareBracket) | Returns a pattern that matches a left square bracket\. |
| [LeftSquareBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftSquareBracket_System_Int32_) | Returns a pattern that matches a specified number of left square brackets\. |

## LeftSquareBracket\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftSquareBracket"></a>

\
Returns a pattern that matches a left square bracket\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern LeftSquareBracket()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## LeftSquareBracket\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftSquareBracket_System_Int32_"></a>

\
Returns a pattern that matches a specified number of left square brackets\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LeftSquareBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

