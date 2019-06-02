# Pattern\.IfGroup Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [IfGroup(Int32, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_IfGroup_System_Int32_System_Object_) | Appends an if construct with a content to match if the numbered group is matched\. |
| [IfGroup(Int32, Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_IfGroup_System_Int32_System_Object_System_Object_) | Appends an if construct with a content to match if the numbered group is matched and a content to match if the numbered group is not matched\. |
| [IfGroup(String, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_IfGroup_System_String_System_Object_) | Appends an if construct with a content to match if the named group is matched\. |
| [IfGroup(String, Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_IfGroup_System_String_System_Object_System_Object_) | Appends an if construct with a content to match if the named group is matched and a content to match if the named group is not matched\. |

## IfGroup\(Int32, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_IfGroup_System_Int32_System_Object_"></a>

### Summary

Appends an if construct with a content to match if the numbered group is matched\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern IfGroup(int groupNumber, object trueContent)
```

### Parameters

**groupNumber**

A number of the group\.

**trueContent**

The content to be matched if the numbered group is matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**trueContent** is `null`\.

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**groupNumber** is less than zero\.

## IfGroup\(Int32, Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_IfGroup_System_Int32_System_Object_System_Object_"></a>

### Summary

Appends an if construct with a content to match if the numbered group is matched and a content to match if the numbered group is not matched\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern IfGroup(int groupNumber, object trueContent, object falseContent)
```

### Parameters

**groupNumber**

A number of the group\.

**trueContent**

The content to be matched if the numbered group is matched\.

**falseContent**

The content to be matched if the numbered group is not matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**trueContent** is `null`\.

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**groupNumber** is less than zero\.

## IfGroup\(String, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_IfGroup_System_String_System_Object_"></a>

### Summary

Appends an if construct with a content to match if the named group is matched\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern IfGroup(string groupName, object trueContent)
```

### Parameters

**groupName**

A name of the group\.

**trueContent**

The content to be matched if the named group is matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** or **trueContent** is `null`\.

## IfGroup\(String, Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_IfGroup_System_String_System_Object_System_Object_"></a>

### Summary

Appends an if construct with a content to match if the named group is matched and a content to match if the named group is not matched\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern IfGroup(string groupName, object trueContent, object falseContent)
```

### Parameters

**groupName**

A name of the group\.

**trueContent**

The content to be matched if the named group is matched\.

**falseContent**

The content to be matched if the named group is not matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** or **trueContent** is `null`\.

