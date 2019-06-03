# PatternBuilder\.AppendIfAssert\(Object, Object, Object\) Method

[Home](../../../../../../README.md)

**Containing Type**: [PatternBuilder](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Appends an if construct\.

```csharp
public void AppendIfAssert(object testContent, object trueContent, object falseContent)
```

### Parameters

**testContent** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The pattern to assert\.

**trueContent** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The pattern to match if the assertion succeeds\.

**falseContent** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The pattern to match if the assertion fails\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**testContent** or **trueContent** is `null`\.

