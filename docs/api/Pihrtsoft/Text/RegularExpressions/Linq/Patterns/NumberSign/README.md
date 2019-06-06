# Patterns\.NumberSign Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NumberSign()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NumberSign) | Returns a pattern that matches a number sign\. |
| [NumberSign(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NumberSign_System_Int32_) | Returns a pattern that matches a specified number of number signs\. |

## NumberSign\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NumberSign"></a>

\
Returns a pattern that matches a number sign\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern NumberSign()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## NumberSign\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NumberSign_System_Int32_"></a>

\
Returns a pattern that matches a specified number of number signs\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NumberSign(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

