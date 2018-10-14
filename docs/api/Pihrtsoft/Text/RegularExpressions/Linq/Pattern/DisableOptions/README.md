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
public Pattern DisableOptions(RegexOptions options)
```

### Parameters

**options**

A bitwise combination of the enumeration values that are disabled\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

## DisableOptions\(RegexOptions, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_DisableOptions_System_Text_RegularExpressions_RegexOptions_System_Object_"></a>

### Summary

Appends a pattern that disables specified options to a specified pattern\.

```csharp
public QuantifiablePattern DisableOptions(RegexOptions options, object content)
```

### Parameters

**options**

A bitwise combination of the enumeration values that are disabled\.

**content**

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
public QuantifiablePattern DisableOptions(RegexOptions options, params object[] content)
```

### Parameters

**options**

A bitwise combination of the enumeration values that are disabled\.

**content**

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

