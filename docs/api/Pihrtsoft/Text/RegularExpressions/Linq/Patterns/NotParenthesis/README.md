# Patterns\.NotParenthesis Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotParenthesis()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotParenthesis) | Returns a pattern that matches a character that is neither left nor right parenthesis\. |
| [NotParenthesis(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotParenthesis_System_Int32_) | Returns a pattern that matches a character that is neither left nor right parenthesis specified number of times\. |

## NotParenthesis\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotParenthesis"></a>

\
Returns a pattern that matches a character that is neither left nor right parenthesis\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup NotParenthesis()
```

### Returns

[CharGroup](../../CharGroup/README.md)

## NotParenthesis\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotParenthesis_System_Int32_"></a>

\
Returns a pattern that matches a character that is neither left nor right parenthesis specified number of times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotParenthesis(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

