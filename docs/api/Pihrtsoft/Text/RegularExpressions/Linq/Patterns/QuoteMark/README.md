# Patterns\.QuoteMark Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [QuoteMark()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_QuoteMark) | Returns a pattern that matches a quote mark\. |
| [QuoteMark(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_QuoteMark_System_Int32_) | Returns a pattern that matches a specified number of quote marks\. |

## QuoteMark\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_QuoteMark"></a>

### Summary

Returns a pattern that matches a quote mark\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern QuoteMark()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## QuoteMark\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_QuoteMark_System_Int32_"></a>

### Summary

Returns a pattern that matches a specified number of quote marks\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup QuoteMark(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

