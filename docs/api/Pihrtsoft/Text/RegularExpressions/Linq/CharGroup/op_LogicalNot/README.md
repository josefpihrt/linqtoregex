# CharGroup\.LogicalNot\(CharGroup\) Operator

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

If the current instance is a positive character group, it returns a negative character group\. Otherwise, it returns a positive character group\. Newly created group has the same content as the current instance\.

```csharp
public static CharGroup operator !(CharGroup value)
```

### Parameters

**value**

A value to negate\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

