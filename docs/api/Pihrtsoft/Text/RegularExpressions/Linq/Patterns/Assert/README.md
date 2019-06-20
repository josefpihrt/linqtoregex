# Patterns\.Assert Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Assert(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Assert_System_Object_) | Returns a zero\-width positive lookahead assertion with a specified content to be matched\. |
| [Assert(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Assert_System_Object___) | Returns a zero\-width positive lookahead assertion that matches any one pattern specified in the object array\. |

## Assert\(Object\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Assert_System_Object_"></a>

\
Returns a zero\-width positive lookahead assertion with a specified content to be matched\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Assertion Assert(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content to be matched\.

### Returns

[Assertion](../../Assertion/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## Assert\(Object\[\]\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Assert_System_Object___"></a>

\
Returns a zero\-width positive lookahead assertion that matches any one pattern specified in the object array\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Assertion Assert(params object[] content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

[Assertion](../../Assertion/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

