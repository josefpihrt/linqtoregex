# QuantifiablePattern\.MaybeCount\(Int32\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Specifies that previous element must be matched at most specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedPattern MaybeCount(int maxCount)
```

### Parameters

**maxCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A maximum number of times the pattern can be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedPattern](../../QuantifiedPattern/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**maxCount** is less than zero\.

