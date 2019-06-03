# PatternBuilder\.AppendOptions Method

[Home](../../../../../../README.md)

**Containing Type**: [PatternBuilder](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AppendOptions(RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendOptions_System_Text_RegularExpressions_RegexOptions_) | Appends a pattern that applies specified options\. |
| [AppendOptions(RegexOptions, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendOptions_System_Text_RegularExpressions_RegexOptions_System_Object_) | Appends a pattern that applies specified options to a specified pattern\. |
| [AppendOptions(RegexOptions, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendOptions_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_) | Appends a pattern that applies and disables specified options to a specified pattern\. |

## AppendOptions\(RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendOptions_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Appends a pattern that applies specified options\.

```csharp
public void AppendOptions(System.Text.RegularExpressions.RegexOptions applyOptions)
```

### Parameters

**applyOptions** &ensp; [RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are applied\.

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**applyOptions** value is not convertible to inline chars\.

## AppendOptions\(RegexOptions, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendOptions_System_Text_RegularExpressions_RegexOptions_System_Object_"></a>

### Summary

Appends a pattern that applies specified options to a specified pattern\.

```csharp
public void AppendOptions(System.Text.RegularExpressions.RegexOptions applyOptions, object content)
```

### Parameters

**applyOptions** &ensp; [RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are applied\.

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The pattern to match\.

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**applyOptions** value is not convertible to inline chars\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## AppendOptions\(RegexOptions, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendOptions_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Appends a pattern that applies and disables specified options to a specified pattern\.

```csharp
public void AppendOptions(System.Text.RegularExpressions.RegexOptions applyOptions, System.Text.RegularExpressions.RegexOptions disableOptions)
```

### Parameters

**applyOptions** &ensp; [RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are applied\.

**disableOptions** &ensp; [RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that are disabled\.

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**applyOptions** or **disableOptions** value is not convertible to inline chars\.

