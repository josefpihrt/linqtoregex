# Patterns\.NotLeftAngleBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotLeftAngleBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLeftAngleBracket) | Returns a pattern that matches a character that is not a left angle bracket \(less\-than sign\)\. |
| [NotLeftAngleBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLeftAngleBracket_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a left angle bracket \(less\-than sign\)\. |

## NotLeftAngleBracket\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLeftAngleBracket"></a>

\
Returns a pattern that matches a character that is not a left angle bracket \(less\-than sign\)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotLeftAngleBracket()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotLeftAngleBracket\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLeftAngleBracket_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not a left angle bracket \(less\-than sign\)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotLeftAngleBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

