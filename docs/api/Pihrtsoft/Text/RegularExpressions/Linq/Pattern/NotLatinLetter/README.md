# Pattern\.NotLatinLetter Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotLatinLetter()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetter) | Appends a pattern that matches a character that is not a latin alphabet letter\. |
| [NotLatinLetter(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetter_System_Int32_) | Appends a pattern that matches a character that is not a latin alphabet letter specified number of times\. |

## NotLatinLetter\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetter"></a>

\
Appends a pattern that matches a character that is not a latin alphabet letter\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGroup NotLatinLetter()
```

### Returns

[CharGroup](../../CharGroup/README.md)

## NotLatinLetter\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLatinLetter_System_Int32_"></a>

\
Appends a pattern that matches a character that is not a latin alphabet letter specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotLatinLetter(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

