# Patterns\.NotWordChar Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotWordChar()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotWordChar) | Returns a pattern that matches a character that is not a word character\. |
| [NotWordChar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotWordChar_System_Int32_) | Returns a pattern that matches a character that is not a word character specified number of times\. |

## NotWordChar\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotWordChar"></a>

\
Returns a pattern that matches a character that is not a word character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern NotWordChar()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## NotWordChar\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotWordChar_System_Int32_"></a>

\
Returns a pattern that matches a character that is not a word character specified number of times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotWordChar(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

