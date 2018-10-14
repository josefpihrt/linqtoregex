# Pattern\.NotAssert Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAssert(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAssert_System_Object_) | Appends a zero\-width negative lookahead assertion with a specified content not to be matched\. |
| [NotAssert(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAssert_System_Object___) | Appends a zero\-width negative lookahead assertion that matches none of patterns specified in the object array\. |

## NotAssert\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAssert_System_Object_"></a>

### Summary

Appends a zero\-width negative lookahead assertion with a specified content not to be matched\.

```csharp
public QuantifiablePattern NotAssert(object content)
```

### Parameters

**content**

A content not to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## NotAssert\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NotAssert_System_Object___"></a>

### Summary

Appends a zero\-width negative lookahead assertion that matches none of patterns specified in the object array\.

```csharp
public QuantifiablePattern NotAssert(params object[] content)
```

### Parameters

**content**

An object array that contains zero or more patterns none of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

