# Patterns\.NotSlash Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotSlash()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotSlash) | Returns a pattern that matches a character that is not a slash\. |
| [NotSlash(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotSlash_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a slash\. |

## NotSlash\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotSlash"></a>

\
Returns a pattern that matches a character that is not a slash\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotSlash()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotSlash\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotSlash_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not a slash\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotSlash(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

