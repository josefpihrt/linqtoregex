# Pattern\.BitwiseOr Operator

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Operator | Summary |
| -------- | ------- |
| [BitwiseOr(Char, Pattern)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_System_Char_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_) | Creates a pattern that matches any one of the specified elements\. |
| [BitwiseOr(CharGrouping, Pattern)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_) | Creates a pattern that matches any one of the specified elements\. |
| [BitwiseOr(Pattern, Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_System_Char_) | Creates a pattern that matches any one of the specified elements\. |
| [BitwiseOr(Pattern, CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Creates a pattern that matches any one of the specified elements\. |
| [BitwiseOr(Pattern, Pattern)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_) | Creates a pattern that matches any one of the specified elements\. |
| [BitwiseOr(Pattern, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_System_String_) | Creates a pattern that matches any one of the specified elements\. |
| [BitwiseOr(String, Pattern)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_System_String_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_) | Creates a pattern that matches any one of the specified elements\. |

## BitwiseOr\(Char, Pattern\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_System_Char_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_"></a>

### Summary

Creates a pattern that matches any one of the specified elements\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern operator |(char left, Pihrtsoft.Text.RegularExpressions.Linq.Pattern right)
```

### Parameters

**left** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The first element to match\.

**right** &ensp; [Pattern](../README.md)

The second element to match\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**right** is `null`\.

## BitwiseOr\(CharGrouping, Pattern\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_"></a>

### Summary

Creates a pattern that matches any one of the specified elements\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern operator |(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping left, Pihrtsoft.Text.RegularExpressions.Linq.Pattern right)
```

### Parameters

**left** &ensp; [CharGrouping](../../CharGrouping/README.md)

The first element to match\.

**right** &ensp; [Pattern](../README.md)

The second element to match\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** or **right** is `null`\.

## BitwiseOr\(Pattern, Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_System_Char_"></a>

### Summary

Creates a pattern that matches any one of the specified elements\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern operator |(Pihrtsoft.Text.RegularExpressions.Linq.Pattern left, char right)
```

### Parameters

**left** &ensp; [Pattern](../README.md)

The first element to match\.

**right** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The second element to match\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** is `null`\.

## BitwiseOr\(Pattern, CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

### Summary

Creates a pattern that matches any one of the specified elements\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern operator |(Pihrtsoft.Text.RegularExpressions.Linq.Pattern left, Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping right)
```

### Parameters

**left** &ensp; [Pattern](../README.md)

The first element to match\.

**right** &ensp; [CharGrouping](../../CharGrouping/README.md)

The second element to match\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** or **right** is `null`\.

## BitwiseOr\(Pattern, Pattern\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_"></a>

### Summary

Creates a pattern that matches any one of the specified elements\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern operator |(Pihrtsoft.Text.RegularExpressions.Linq.Pattern left, Pihrtsoft.Text.RegularExpressions.Linq.Pattern right)
```

### Parameters

**left** &ensp; [Pattern](../README.md)

The first element to match\.

**right** &ensp; [Pattern](../README.md)

The second element to match\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** or **right** is `null`\.

## BitwiseOr\(Pattern, String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_System_String_"></a>

### Summary

Creates a pattern that matches any one of the specified elements\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern operator |(Pihrtsoft.Text.RegularExpressions.Linq.Pattern left, string right)
```

### Parameters

**left** &ensp; [Pattern](../README.md)

The first element to match\.

**right** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The second element to match\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** or **right** is `null`\.

## BitwiseOr\(String, Pattern\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_BitwiseOr_System_String_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_"></a>

### Summary

Creates a pattern that matches any one of the specified elements\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern operator |(string left, Pihrtsoft.Text.RegularExpressions.Linq.Pattern right)
```

### Parameters

**left** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The first element to match\.

**right** &ensp; [Pattern](../README.md)

The second element to match\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** or **right** is `null`\.

