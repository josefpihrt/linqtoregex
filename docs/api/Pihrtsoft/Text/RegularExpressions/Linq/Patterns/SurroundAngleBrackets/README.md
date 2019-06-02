# Patterns\.SurroundAngleBrackets Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SurroundAngleBrackets()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundAngleBrackets) | Returns a pattern that matches a text consisting of left and right angle bracket, allowing zero or more characters that are not a right angle bracket between the brackets\. |
| [SurroundAngleBrackets(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundAngleBrackets_System_Object_) | Returns a pattern that matches specified pattern surrounded with left and right angle bracket\. |
| [SurroundAngleBrackets(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundAngleBrackets_System_Object___) | Returns a pattern that matches specified content surrounded with left and right angle bracket\. |

## SurroundAngleBrackets\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundAngleBrackets"></a>

### Summary

Returns a pattern that matches a text consisting of left and right angle bracket, allowing zero or more characters that are not a right angle bracket between the brackets\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundAngleBrackets()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../../Pattern/README.md)

## SurroundAngleBrackets\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundAngleBrackets_System_Object_"></a>

### Summary

Returns a pattern that matches specified pattern surrounded with left and right angle bracket\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundAngleBrackets(object content)
```

### Parameters

**content** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../../Pattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## SurroundAngleBrackets\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundAngleBrackets_System_Object___"></a>

### Summary

Returns a pattern that matches specified content surrounded with left and right angle bracket\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundAngleBrackets(params object[] content)
```

### Parameters

**content** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../../Pattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

