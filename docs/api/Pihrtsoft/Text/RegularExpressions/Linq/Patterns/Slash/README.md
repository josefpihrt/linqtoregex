# Patterns\.Slash Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Slash()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Slash) | Returns a pattern that matches a slash\. |
| [Slash(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Slash_System_Int32_) | Returns a pattern that matches a specified number of slashes\. |

## Slash\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Slash"></a>

### Summary

Returns a pattern that matches a slash\.

```csharp
public static CharPattern Slash()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Slash\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Slash_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of slashes\.

```csharp
public static QuantifiedGroup Slash(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

