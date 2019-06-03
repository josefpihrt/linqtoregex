# Patterns\.MaybeCount Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [MaybeCount(Int32, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_MaybeCount_System_Int32_System_Object_) | Returns a pattern that matches specified pattern at most specified number of times\. |
| [MaybeCount(Int32, Object, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_MaybeCount_System_Int32_System_Object_System_Object___) | Returns a pattern that matches any one specified pattern at most specified number of times\. |

## MaybeCount\(Int32, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_MaybeCount_System_Int32_System_Object_"></a>

### Summary

Returns a pattern that matches specified pattern at most specified number of times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup MaybeCount(int maxCount, object content)
```

### Parameters

**maxCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A maximum number of times the pattern can be matched\.

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**maxCount** is less than zero\.

## MaybeCount\(Int32, Object, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_MaybeCount_System_Int32_System_Object_System_Object___"></a>

### Summary

Returns a pattern that matches any one specified pattern at most specified number of times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup MaybeCount(int maxCount, object first, params object[] others)
```

### Parameters

**maxCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A maximum number of times the pattern can be matched\.

**first** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

First element of a sequence that contains patterns any one of which has to be matched\.

**others** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

Other elements of a sequence that contains patterns any one of which has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**first** is `null`\.

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**maxCount** is less than zero\.

