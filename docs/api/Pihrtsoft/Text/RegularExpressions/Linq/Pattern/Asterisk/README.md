# Pattern\.Asterisk Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Asterisk()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Asterisk) | Appends a pattern that matches an asterisk\. |
| [Asterisk(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Asterisk_System_Int32_) | Appends a pattern that matches a specified number of asterisks\. |

## Asterisk\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Asterisk"></a>

\
Appends a pattern that matches an asterisk\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Asterisk()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Asterisk\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Asterisk_System_Int32_"></a>

\
Appends a pattern that matches a specified number of asterisks\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Asterisk(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

