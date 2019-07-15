# Pattern\.NoncapturingGroup Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NoncapturingGroup(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NoncapturingGroup_System_Object_) | Appends a noncapturing group with a specified content\. |
| [NoncapturingGroup(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NoncapturingGroup_System_Object___) | Appends a noncapturing group with a specified content\. |

## NoncapturingGroup\(Object\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NoncapturingGroup_System_Object_"></a>

\
Appends a noncapturing group with a specified content\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NoncapturingGroup(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## NoncapturingGroup\(Object\[\]\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_NoncapturingGroup_System_Object___"></a>

\
Appends a noncapturing group with a specified content\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern NoncapturingGroup(params object[] content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

