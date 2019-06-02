# Patterns\.Options Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Options(RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Options_System_Text_RegularExpressions_RegexOptions_) | Returns a pattern that applies specified options\. |
| [Options(RegexOptions, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Options_System_Text_RegularExpressions_RegexOptions_System_Object_) | Returns a pattern that applies specified options to a specified pattern\. |
| [Options(RegexOptions, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Options_System_Text_RegularExpressions_RegexOptions_System_Object___) | Returns a pattern that applies specified options to a specified pattern\. |
| [Options(RegexOptions, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Options_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_) | Returns a pattern that applies and disables specified options to a specified pattern\. |
| [Options(RegexOptions, RegexOptions, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Options_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_System_Object_) | Returns a pattern that applies and disables specified options to a specified pattern\. |
| [Options(RegexOptions, RegexOptions, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Options_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_System_Object___) | Returns a pattern that applies and disables specified options to a specified pattern\. |

## Options\(RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Options_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Returns a pattern that applies specified options\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern Options(System.Text.RegularExpressions.RegexOptions applyOptions)
```

### Parameters

**applyOptions** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are applied\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../../Pattern/README.md)

## Options\(RegexOptions, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Options_System_Text_RegularExpressions_RegexOptions_System_Object_"></a>

### Summary

Returns a pattern that applies specified options to a specified pattern\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Options(System.Text.RegularExpressions.RegexOptions applyOptions, object content)
```

### Parameters

**applyOptions** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are applied\.

**content** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## Options\(RegexOptions, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Options_System_Text_RegularExpressions_RegexOptions_System_Object___"></a>

### Summary

Returns a pattern that applies specified options to a specified pattern\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Options(System.Text.RegularExpressions.RegexOptions applyOptions, params object[] content)
```

### Parameters

**applyOptions** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are applied\.

**content** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## Options\(RegexOptions, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Options_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Returns a pattern that applies and disables specified options to a specified pattern\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern Options(System.Text.RegularExpressions.RegexOptions applyOptions, System.Text.RegularExpressions.RegexOptions disableOptions)
```

### Parameters

**applyOptions** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are applied\.

**disableOptions** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are disabled\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../../Pattern/README.md)

## Options\(RegexOptions, RegexOptions, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Options_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_System_Object_"></a>

### Summary

Returns a pattern that applies and disables specified options to a specified pattern\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Options(System.Text.RegularExpressions.RegexOptions applyOptions, System.Text.RegularExpressions.RegexOptions disableOptions, object content)
```

### Parameters

**applyOptions** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are applied\.

**disableOptions** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are disabled\.

**content** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## Options\(RegexOptions, RegexOptions, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Options_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_System_Object___"></a>

### Summary

Returns a pattern that applies and disables specified options to a specified pattern\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Options(System.Text.RegularExpressions.RegexOptions applyOptions, System.Text.RegularExpressions.RegexOptions disableOptions, params object[] content)
```

### Parameters

**applyOptions** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are applied\.

**disableOptions** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are disabled\.

**content** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

