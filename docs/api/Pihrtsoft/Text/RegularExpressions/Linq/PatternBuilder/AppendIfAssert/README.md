# PatternBuilder\.AppendIfAssert\(Object, Object, Object\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[PatternBuilder](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Appends an if construct\.

```csharp
public void AppendIfAssert(object testContent, object trueContent, object falseContent)
```

### Parameters

**testContent** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The pattern to assert\.

**trueContent** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The pattern to match if the assertion succeeds\.

**falseContent** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The pattern to match if the assertion fails\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**testContent** or **trueContent** is `null`\.

