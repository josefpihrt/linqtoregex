# Pattern\.Not\<TPattern>\(INegateable\<TPattern>\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Appends a pattern that is a negation of the specified pattern\.

```csharp
public TPattern Not<TPattern>(INegateable<TPattern> value) where TPattern : Pattern
```

### Type Parameters

**TPattern**

### Parameters

**value**

A pattern to be negated\.

### Returns

TPattern

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

