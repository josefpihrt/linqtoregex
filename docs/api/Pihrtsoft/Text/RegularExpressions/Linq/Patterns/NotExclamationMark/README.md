# Patterns\.NotExclamationMark Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotExclamationMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotExclamationMark) | Returns a pattern that matches a character that is not an exclamation mark\. |
| [NotExclamationMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotExclamationMark_System_Int32_) | Returns a pattern that matches a specified number of characters that are not an exclamation mark\. |

## NotExclamationMark\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotExclamationMark"></a>

\
Returns a pattern that matches a character that is not an exclamation mark\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotExclamationMark()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotExclamationMark\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotExclamationMark_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not an exclamation mark\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotExclamationMark(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

