# Patterns\.Except\(IBaseGroup, IExcludedGroup\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharSubtraction Except(Pihrtsoft.Text.RegularExpressions.Linq.IBaseGroup baseGroup, Pihrtsoft.Text.RegularExpressions.Linq.IExcludedGroup excludedGroup)
```

### Parameters

**baseGroup**

A base group\.

**excludedGroup**

An excluded group\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

