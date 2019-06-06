# Patterns\.LeftAngleBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LeftAngleBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftAngleBracket) | Returns a pattern that matches a left angle bracket \(less\-than sign\)\. |
| [LeftAngleBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftAngleBracket_System_Int32_) | Returns a pattern that matches a specified number of left angle brackets \(less\-than signs\)\. |

## LeftAngleBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftAngleBracket"></a>

\
Returns a pattern that matches a left angle bracket \(less\-than sign\)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern LeftAngleBracket()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## LeftAngleBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LeftAngleBracket_System_Int32_"></a>

\
Returns a pattern that matches a specified number of left angle brackets \(less\-than signs\)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LeftAngleBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

