# PatternBuilder\.AppendNamedGroup\(String, Object\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[PatternBuilder](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Appends a named group with a specified name and content\.

```csharp
public void AppendNamedGroup(string name, object content)
```

### Parameters

**name**

A name of the group\.

**content**

The content to be matched\.

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**name** is not a valid regex group name\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**name** or **content** is `null`\.

