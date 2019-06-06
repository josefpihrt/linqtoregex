# Patterns\.NotCurlyBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotCurlyBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotCurlyBracket) | Returns a pattern that matches a character that is neither left nor right curly bracket\. |
| [NotCurlyBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotCurlyBracket_System_Int32_) | Returns a pattern that matches a character that is neither left nor right curly bracket specified number of times\. |

## NotCurlyBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotCurlyBracket"></a>

\
Returns a pattern that matches a character that is neither left nor right curly bracket\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup NotCurlyBracket()
```

### Returns

[CharGroup](../../CharGroup/README.md)

## NotCurlyBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotCurlyBracket_System_Int32_"></a>

\
Returns a pattern that matches a character that is neither left nor right curly bracket specified number of times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotCurlyBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

