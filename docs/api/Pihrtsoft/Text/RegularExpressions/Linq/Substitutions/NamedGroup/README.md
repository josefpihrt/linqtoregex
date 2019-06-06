# Substitutions\.NamedGroup\(String\) Method

[Home](../../../../../../README.md)

**Containing Type**: [Substitutions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Returns a substitution pattern that substitutes the last substring matched by the named group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Substitution NamedGroup(string groupName)
```

### Parameters

**groupName** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Valid regex group name\.

### Returns

[Substitution](../../Substitution/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** is `null`\.

