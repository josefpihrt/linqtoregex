# Pattern\.RightCurlyBracket Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [RightCurlyBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightCurlyBracket) | Appends a pattern that matches a right curly bracket\. |
| [RightCurlyBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightCurlyBracket_System_Int32_) | Appends a pattern that matches a specified number of right curly brackets\. |

## RightCurlyBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightCurlyBracket"></a>

### Summary

Appends a pattern that matches a right curly bracket\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern RightCurlyBracket()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## RightCurlyBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightCurlyBracket_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of right curly brackets\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup RightCurlyBracket(int exactCount)
```

### Parameters

**exactCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

