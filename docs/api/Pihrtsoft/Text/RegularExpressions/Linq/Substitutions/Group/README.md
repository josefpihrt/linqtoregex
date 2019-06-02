# Substitutions\.Group\(Int32\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Substitutions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Returns a substitution pattern that substitutes the last substring matched by the numbered or named group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Substitution Group(int groupNumber)
```

### Parameters

**groupNumber**

A number of the group\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Substitution](../../Substitution/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**groupNumber** is less than zero\.

