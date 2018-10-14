# Pattern\.NotSpace Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotSpace()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSpace) | Appends a pattern that matches a character that is not a space\. |
| [NotSpace(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSpace_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a space\. |

## NotSpace\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSpace"></a>

### Summary

Appends a pattern that matches a character that is not a space\.

```csharp
public QuantifiablePattern NotSpace()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotSpace\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotSpace_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not a space\.

```csharp
public QuantifiedGroup NotSpace(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

