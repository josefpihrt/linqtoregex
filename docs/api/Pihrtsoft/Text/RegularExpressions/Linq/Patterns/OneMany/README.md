# Patterns\.OneMany Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [OneMany(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_OneMany_System_Object_) | Returns a pattern that matches specified content one or more times\. |
| [OneMany(Object, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_OneMany_System_Object_System_Object___) | Returns a pattern that matches any one specified element one or more times\. |

## OneMany\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_OneMany_System_Object_"></a>

### Summary

Returns a pattern that matches specified content one or more times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup OneMany(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## OneMany\(Object, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_OneMany_System_Object_System_Object___"></a>

### Summary

Returns a pattern that matches any one specified element one or more times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup OneMany(object first, params object[] others)
```

### Parameters

**first** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

First element of a sequence that contains patterns any one of which has to be matched\.

**others** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

Other elements of a sequence that contains patterns any one of which has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**first** is `null`\.

