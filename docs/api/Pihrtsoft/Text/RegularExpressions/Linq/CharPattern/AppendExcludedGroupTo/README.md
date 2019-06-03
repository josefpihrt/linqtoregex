# CharPattern\.AppendExcludedGroupTo\(PatternBuilder\) Method

[Home](../../../../../../README.md)

**Containing Type**: [CharPattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Appends the text representation of the character group containing the current instance to the specified [PatternBuilder](../../PatternBuilder/README.md)\.

```csharp
public void AppendExcludedGroupTo(Pihrtsoft.Text.RegularExpressions.Linq.PatternBuilder builder)
```

### Parameters

**builder** &ensp; [PatternBuilder](../../PatternBuilder/README.md)

The builder to use for appending the text\.

### Implements

* [IExcludedGroup.AppendExcludedGroupTo](../../IExcludedGroup/AppendExcludedGroupTo/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**builder** is `null`\.

