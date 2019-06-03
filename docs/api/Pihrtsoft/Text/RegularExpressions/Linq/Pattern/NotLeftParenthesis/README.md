# Pattern\.NotLeftParenthesis Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotLeftParenthesis()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLeftParenthesis) | Appends a pattern that matches a character that is not a left parenthesis\. |
| [NotLeftParenthesis(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLeftParenthesis_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a left parenthesis\. |

## NotLeftParenthesis\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLeftParenthesis"></a>

### Summary

Appends a pattern that matches a character that is not a left parenthesis\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotLeftParenthesis()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotLeftParenthesis\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotLeftParenthesis_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not a left parenthesis\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotLeftParenthesis(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

