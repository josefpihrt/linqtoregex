# Pattern\.Colon Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Colon()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Colon) | Appends a pattern that matches a colon\. |
| [Colon(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Colon_System_Int32_) | Appends a pattern that matches a specified number of colons\. |

## Colon\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Colon"></a>

### Summary

Appends a pattern that matches a colon\.

```csharp
public QuantifiablePattern Colon()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Colon\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Colon_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of colons\.

```csharp
public QuantifiedGroup Colon(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

