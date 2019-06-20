# Patterns\.NotRightAngleBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotRightAngleBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightAngleBracket) | Returns a pattern that matches a character that is not a right angle bracket \(greater\-than sign\)\. |
| [NotRightAngleBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightAngleBracket_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a right angle bracket \(greater\-than sign\)\. |

## NotRightAngleBracket\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightAngleBracket"></a>

\
Returns a pattern that matches a character that is not a right angle bracket \(greater\-than sign\)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotRightAngleBracket()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotRightAngleBracket\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightAngleBracket_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not a right angle bracket \(greater\-than sign\)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotRightAngleBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

