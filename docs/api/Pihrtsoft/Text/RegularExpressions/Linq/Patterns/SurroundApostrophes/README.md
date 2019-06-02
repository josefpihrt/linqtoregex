# Patterns\.SurroundApostrophes Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SurroundApostrophes()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundApostrophes) | Returns a pattern that matches two apostrophes, allowing zero or more characters that are not an apostrophe between the apostrophes\. |
| [SurroundApostrophes(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundApostrophes_System_Object_) | Returns a pattern that matches specified pattern surrounded with apostrophes\. |
| [SurroundApostrophes(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundApostrophes_System_Object___) | Returns a pattern that matches specified content surrounded with apostrophes\. |

## SurroundApostrophes\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundApostrophes"></a>

### Summary

Returns a pattern that matches two apostrophes, allowing zero or more characters that are not an apostrophe between the apostrophes\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundApostrophes()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../../Pattern/README.md)

## SurroundApostrophes\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundApostrophes_System_Object_"></a>

### Summary

Returns a pattern that matches specified pattern surrounded with apostrophes\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundApostrophes(object content)
```

### Parameters

**content** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../../Pattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## SurroundApostrophes\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundApostrophes_System_Object___"></a>

### Summary

Returns a pattern that matches specified content surrounded with apostrophes\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundApostrophes(params object[] content)
```

### Parameters

**content** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../../Pattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

