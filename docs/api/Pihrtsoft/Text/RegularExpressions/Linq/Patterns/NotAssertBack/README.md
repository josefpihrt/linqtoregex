# Patterns\.NotAssertBack Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAssertBack(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssertBack_System_Object_) | Returns a zero\-width negative lookbehind assertion with a specified content not to be matched\. |
| [NotAssertBack(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssertBack_System_Object___) | Returns a zero\-width negative lookbehind assertion that matches none of patterns specified in the object array\. |

## NotAssertBack\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssertBack_System_Object_"></a>

### Summary

Returns a zero\-width negative lookbehind assertion with a specified content not to be matched\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotAssertBack(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content not to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## NotAssertBack\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssertBack_System_Object___"></a>

### Summary

Returns a zero\-width negative lookbehind assertion that matches none of patterns specified in the object array\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotAssertBack(params object[] content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns none of which has to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

