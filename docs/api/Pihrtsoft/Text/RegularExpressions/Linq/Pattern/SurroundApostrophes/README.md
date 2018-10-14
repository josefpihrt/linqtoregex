# Pattern\.SurroundApostrophes Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SurroundApostrophes()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundApostrophes) | Appends a pattern that matches two apostrophes, allowing zero or more characters that are not an apostrophe between the apostrophes\. |
| [SurroundApostrophes(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundApostrophes_System_Object_) | Appends a pattern that matches specified pattern surrounded with apostrophes\. |
| [SurroundApostrophes(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundApostrophes_System_Object___) | Appends a pattern that matches specified content surrounded with apostrophes\. |

## SurroundApostrophes\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundApostrophes"></a>

### Summary

Appends a pattern that matches two apostrophes, allowing zero or more characters that are not an apostrophe between the apostrophes\.

```csharp
public Pattern SurroundApostrophes()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

## SurroundApostrophes\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundApostrophes_System_Object_"></a>

### Summary

Appends a pattern that matches specified pattern surrounded with apostrophes\.

```csharp
public Pattern SurroundApostrophes(object content)
```

### Parameters

**content**

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## SurroundApostrophes\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundApostrophes_System_Object___"></a>

### Summary

Appends a pattern that matches specified content surrounded with apostrophes\.

```csharp
public Pattern SurroundApostrophes(params object[] content)
```

### Parameters

**content**

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

