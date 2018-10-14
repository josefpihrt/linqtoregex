# Patterns\.Join Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Join(Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Join_System_Object_System_Object_) | Concatenates the elements in a specified **content** using the specified separator between each element\. |
| [Join(Object, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Join_System_Object_System_Object___) | Concatenates the elements of an object array, using the specified separator between each element\. |

## Join\(Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Join_System_Object_System_Object_"></a>

### Summary

Concatenates the elements in a specified **content** using the specified separator between each element\.

```csharp
public static Pattern Join(object separator, object content)
```

### Parameters

**separator**

The pattern to use as a separator\.

**content**

An object that contains the elements to join\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../../Pattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## Join\(Object, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Join_System_Object_System_Object___"></a>

### Summary

Concatenates the elements of an object array, using the specified separator between each element\.

```csharp
public static Pattern Join(object separator, params object[] content)
```

### Parameters

**separator**

The pattern to use as a separator\.

**content**

An object array that contains the elements to join\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../../Pattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

