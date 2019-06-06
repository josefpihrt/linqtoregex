# Patterns\.LetterLower Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LetterLower()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LetterLower) | Returns a pattern that matches a character from [GeneralCategory.LetterLowercase](../../GeneralCategory/LetterLowercase/README.md)\. |
| [LetterLower(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LetterLower_System_Int32_) | Returns a pattern that matches a specified number of letters from [GeneralCategory.LetterLowercase](../../GeneralCategory/LetterLowercase/README.md)\. |

## LetterLower\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LetterLower"></a>

\
Returns a pattern that matches a character from [GeneralCategory.LetterLowercase](../../GeneralCategory/LetterLowercase/README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern LetterLower()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## LetterLower\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_LetterLower_System_Int32_"></a>

\
Returns a pattern that matches a specified number of letters from [GeneralCategory.LetterLowercase](../../GeneralCategory/LetterLowercase/README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup LetterLower(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

