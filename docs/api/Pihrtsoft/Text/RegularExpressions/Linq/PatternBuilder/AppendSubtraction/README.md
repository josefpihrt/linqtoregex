# PatternBuilder\.AppendSubtraction\(IBaseGroup, IExcludedGroup\) Method

[Home](../../../../../../README.md)

**Containing Type**: [PatternBuilder](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Appends a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public void AppendSubtraction(Pihrtsoft.Text.RegularExpressions.Linq.IBaseGroup baseGroup, Pihrtsoft.Text.RegularExpressions.Linq.IExcludedGroup excludedGroup)
```

### Parameters

**baseGroup** &ensp; [IBaseGroup](../../IBaseGroup/README.md)

A base group\.

**excludedGroup** &ensp; [IExcludedGroup](../../IExcludedGroup/README.md)

An excluded group\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

