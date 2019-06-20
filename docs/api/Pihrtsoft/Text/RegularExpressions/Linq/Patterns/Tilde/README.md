# Patterns\.Tilde Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Tilde()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Tilde) | Returns a pattern that matches a tilde\. |
| [Tilde(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Tilde_System_Int32_) | Returns a pattern that matches a specified number of tildes\. |

## Tilde\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Tilde"></a>

\
Returns a pattern that matches a tilde\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Tilde()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## Tilde\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Tilde_System_Int32_"></a>

\
Returns a pattern that matches a specified number of tildes\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Tilde(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

