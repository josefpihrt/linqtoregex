# Pattern\.CircumflexAccent Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [CircumflexAccent()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_CircumflexAccent) | Appends a pattern that matches a circumflex accent\. |
| [CircumflexAccent(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_CircumflexAccent_System_Int32_) | Appends a pattern that matches a specified number of circumflex accents\. |

## CircumflexAccent\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_CircumflexAccent"></a>

### Summary

Appends a pattern that matches a circumflex accent\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern CircumflexAccent()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## CircumflexAccent\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_CircumflexAccent_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of circumflex accents\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup CircumflexAccent(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

