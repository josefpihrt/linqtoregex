# Pattern\.DisableOptions Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [DisableOptions(RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_DisableOptions_System_Text_RegularExpressions_RegexOptions_) | Appends a pattern that disables specified options\. |
| [DisableOptions(RegexOptions, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_DisableOptions_System_Text_RegularExpressions_RegexOptions_System_Object_) | Appends a pattern that disables specified options to a specified pattern\. |
| [DisableOptions(RegexOptions, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_DisableOptions_System_Text_RegularExpressions_RegexOptions_System_Object___) | Appends a pattern that disables specified options to a specified pattern\. |

## DisableOptions\(RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_DisableOptions_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Appends a pattern that disables specified options\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern DisableOptions(System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**options** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are disabled\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

## DisableOptions\(RegexOptions, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_DisableOptions_System_Text_RegularExpressions_RegexOptions_System_Object_"></a>

### Summary

Appends a pattern that disables specified options to a specified pattern\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern DisableOptions(System.Text.RegularExpressions.RegexOptions options, object content)
```

### Parameters

**options** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are disabled\.

**content** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## DisableOptions\(RegexOptions, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_DisableOptions_System_Text_RegularExpressions_RegexOptions_System_Object___"></a>

### Summary

Appends a pattern that disables specified options to a specified pattern\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern DisableOptions(System.Text.RegularExpressions.RegexOptions options, params object[] content)
```

### Parameters

**options** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are disabled\.

**content** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

