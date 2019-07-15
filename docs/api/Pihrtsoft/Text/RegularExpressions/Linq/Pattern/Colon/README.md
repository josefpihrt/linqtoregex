# Pattern\.Colon Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Colon()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Colon) | Appends a pattern that matches a colon\. |
| [Colon(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Colon_System_Int32_) | Appends a pattern that matches a specified number of colons\. |

## Colon\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Colon"></a>

\
Appends a pattern that matches a colon\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Colon()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Colon\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Colon_System_Int32_"></a>

\
Appends a pattern that matches a specified number of colons\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Colon(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

