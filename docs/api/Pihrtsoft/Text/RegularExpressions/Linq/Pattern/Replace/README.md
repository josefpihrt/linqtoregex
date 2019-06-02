# Pattern\.Replace Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Replace(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Replace_System_String_) | Within a specified input string, replaces strings that match the current instance with an empty string\. |
| [Replace(String, MatchEvaluator)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Replace_System_String_System_Text_RegularExpressions_MatchEvaluator_) | Within a specified input string, replaces all strings that match the current instance with a string returned by a [MatchEvaluator](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.matchevaluator) delegate\. |
| [Replace(String, MatchEvaluator, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Replace_System_String_System_Text_RegularExpressions_MatchEvaluator_System_Text_RegularExpressions_RegexOptions_) | Within a specified input string, replaces all strings that match the current instance with a string returned by a [MatchEvaluator](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.matchevaluator) delegate\. Specified options modify the matching operation\. |
| [Replace(String, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Replace_System_String_System_String_) | Within a specified input string, replaces all strings that match the current instance with a specified replacement string\. |
| [Replace(String, String, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Replace_System_String_System_String_System_Text_RegularExpressions_RegexOptions_) | Within a specified input string, replaces all strings that match the current instance with a specified replacement string\. Specified options modify the matching operation\. |

## Replace\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Replace_System_String_"></a>

### Summary

Within a specified input string, replaces strings that match the current instance with an empty string\.

```csharp
public string Replace(string input)
```

### Parameters

**input**

The string to search for a match\.

### Returns

System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

## Replace\(String, MatchEvaluator\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Replace_System_String_System_Text_RegularExpressions_MatchEvaluator_"></a>

### Summary

Within a specified input string, replaces all strings that match the current instance with a string returned by a [MatchEvaluator](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.matchevaluator) delegate\.

```csharp
public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator)
```

### Parameters

**input**

The string to search for a match\.

**evaluator**

A method that examines each match and returns a replacement string\.

### Returns

System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** or **evaluator** is `null`\.

## Replace\(String, MatchEvaluator, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Replace_System_String_System_Text_RegularExpressions_MatchEvaluator_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Within a specified input string, replaces all strings that match the current instance with a string returned by a [MatchEvaluator](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.matchevaluator) delegate\. Specified options modify the matching operation\.

```csharp
public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**input**

The string to search for a match\.

**evaluator**

A method that examines each match and returns a replacement string\.

**options**

A bitwise combination of the enumeration values that specify options for matching\.

### Returns

System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** or **evaluator** is `null`\.

## Replace\(String, String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Replace_System_String_System_String_"></a>

### Summary

Within a specified input string, replaces all strings that match the current instance with a specified replacement string\.

```csharp
public string Replace(string input, string replacement)
```

### Parameters

**input**

The string to search for a match\.

**replacement**

The replacement string\.

### Returns

System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

## Replace\(String, String, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Replace_System_String_System_String_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Within a specified input string, replaces all strings that match the current instance with a specified replacement string\. Specified options modify the matching operation\.

```csharp
public string Replace(string input, string replacement, System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**input**

The string to search for a match\.

**replacement**

The replacement string\.

**options**

A bitwise combination of the enumeration values that specify options for matching\.

### Returns

System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

