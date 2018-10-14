# Pattern\.NumberSign Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NumberSign()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NumberSign) | Appends a pattern that matches a number sign\. |
| [NumberSign(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NumberSign_System_Int32_) | Appends a pattern that matches a specified number of number signs\. |

## NumberSign\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NumberSign"></a>

### Summary

Appends a pattern that matches a number sign\.

```csharp
public QuantifiablePattern NumberSign()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## NumberSign\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NumberSign_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of number signs\.

```csharp
public QuantifiedGroup NumberSign(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

