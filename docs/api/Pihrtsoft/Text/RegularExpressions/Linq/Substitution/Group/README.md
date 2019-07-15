# Substitution\.Group\(Int32\) Method

[Home](../../../../../../README.md)

**Containing Type**: [Substitution](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Appends a substitution pattern that substitutes the last substring matched by the numbered or named group\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Substitution Group(int groupNumber)
```

### Parameters

**groupNumber** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of the group\.

### Returns

[Substitution](../README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**groupNumber** is less than zero\.

