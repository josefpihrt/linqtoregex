# Pattern\.WordChar Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WordChar()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WordChar) | Appends a pattern that matches a word character\. |
| [WordChar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WordChar_System_Int32_) | Appends a pattern that matches a specified number of word characters\. |

## WordChar\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WordChar"></a>

\
Appends a pattern that matches a word character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern WordChar()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## WordChar\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WordChar_System_Int32_"></a>

\
Appends a pattern that matches a specified number of word characters\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup WordChar(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

