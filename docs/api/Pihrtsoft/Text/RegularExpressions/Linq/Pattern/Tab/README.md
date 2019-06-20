# Pattern\.Tab Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Tab()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Tab) | Appends a pattern that matches a tab\. |
| [Tab(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Tab_System_Int32_) | Appends a pattern that matches a specified number of tabs\. |

## Tab\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Tab"></a>

\
Appends a pattern that matches a tab\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Tab()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Tab\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Tab_System_Int32_"></a>

\
Appends a pattern that matches a specified number of tabs\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Tab(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

