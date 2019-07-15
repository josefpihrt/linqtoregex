# Patterns\.NoncapturingGroup Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NoncapturingGroup(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NoncapturingGroup_System_Object_) | Returns a noncapturing group with a specified content\. |
| [NoncapturingGroup(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NoncapturingGroup_System_Object___) | Returns a noncapturing group with a specified content\. |

## NoncapturingGroup\(Object\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NoncapturingGroup_System_Object_"></a>

\
Returns a noncapturing group with a specified content\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NoncapturingGroup(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## NoncapturingGroup\(Object\[\]\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NoncapturingGroup_System_Object___"></a>

\
Returns a noncapturing group with a specified content\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NoncapturingGroup(params object[] content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

