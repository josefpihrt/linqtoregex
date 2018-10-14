# Pattern\.MaybeMany Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [MaybeMany(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_MaybeMany_System_Object_) | Appends a pattern that matches specified content zero or more times\. |
| [MaybeMany(Object, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_MaybeMany_System_Object_System_Object___) | Appends a pattern that matches any one specified element zero or more times\. |

## MaybeMany\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_MaybeMany_System_Object_"></a>

### Summary

Appends a pattern that matches specified content zero or more times\.

```csharp
public QuantifiedGroup MaybeMany(object content)
```

### Parameters

**content**

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## MaybeMany\(Object, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_MaybeMany_System_Object_System_Object___"></a>

### Summary

Appends a pattern that matches any one specified element zero or more times\.

```csharp
public QuantifiedGroup MaybeMany(object first, params object[] others)
```

### Parameters

**first**

First element of a sequence that contains patterns any one of which has to be matched\.

**others**

Other elements of a sequence that contains patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**first** is `null`\.

