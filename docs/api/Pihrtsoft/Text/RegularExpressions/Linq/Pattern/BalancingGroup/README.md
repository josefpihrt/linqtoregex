# Pattern\.BalancingGroup Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [BalancingGroup(String, String, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_BalancingGroup_System_String_System_String_System_Object_) | Appends a balancing group with specified group names and a content\. |
| [BalancingGroup(String, String, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_BalancingGroup_System_String_System_String_System_Object___) | Appends a balancing group with specified group names and a content\. |

## BalancingGroup\(String, String, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_BalancingGroup_System_String_System_String_System_Object_"></a>

### Summary

Appends a balancing group with specified group names and a content\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern BalancingGroup(string name1, string name2, object content)
```

### Parameters

**name1** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Current group name\.

**name2** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Previously defined group name\.

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**name1** or **name2** is not a valid regex group name\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**name1** or **name2** or **content** is `null`\.

## BalancingGroup\(String, String, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_BalancingGroup_System_String_System_String_System_Object___"></a>

### Summary

Appends a balancing group with specified group names and a content\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern BalancingGroup(string name1, string name2, params object[] content)
```

### Parameters

**name1** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Current group name\.

**name2** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Previously defined group name\.

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**name1** or **name2** is not a valid regex group name\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**name1** or **name2** or **content** is `null`\.

