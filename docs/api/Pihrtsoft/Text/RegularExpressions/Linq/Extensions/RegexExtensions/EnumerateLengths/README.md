# RegexExtensions\.EnumerateLengths\(Regex, String\) Method

[Home](../../../../../../../README.md)

**Containing Type**: [RegexExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Searches the specified input string for occurrence of the specified regular expression and returns an enumerable collection of matches lengths\.

```csharp
public static System.Collections.Generic.IEnumerable<int> EnumerateLengths(this System.Text.RegularExpressions.Regex regex, string input)
```

### Parameters

**regex** &ensp; [Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex)

The regular expression to be matched\.

**input** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to search for a match\.

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**regex** or **input** is `null`\.

