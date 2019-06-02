# PatternBuilder\.AppendCount Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[PatternBuilder](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AppendCount(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCount_System_Int32_) | Appends a quantifier that matches previous element specific number of times\. |
| [AppendCount(Int32, Boolean)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCount_System_Int32_System_Boolean_) | Appends a quantifier that matches previous element specific number of times\. |
| [AppendCount(Int32, Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCount_System_Int32_System_Int32_) | Appends a quantifier that matches previous element from minimal to maximum times\. |
| [AppendCount(Int32, Int32, Boolean)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCount_System_Int32_System_Int32_System_Boolean_) | Appends a quantifier that matches previous element from minimal to maximum times\. |

## AppendCount\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCount_System_Int32_"></a>

### Summary

Appends a quantifier that matches previous element specific number of times\.

```csharp
public void AppendCount(int exactCount)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times the pattern must be matched\.

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

## AppendCount\(Int32, Boolean\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCount_System_Int32_System_Boolean_"></a>

### Summary

Appends a quantifier that matches previous element specific number of times\.

```csharp
public void AppendCount(int exactCount, bool lazy)
```

### Parameters

**exactCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of times the pattern must be matched\.

**lazy** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

Indicates whether the quantifier will be greedy or lazy\.

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

## AppendCount\(Int32, Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCount_System_Int32_System_Int32_"></a>

### Summary

Appends a quantifier that matches previous element from minimal to maximum times\.

```csharp
public void AppendCount(int minCount, int maxCount)
```

### Parameters

**minCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A minimal number of times the pattern must be matched\.

**maxCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A maximum number of times the pattern can be matched\.

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**minCount** is less than zero or **maxCount** is less than **minCount**\.

## AppendCount\(Int32, Int32, Boolean\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCount_System_Int32_System_Int32_System_Boolean_"></a>

### Summary

Appends a quantifier that matches previous element from minimal to maximum times\.

```csharp
public void AppendCount(int minCount, int maxCount, bool lazy)
```

### Parameters

**minCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A minimal number of times the pattern must be matched\.

**maxCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A maximum number of times the pattern can be matched\.

**lazy** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

Indicates whether the quantifier will be greedy or lazy\.

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**minCount** is less than zero or **maxCount** is less than **minCount**\.

