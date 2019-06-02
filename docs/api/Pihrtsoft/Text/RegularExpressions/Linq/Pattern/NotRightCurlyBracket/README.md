# Pattern\.NotRightCurlyBracket Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotRightCurlyBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotRightCurlyBracket) | Appends a pattern that matches a character that is not a right curly bracket\. |
| [NotRightCurlyBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotRightCurlyBracket_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a right curly bracket\. |

## NotRightCurlyBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotRightCurlyBracket"></a>

### Summary

Appends a pattern that matches a character that is not a right curly bracket\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotRightCurlyBracket()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotRightCurlyBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotRightCurlyBracket_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not a right curly bracket\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotRightCurlyBracket(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

