# RegexExtensions\.ReplaceMatchChar\(Regex, String, Char\) Method

[Home](../../../../../../../README.md)

**Containing Type**: [RegexExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Within a specified input string, replaces all strings that match the regular expression with a string where each character is replaced with the specified character\.

```csharp
public static string ReplaceMatchChar(this System.Text.RegularExpressions.Regex regex, string input, char replacementChar)
```

### Parameters

**regex** &ensp; [Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex)

The regular expression to be matched\.

**input** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

**replacementChar** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The replacement char\.

### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**regex** or **input** is `null`\.

