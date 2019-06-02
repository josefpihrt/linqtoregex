# Patterns\.Ampersand Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Ampersand()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Ampersand) | Returns a pattern that matches an ampersand\. |
| [Ampersand(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Ampersand_System_Int32_) | Returns a pattern that matches a specified number of ampersands\. |

## Ampersand\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Ampersand"></a>

### Summary

Returns a pattern that matches an ampersand\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Ampersand()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Ampersand\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Ampersand_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of ampersands\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Ampersand(int exactCount)
```

### Parameters

**exactCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

