# Pattern\.SurroundAngleBrackets Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SurroundAngleBrackets()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundAngleBrackets) | Appends a pattern that matches a text consisting of left and right angle bracket, allowing zero or more characters that are not a right angle bracket between the brackets\. |
| [SurroundAngleBrackets(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundAngleBrackets_System_Object_) | Appends a pattern that matches specified pattern surrounded with left and right angle bracket\. |
| [SurroundAngleBrackets(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundAngleBrackets_System_Object___) | Appends a pattern that matches specified content surrounded with left and right angle bracket\. |

## SurroundAngleBrackets\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundAngleBrackets"></a>

### Summary

Appends a pattern that matches a text consisting of left and right angle bracket, allowing zero or more characters that are not a right angle bracket between the brackets\.

```csharp
public Pattern SurroundAngleBrackets()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

## SurroundAngleBrackets\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundAngleBrackets_System_Object_"></a>

### Summary

Appends a pattern that matches specified pattern surrounded with left and right angle bracket\.

```csharp
public Pattern SurroundAngleBrackets(object content)
```

### Parameters

**content**

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## SurroundAngleBrackets\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundAngleBrackets_System_Object___"></a>

### Summary

Appends a pattern that matches specified content surrounded with left and right angle bracket\.

```csharp
public Pattern SurroundAngleBrackets(params object[] content)
```

### Parameters

**content**

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

