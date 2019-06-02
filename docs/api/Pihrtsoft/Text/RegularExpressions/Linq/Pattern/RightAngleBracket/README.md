# Pattern\.RightAngleBracket Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [RightAngleBracket()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightAngleBracket) | Appends a pattern that matches a right angle bracket \(greater\-than sign\)\. |
| [RightAngleBracket(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightAngleBracket_System_Int32_) | Appends a pattern that matches a specified number of right angle brackets \(greater\-than signs\)\. |

## RightAngleBracket\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightAngleBracket"></a>

### Summary

Appends a pattern that matches a right angle bracket \(greater\-than sign\)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern RightAngleBracket()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## RightAngleBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightAngleBracket_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of right angle brackets \(greater\-than signs\)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup RightAngleBracket(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

