# Pattern\.NotLeftSquareBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotLeftSquareBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLeftSquareBracket) | Appends a pattern that matches a character that is not a left square bracket\. |
| [NotLeftSquareBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLeftSquareBracket_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a left square bracket\. |

## NotLeftSquareBracket\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLeftSquareBracket"></a>

\
Appends a pattern that matches a character that is not a left square bracket\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotLeftSquareBracket()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotLeftSquareBracket\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLeftSquareBracket_System_Int32_"></a>

\
Appends a pattern that matches a specified number of characters that are not a left square bracket\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotLeftSquareBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

