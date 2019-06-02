# Pattern\.NotAlphanumeric Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAlphanumeric()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAlphanumeric) | Appends a pattern that matches a character that is not an alphanumeric character\. Alphanumeric character is a latin alphabet letter or an arabic digit\. |
| [NotAlphanumeric(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAlphanumeric_System_Int32_) | Appends a pattern that matches a character that is not an alphanumeric character specified number of times\. Alphanumeric character is a latin alphabet letter or an arabic digit\. |

## NotAlphanumeric\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAlphanumeric"></a>

### Summary

Appends a pattern that matches a character that is not an alphanumeric character\. Alphanumeric character is a latin alphabet letter or an arabic digit\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGroup NotAlphanumeric()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## NotAlphanumeric\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAlphanumeric_System_Int32_"></a>

### Summary

Appends a pattern that matches a character that is not an alphanumeric character specified number of times\. Alphanumeric character is a latin alphabet letter or an arabic digit\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotAlphanumeric(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

