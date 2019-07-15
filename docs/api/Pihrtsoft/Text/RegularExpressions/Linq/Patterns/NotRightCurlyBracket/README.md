# Patterns\.NotRightCurlyBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotRightCurlyBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightCurlyBracket) | Returns a pattern that matches a character that is not a right curly bracket\. |
| [NotRightCurlyBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightCurlyBracket_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a right curly bracket\. |

## NotRightCurlyBracket\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightCurlyBracket"></a>

\
Returns a pattern that matches a character that is not a right curly bracket\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotRightCurlyBracket()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotRightCurlyBracket\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightCurlyBracket_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not a right curly bracket\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotRightCurlyBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

