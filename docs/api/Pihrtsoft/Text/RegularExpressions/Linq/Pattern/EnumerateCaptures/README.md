# Pattern\.EnumerateCaptures Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EnumerateCaptures(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateCaptures_System_String_) | Searches the specified input string and returns an enumerable collection of captures\. |
| [EnumerateCaptures(String, Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateCaptures_System_String_System_Int32_) | Searches the specified input string and returns an enumerable collection of captures from groups that have a specified number\. |
| [EnumerateCaptures(String, Int32, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateCaptures_System_String_System_Int32_System_Text_RegularExpressions_RegexOptions_) | Searches the specified input string and returns an enumerable collection of captures from groups that have a specified number, using the specified matching options\. |
| [EnumerateCaptures(String, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateCaptures_System_String_System_Text_RegularExpressions_RegexOptions_) | Searches the specified input string and returns an enumerable collection of captures, using the specified matching options\. |
| [EnumerateCaptures(String, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateCaptures_System_String_System_String_) | Searches the specified input string and returns an enumerable collection of captures from groups that have a specified name\. |
| [EnumerateCaptures(String, String, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateCaptures_System_String_System_String_System_Text_RegularExpressions_RegexOptions_) | Searches the specified input string and returns an enumerable collection of captures from groups that have a specified name, using the specified matching options\. |

## EnumerateCaptures\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateCaptures_System_String_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of captures\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture> EnumerateCaptures(string input)
```

### Parameters

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

## EnumerateCaptures\(String, Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateCaptures_System_String_System_Int32_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of captures from groups that have a specified number\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture> EnumerateCaptures(string input, int groupNumber)
```

### Parameters

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**groupNumber** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A valid number of the group\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

## EnumerateCaptures\(String, Int32, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateCaptures_System_String_System_Int32_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of captures from groups that have a specified number, using the specified matching options\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture> EnumerateCaptures(string input, int groupNumber, System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**groupNumber** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A valid number of the group\.

**options** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that specify options for matching\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

## EnumerateCaptures\(String, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateCaptures_System_String_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of captures, using the specified matching options\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture> EnumerateCaptures(string input, System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**options** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that specify options for matching\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

## EnumerateCaptures\(String, String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateCaptures_System_String_System_String_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of captures from groups that have a specified name\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture> EnumerateCaptures(string input, string groupName)
```

### Parameters

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**groupName** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** or **groupName** is `null`\.

## EnumerateCaptures\(String, String, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateCaptures_System_String_System_String_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of captures from groups that have a specified name, using the specified matching options\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture> EnumerateCaptures(string input, string groupName, System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**groupName** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group\.

**options** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that specify options for matching\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** or **groupName** is `null`\.

