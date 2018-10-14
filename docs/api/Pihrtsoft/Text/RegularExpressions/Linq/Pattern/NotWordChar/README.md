# Pattern\.NotWordChar Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotWordChar()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotWordChar) | Appends a pattern that matches a character that is not a word character\. |
| [NotWordChar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotWordChar_System_Int32_) | Appends a pattern that matches a character that is not a word character specified number of times\. |

## NotWordChar\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotWordChar"></a>

### Summary

Appends a pattern that matches a character that is not a word character\.

```csharp
public QuantifiablePattern NotWordChar()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotWordChar\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotWordChar_System_Int32_"></a>

### Summary

Appends a pattern that matches a character that is not a word character specified number of times\.

```csharp
public QuantifiedGroup NotWordChar(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

