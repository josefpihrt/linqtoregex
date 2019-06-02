# Pattern\.Range\(Char, Char\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Appends a pattern that matches a character in the specified range\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Range(char first, char last)
```

### Parameters

**first** &emsp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The first character of the range\.

**last** &emsp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The last character of the range\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**last** character number is less than **first** character number\.

