# CharPattern\.Subtraction Operator

[Home](../../../../../../README.md)

**Containing Type**: [CharPattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Operator | Summary |
| -------- | ------- |
| [Subtraction(CharPattern, CharGroup)](#Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |
| [Subtraction(CharPattern, CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |
| [Subtraction(CharPattern, CharPattern)](#Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |

## Subtraction\(CharPattern, CharGroup\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_"></a>

### Summary

Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharSubtraction operator -(Pihrtsoft.Text.RegularExpressions.Linq.CharPattern baseGroup, Pihrtsoft.Text.RegularExpressions.Linq.CharGroup excludedGroup)
```

### Parameters

**baseGroup** &ensp; [CharPattern](../README.md)

A base group\.

**excludedGroup** &ensp; [CharGroup](../../CharGroup/README.md)

An excluded group\.

### Returns

[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

## Subtraction\(CharPattern, CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

### Summary

Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharSubtraction operator -(Pihrtsoft.Text.RegularExpressions.Linq.CharPattern baseGroup, Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping excludedGroup)
```

### Parameters

**baseGroup** &ensp; [CharPattern](../README.md)

A base group\.

**excludedGroup** &ensp; [CharGrouping](../../CharGrouping/README.md)

An excluded group\.

### Returns

[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

## Subtraction\(CharPattern, CharPattern\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_"></a>

### Summary

Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharSubtraction operator -(Pihrtsoft.Text.RegularExpressions.Linq.CharPattern baseGroup, Pihrtsoft.Text.RegularExpressions.Linq.CharPattern excludedGroup)
```

### Parameters

**baseGroup** &ensp; [CharPattern](../README.md)

A base group\.

**excludedGroup** &ensp; [CharPattern](../README.md)

An excluded group\.

### Returns

[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

