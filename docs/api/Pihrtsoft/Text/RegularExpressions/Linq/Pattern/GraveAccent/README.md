# Pattern\.GraveAccent Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [GraveAccent()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_GraveAccent) | Appends a pattern that matches a grave accent\. |
| [GraveAccent(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_GraveAccent_System_Int32_) | Appends a pattern that matches a specified number of grave accents\. |

## GraveAccent\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_GraveAccent"></a>

### Summary

Appends a pattern that matches a grave accent\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern GraveAccent()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## GraveAccent\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_GraveAccent_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of grave accents\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup GraveAccent(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

