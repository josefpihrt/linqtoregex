# Pattern\.NotLatinLetterUpper Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotLatinLetterUpper()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetterUpper) | Appends a pattern that matches a character that is not a latin alphabet upper\-case letter\. |
| [NotLatinLetterUpper(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetterUpper_System_Int32_) | Appends a pattern that matches a character that is not a latin alphabet upper\-case letter specified number of times\. |

## NotLatinLetterUpper\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetterUpper"></a>

\
Appends a pattern that matches a character that is not a latin alphabet upper\-case letter\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotLatinLetterUpper()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotLatinLetterUpper\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetterUpper_System_Int32_"></a>

\
Appends a pattern that matches a character that is not a latin alphabet upper\-case letter specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotLatinLetterUpper(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

