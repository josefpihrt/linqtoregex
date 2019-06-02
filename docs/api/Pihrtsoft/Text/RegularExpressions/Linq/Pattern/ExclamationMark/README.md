# Pattern\.ExclamationMark Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ExclamationMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_ExclamationMark) | Appends a pattern that matches an exclamation mark\. |
| [ExclamationMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_ExclamationMark_System_Int32_) | Appends a pattern that matches a specified number of exclamation marks\. |

## ExclamationMark\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_ExclamationMark"></a>

### Summary

Appends a pattern that matches an exclamation mark\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern ExclamationMark()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## ExclamationMark\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_ExclamationMark_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of exclamation marks\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup ExclamationMark(int exactCount)
```

### Parameters

**exactCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

