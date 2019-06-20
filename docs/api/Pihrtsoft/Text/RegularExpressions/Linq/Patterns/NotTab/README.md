# Patterns\.NotTab Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotTab()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotTab) | Returns a pattern that matches a character that is not a tab\. |
| [NotTab(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotTab_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a tab\. |

## NotTab\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotTab"></a>

\
Returns a pattern that matches a character that is not a tab\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotTab()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotTab\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotTab_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not a tab\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotTab(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

