# Patterns\.Percent Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Percent()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Percent) | Returns a pattern that matches a percent\. |
| [Percent(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Percent_System_Int32_) | Returns a pattern that matches a specified number of percents\. |

## Percent\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Percent"></a>

\
Returns a pattern that matches a percent\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Percent()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## Percent\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Percent_System_Int32_"></a>

\
Returns a pattern that matches a specified number of percents\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Percent(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

