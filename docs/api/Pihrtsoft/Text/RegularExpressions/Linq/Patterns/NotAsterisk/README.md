# Patterns\.NotAsterisk Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAsterisk()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAsterisk) | Returns a pattern that matches a character that is not an asterisk\. |
| [NotAsterisk(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAsterisk_System_Int32_) | Returns a pattern that matches a specified number of characters that are not an asterisk\. |

## NotAsterisk\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAsterisk"></a>

\
Returns a pattern that matches a character that is not an asterisk\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotAsterisk()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotAsterisk\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAsterisk_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not an asterisk\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotAsterisk(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

