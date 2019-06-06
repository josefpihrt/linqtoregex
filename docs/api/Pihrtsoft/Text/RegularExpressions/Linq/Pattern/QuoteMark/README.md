# Pattern\.QuoteMark Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [QuoteMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_QuoteMark) | Appends a pattern that matches a quote mark\. |
| [QuoteMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_QuoteMark_System_Int32_) | Appends a pattern that matches a specified number of quote marks\. |

## QuoteMark\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_QuoteMark"></a>

\
Appends a pattern that matches a quote mark\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern QuoteMark()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## QuoteMark\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_QuoteMark_System_Int32_"></a>

\
Appends a pattern that matches a specified number of quote marks\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup QuoteMark(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

