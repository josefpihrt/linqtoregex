# Patterns\.Plus Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Plus()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Plus) | Returns a pattern that matches a plus\. |
| [Plus(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Plus_System_Int32_) | Returns a pattern that matches a specified number of pluses\. |

## Plus\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Plus"></a>

\
Returns a pattern that matches a plus\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Plus()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## Plus\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Plus_System_Int32_"></a>

\
Returns a pattern that matches a specified number of pluses\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Plus(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

