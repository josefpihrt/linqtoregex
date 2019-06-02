# Pattern\.SurroundQuoteMarks Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SurroundQuoteMarks()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarks) | Appends a pattern that matches two quotation marks, allowing zero or more characters that are not a quotation mark between the quotation marks\. |
| [SurroundQuoteMarks(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarks_System_Object_) | Appends a pattern that matches specified pattern surrounded with quotation marks\. |
| [SurroundQuoteMarks(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarks_System_Object___) | Appends a pattern that matches specified content surrounded with quotation marks\. |

## SurroundQuoteMarks\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarks"></a>

### Summary

Appends a pattern that matches two quotation marks, allowing zero or more characters that are not a quotation mark between the quotation marks\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundQuoteMarks()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

## SurroundQuoteMarks\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarks_System_Object_"></a>

### Summary

Appends a pattern that matches specified pattern surrounded with quotation marks\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundQuoteMarks(object content)
```

### Parameters

**content** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## SurroundQuoteMarks\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarks_System_Object___"></a>

### Summary

Appends a pattern that matches specified content surrounded with quotation marks\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundQuoteMarks(params object[] content)
```

### Parameters

**content** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

