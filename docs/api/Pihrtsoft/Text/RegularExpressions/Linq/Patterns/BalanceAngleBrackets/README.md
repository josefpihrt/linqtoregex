# Patterns\.BalanceAngleBrackets\(String\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Returns a pattern that matches one or many left angle bracket balanced with one or many right angle bracket\.
Between the characters can be zero or many characters that are neither left nor right angle bracket\.

```csharp
public static Pattern BalanceAngleBrackets(string groupName)
```

### Parameters

**groupName**

A name of the group that contains balanced content between left and right angle bracket\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../../Pattern/README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** is `null`\.

