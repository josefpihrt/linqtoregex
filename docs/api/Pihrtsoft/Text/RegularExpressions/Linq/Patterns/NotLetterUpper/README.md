# Patterns\.NotLetterUpper Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotLetterUpper()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLetterUpper) | Returns a pattern that matches a character that is not a character from [GeneralCategory.LetterUppercase](../../GeneralCategory/LetterUppercase/README.md)\. |
| [NotLetterUpper(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLetterUpper_System_Int32_) | Returns a pattern that matches a character that is not a character from [GeneralCategory.LetterUppercase](../../GeneralCategory/LetterUppercase/README.md) specified number of times\. |

## NotLetterUpper\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLetterUpper"></a>

### Summary

Returns a pattern that matches a character that is not a character from [GeneralCategory.LetterUppercase](../../GeneralCategory/LetterUppercase/README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotLetterUpper()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotLetterUpper\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLetterUpper_System_Int32_"></a>

### Summary

Returns a pattern that matches a character that is not a character from [GeneralCategory.LetterUppercase](../../GeneralCategory/LetterUppercase/README.md) specified number of times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotLetterUpper(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

