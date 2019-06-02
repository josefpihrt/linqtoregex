# Patterns\.Space Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Space()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Space) | Returns a pattern that matches a space\. |
| [Space(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Space_System_Int32_) | Returns a pattern that matches a specified number of spaces\. |

## Space\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Space"></a>

### Summary

Returns a pattern that matches a space\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Space()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Space\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Space_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of spaces\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Space(int exactCount)
```

### Parameters

**exactCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

