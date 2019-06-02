# Pattern\.AssertBack Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AssertBack(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AssertBack_System_Object_) | Appends a zero\-width positive lookbehind assertion with a specified content to be matched\. |
| [AssertBack(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AssertBack_System_Object___) | Appends a zero\-width positive lookbehind assertion that matches any one pattern specified in the object array\. |

## AssertBack\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AssertBack_System_Object_"></a>

### Summary

Appends a zero\-width positive lookbehind assertion with a specified content to be matched\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern AssertBack(object content)
```

### Parameters

**content** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## AssertBack\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_AssertBack_System_Object___"></a>

### Summary

Appends a zero\-width positive lookbehind assertion that matches any one pattern specified in the object array\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern AssertBack(params object[] content)
```

### Parameters

**content** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

