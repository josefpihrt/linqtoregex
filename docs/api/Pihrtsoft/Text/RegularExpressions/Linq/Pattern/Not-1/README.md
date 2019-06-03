# Pattern\.Not\<TPattern>\(INegateable\<TPattern>\) Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Appends a pattern that is a negation of the specified pattern\.

```csharp
public TPattern Not<TPattern>(Pihrtsoft.Text.RegularExpressions.Linq.INegateable<TPattern> value) where TPattern : Pihrtsoft.Text.RegularExpressions.Linq.Pattern
```

### Type Parameters

**TPattern**

### Parameters

**value** &ensp; [INegateable](../../INegateable-1/README.md)\<TPattern>

A pattern to be negated\.

### Returns

TPattern

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

