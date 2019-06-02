# Patterns\.Tilde Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Tilde()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Tilde) | Returns a pattern that matches a tilde\. |
| [Tilde(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Tilde_System_Int32_) | Returns a pattern that matches a specified number of tildes\. |

## Tilde\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Tilde"></a>

### Summary

Returns a pattern that matches a tilde\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Tilde()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Tilde\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Tilde_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of tildes\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Tilde(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

