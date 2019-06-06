# Pattern\.NotLatinLetterLower Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotLatinLetterLower()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetterLower) | Appends a pattern that matches a character that is not a latin alphabet lower\-case letter\. |
| [NotLatinLetterLower(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetterLower_System_Int32_) | Appends a pattern that matches a character that is not a latin alphabet lower\-case letter specified number of times\. |

## NotLatinLetterLower\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetterLower"></a>

\
Appends a pattern that matches a character that is not a latin alphabet lower\-case letter\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotLatinLetterLower()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotLatinLetterLower\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetterLower_System_Int32_"></a>

\
Appends a pattern that matches a character that is not a latin alphabet lower\-case letter specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotLatinLetterLower(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

