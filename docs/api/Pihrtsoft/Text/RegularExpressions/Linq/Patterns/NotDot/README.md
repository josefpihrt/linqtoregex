# Patterns\.NotDot Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotDot()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDot) | Returns a pattern that matches a character that is not a dot\. |
| [NotDot(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDot_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a dot\. |

## NotDot\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDot"></a>

\
Returns a pattern that matches a character that is not a dot\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotDot()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotDot\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDot_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not a dot\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotDot(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

