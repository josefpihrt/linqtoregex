# Pattern\.NotTab Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotTab()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotTab) | Appends a pattern that matches a character that is not a tab\. |
| [NotTab(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotTab_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a tab\. |

## NotTab\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotTab"></a>

### Summary

Appends a pattern that matches a character that is not a tab\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotTab()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotTab\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotTab_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not a tab\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotTab(int exactCount)
```

### Parameters

**exactCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

