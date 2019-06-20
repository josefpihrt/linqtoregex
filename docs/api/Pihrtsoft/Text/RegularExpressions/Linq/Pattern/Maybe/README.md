# Pattern\.Maybe Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Maybe(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Maybe_System_Object_) | Appends a pattern that matches specified content zero or one time\. |
| [Maybe(Object, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Maybe_System_Object_System_Object___) | Appends a pattern that matches any one specified element zero or one time\. |

## Maybe\(Object\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Maybe_System_Object_"></a>

\
Appends a pattern that matches specified content zero or one time\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Maybe(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## Maybe\(Object, Object\[\]\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Maybe_System_Object_System_Object___"></a>

\
Appends a pattern that matches any one specified element zero or one time\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Maybe(object first, params object[] others)
```

### Parameters

**first** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

First element of a sequence that contains patterns any one of which has to be matched\.

**others** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

Other elements of a sequence that contains patterns any one of which has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**first** is `null`\.

