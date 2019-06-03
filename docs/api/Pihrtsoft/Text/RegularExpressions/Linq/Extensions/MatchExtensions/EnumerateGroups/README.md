# MatchExtensions\.EnumerateGroups\(Match\) Method

[Home](../../../../../../../README.md)

**Containing Type**: [MatchExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Returns enumerable collection of group of a specified match\.

```csharp
public static System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> EnumerateGroups(this System.Text.RegularExpressions.Match match)
```

### Parameters

**match** &ensp; [Match](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match)

A regular expression match\.

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**match** is `null`\.

