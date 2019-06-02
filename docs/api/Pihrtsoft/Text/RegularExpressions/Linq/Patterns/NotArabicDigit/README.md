# Patterns\.NotArabicDigit Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotArabicDigit()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotArabicDigit) | Returns a pattern that matches a character that is not an arabic digit\. |
| [NotArabicDigit(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotArabicDigit_System_Int32_) | Returns a pattern that matches a character that is not an arabic digit specified number of times\. |

## NotArabicDigit\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotArabicDigit"></a>

### Summary

Returns a pattern that matches a character that is not an arabic digit\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup NotArabicDigit()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## NotArabicDigit\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotArabicDigit_System_Int32_"></a>

### Summary

Returns a pattern that matches a character that is not an arabic digit specified number of times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotArabicDigit(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

