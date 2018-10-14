# PatternBuilder\.AppendOptions Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[PatternBuilder](../README.md)

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
public void AppendOptions(RegexOptions applyOptions)
```

### Parameters

**applyOptions**

A bitwise combination of the enumeration values that are applied\.

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**applyOptions** value is not convertible to inline chars\.

## AppendOptions\(RegexOptions, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendOptions_System_Text_RegularExpressions_RegexOptions_System_Object_"></a>

### Summary

Appends a pattern that applies specified options to a specified pattern\.

```csharp
public void AppendOptions(RegexOptions applyOptions, object content)
```

### Parameters

**applyOptions**

A bitwise combination of the enumeration values that are applied\.

**content**

The pattern to match\.

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**applyOptions** value is not convertible to inline chars\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## AppendOptions\(RegexOptions, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendOptions_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Appends a pattern that applies and disables specified options to a specified pattern\.

```csharp
public void AppendOptions(RegexOptions applyOptions, RegexOptions disableOptions)
```

### Parameters

**applyOptions**

A bitwise combination of the enumeration values that are applied\.

**disableOptions**

A bitwise combination of the enumeration values that are disabled\.

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**applyOptions** or **disableOptions** value is not convertible to inline chars\.

