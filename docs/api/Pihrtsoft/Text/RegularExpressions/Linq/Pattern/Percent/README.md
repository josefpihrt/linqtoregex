# Pattern\.Percent Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Percent()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Percent) | Appends a pattern that matches a percent\. |
| [Percent(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Percent_System_Int32_) | Appends a pattern that matches a specified number of percents\. |

## Percent\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Percent"></a>

### Summary

Appends a pattern that matches a percent\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Percent()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Percent\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Percent_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of percents\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Percent(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

