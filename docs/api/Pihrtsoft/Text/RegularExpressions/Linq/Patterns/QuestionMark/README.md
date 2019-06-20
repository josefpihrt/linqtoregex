# Patterns\.QuestionMark Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [QuestionMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_QuestionMark) | Returns a pattern that matches a question mark\. |
| [QuestionMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_QuestionMark_System_Int32_) | Returns a pattern that matches a specified number of question marks\. |

## QuestionMark\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_QuestionMark"></a>

\
Returns a pattern that matches a question mark\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern QuestionMark()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## QuestionMark\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_QuestionMark_System_Int32_"></a>

\
Returns a pattern that matches a specified number of question marks\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup QuestionMark(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

