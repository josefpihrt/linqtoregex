# Patterns\.ExclamationMark Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ExclamationMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_ExclamationMark) | Returns a pattern that matches an exclamation mark\. |
| [ExclamationMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_ExclamationMark_System_Int32_) | Returns a pattern that matches a specified number of exclamation marks\. |

## ExclamationMark\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_ExclamationMark"></a>

### Summary

Returns a pattern that matches an exclamation mark\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern ExclamationMark()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## ExclamationMark\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_ExclamationMark_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of exclamation marks\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup ExclamationMark(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

