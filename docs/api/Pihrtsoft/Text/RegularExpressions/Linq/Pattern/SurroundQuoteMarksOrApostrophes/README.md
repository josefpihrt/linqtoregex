# Pattern\.SurroundQuoteMarksOrApostrophes Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SurroundQuoteMarksOrApostrophes()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarksOrApostrophes) | Appends a pattern that matches two quotation marks \(apostrophes\), allowing zero or more characters that are not a quotation mark \(apostrophe\) between the quotation marks \(apostrophes\)\. |
| [SurroundQuoteMarksOrApostrophes(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarksOrApostrophes_System_Object_) | Appends a pattern that matches specified pattern surrounded with quotation marks or apostrophes\. |
| [SurroundQuoteMarksOrApostrophes(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarksOrApostrophes_System_Object___) | Appends a pattern that matches specified content surrounded with quotation marks or apostrophes\. |

## SurroundQuoteMarksOrApostrophes\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarksOrApostrophes"></a>

### Summary

Appends a pattern that matches two quotation marks \(apostrophes\), allowing zero or more characters that are not a quotation mark \(apostrophe\) between the quotation marks \(apostrophes\)\.

```csharp
public QuantifiablePattern SurroundQuoteMarksOrApostrophes()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## SurroundQuoteMarksOrApostrophes\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarksOrApostrophes_System_Object_"></a>

### Summary

Appends a pattern that matches specified pattern surrounded with quotation marks or apostrophes\.

```csharp
public QuantifiablePattern SurroundQuoteMarksOrApostrophes(object content)
```

### Parameters

**content**

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## SurroundQuoteMarksOrApostrophes\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarksOrApostrophes_System_Object___"></a>

### Summary

Appends a pattern that matches specified content surrounded with quotation marks or apostrophes\.

```csharp
public QuantifiablePattern SurroundQuoteMarksOrApostrophes(params object[] content)
```

### Parameters

**content**

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

