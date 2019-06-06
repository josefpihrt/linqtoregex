# Patterns\.NotAlphanumericUpper Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAlphanumericUpper()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAlphanumericUpper) | Returns a pattern that matches a character that is not an upper\-case alphanumeric character\. Alphanumeric character is a latin alphabet upper\-case letter or an arabic digit\. |
| [NotAlphanumericUpper(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAlphanumericUpper_System_Int32_) | Returns a pattern that matches a character that is not an upper\-case alphanumeric character specified number of times\. Alphanumeric character is a latin alphabet upper\-case letter or an arabic digit\. |

## NotAlphanumericUpper\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAlphanumericUpper"></a>

\
Returns a pattern that matches a character that is not an upper\-case alphanumeric character\. Alphanumeric character is a latin alphabet upper\-case letter or an arabic digit\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotAlphanumericUpper()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotAlphanumericUpper\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAlphanumericUpper_System_Int32_"></a>

\
Returns a pattern that matches a character that is not an upper\-case alphanumeric character specified number of times\. Alphanumeric character is a latin alphabet upper\-case letter or an arabic digit\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotAlphanumericUpper(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

