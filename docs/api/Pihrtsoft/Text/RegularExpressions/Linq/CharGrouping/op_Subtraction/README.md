# CharGrouping\.Subtraction Operator

[Home](../../../../../../README.md)

**Containing Type**: [CharGrouping](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Operator | Summary |
| -------- | ------- |
| [Subtraction(CharGrouping, CharGroup)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |
| [Subtraction(CharGrouping, CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |
| [Subtraction(CharGrouping, CharPattern)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |

## Subtraction\(CharGrouping, CharGroup\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_"></a>

\
Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharSubtraction operator -(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping baseGroup, Pihrtsoft.Text.RegularExpressions.Linq.CharGroup excludedGroup)
```

### Parameters

**baseGroup** &ensp; [CharGrouping](../README.md)

A base group\.

**excludedGroup** &ensp; [CharGroup](../../CharGroup/README.md)

An excluded group\.

### Returns

[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

## Subtraction\(CharGrouping, CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

\
Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharSubtraction operator -(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping baseGroup, Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping excludedGroup)
```

### Parameters

**baseGroup** &ensp; [CharGrouping](../README.md)

A base group\.

**excludedGroup** &ensp; [CharGrouping](../README.md)

An excluded group\.

### Returns

[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

## Subtraction\(CharGrouping, CharPattern\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_"></a>

\
Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharSubtraction operator -(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping baseGroup, Pihrtsoft.Text.RegularExpressions.Linq.CharPattern excludedGroup)
```

### Parameters

**baseGroup** &ensp; [CharGrouping](../README.md)

A base group\.

**excludedGroup** &ensp; [CharPattern](../../CharPattern/README.md)

An excluded group\.

### Returns

[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

