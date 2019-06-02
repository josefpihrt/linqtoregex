# Pattern\.NotNumberSign Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotNumberSign()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotNumberSign) | Appends a pattern that matches a character that is not a number sign\. |
| [NotNumberSign(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotNumberSign_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a number sign\. |

## NotNumberSign\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotNumberSign"></a>

### Summary

Appends a pattern that matches a character that is not a number sign\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotNumberSign()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotNumberSign\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotNumberSign_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not a number sign\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotNumberSign(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

