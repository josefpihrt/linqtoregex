# Patterns\.NotDigit Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotDigit()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDigit) | Returns a pattern that matches a character that is not a digit character\. |
| [NotDigit(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDigit_System_Int32_) | Returns a pattern that matches a character that is not a digit character specified number of times\. |

## NotDigit\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDigit"></a>

\
Returns a pattern that matches a character that is not a digit character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern NotDigit()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## NotDigit\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotDigit_System_Int32_"></a>

\
Returns a pattern that matches a character that is not a digit character specified number of times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotDigit(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

