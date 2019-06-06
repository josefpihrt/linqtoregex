# Patterns\.IfAssert Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [IfAssert(Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_IfAssert_System_Object_System_Object_) | Returns an if construct with the specified content to assert and a content to match if the assertion succeeds\. |
| [IfAssert(Object, Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_IfAssert_System_Object_System_Object_System_Object_) | Returns an if construct with the specified content to assert and a content to match if the assertion succeeds and a content to match if the assertion fails\. |

## IfAssert\(Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_IfAssert_System_Object_System_Object_"></a>

\
Returns an if construct with the specified content to assert and a content to match if the assertion succeeds\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern IfAssert(object testContent, object trueContent)
```

### Parameters

**testContent** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to assert\.

**trueContent** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched if the assertion succeeds\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**testContent** or **trueContent** is `null`\.

## IfAssert\(Object, Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_IfAssert_System_Object_System_Object_System_Object_"></a>

\
Returns an if construct with the specified content to assert and a content to match if the assertion succeeds and a content to match if the assertion fails\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern IfAssert(object testContent, object trueContent, object falseContent)
```

### Parameters

**testContent** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to assert\.

**trueContent** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched if the assertion succeeds\.

**falseContent** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched if the assertion fails\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**testContent** or **trueContent** is `null`\.

