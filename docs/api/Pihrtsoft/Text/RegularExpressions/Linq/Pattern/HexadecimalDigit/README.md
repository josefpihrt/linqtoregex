# Pattern\.HexadecimalDigit Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [HexadecimalDigit()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_HexadecimalDigit) | Appends a pattern that matches a hexadecimal digit\. |
| [HexadecimalDigit(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_HexadecimalDigit_System_Int32_) | Appends a pattern that matches a specified number of hexadecimal digits\. |

## HexadecimalDigit\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_HexadecimalDigit"></a>

\
Appends a pattern that matches a hexadecimal digit\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern HexadecimalDigit()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## HexadecimalDigit\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_HexadecimalDigit_System_Int32_"></a>

\
Appends a pattern that matches a specified number of hexadecimal digits\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup HexadecimalDigit(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

