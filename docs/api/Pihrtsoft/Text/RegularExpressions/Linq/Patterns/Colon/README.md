# Patterns\.Colon Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Colon()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Colon) | Returns a pattern that matches a colon\. |
| [Colon(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Colon_System_Int32_) | Returns a pattern that matches a specified number of colons\. |

## Colon\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Colon"></a>

### Summary

Returns a pattern that matches a colon\.

```csharp
public static CharPattern Colon()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Colon\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Colon_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of colons\.

```csharp
public static QuantifiedGroup Colon(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

