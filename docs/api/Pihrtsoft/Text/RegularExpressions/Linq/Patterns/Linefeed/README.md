# Patterns\.Linefeed Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Linefeed()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Linefeed) | Returns a pattern that matches a linefeed\. |
| [Linefeed(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Linefeed_System_Int32_) | Returns a pattern that matches a specified number of linefeeds\. |

## Linefeed\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Linefeed"></a>

### Summary

Returns a pattern that matches a linefeed\.

```csharp
public static CharPattern Linefeed()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Linefeed\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Linefeed_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of linefeeds\.

```csharp
public static QuantifiedGroup Linefeed(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

