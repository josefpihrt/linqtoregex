# Patterns\.NotPlus Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotPlus()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPlus) | Returns a pattern that matches a character that is not a plus\. |
| [NotPlus(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPlus_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a plus\. |

## NotPlus\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPlus"></a>

\
Returns a pattern that matches a character that is not a plus\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotPlus()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotPlus\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotPlus_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not a plus\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotPlus(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

