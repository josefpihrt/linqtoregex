# Patterns\.WordChar Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WordChar()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WordChar) | Returns a pattern that matches a word character\. |
| [WordChar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WordChar_System_Int32_) | Returns a pattern that matches a specified number of word characters\. |

## WordChar\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WordChar"></a>

### Summary

Returns a pattern that matches a word character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern WordChar()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## WordChar\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WordChar_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of word characters\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup WordChar(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

