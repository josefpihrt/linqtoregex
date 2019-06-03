# BaseGroupExtensions\.Except\(IBaseGroup, IExcludedGroup\) Method

[Home](../../../../../../README.md)

**Containing Type**: [BaseGroupExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharSubtraction Except(this Pihrtsoft.Text.RegularExpressions.Linq.IBaseGroup baseGroup, Pihrtsoft.Text.RegularExpressions.Linq.IExcludedGroup excludedGroup)
```

### Parameters

**baseGroup** &ensp; [IBaseGroup](../../IBaseGroup/README.md)

A base group\.

**excludedGroup** &ensp; [IExcludedGroup](../../IExcludedGroup/README.md)

An excluded group\.

### Returns

[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

