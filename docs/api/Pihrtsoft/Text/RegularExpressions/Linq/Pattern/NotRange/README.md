# Pattern\.NotRange\(Char, Char\) Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Appends a pattern that matches a character that is not in the specified range\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NotRange(char first, char last)
```

### Parameters

**first** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The first character of the range\.

**last** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The last character of the range\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**last** character number is less than **first** character number\.

