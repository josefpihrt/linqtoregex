# Pattern\.NotWhiteSpace Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotWhiteSpace()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotWhiteSpace) | Appends a pattern that matches a character that is not a white\-space character\. |
| [NotWhiteSpace(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotWhiteSpace_System_Int32_) | Appends a pattern that matches a character that is not a white\-space character specified number of times\. |

## NotWhiteSpace\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotWhiteSpace"></a>

### Summary

Appends a pattern that matches a character that is not a white\-space character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotWhiteSpace()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotWhiteSpace\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotWhiteSpace_System_Int32_"></a>

### Summary

Appends a pattern that matches a character that is not a white\-space character specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotWhiteSpace(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

