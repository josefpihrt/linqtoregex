# Patterns\.SurroundQuoteMarks Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SurroundQuoteMarks()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundQuoteMarks) | Returns a pattern that matches two quotation marks, allowing zero or more characters that are not a quotation mark between the quotation marks\. |
| [SurroundQuoteMarks(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundQuoteMarks_System_Object_) | Returns a pattern that matches specified pattern surrounded with quotation marks\. |
| [SurroundQuoteMarks(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundQuoteMarks_System_Object___) | Returns a pattern that matches specified content surrounded with quotation marks\. |

## SurroundQuoteMarks\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundQuoteMarks"></a>

\
Returns a pattern that matches two quotation marks, allowing zero or more characters that are not a quotation mark between the quotation marks\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundQuoteMarks()
```

### Returns

[Pattern](../../Pattern/README.md)

## SurroundQuoteMarks\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundQuoteMarks_System_Object_"></a>

\
Returns a pattern that matches specified pattern surrounded with quotation marks\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundQuoteMarks(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[Pattern](../../Pattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## SurroundQuoteMarks\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_SurroundQuoteMarks_System_Object___"></a>

\
Returns a pattern that matches specified content surrounded with quotation marks\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundQuoteMarks(params object[] content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

[Pattern](../../Pattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

