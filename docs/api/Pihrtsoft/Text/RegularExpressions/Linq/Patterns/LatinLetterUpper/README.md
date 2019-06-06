# Patterns\.LatinLetterUpper Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LatinLetterUpper()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LatinLetterUpper) | Returns a pattern that matches a latin alphabet upper\-case letter\. |
| [LatinLetterUpper(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LatinLetterUpper_System_Int32_) | Returns a pattern that matches a specified number of latin alphabet upper\-case letters\. |

## LatinLetterUpper\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LatinLetterUpper"></a>

\
Returns a pattern that matches a latin alphabet upper\-case letter\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern LatinLetterUpper()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## LatinLetterUpper\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LatinLetterUpper_System_Int32_"></a>

\
Returns a pattern that matches a specified number of latin alphabet upper\-case letters\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LatinLetterUpper(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

