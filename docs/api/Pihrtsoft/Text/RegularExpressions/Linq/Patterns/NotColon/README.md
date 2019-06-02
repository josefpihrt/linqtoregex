# Patterns\.NotColon Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotColon()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotColon) | Returns a pattern that matches a character that is not a colon\. |
| [NotColon(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotColon_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a colon\. |

## NotColon\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotColon"></a>

### Summary

Returns a pattern that matches a character that is not a colon\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotColon()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotColon\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotColon_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a colon\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotColon(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

