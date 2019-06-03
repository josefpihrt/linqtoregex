# Pattern\.Plus Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Plus()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Plus) | Appends a pattern that matches a plus\. |
| [Plus(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Plus_System_Int32_) | Appends a pattern that matches a specified number of pluses\. |

## Plus\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Plus"></a>

### Summary

Appends a pattern that matches a plus\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Plus()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Plus\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Plus_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of pluses\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Plus(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

