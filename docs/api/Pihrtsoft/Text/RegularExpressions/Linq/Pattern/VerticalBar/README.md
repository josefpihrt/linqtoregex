# Pattern\.VerticalBar Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [VerticalBar()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_VerticalBar) | Appends a pattern that matches a vertical bar\. |
| [VerticalBar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_VerticalBar_System_Int32_) | Appends a pattern that matches a specified number of vertical bars\. |

## VerticalBar\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_VerticalBar"></a>

### Summary

Appends a pattern that matches a vertical bar\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern VerticalBar()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## VerticalBar\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_VerticalBar_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of vertical bars\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup VerticalBar(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

