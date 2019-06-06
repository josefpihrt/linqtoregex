# Patterns\.WhiteSpace Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WhiteSpace()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhiteSpace) | Returns a pattern that matches a white\-space character\. |
| [WhiteSpace(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhiteSpace_System_Int32_) | Returns a pattern that matches a specified number of white\-space characters\. |

## WhiteSpace\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhiteSpace"></a>

\
Returns a pattern that matches a white\-space character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern WhiteSpace()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## WhiteSpace\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhiteSpace_System_Int32_"></a>

\
Returns a pattern that matches a specified number of white\-space characters\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup WhiteSpace(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

