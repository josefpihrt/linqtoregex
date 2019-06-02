# Pattern\.NotAsterisk Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAsterisk()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAsterisk) | Appends a pattern that matches a character that is not an asterisk\. |
| [NotAsterisk(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAsterisk_System_Int32_) | Appends a pattern that matches a specified number of characters that are not an asterisk\. |

## NotAsterisk\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAsterisk"></a>

### Summary

Appends a pattern that matches a character that is not an asterisk\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotAsterisk()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotAsterisk\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAsterisk_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not an asterisk\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotAsterisk(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

