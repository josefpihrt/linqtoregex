# Pattern\.EnumerateMatches Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EnumerateMatches(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateMatches_System_String_) | Searches the specified input string and returns an enumerable collection of matches\. |
| [EnumerateMatches(String, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateMatches_System_String_System_Text_RegularExpressions_RegexOptions_) | Searches the specified input string and returns an enumerable collection of matches, using the specified matching options\. |

## EnumerateMatches\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateMatches_System_String_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of matches\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match> EnumerateMatches(string input)
```

### Parameters

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Match](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

## EnumerateMatches\(String, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EnumerateMatches_System_String_System_Text_RegularExpressions_RegexOptions_"></a>

### Summary

Searches the specified input string and returns an enumerable collection of matches, using the specified matching options\.

```csharp
public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match> EnumerateMatches(string input, System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**options** &emsp; System\.Text\.RegularExpressions\.[RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that specify options for matching\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Match](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

