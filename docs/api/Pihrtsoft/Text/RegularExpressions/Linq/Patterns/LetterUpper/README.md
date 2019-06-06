# Patterns\.LetterUpper Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LetterUpper()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LetterUpper) | Returns a pattern that matches a character from [GeneralCategory.LetterUppercase](../../GeneralCategory/LetterUppercase/README.md)\. |
| [LetterUpper(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LetterUpper_System_Int32_) | Returns a pattern that matches a specified number of letters from [GeneralCategory.LetterUppercase](../../GeneralCategory/LetterUppercase/README.md)\. |

## LetterUpper\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LetterUpper"></a>

\
Returns a pattern that matches a character from [GeneralCategory.LetterUppercase](../../GeneralCategory/LetterUppercase/README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern LetterUpper()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## LetterUpper\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LetterUpper_System_Int32_"></a>

\
Returns a pattern that matches a specified number of letters from [GeneralCategory.LetterUppercase](../../GeneralCategory/LetterUppercase/README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LetterUpper(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

