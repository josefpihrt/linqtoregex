# Pattern\.Dollar Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Dollar()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Dollar) | Appends a pattern that matches a dollar\. |
| [Dollar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Dollar_System_Int32_) | Appends a pattern that matches a specified number of dollars\. |

## Dollar\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Dollar"></a>

\
Appends a pattern that matches a dollar\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Dollar()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Dollar\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Dollar_System_Int32_"></a>

\
Appends a pattern that matches a specified number of dollars\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Dollar(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

