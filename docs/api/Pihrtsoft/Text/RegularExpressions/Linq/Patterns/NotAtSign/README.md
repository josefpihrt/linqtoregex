# Patterns\.NotAtSign Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAtSign()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAtSign) | Returns a pattern that matches a character that is not an at sign\. |
| [NotAtSign(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAtSign_System_Int32_) | Returns a pattern that matches a specified number of characters that are not an at sign\. |

## NotAtSign\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAtSign"></a>

\
Returns a pattern that matches a character that is not an at sign\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotAtSign()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotAtSign\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAtSign_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not an at sign\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotAtSign(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

