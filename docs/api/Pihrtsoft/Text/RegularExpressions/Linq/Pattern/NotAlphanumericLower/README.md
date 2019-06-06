# Pattern\.NotAlphanumericLower Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAlphanumericLower()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAlphanumericLower) | Appends a pattern that matches a character that is not a lower\-case alphanumeric character\. Alphanumeric character is a latin alphabet lower\-case letter or an arabic digit\. |
| [NotAlphanumericLower(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAlphanumericLower_System_Int32_) | Appends a pattern that matches a character that is not a lower\-case alphanumeric character specified number of times\. Alphanumeric character is a latin alphabet lower\-case letter or an arabic digit\. |

## NotAlphanumericLower\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAlphanumericLower"></a>

\
Appends a pattern that matches a character that is not a lower\-case alphanumeric character\. Alphanumeric character is a latin alphabet lower\-case letter or an arabic digit\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotAlphanumericLower()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotAlphanumericLower\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAlphanumericLower_System_Int32_"></a>

\
Appends a pattern that matches a character that is not a lower\-case alphanumeric character specified number of times\. Alphanumeric character is a latin alphabet lower\-case letter or an arabic digit\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotAlphanumericLower(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

