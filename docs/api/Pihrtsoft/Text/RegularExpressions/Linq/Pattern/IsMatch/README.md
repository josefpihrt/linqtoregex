# Pattern\.IsMatch Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [IsMatch(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_IsMatch_System_String_) | Indicates whether the current instance finds a match in the specified input string\. |
| [IsMatch(String, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_IsMatch_System_String_System_Text_RegularExpressions_RegexOptions_) | Indicates whether the current instance finds a match in the specified input string, using the specified matching options\. |

## IsMatch\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_IsMatch_System_String_"></a>

### Summary

Indicates whether the current instance finds a match in the specified input string\.

```csharp
public bool IsMatch(string input)
```

### Parameters

**input**

The string to search for a match\.

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

## IsMatch\(String, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_IsMatch_System_String_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Indicates whether the current instance finds a match in the specified input string, using the specified matching options\.

```csharp
public bool IsMatch(string input, RegexOptions options)
```

### Parameters

**input**

The string to search for a match\.

**options**

A bitwise combination of the enumeration values that specify options for matching\.

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

