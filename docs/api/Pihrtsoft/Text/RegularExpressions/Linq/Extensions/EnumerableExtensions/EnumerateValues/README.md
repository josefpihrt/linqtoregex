# EnumerableExtensions\.EnumerateValues\(IEnumerable\<Capture>\) Method

[Home](../../../../../../../README.md)

**Containing Type**: [EnumerableExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Returns enumerable collection of captures values\.

```csharp
public static System.Collections.Generic.IEnumerable<string> EnumerateValues(this System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture> captures)
```

### Parameters

**captures** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

The sequence to enumerate\.

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**captures** is `null`\.

