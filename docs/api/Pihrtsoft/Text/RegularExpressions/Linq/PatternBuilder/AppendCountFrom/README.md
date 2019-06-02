# PatternBuilder\.AppendCountFrom Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[PatternBuilder](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AppendCountFrom(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCountFrom_System_Int32_) | Appends a quantifier that matches previous element at least specified number of times\. |
| [AppendCountFrom(Int32, Boolean)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCountFrom_System_Int32_System_Boolean_) | Appends a quantifier that matches previous element at least specified number of times\. |

## AppendCountFrom\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCountFrom_System_Int32_"></a>

### Summary

Appends a quantifier that matches previous element at least specified number of times\.

```csharp
public void AppendCountFrom(int minCount)
```

### Parameters

**minCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A minimal number of times the pattern must be matched\.

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**minCount** is less than zero\.

## AppendCountFrom\(Int32, Boolean\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCountFrom_System_Int32_System_Boolean_"></a>

### Summary

Appends a quantifier that matches previous element at least specified number of times\.

```csharp
public void AppendCountFrom(int minCount, bool lazy)
```

### Parameters

**minCount** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A minimal number of times the pattern must be matched\.

**lazy** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

Indicates whether the quantifier will be greedy or lazy\.

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**minCount** is less than zero\.

