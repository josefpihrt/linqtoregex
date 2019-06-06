# Pattern\.Match Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Match(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Match_System_String_) | Searches a specified input string for the first occurrence of the current instance\. |
| [Match(String, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Match_System_String_System_Text_RegularExpressions_RegexOptions_) | Searches a specified input string for the first occurrence of the current instance, using the specified matching options\. |

## Match\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Match_System_String_"></a>

\
Searches a specified input string for the first occurrence of the current instance\.

```csharp
public System.Text.RegularExpressions.Match Match(string input)
```

### Parameters

**input** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

### Returns

[Match](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

## Match\(String, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Match_System_String_System_Text_RegularExpressions_RegexOptions_"></a>

\
Searches a specified input string for the first occurrence of the current instance, using the specified matching options\.

```csharp
public System.Text.RegularExpressions.Match Match(string input, System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**input** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**options** &ensp; [RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that specify options for matching\.

### Returns

[Match](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**input** is `null`\.

