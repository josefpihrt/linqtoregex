# Patterns\.NotLeftParenthesis Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotLeftParenthesis()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLeftParenthesis) | Returns a pattern that matches a character that is not a left parenthesis\. |
| [NotLeftParenthesis(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLeftParenthesis_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a left parenthesis\. |

## NotLeftParenthesis\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLeftParenthesis"></a>

### Summary

Returns a pattern that matches a character that is not a left parenthesis\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotLeftParenthesis()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotLeftParenthesis\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotLeftParenthesis_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a left parenthesis\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotLeftParenthesis(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

