# Patterns\.Dollar Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Dollar()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Dollar) | Returns a pattern that matches a dollar\. |
| [Dollar(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Dollar_System_Int32_) | Returns a pattern that matches a specified number of dollars\. |

## Dollar\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Dollar"></a>

\
Returns a pattern that matches a dollar\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern Dollar()
```

### Returns

[CharPattern](../../CharPattern/README.md)

## Dollar\(Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Dollar_System_Int32_"></a>

\
Returns a pattern that matches a specified number of dollars\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Dollar(int exactCount)
```

### Parameters

**exactCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times a character has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

