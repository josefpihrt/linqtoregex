# Patterns\.NotQuestionMark Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotQuestionMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotQuestionMark) | Returns a pattern that matches a character that is not a question mark\. |
| [NotQuestionMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotQuestionMark_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a question mark\. |

## NotQuestionMark\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotQuestionMark"></a>

### Summary

Returns a pattern that matches a character that is not a question mark\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotQuestionMark()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotQuestionMark\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotQuestionMark_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a question mark\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotQuestionMark(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

