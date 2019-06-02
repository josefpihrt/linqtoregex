# Pattern\.NotLatinLetterLower Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotLatinLetterLower()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetterLower) | Appends a pattern that matches a character that is not a latin alphabet lower\-case letter\. |
| [NotLatinLetterLower(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetterLower_System_Int32_) | Appends a pattern that matches a character that is not a latin alphabet lower\-case letter specified number of times\. |

## NotLatinLetterLower\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetterLower"></a>

### Summary

Appends a pattern that matches a character that is not a latin alphabet lower\-case letter\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotLatinLetterLower()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotLatinLetterLower\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetterLower_System_Int32_"></a>

### Summary

Appends a pattern that matches a character that is not a latin alphabet lower\-case letter specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotLatinLetterLower(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

