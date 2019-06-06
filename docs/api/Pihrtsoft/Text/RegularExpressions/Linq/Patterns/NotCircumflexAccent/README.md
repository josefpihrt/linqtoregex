# Patterns\.NotCircumflexAccent Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotCircumflexAccent()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotCircumflexAccent) | Returns a pattern that matches a character that is not a circumflex accent\. |
| [NotCircumflexAccent(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotCircumflexAccent_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a circumflex accent\. |

## NotCircumflexAccent\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotCircumflexAccent"></a>

\
Returns a pattern that matches a character that is not a circumflex accent\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotCircumflexAccent()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotCircumflexAccent\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotCircumflexAccent_System_Int32_"></a>

\
Returns a pattern that matches a specified number of characters that are not a circumflex accent\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotCircumflexAccent(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

