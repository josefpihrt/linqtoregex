# Pattern\.BalanceCurlyBrackets\(String\) Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Appends a pattern that matches one or many left curly bracket balanced with one or many right curly bracket\.
Between the characters can be zero or many characters that are neither left nor right curly bracket\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern BalanceCurlyBrackets(string groupName)
```

### Parameters

**groupName** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group that contains balanced content between left and right curly bracket\.

### Returns

[Pattern](../README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** is `null`\.

