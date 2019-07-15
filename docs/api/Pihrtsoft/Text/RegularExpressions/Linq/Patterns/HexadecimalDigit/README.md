# Patterns\.HexadecimalDigit Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [HexadecimalDigit()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_HexadecimalDigit) | Returns a pattern that matches a hexadecimal digit\. |
| [HexadecimalDigit(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_HexadecimalDigit_System_Int32_) | Returns a pattern that matches a specified number of hexadecimal digits\. |

## HexadecimalDigit\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_HexadecimalDigit"></a>

\
Returns a pattern that matches a hexadecimal digit\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup HexadecimalDigit()
```

### Returns

[CharGroup](../../CharGroup/README.md)

## HexadecimalDigit\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_HexadecimalDigit_System_Int32_"></a>

\
Returns a pattern that matches a specified number of hexadecimal digits\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup HexadecimalDigit(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

