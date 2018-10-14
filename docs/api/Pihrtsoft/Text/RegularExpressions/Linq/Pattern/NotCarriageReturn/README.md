# Pattern\.NotCarriageReturn Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotCarriageReturn()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotCarriageReturn) | Appends a pattern that matches a character that is not a carriage return\. |
| [NotCarriageReturn(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotCarriageReturn_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a carriage return\. |

## NotCarriageReturn\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotCarriageReturn"></a>

### Summary

Appends a pattern that matches a character that is not a carriage return\.

```csharp
public QuantifiablePattern NotCarriageReturn()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotCarriageReturn\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotCarriageReturn_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not a carriage return\.

```csharp
public QuantifiedGroup NotCarriageReturn(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

