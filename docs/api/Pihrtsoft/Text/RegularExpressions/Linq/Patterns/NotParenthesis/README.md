# Patterns\.NotParenthesis Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotParenthesis()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotParenthesis) | Returns a pattern that matches a character that is neither left nor right parenthesis\. |
| [NotParenthesis(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotParenthesis_System_Int32_) | Returns a pattern that matches a character that is neither left nor right parenthesis specified number of times\. |

## NotParenthesis\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotParenthesis"></a>

### Summary

Returns a pattern that matches a character that is neither left nor right parenthesis\.

```csharp
public static CharGroup NotParenthesis()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## NotParenthesis\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotParenthesis_System_Int32_"></a>

### Summary

Returns a pattern that matches a character that is neither left nor right parenthesis specified number of times\.

```csharp
public static QuantifiedGroup NotParenthesis(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

