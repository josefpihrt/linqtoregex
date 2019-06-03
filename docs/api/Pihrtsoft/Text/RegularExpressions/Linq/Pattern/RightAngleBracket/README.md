# Pattern\.RightAngleBracket Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

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

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## RightAngleBracket\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_RightAngleBracket_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of right angle brackets \(greater\-than signs\)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup RightAngleBracket(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

