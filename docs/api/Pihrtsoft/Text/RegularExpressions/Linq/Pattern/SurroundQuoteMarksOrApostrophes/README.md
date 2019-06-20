# Pattern\.SurroundQuoteMarksOrApostrophes Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SurroundQuoteMarksOrApostrophes()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarksOrApostrophes) | Appends a pattern that matches two quotation marks \(apostrophes\), allowing zero or more characters that are not a quotation mark \(apostrophe\) between the quotation marks \(apostrophes\)\. |
| [SurroundQuoteMarksOrApostrophes(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarksOrApostrophes_System_Object_) | Appends a pattern that matches specified pattern surrounded with quotation marks or apostrophes\. |
| [SurroundQuoteMarksOrApostrophes(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarksOrApostrophes_System_Object___) | Appends a pattern that matches specified content surrounded with quotation marks or apostrophes\. |

## SurroundQuoteMarksOrApostrophes\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarksOrApostrophes"></a>

\
Appends a pattern that matches two quotation marks \(apostrophes\), allowing zero or more characters that are not a quotation mark \(apostrophe\) between the quotation marks \(apostrophes\)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern SurroundQuoteMarksOrApostrophes()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## SurroundQuoteMarksOrApostrophes\(Object\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarksOrApostrophes_System_Object_"></a>

\
Appends a pattern that matches specified pattern surrounded with quotation marks or apostrophes\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern SurroundQuoteMarksOrApostrophes(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## SurroundQuoteMarksOrApostrophes\(Object\[\]\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundQuoteMarksOrApostrophes_System_Object___"></a>

\
Appends a pattern that matches specified content surrounded with quotation marks or apostrophes\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern SurroundQuoteMarksOrApostrophes(params object[] content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

