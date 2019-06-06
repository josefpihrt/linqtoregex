# Patterns\.SlashOrBackslash Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SlashOrBackslash()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SlashOrBackslash) | Returns a pattern that matches a slash or a backslash\. |
| [SlashOrBackslash(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SlashOrBackslash_System_Int32_) | Returns a pattern that matches a specified number of characters that are slash or backslash\. |

## SlashOrBackslash\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SlashOrBackslash"></a>

\
Returns a pattern that matches a slash or a backslash\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup SlashOrBackslash()
```

### Returns

[CharGroup](../../CharGroup/README.md)

## SlashOrBackslash\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SlashOrBackslash_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are slash or backslash\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup SlashOrBackslash(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

