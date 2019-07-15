# Patterns\.NotApostrophe Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotApostrophe()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotApostrophe) | Returns a pattern that matches a character that is not an apostrophe\. |
| [NotApostrophe(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotApostrophe_System_Int32_) | Returns a pattern that matches a specified number of characters that are not an apostrophe\. |

## NotApostrophe\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotApostrophe"></a>

\
Returns a pattern that matches a character that is not an apostrophe\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotApostrophe()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotApostrophe\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotApostrophe_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not an apostrophe\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotApostrophe(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

