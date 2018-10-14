# PatternBuilder\.AppendIfGroup Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[PatternBuilder](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AppendIfGroup(Int32, Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendIfGroup_System_Int32_System_Object_System_Object_) | Appends an if construct\. |
| [AppendIfGroup(String, Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendIfGroup_System_String_System_Object_System_Object_) | Appends an if construct\. |

## AppendIfGroup\(Int32, Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendIfGroup_System_Int32_System_Object_System_Object_"></a>

### Summary

Appends an if construct\.

```csharp
public void AppendIfGroup(int groupNumber, object trueContent, object falseContent)
```

### Parameters

**groupNumber**

A number of the group\.

**trueContent**

The pattern to match if the named group is matched\.

**falseContent**

The pattern to match if the named group is not matched\.

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**trueContent** is `null`\.

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**groupNumber** is less than zero\.

## AppendIfGroup\(String, Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendIfGroup_System_String_System_Object_System_Object_"></a>

### Summary

Appends an if construct\.

```csharp
public void AppendIfGroup(string groupName, object trueContent, object falseContent)
```

### Parameters

**groupName**

A name of the group\.

**trueContent**

The pattern to match if the named group is matched\.

**falseContent**

The pattern to match if the named group is not matched\.

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** or **trueContent** is `null`\.

