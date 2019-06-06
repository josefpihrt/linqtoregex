# Patterns\.DisableOptions Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [DisableOptions(RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_DisableOptions_System_Text_RegularExpressions_RegexOptions_) | Returns a pattern that disables specified options\. |
| [DisableOptions(RegexOptions, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_DisableOptions_System_Text_RegularExpressions_RegexOptions_System_Object_) | Returns a pattern that disables specified options to a specified pattern\. |
| [DisableOptions(RegexOptions, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_DisableOptions_System_Text_RegularExpressions_RegexOptions_System_Object___) | Returns a pattern that disables specified options to a specified pattern\. |

## DisableOptions\(RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_DisableOptions_System_Text_RegularExpressions_RegexOptions_"></a>

\
Returns a pattern that disables specified options\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern DisableOptions(System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**options** &ensp; [RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are disabled\.

### Returns

[Pattern](../../Pattern/README.md)

## DisableOptions\(RegexOptions, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_DisableOptions_System_Text_RegularExpressions_RegexOptions_System_Object_"></a>

\
Returns a pattern that disables specified options to a specified pattern\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern DisableOptions(System.Text.RegularExpressions.RegexOptions options, object content)
```

### Parameters

**options** &ensp; [RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are disabled\.

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## DisableOptions\(RegexOptions, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_DisableOptions_System_Text_RegularExpressions_RegexOptions_System_Object___"></a>

\
Returns a pattern that disables specified options to a specified pattern\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern DisableOptions(System.Text.RegularExpressions.RegexOptions options, params object[] content)
```

### Parameters

**options** &ensp; [RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are disabled\.

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

