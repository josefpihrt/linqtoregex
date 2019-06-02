# Patterns\.Apostrophe Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Apostrophe()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Apostrophe) | Returns a pattern that matches an apostrophe\. |
| [Apostrophe(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Apostrophe_System_Int32_) | Returns a pattern that matches a specified number of apostrophes\. |

## Apostrophe\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Apostrophe"></a>

### Summary

Returns a pattern that matches an apostrophe\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Apostrophe()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Apostrophe\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Apostrophe_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of apostrophes\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Apostrophe(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

