# Patterns\.Linefeed Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Linefeed()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Linefeed) | Returns a pattern that matches a linefeed\. |
| [Linefeed(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Linefeed_System_Int32_) | Returns a pattern that matches a specified number of linefeeds\. |

## Linefeed\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Linefeed"></a>

\
Returns a pattern that matches a linefeed\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Linefeed()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## Linefeed\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Linefeed_System_Int32_"></a>

\
Returns a pattern that matches a specified number of linefeeds\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Linefeed(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

