# Pattern\.EnumerateGroups Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EnumerateGroups(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateGroups_System_String_) | Searches the specified input string and returns an enumerable collection of groups\. |
| [EnumerateGroups(String, Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateGroups_System_String_System_Int32_) | Searches the specified input string and returns an enumerable collection of groups with a specified number\. |
| [EnumerateGroups(String, Int32, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateGroups_System_String_System_Int32_System_Text_RegularExpressions_RegexOptions_) | Searches the specified input string and returns an enumerable collection of groups with a specified number, using the specified matching options\. |
| [EnumerateGroups(String, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateGroups_System_String_System_Text_RegularExpressions_RegexOptions_) | Searches the specified input string and returns an enumerable collection of groups, using the specified matching options\. |
| [EnumerateGroups(String, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateGroups_System_String_System_String_) | Searches the specified input string and returns an enumerable collection of groups with a specified name\. |
| [EnumerateGroups(String, String, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateGroups_System_String_System_String_System_Text_RegularExpressions_RegexOptions_) | Searches the specified input string and returns an enumerable collection of groups with a specified name, using the specified matching options\. |

## EnumerateGroups\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateGroups_System_String_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of groups\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> EnumerateGroups(string input)
```

### Parameters

**input** &emsp; System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

## EnumerateGroups\(String, Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateGroups_System_String_System_Int32_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of groups with a specified number\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> EnumerateGroups(string input, int groupNumber)
```

### Parameters

**input** &emsp; System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**groupNumber** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A valid number of the group\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

## EnumerateGroups\(String, Int32, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateGroups_System_String_System_Int32_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of groups with a specified number, using the specified matching options\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> EnumerateGroups(string input, int groupNumber, System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**input** &emsp; System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**groupNumber** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A valid number of the group\.

**options** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that specify options for matching\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

## EnumerateGroups\(String, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateGroups_System_String_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of groups, using the specified matching options\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> EnumerateGroups(string input, System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**input** &emsp; System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**options** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that specify options for matching\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

## EnumerateGroups\(String, String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateGroups_System_String_System_String_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of groups with a specified name\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> EnumerateGroups(string input, string groupName)
```

### Parameters

**input** &emsp; System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**groupName** &emsp; System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** or **groupName** is `null`\.

## EnumerateGroups\(String, String, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateGroups_System_String_System_String_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of groups with a specified name, using the specified matching options\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> EnumerateGroups(string input, string groupName, System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**input** &emsp; System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**groupName** &emsp; System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group\.

**options** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that specify options for matching\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** or **groupName** is `null`\.

