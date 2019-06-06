# Patterns\.Semicolon Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Semicolon()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Semicolon) | Returns a pattern that matches a semicolon\. |
| [Semicolon(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Semicolon_System_Int32_) | Returns a pattern that matches a specified number of semicolons\. |

## Semicolon\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Semicolon"></a>

\
Returns a pattern that matches a semicolon\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Semicolon()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## Semicolon\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Semicolon_System_Int32_"></a>

\
Returns a pattern that matches a specified number of semicolons\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Semicolon(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

