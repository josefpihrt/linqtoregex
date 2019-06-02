# Patterns\.CarriageReturn Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [CarriageReturn()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_CarriageReturn) | Returns a pattern that matches a carriage return\. |
| [CarriageReturn(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_CarriageReturn_System_Int32_) | Returns a pattern that matches a specified number of carriage returns\. |

## CarriageReturn\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_CarriageReturn"></a>

### Summary

Returns a pattern that matches a carriage return\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern CarriageReturn()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## CarriageReturn\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_CarriageReturn_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of carriage returns\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup CarriageReturn(int exactCount)
```

### Parameters

**exactCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

