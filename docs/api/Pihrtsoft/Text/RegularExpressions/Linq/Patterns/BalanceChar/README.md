# Patterns\.BalanceChar\(Char, Char, String\) Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Returns a pattern that matches one or many opening characters balanced with one or many closing characters\.
Between the characters can be zero or many characters that are neither opening nor closing character\.

```csharp
public static Pattern BalanceChar(char openingCharacter, char closingCharacter, string groupName)
```

### Parameters

**openingCharacter**

Opening Unicode character to balance\.

**closingCharacter**

Closing Unicode character to balance\.

**groupName**

A name of the group that contains balanced content of the opening and closing character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../../Pattern/README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** is `null`\.

