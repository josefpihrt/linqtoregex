# Pattern\.BalanceChar\(Char, Char, String\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Appends a pattern that matches one or many opening characters balanced with one or many closing characters\.
Between the characters can be zero or many characters that are neither opening nor closing character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern BalanceChar(char openingCharacter, char closingCharacter, string groupName)
```

### Parameters

**openingCharacter** &emsp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

Opening Unicode character to balance\.

**closingCharacter** &emsp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

Closing Unicode character to balance\.

**groupName** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group that contains balanced content of the opening and closing character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** is `null`\.

