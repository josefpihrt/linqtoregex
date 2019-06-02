# Pattern\.NotDigit Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotDigit()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotDigit) | Appends a pattern that matches a character that is not a digit character\. |
| [NotDigit(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotDigit_System_Int32_) | Appends a pattern that matches a character that is not a digit character specified number of times\. |

## NotDigit\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotDigit"></a>

### Summary

Appends a pattern that matches a character that is not a digit character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotDigit()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotDigit\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotDigit_System_Int32_"></a>

### Summary

Appends a pattern that matches a character that is not a digit character specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotDigit(int exactCount)
```

### Parameters

**exactCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

