# Patterns\.NotAssert Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAssert(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssert_System_Object_) | Returns a zero\-width negative lookahead assertion with a specified content not to be matched\. |
| [NotAssert(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssert_System_Object___) | Returns a zero\-width negative lookahead assertion that matches none of patterns specified in the object array\. |

## NotAssert\(Object\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssert_System_Object_"></a>

\
Returns a zero\-width negative lookahead assertion with a specified content not to be matched\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotAssert(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content not to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## NotAssert\(Object\[\]\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssert_System_Object___"></a>

\
Returns a zero\-width negative lookahead assertion that matches none of patterns specified in the object array\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotAssert(params object[] content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns none of which has to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

