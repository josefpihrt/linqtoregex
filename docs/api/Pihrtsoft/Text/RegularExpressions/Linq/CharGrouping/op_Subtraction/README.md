# CharGrouping\.Subtraction Operator

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGrouping](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Operator | Summary |
| -------- | ------- |
| [Subtraction(CharGrouping, CharGroup)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |
| [Subtraction(CharGrouping, CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |
| [Subtraction(CharGrouping, CharPattern)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |

## Subtraction\(CharGrouping, CharGroup\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_"></a>

### Summary

Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static CharSubtraction operator -(CharGrouping baseGroup, CharGroup excludedGroup)
```

### Parameters

**baseGroup**

A base group\.

**excludedGroup**

An excluded group\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

## Subtraction\(CharGrouping, CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

### Summary

Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static CharSubtraction operator -(CharGrouping baseGroup, CharGrouping excludedGroup)
```

### Parameters

**baseGroup**

A base group\.

**excludedGroup**

An excluded group\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

## Subtraction\(CharGrouping, CharPattern\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_"></a>

### Summary

Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static CharSubtraction operator -(CharGrouping baseGroup, CharPattern excludedGroup)
```

### Parameters

**baseGroup**

A base group\.

**excludedGroup**

An excluded group\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

