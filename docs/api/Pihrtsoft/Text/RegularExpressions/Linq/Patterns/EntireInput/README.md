# Patterns\.EntireInput Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EntireInput(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_EntireInput_System_Object_) | Returns a pattern that matches a specified content surrounded with the beginning and the end of the string\. |
| [EntireInput(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_EntireInput_System_Object___) | Returns a pattern that matches any one pattern surrounded with the beginning and the end of the string\. |

## EntireInput\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_EntireInput_System_Object_"></a>

### Summary

Returns a pattern that matches a specified content surrounded with the beginning and the end of the string\.

```csharp
public static QuantifiablePattern EntireInput(object content)
```

### Parameters

**content**

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## EntireInput\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_EntireInput_System_Object___"></a>

### Summary

Returns a pattern that matches any one pattern surrounded with the beginning and the end of the string\.

```csharp
public static QuantifiablePattern EntireInput(params object[] content)
```

### Parameters

**content**

An object array that contains zero or more values any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

