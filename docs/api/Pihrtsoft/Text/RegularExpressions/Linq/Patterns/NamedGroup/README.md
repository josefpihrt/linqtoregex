# Patterns\.NamedGroup Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NamedGroup(String, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NamedGroup_System_String_System_Object_) | Returns a named group with a specified name and content\. |
| [NamedGroup(String, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NamedGroup_System_String_System_Object___) | Returns a named group with a specified name and content\. |

## NamedGroup\(String, Object\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NamedGroup_System_String_System_Object_"></a>

\
Returns a named group with a specified name and content\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NamedGroup(string name, object content)
```

### Parameters

**name** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group\.

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**name** is not a valid regex group name\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**name** **content** is `null`\.

## NamedGroup\(String, Object\[\]\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NamedGroup_System_String_System_Object___"></a>

\
Returns a named group with a specified name and content\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NamedGroup(string name, params object[] content)
```

### Parameters

**name** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group\.

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**name** is not a valid regex group name\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**name** **content** is `null`\.

