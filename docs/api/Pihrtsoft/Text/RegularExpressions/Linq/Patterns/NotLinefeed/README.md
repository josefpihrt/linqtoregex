# Patterns\.NotLinefeed Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotLinefeed()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLinefeed) | Returns a pattern that matches a character that is not a linefeed\. |
| [NotLinefeed(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLinefeed_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a linefeed\. |

## NotLinefeed\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLinefeed"></a>

\
Returns a pattern that matches a character that is not a linefeed\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotLinefeed()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotLinefeed\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLinefeed_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not a linefeed\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotLinefeed(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

