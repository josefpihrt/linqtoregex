# Patterns\.Colon Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Colon()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Colon) | Returns a pattern that matches a colon\. |
| [Colon(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Colon_System_Int32_) | Returns a pattern that matches a specified number of colons\. |

## Colon\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Colon"></a>

\
Returns a pattern that matches a colon\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Colon()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## Colon\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Colon_System_Int32_"></a>

\
Returns a pattern that matches a specified number of colons\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Colon(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

