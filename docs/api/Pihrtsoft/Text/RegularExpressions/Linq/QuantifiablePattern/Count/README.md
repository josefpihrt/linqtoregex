# QuantifiablePattern\.Count Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Count(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern_Count_System_Int32_) | Specifies that previous element must be matched a specified number of times\. |
| [Count(Int32, Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern_Count_System_Int32_System_Int32_) | Specifies that previous element must be matched from minimal to maximum times\. |

## Count\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern_Count_System_Int32_"></a>

### Summary

Specifies that previous element must be matched a specified number of times\.

```csharp
public QuantifiedPattern Count(int exactCount)
```

### Parameters

**exactCount**

A number of times the pattern must be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedPattern](../../QuantifiedPattern/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**exactCount** is less than zero\.

## Count\(Int32, Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern_Count_System_Int32_System_Int32_"></a>

### Summary

Specifies that previous element must be matched from minimal to maximum times\.

```csharp
public QuantifiedPattern Count(int minCount, int maxCount)
```

### Parameters

**minCount**

A minimal number of times the pattern must be matched\.

**maxCount**

A maximum number of times the pattern can be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedPattern](../../QuantifiedPattern/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**minCount** is less than zero or **maxCount** is less than **minCount**\.

