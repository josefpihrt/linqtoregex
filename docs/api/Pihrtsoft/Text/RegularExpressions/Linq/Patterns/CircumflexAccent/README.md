# Patterns\.CircumflexAccent Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [CircumflexAccent()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_CircumflexAccent) | Returns a pattern that matches a circumflex accent\. |
| [CircumflexAccent(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_CircumflexAccent_System_Int32_) | Returns a pattern that matches a specified number of circumflex accents\. |

## CircumflexAccent\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_CircumflexAccent"></a>

\
Returns a pattern that matches a circumflex accent\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern CircumflexAccent()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## CircumflexAccent\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_CircumflexAccent_System_Int32_"></a>

\
Returns a pattern that matches a specified number of circumflex accents\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup CircumflexAccent(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

