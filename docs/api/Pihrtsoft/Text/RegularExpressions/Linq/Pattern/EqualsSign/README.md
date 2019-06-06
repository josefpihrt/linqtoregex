# Pattern\.EqualsSign Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EqualsSign()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EqualsSign) | Appends a pattern that matches an equals sign\. |
| [EqualsSign(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EqualsSign_System_Int32_) | Appends a pattern that matches a specified number of equals signs\. |

## EqualsSign\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EqualsSign"></a>

\
Appends a pattern that matches an equals sign\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern EqualsSign()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## EqualsSign\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EqualsSign_System_Int32_"></a>

\
Appends a pattern that matches a specified number of equals signs\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup EqualsSign(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

