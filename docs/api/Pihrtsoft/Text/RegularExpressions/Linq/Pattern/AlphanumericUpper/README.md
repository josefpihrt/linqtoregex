# Pattern\.AlphanumericUpper Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AlphanumericUpper()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AlphanumericUpper) | Appends a pattern that matches an upper\-case alphanumeric character\. Alphanumeric character is a latin alphabet upper\-case letter or an arabic digit\. |
| [AlphanumericUpper(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AlphanumericUpper_System_Int32_) | Appends a pattern that matches a specified number of upper\-case alphanumeric characters\. Alphanumeric character is a latin alphabet upper\-case letter or an arabic digit\. |

## AlphanumericUpper\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AlphanumericUpper"></a>

\
Appends a pattern that matches an upper\-case alphanumeric character\. Alphanumeric character is a latin alphabet upper\-case letter or an arabic digit\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern AlphanumericUpper()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## AlphanumericUpper\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AlphanumericUpper_System_Int32_"></a>

\
Appends a pattern that matches a specified number of upper\-case alphanumeric characters\. Alphanumeric character is a latin alphabet upper\-case letter or an arabic digit\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup AlphanumericUpper(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

