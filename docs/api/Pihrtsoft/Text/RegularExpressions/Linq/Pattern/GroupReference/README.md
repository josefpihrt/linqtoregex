# Pattern\.GroupReference Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [GroupReference(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_GroupReference_System_Int32_) | Appends a pattern that matches previously defined numbered group\. |
| [GroupReference(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_GroupReference_System_String_) | Appends a pattern that matches previously defined named group\. |

## GroupReference\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_GroupReference_System_Int32_"></a>

\
Appends a pattern that matches previously defined numbered group\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern GroupReference(int groupNumber)
```

### Parameters

**groupNumber** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of the group\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**groupNumber** is less than zero\.

## GroupReference\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_GroupReference_System_String_"></a>

\
Appends a pattern that matches previously defined named group\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern GroupReference(string groupName)
```

### Parameters

**groupName** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** is `null`\.

