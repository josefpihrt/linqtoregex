# Pattern\.Linefeed Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Linefeed()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Linefeed) | Appends a pattern that matches a linefeed\. |
| [Linefeed(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Linefeed_System_Int32_) | Appends a pattern that matches a specified number of linefeeds\. |

## Linefeed\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Linefeed"></a>

### Summary

Appends a pattern that matches a linefeed\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Linefeed()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Linefeed\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Linefeed_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of linefeeds\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Linefeed(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

