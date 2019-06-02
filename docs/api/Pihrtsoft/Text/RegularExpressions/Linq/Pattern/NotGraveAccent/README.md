# Pattern\.NotGraveAccent Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotGraveAccent()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotGraveAccent) | Appends a pattern that matches a character that is not a grave accent\. |
| [NotGraveAccent(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotGraveAccent_System_Int32_) | Appends a pattern that matches a specified number of characters that are not a grave accent\. |

## NotGraveAccent\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotGraveAccent"></a>

### Summary

Appends a pattern that matches a character that is not a grave accent\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotGraveAccent()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NotGraveAccent\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotGraveAccent_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are not a grave accent\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup NotGraveAccent(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

