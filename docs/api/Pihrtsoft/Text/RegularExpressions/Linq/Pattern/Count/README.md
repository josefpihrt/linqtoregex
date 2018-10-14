# Pattern\.Count Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Count(Int32, Int32, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Count_System_Int32_System_Int32_System_Object_) | Appends a pattern that matches specified pattern from minimal to maximum number of times\. |
| [Count(Int32, Int32, Object, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Count_System_Int32_System_Int32_System_Object_System_Object___) | Appends a pattern that matches any one specified pattern from minimal to maximum number of times\. |
| [Count(Int32, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Count_System_Int32_System_Object_) | Appends a pattern that matches specified pattern specified number of times\. |
| [Count(Int32, Object, Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Count_System_Int32_System_Object_System_Object___) | Appends a pattern that matches any one specified pattern specified number of times\. |

## Count\(Int32, Int32, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Count_System_Int32_System_Int32_System_Object_"></a>

### Summary

Appends a pattern that matches specified pattern from minimal to maximum number of times\.

```csharp
public QuantifiedGroup Count(int minCount, int maxCount, object content)
```

### Parameters

**minCount**

A minimal number of times the pattern must be matched\.

**maxCount**

A maximum number of times the pattern can be matched\.

**content**

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**minCount** is less than zero or **maxCount** is less than **minCount**\.

## Count\(Int32, Int32, Object, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Count_System_Int32_System_Int32_System_Object_System_Object___"></a>

### Summary

Appends a pattern that matches any one specified pattern from minimal to maximum number of times\.

```csharp
public QuantifiedGroup Count(int minCount, int maxCount, object first, params object[] others)
```

### Parameters

**minCount**

A minimal number of times the pattern must be matched\.

**maxCount**

A maximum number of times the pattern can be matched\.

**first**

First element of a sequence that contains patterns any one of which has to be matched\.

**others**

Other elements of a sequence that contains patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**first** is `null`\.

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**minCount** is less than zero or **maxCount** is less than **minCount**\.

## Count\(Int32, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Count_System_Int32_System_Object_"></a>

### Summary

Appends a pattern that matches specified pattern specified number of times\.

```csharp
public QuantifiedGroup Count(int exactCount, object content)
```

### Parameters

**exactCount**

A number of times the pattern has to be matched\.

**content**

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

## Count\(Int32, Object, Object\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Count_System_Int32_System_Object_System_Object___"></a>

### Summary

Appends a pattern that matches any one specified pattern specified number of times\.

```csharp
public QuantifiedGroup Count(int exactCount, object first, params object[] others)
```

### Parameters

**exactCount**

A number of times the pattern has to be matched\.

**first**

First element of a sequence that contains patterns any one of which has to be matched\.

**others**

Other elements of a sequence that contains patterns any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**first** is `null`\.

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

