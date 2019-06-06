# Patterns\.Underscore Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Underscore()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Underscore) | Returns a pattern that matches an underscore\. |
| [Underscore(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Underscore_System_Int32_) | Returns a pattern that matches a specified number of underscores\. |

## Underscore\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Underscore"></a>

\
Returns a pattern that matches an underscore\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Underscore()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## Underscore\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Underscore_System_Int32_"></a>

\
Returns a pattern that matches a specified number of underscores\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Underscore(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

