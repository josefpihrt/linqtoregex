# Pattern\.LetterUpper Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LetterUpper()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LetterUpper) | Appends a pattern that matches a character from [GeneralCategory.LetterUppercase](../../GeneralCategory/LetterUppercase/README.md)\. |
| [LetterUpper(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LetterUpper_System_Int32_) | Appends a pattern that matches a specified number of letters from [GeneralCategory.LetterUppercase](../../GeneralCategory/LetterUppercase/README.md)\. |

## LetterUpper\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LetterUpper"></a>

### Summary

Appends a pattern that matches a character from [GeneralCategory.LetterUppercase](../../GeneralCategory/LetterUppercase/README.md)\.

```csharp
public QuantifiablePattern LetterUpper()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## LetterUpper\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_LetterUpper_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of letters from [GeneralCategory.LetterUppercase](../../GeneralCategory/LetterUppercase/README.md)\.

```csharp
public QuantifiedGroup LetterUpper(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

