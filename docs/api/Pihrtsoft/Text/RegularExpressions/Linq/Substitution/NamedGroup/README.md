# Substitution\.NamedGroup\(String\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Substitution](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Appends a substitution pattern that substitutes the last substring matched by the named group\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Substitution NamedGroup(string groupName)
```

### Parameters

**groupName** &emsp; System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Valid regex group name\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Substitution](../README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** is `null`\.

