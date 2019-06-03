# Pattern\.NotSlashOrBackslash Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotSlashOrBackslash()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSlashOrBackslash) | Appends a pattern that matches a character that is not a slash or backslash\. |
| [NotSlashOrBackslash(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSlashOrBackslash_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a slash or backslash |

## NotSlashOrBackslash\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSlashOrBackslash"></a>

### Summary

Appends a pattern that matches a character that is not a slash or backslash\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotSlashOrBackslash()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotSlashOrBackslash\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSlashOrBackslash_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not a slash or backslash

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotSlashOrBackslash(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.
