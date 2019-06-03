# Patterns\.NotRightParenthesis Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotRightParenthesis()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightParenthesis) | Returns a pattern that matches a character that is not a right parenthesis\. |
| [NotRightParenthesis(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightParenthesis_System_Int32_) | Returns a pattern that matches a specified number of characters that are not a right parenthesis\. |

## NotRightParenthesis\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightParenthesis"></a>

### Summary

Returns a pattern that matches a character that is not a right parenthesis\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotRightParenthesis()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotRightParenthesis\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotRightParenthesis_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of characters that are not a right parenthesis\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotRightParenthesis(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

