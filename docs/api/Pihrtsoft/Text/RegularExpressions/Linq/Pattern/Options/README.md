# Pattern\.Options Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Options(RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Options_System_Text_RegularExpressions_RegexOptions_) | Appends a pattern that applies specified options\. |
| [Options(RegexOptions, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Options_System_Text_RegularExpressions_RegexOptions_System_Object_) | Appends a pattern that applies specified options to a specified pattern\. |
| [Options(RegexOptions, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Options_System_Text_RegularExpressions_RegexOptions_System_Object___) | Appends a pattern that applies specified options to a specified pattern\. |
| [Options(RegexOptions, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Options_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_) | Appends a pattern that applies and disables specified options to a specified pattern\. |
| [Options(RegexOptions, RegexOptions, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Options_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_System_Object_) | Appends a pattern that applies and disables specified options to a specified pattern\. |
| [Options(RegexOptions, RegexOptions, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Options_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_System_Object___) | Appends a pattern that applies and disables specified options to a specified pattern\. |

## Options\(RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Options_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Appends a pattern that applies specified options\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern Options(System.Text.RegularExpressions.RegexOptions applyOptions)
```

### Parameters

**applyOptions**

A bitwise combination of the enumeration values that are applied\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

## Options\(RegexOptions, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Options_System_Text_RegularExpressions_RegexOptions_System_Object_"></a>

### Summary

Appends a pattern that applies specified options to a specified pattern\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Options(System.Text.RegularExpressions.RegexOptions applyOptions, object content)
```

### Parameters

**applyOptions**

A bitwise combination of the enumeration values that are applied\.

**content**

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## Options\(RegexOptions, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Options_System_Text_RegularExpressions_RegexOptions_System_Object___"></a>

### Summary

Appends a pattern that applies specified options to a specified pattern\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Options(System.Text.RegularExpressions.RegexOptions applyOptions, params object[] content)
```

### Parameters

**applyOptions**

A bitwise combination of the enumeration values that are applied\.

**content**

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## Options\(RegexOptions, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Options_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Appends a pattern that applies and disables specified options to a specified pattern\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern Options(System.Text.RegularExpressions.RegexOptions applyOptions, System.Text.RegularExpressions.RegexOptions disableOptions)
```

### Parameters

**applyOptions**

A bitwise combination of the enumeration values that are applied\.

**disableOptions**

A bitwise combination of the enumeration values that are disabled\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

## Options\(RegexOptions, RegexOptions, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Options_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_System_Object_"></a>

### Summary

Appends a pattern that applies and disables specified options to a specified pattern\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Options(System.Text.RegularExpressions.RegexOptions applyOptions, System.Text.RegularExpressions.RegexOptions disableOptions, object content)
```

### Parameters

**applyOptions**

A bitwise combination of the enumeration values that are applied\.

**disableOptions**

A bitwise combination of the enumeration values that are disabled\.

**content**

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## Options\(RegexOptions, RegexOptions, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Options_System_Text_RegularExpressions_RegexOptions_System_Text_RegularExpressions_RegexOptions_System_Object___"></a>

### Summary

Appends a pattern that applies and disables specified options to a specified pattern\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Options(System.Text.RegularExpressions.RegexOptions applyOptions, System.Text.RegularExpressions.RegexOptions disableOptions, params object[] content)
```

### Parameters

**applyOptions**

A bitwise combination of the enumeration values that are applied\.

**disableOptions**

A bitwise combination of the enumeration values that are disabled\.

**content**

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

