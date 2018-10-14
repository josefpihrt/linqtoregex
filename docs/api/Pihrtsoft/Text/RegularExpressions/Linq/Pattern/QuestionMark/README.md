# Pattern\.QuestionMark Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [QuestionMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_QuestionMark) | Appends a pattern that matches a question mark\. |
| [QuestionMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_QuestionMark_System_Int32_) | Appends a pattern that matches a specified number of question marks\. |

## QuestionMark\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_QuestionMark"></a>

### Summary

Appends a pattern that matches a question mark\.

```csharp
public QuantifiablePattern QuestionMark()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## QuestionMark\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_QuestionMark_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of question marks\.

```csharp
public QuantifiedGroup QuestionMark(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

