# Patterns\.NotTilde Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotTilde()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotTilde) | Returns a pattern that matches a character that is not a tilde\. |
| [NotTilde(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotTilde_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a tilde\. |

## NotTilde\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotTilde"></a>

\
Returns a pattern that matches a character that is not a tilde\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotTilde()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotTilde\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotTilde_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not a tilde\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotTilde(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

