# Patterns\.Not\<TPattern>\(INegateable\<TPattern>\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Returns a pattern that is a negation of the specified pattern\.

```csharp
public static TPattern Not<TPattern>(INegateable<TPattern> value) where TPattern : Pattern
```

### Type Parameters

**TPattern**

The type of the pattern\.

### Parameters

**value**

A pattern to be negated\.

### Returns

TPattern

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

