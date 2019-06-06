# Pattern\.Space Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Space()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Space) | Appends a pattern that matches a space\. |
| [Space(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Space_System_Int32_) | Appends a pattern that matches a specified number of spaces\. |

## Space\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Space"></a>

\
Appends a pattern that matches a space\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Space()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Space\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Space_System_Int32_"></a>

\
Appends a pattern that matches a specified number of spaces\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Space(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

