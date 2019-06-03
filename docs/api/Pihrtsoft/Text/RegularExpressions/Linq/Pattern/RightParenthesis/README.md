# Pattern\.RightParenthesis Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [RightParenthesis()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightParenthesis) | Appends a pattern that matches a right parenthesis\. |
| [RightParenthesis(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightParenthesis_System_Int32_) | Appends a pattern that matches a specified number of right parentheses\. |

## RightParenthesis\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightParenthesis"></a>

### Summary

Appends a pattern that matches a right parenthesis\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern RightParenthesis()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## RightParenthesis\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightParenthesis_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of right parentheses\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup RightParenthesis(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

