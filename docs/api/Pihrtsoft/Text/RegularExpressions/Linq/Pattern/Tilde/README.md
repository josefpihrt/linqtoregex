# Pattern\.Tilde Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Tilde()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Tilde) | Appends a pattern that matches a tilde\. |
| [Tilde(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Tilde_System_Int32_) | Appends a pattern that matches a specified number of tildes\. |

## Tilde\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Tilde"></a>

### Summary

Appends a pattern that matches a tilde\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Tilde()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Tilde\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Tilde_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of tildes\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Tilde(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

