# Pattern\.NotQuoteMark Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotQuoteMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotQuoteMark) | Appends a pattern that matches a character that is not a quote mark\. |
| [NotQuoteMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotQuoteMark_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a quote mark\. |

## NotQuoteMark\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotQuoteMark"></a>

### Summary

Appends a pattern that matches a character that is not a quote mark\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotQuoteMark()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotQuoteMark\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotQuoteMark_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not a quote mark\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotQuoteMark(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

