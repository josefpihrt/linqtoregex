# CharGroup\.Subtraction Operator

[Home](../../../../../../README.md)

**Containing Type**: [CharGroup](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Operator | Summary |
| -------- | ------- |
| [Subtraction(CharGroup, CharGroup)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |
| [Subtraction(CharGroup, CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |
| [Subtraction(CharGroup, CharPattern)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_) | Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\. |

## Subtraction\(CharGroup, CharGroup\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_"></a>

\
Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharSubtraction operator -(Pihrtsoft.Text.RegularExpressions.Linq.CharGroup baseGroup, Pihrtsoft.Text.RegularExpressions.Linq.CharGroup excludedGroup)
```

### Parameters

**baseGroup** &ensp; [CharGroup](../README.md)

A base group\.

**excludedGroup** &ensp; [CharGroup](../README.md)

An excluded group\.

### Returns

[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

## Subtraction\(CharGroup, CharGrouping\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

\
Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharSubtraction operator -(Pihrtsoft.Text.RegularExpressions.Linq.CharGroup baseGroup, Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping excludedGroup)
```

### Parameters

**baseGroup** &ensp; [CharGroup](../README.md)

A base group\.

**excludedGroup** &ensp; [CharGrouping](../../CharGrouping/README.md)

An excluded group\.

### Returns

[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

## Subtraction\(CharGroup, CharPattern\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Subtraction_Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_Pihrtsoft_Text_RegularExpressions_Linq_CharPattern_"></a>

\
Returns a pattern that matches a character from a specified base group except characters from a specified excluded group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharSubtraction operator -(Pihrtsoft.Text.RegularExpressions.Linq.CharGroup baseGroup, Pihrtsoft.Text.RegularExpressions.Linq.CharPattern excludedGroup)
```

### Parameters

**baseGroup** &ensp; [CharGroup](../README.md)

A base group\.

**excludedGroup** &ensp; [CharPattern](../../CharPattern/README.md)

An excluded group\.

### Returns

[CharSubtraction](../../CharSubtraction/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**baseGroup** or **excludedGroup** is `null`\.

