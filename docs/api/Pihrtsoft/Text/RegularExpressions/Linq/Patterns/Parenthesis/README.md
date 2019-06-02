# Patterns\.Parenthesis Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Parenthesis()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Parenthesis) | Returns a pattern that matches left or right parenthesis\. |
| [Parenthesis(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Parenthesis_System_Int32_) | Returns a pattern that matches left or right parenthesis specified number of times\. |

## Parenthesis\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Parenthesis"></a>

### Summary

Returns a pattern that matches left or right parenthesis\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup Parenthesis()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## Parenthesis\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Parenthesis_System_Int32_"></a>

### Summary

Returns a pattern that matches left or right parenthesis specified number of times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Parenthesis(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

