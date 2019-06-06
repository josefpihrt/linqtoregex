# Pattern\.AtSign Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AtSign()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AtSign) | Appends a pattern that matches an at sign\. |
| [AtSign(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AtSign_System_Int32_) | Appends a pattern that matches a specified number of at signs\. |

## AtSign\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AtSign"></a>

\
Appends a pattern that matches an at sign\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern AtSign()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## AtSign\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AtSign_System_Int32_"></a>

\
Appends a pattern that matches a specified number of at signs\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup AtSign(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

