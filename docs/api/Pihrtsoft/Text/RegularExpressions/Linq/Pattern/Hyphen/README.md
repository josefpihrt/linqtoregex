# Pattern\.Hyphen Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Hyphen()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Hyphen) | Appends a pattern that matches a hyphen\. |
| [Hyphen(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Hyphen_System_Int32_) | Appends a pattern that matches a specified number of hyphens\. |

## Hyphen\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Hyphen"></a>

\
Appends a pattern that matches a hyphen\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Hyphen()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Hyphen\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Hyphen_System_Int32_"></a>

\
Appends a pattern that matches a specified number of hyphens\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Hyphen(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

