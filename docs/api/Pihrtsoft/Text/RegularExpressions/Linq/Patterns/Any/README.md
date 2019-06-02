# Patterns\.Any Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Any()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Any) | Returns a pattern that matches any character\. |
| [Any(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Any_System_Int32_) | Returns a pattern that matches any character specified number of times\. |
| [Any(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Any_System_Object_) | Returns a noncapturing group with a specified content\. |
| [Any(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Any_System_Object___) | Returns a pattern that matches any one of the patterns specified in the object array\. |

## Any\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Any"></a>

### Summary

Returns a pattern that matches any character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Any()
```

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Any\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Any_System_Int32_"></a>

### Summary

Returns a pattern that matches any character specified number of times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Any(int exactCount)
```

### Parameters

**exactCount**

A number of times a character has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

## Any\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Any_System_Object_"></a>

### Summary

Returns a noncapturing group with a specified content\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Any(object content)
```

### Parameters

**content**

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Any\(Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Any_System_Object___"></a>

### Summary

Returns a pattern that matches any one of the patterns specified in the object array\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Any(params object[] content)
```

### Parameters

**content**

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

