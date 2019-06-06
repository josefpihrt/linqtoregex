# Patterns\.Dot Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Dot()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Dot) | Returns a pattern that matches a dot\. |
| [Dot(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Dot_System_Int32_) | Returns a pattern that matches a specified number of dots\. |

## Dot\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Dot"></a>

\
Returns a pattern that matches a dot\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Dot()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## Dot\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Dot_System_Int32_"></a>

\
Returns a pattern that matches a specified number of dots\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Dot(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

