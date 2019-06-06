# PatternBuilder\.AppendMaybeCount Method

[Home](../../../../../../README.md)

**Containing Type**: [PatternBuilder](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AppendMaybeCount(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendMaybeCount_System_Int32_) | Appends a quantifier that matches previous element at most specified number of times\. |
| [AppendMaybeCount(Int32, Boolean)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendMaybeCount_System_Int32_System_Boolean_) | Appends a quantifier that matches previous element at most specified number of times\. |

## AppendMaybeCount\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendMaybeCount_System_Int32_"></a>

\
Appends a quantifier that matches previous element at most specified number of times\.

```csharp
public void AppendMaybeCount(int maxCount)
```

### Parameters

**maxCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A maximum number of times the pattern can be matched\.

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**maxCount** is less than zero\.

## AppendMaybeCount\(Int32, Boolean\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendMaybeCount_System_Int32_System_Boolean_"></a>

\
Appends a quantifier that matches previous element at most specified number of times\.

```csharp
public void AppendMaybeCount(int maxCount, bool lazy)
```

### Parameters

**maxCount** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A maximum number of times the pattern can be matched\.

**lazy** &ensp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

Indicates whether the quantifier will be greedy or lazy\.

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**maxCount** is less than zero\.

