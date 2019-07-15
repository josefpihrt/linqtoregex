# Patterns\.ExclamationMark Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ExclamationMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_ExclamationMark) | Returns a pattern that matches an exclamation mark\. |
| [ExclamationMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_ExclamationMark_System_Int32_) | Returns a pattern that matches a specified number of exclamation marks\. |

## ExclamationMark\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_ExclamationMark"></a>

\
Returns a pattern that matches an exclamation mark\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern ExclamationMark()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## ExclamationMark\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_ExclamationMark_System_Int32_"></a>

\
Returns a pattern that matches a specified number of exclamation marks\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup ExclamationMark(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

