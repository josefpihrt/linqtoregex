# Pattern\.SlashOrBackslash Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SlashOrBackslash()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SlashOrBackslash) | Appends a pattern that matches a slash or a backslash\. |
| [SlashOrBackslash(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SlashOrBackslash_System_Int32_) | Appends a pattern that matches a specified number of characters that are slash or backslash\. |

## SlashOrBackslash\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SlashOrBackslash"></a>

### Summary

Appends a pattern that matches a slash or a backslash\.

```csharp
public CharGroup SlashOrBackslash()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## SlashOrBackslash\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SlashOrBackslash_System_Int32_"></a>

### Summary

Appends a pattern that matches a specified number of characters that are slash or backslash\.

```csharp
public QuantifiedGroup SlashOrBackslash(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

