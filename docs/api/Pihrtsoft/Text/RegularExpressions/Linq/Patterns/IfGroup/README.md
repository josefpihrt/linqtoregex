# Patterns\.IfGroup Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [IfGroup(Int32, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_IfGroup_System_Int32_System_Object_) | Returns an if construct with a content to match if the numbered group is matched\. |
| [IfGroup(Int32, Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_IfGroup_System_Int32_System_Object_System_Object_) | Returns an if construct with a content to match if the numbered group is matched and a content to match if the numbered group is not matched\. |
| [IfGroup(String, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_IfGroup_System_String_System_Object_) | Returns an if construct with a content to match if the named group is matched\. |
| [IfGroup(String, Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_IfGroup_System_String_System_Object_System_Object_) | Returns an if construct with a content to match if the named group is matched and a content to match if the named group is not matched\. |

## IfGroup\(Int32, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_IfGroup_System_Int32_System_Object_"></a>

### Summary

Returns an if construct with a content to match if the numbered group is matched\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern IfGroup(int groupNumber, object trueContent)
```

### Parameters

**groupNumber** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of the group\.

**trueContent** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched if the numbered group is matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**trueContent** is `null`\.

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**groupNumber** is less than zero\.

## IfGroup\(Int32, Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_IfGroup_System_Int32_System_Object_System_Object_"></a>

### Summary

Returns an if construct with a content to match if the numbered group is matched and a content to match if the numbered group is not matched\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern IfGroup(int groupNumber, object trueContent, object falseContent)
```

### Parameters

**groupNumber** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of the group\.

**trueContent** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched if the numbered group is matched\.

**falseContent** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched if the numbered group is not matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**trueContent** is `null`\.

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**groupNumber** is less than zero\.

## IfGroup\(String, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_IfGroup_System_String_System_Object_"></a>

### Summary

Returns an if construct with a content to match if the named group is matched\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern IfGroup(string groupName, object trueContent)
```

### Parameters

**groupName** &emsp; System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group\.

**trueContent** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched if the named group is matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** or **trueContent** is `null`\.

## IfGroup\(String, Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_IfGroup_System_String_System_Object_System_Object_"></a>

### Summary

Returns an if construct with a content to match if the named group is matched and a content to match if the named group is not matched\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern IfGroup(string groupName, object trueContent, object falseContent)
```

### Parameters

**groupName** &emsp; System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group\.

**trueContent** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched if the named group is matched\.

**falseContent** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched if the named group is not matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** or **trueContent** is `null`\.

