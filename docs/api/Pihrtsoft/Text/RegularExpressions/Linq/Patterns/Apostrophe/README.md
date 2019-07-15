# Patterns\.Apostrophe Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Apostrophe()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Apostrophe) | Returns a pattern that matches an apostrophe\. |
| [Apostrophe(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Apostrophe_System_Int32_) | Returns a pattern that matches a specified number of apostrophes\. |

## Apostrophe\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Apostrophe"></a>

\
Returns a pattern that matches an apostrophe\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Apostrophe()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## Apostrophe\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Apostrophe_System_Int32_"></a>

\
Returns a pattern that matches a specified number of apostrophes\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Apostrophe(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

