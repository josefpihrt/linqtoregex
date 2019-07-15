# CharGroup\.LogicalNot\(CharGroup\) Operator

[Home](../../../../../../README.md)

**Containing Type**: [CharGroup](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
If the current instance is a positive character group, it returns a negative character group\. Otherwise, it returns a positive character group\. Newly created group has the same content as the current instance\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup operator !(Pihrtsoft.Text.RegularExpressions.Linq.CharGroup value)
```

### Parameters

**value** &ensp; [CharGroup](../README.md)

A value to negate\.

### Returns

[CharGroup](../README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

