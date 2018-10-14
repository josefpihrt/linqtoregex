# Pattern\.Parenthesis Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Parenthesis()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Parenthesis) | Appends a pattern that matches left or right parenthesis\. |
| [Parenthesis(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Parenthesis_System_Int32_) | Appends a pattern that matches left or right parenthesis specified number of times\. |

## Parenthesis\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Parenthesis"></a>

### Summary

Appends a pattern that matches left or right parenthesis\.

```csharp
public CharGroup Parenthesis()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## Parenthesis\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Parenthesis_System_Int32_"></a>

### Summary

Appends a pattern that matches left or right parenthesis specified number of times\.

```csharp
public QuantifiedGroup Parenthesis(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

