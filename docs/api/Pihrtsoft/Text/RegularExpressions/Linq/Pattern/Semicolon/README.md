# Pattern\.Semicolon Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Semicolon()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Semicolon) | Appends a pattern that matches a semicolon\. |
| [Semicolon(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Semicolon_System_Int32_) | Appends a pattern that matches a specified number of semicolons\. |

## Semicolon\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Semicolon"></a>

### Summary

Appends a pattern that matches a semicolon\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Semicolon()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Semicolon\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Semicolon_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of semicolons\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Semicolon(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

