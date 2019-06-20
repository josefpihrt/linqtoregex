# Patterns\.NotDollar Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotDollar()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDollar) | Returns a pattern that matches a character that is not a dollar\. |
| [NotDollar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDollar_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a dollar\. |

## NotDollar\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDollar"></a>

\
Returns a pattern that matches a character that is not a dollar\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotDollar()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotDollar\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDollar_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not a dollar\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotDollar(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

