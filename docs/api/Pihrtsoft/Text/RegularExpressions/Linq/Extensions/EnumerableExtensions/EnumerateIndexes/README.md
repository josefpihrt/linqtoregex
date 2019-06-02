# EnumerableExtensions\.EnumerateIndexes\(IEnumerable\<Capture>\) Method

[Home](../../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.Extensions\.[EnumerableExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Returns an enumerable collection of captures indexes\.

```csharp
public static System.Collections.Generic.IEnumerable<int> EnumerateIndexes(this System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture> captures)
```

### Parameters

**captures** &emsp; System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<System\.Text\.RegularExpressions\.[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

The sequence to enumerate\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**captures** is `null`\.

