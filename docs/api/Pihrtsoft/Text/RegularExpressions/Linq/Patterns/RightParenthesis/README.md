# Patterns\.RightParenthesis Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [RightParenthesis()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_RightParenthesis) | Returns a pattern that matches a right parenthesis\. |
| [RightParenthesis(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_RightParenthesis_System_Int32_) | Returns a pattern that matches a specified number of right parentheses\. |

## RightParenthesis\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_RightParenthesis"></a>

### Summary

Returns a pattern that matches a right parenthesis\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern RightParenthesis()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## RightParenthesis\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_RightParenthesis_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of right parentheses\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup RightParenthesis(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

