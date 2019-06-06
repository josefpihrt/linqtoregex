# Pattern\.NotLetterLower Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotLetterLower()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLetterLower) | Appends a pattern that matches a character that is not a character from [GeneralCategory.LetterLowercase](../../GeneralCategory/LetterLowercase/README.md)\. |
| [NotLetterLower(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLetterLower_System_Int32_) | Appends a pattern that matches a character that is not a character from [GeneralCategory.LetterLowercase](../../GeneralCategory/LetterLowercase/README.md) specified number of times\. |

## NotLetterLower\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLetterLower"></a>

\
Appends a pattern that matches a character that is not a character from [GeneralCategory.LetterLowercase](../../GeneralCategory/LetterLowercase/README.md)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotLetterLower()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotLetterLower\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLetterLower_System_Int32_"></a>

\
Appends a pattern that matches a character that is not a character from [GeneralCategory.LetterLowercase](../../GeneralCategory/LetterLowercase/README.md) specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotLetterLower(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

