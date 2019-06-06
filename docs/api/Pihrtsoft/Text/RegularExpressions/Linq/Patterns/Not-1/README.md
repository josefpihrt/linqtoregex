# Patterns\.Not\<TPattern>\(INegateable\<TPattern>\) Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Returns a pattern that is a negation of the specified pattern\.

```csharp
public static TPattern Not<TPattern>(Pihrtsoft.Text.RegularExpressions.Linq.INegateable<TPattern> value) where TPattern : Pihrtsoft.Text.RegularExpressions.Linq.Pattern
```

### Type Parameters

**TPattern**

The type of the pattern\.

### Parameters

**value** &ensp; [INegateable](../../INegateable-1/README.md)\<TPattern>

A pattern to be negated\.

### Returns

TPattern

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

