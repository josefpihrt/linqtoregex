# Patterns\.SurroundWordBoundary Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SurroundWordBoundary(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundWordBoundary_System_Object_) | Returns a pattern that matches spefified pattern surrounded with a word boundary\. |
| [SurroundWordBoundary(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundWordBoundary_System_Object___) | Returns a pattern that matches specified content surrounded with a word boundary\. |

## SurroundWordBoundary\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundWordBoundary_System_Object_"></a>

### Summary

Returns a pattern that matches spefified pattern surrounded with a word boundary\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern SurroundWordBoundary(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A text to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## SurroundWordBoundary\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundWordBoundary_System_Object___"></a>

### Summary

Returns a pattern that matches specified content surrounded with a word boundary\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern SurroundWordBoundary(params object[] content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more values any one of which has to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

