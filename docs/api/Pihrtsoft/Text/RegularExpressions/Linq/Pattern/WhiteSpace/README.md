# Pattern\.WhiteSpace Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WhiteSpace()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhiteSpace) | Appends a pattern that matches a white\-space character\. |
| [WhiteSpace(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhiteSpace_System_Int32_) | Appends a pattern that matches a specified number of white\-space characters\. |

## WhiteSpace\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhiteSpace"></a>

### Summary

Appends a pattern that matches a white\-space character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern WhiteSpace()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## WhiteSpace\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhiteSpace_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of white\-space characters\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup WhiteSpace(int exactCount)
```

### Parameters

**exactCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

