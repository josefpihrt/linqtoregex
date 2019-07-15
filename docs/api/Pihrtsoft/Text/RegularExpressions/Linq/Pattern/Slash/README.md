# Pattern\.Slash Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Slash()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Slash) | Appends a pattern that matches a slash\. |
| [Slash(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Slash_System_Int32_) | Appends a pattern that matches a specified number of slashes\. |

## Slash\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Slash"></a>

\
Appends a pattern that matches a slash\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Slash()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Slash\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Slash_System_Int32_"></a>

\
Appends a pattern that matches a specified number of slashes\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Slash(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

