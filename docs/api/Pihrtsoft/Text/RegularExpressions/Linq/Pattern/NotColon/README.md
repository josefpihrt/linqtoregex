# Pattern\.NotColon Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotColon()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotColon) | Appends a pattern that matches a character that is not a colon\. |
| [NotColon(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotColon_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a colon\. |

## NotColon\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotColon"></a>

### Summary

Appends a pattern that matches a character that is not a colon\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotColon()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotColon\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotColon_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not a colon\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotColon(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

