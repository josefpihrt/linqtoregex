# Patterns\.AssertBack Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AssertBack(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AssertBack_System_Object_) | Returns a zero\-width positive lookbehind assertion with a specified content to be matched\. |
| [AssertBack(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AssertBack_System_Object___) | Returns a zero\-width positive lookbehind assertion that matches any one pattern specified in the object array\. |

## AssertBack\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AssertBack_System_Object_"></a>

### Summary

Returns a zero\-width positive lookbehind assertion with a specified content to be matched\.

```csharp
public static BackAssertion AssertBack(object content)
```

### Parameters

**content**

A content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[BackAssertion](../../BackAssertion/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## AssertBack\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AssertBack_System_Object___"></a>

### Summary

Returns a zero\-width positive lookbehind assertion that matches any one pattern specified in the object array\.

```csharp
public static BackAssertion AssertBack(params object[] content)
```

### Parameters

**content**

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[BackAssertion](../../BackAssertion/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

