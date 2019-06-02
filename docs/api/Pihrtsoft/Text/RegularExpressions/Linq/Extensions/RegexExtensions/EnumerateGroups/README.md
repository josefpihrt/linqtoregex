# RegexExtensions\.EnumerateGroups Method

[Home](../../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.Extensions\.[RegexExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EnumerateGroups(Regex, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateGroups_System_Text_RegularExpressions_Regex_System_String_) | Searches the specified input string and returns enumerable collection of groups\. |
| [EnumerateGroups(Regex, String, Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateGroups_System_Text_RegularExpressions_Regex_System_String_System_Int32_) | Searches the specified input string and returns enumerable collection of groups that have a specified number\. |
| [EnumerateGroups(Regex, String, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateGroups_System_Text_RegularExpressions_Regex_System_String_System_String_) | Searches the specified input string and returns enumerable collection of groups with a specified name\. |

## EnumerateGroups\(Regex, String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateGroups_System_Text_RegularExpressions_Regex_System_String_"></a>

### Summary

Searches the specified input string and returns enumerable collection of groups\.

```csharp
public static System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> EnumerateGroups(this System.Text.RegularExpressions.Regex regex, string input)
```

### Parameters

**regex**

The regular expression to be matched\.

**input**

The string to search for a match\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**regex** or **input** is `null`\.

## EnumerateGroups\(Regex, String, Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateGroups_System_Text_RegularExpressions_Regex_System_String_System_Int32_"></a>

### Summary

Searches the specified input string and returns enumerable collection of groups that have a specified number\.

```csharp
public static System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> EnumerateGroups(this System.Text.RegularExpressions.Regex regex, string input, int groupNumber)
```

### Parameters

**regex**

The regular expression to be matched\.

**input**

The string to search for a match\.

**groupNumber**

A number of the group\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**regex** or **input** is `null`\.

## EnumerateGroups\(Regex, String, String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateGroups_System_Text_RegularExpressions_Regex_System_String_System_String_"></a>

### Summary

Searches the specified input string and returns enumerable collection of groups with a specified name\.

```csharp
public static System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> EnumerateGroups(this System.Text.RegularExpressions.Regex regex, string input, string groupName)
```

### Parameters

**regex**

The regular expression to be matched\.

**input**

The string to search for a match\.

**groupName**

A name of the group\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**regex** or **input** or **groupName** is `null`\.

