# Patterns\.Range\(Char, Char\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Returns a pattern that matches a character in the specified range\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup Range(char first, char last)
```

### Parameters

**first**

The first character of the range\.

**last**

The last character of the range\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**last** character number is less than **first** character number\.

