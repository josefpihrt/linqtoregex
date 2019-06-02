# Patterns\.SurroundQuoteMarksOrApostrophes Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SurroundQuoteMarksOrApostrophes()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundQuoteMarksOrApostrophes) | Returns a pattern that matches two quotation marks \(apostrophes\), allowing zero or more characters that are not a quotation mark \(apostrophe\) between the quotation marks \(apostrophes\)\. |
| [SurroundQuoteMarksOrApostrophes(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundQuoteMarksOrApostrophes_System_Object_) | Returns a pattern that matches specified pattern surrounded with quotation marks or apostrophes\. |
| [SurroundQuoteMarksOrApostrophes(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundQuoteMarksOrApostrophes_System_Object___) | Returns a pattern that matches specified content surrounded with quotation marks or apostrophes\. |

## SurroundQuoteMarksOrApostrophes\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundQuoteMarksOrApostrophes"></a>

### Summary

Returns a pattern that matches two quotation marks \(apostrophes\), allowing zero or more characters that are not a quotation mark \(apostrophe\) between the quotation marks \(apostrophes\)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern SurroundQuoteMarksOrApostrophes()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## SurroundQuoteMarksOrApostrophes\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundQuoteMarksOrApostrophes_System_Object_"></a>

### Summary

Returns a pattern that matches specified pattern surrounded with quotation marks or apostrophes\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern SurroundQuoteMarksOrApostrophes(object content)
```

### Parameters

**content** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## SurroundQuoteMarksOrApostrophes\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundQuoteMarksOrApostrophes_System_Object___"></a>

### Summary

Returns a pattern that matches specified content surrounded with quotation marks or apostrophes\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern SurroundQuoteMarksOrApostrophes(params object[] content)
```

### Parameters

**content** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

