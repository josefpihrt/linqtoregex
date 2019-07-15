# Pattern\.NotDollar Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotDollar()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotDollar) | Appends a pattern that matches a character that is not a dollar\. |
| [NotDollar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotDollar_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a dollar\. |

## NotDollar\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotDollar"></a>

\
Appends a pattern that matches a character that is not a dollar\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotDollar()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotDollar\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotDollar_System_Int32_"></a>

\
Appends a pattern that matches a specified number of characters that are not a dollar\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotDollar(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

