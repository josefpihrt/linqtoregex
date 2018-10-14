# Patterns\.RightAngleBracket Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [RightAngleBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_RightAngleBracket) | Returns a pattern that matches a right angle bracket \(greater\-than sign\)\. |
| [RightAngleBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_RightAngleBracket_System_Int32_) | Returns a pattern that matches a specified number of right angle brackets \(greater\-than signs\)\. |

## RightAngleBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_RightAngleBracket"></a>

### Summary

Returns a pattern that matches a right angle bracket \(greater\-than sign\)\.

```csharp
public static CharPattern RightAngleBracket()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## RightAngleBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_RightAngleBracket_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of right angle brackets \(greater\-than signs\)\.

```csharp
public static QuantifiedGroup RightAngleBracket(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

