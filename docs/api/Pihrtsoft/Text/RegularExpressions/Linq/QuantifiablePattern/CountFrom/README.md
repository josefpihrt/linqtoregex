# QuantifiablePattern\.CountFrom\(Int32\) Method

[Home](../../../../../../README.md)

**Containing Type**: [QuantifiablePattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Specifies that previous element must be matched at least specified number of times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedPattern CountFrom(int minCount)
```

### Parameters

**minCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A minimal number of times the pattern must be matched\.

### Returns

[QuantifiedPattern](../../QuantifiedPattern/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**minCount** is less than zero\.

