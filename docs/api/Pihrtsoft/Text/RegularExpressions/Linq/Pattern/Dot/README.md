# Pattern\.Dot Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Dot()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Dot) | Appends a pattern that matches a dot\. |
| [Dot(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Dot_System_Int32_) | Appends a pattern that matches a specified number of dots\. |

## Dot\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Dot"></a>

### Summary

Appends a pattern that matches a dot\.

```csharp
public QuantifiablePattern Dot()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Dot\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Dot_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of dots\.

```csharp
public QuantifiedGroup Dot(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

