# Patterns\.CountFrom Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [CountFrom(Int32, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_CountFrom_System_Int32_System_Object_) | Returns a pattern that matches specified pattern at least specified number of times\. |
| [CountFrom(Int32, Object, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_CountFrom_System_Int32_System_Object_System_Object___) | Returns a pattern that matches any one specified pattern at least specified number of times\. |

## CountFrom\(Int32, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_CountFrom_System_Int32_System_Object_"></a>

### Summary

Returns a pattern that matches specified pattern at least specified number of times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup CountFrom(int minCount, object content)
```

### Parameters

**minCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A minimal number of times the pattern must be matched\.

**content** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**minCount** is less than zero\.

## CountFrom\(Int32, Object, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_CountFrom_System_Int32_System_Object_System_Object___"></a>

### Summary

Returns a pattern that matches any one specified pattern at least specified number of times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup CountFrom(int minCount, object first, params object[] others)
```

### Parameters

**minCount** &emsp; System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A minimal number of times the pattern must be matched\.

**first** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

First element of a sequence that contains patterns any one of which has to be matched\.

**others** &emsp; System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

Other elements of a sequence that contains patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**first** is `null`\.

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**minCount** is less than zero\.

