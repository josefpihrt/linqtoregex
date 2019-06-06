# Pattern\.Comma Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Comma()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Comma) | Appends a pattern that matches a comma\. |
| [Comma(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Comma_System_Int32_) | Appends a pattern that matches a specified number of commas\. |

## Comma\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Comma"></a>

\
Appends a pattern that matches a comma\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Comma()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Comma\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Comma_System_Int32_"></a>

\
Appends a pattern that matches a specified number of commas\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Comma(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

