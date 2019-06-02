# Pattern\.Addition Operator

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Operator | Summary |
| -------- | ------- |
| [Addition(Char, Pattern)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_Addition_System_Char_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_) | Concatenate two elements into a new [Pattern](../README.md)\. |
| [Addition(Pattern, Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_System_Char_) | Concatenate two elements into a new [Pattern](../README.md)\. |
| [Addition(Pattern, Pattern)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_) | Concatenate two elements into a new [Pattern](../README.md)\. |
| [Addition(Pattern, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_System_String_) | Concatenate two elements into a new [Pattern](../README.md)\. |
| [Addition(String, Pattern)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_Addition_System_String_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_) | Concatenate two elements into a new [Pattern](../README.md)\. |

## Addition\(Char, Pattern\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_Addition_System_Char_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_"></a>

### Summary

Concatenate two elements into a new [Pattern](../README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern operator +(char left, Pihrtsoft.Text.RegularExpressions.Linq.Pattern right)
```

### Parameters

**left** &emsp; System\.[Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The first element to concatenate\.

**right** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

The second element to concatenate\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**right** is `null`\.

## Addition\(Pattern, Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_System_Char_"></a>

### Summary

Concatenate two elements into a new [Pattern](../README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern operator +(Pihrtsoft.Text.RegularExpressions.Linq.Pattern left, char right)
```

### Parameters

**left** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

The first element to concatenate\.

**right** &emsp; System\.[Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The second element to concatenate\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** is `null`\.

## Addition\(Pattern, Pattern\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_"></a>

### Summary

Concatenate two elements into a new [Pattern](../README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern operator +(Pihrtsoft.Text.RegularExpressions.Linq.Pattern left, Pihrtsoft.Text.RegularExpressions.Linq.Pattern right)
```

### Parameters

**left** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

The first element to concatenate\.

**right** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

The second element to concatenate\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** or **right** is `null`\.

## Addition\(Pattern, String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_System_String_"></a>

### Summary

Concatenate two elements into a new [Pattern](../README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern operator +(Pihrtsoft.Text.RegularExpressions.Linq.Pattern left, string right)
```

### Parameters

**left** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

The first element to concatenate\.

**right** &emsp; System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The second element to concatenate\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** or **right** is `null`\.

## Addition\(String, Pattern\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_op_Addition_System_String_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_"></a>

### Summary

Concatenate two elements into a new [Pattern](../README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Pattern operator +(string left, Pihrtsoft.Text.RegularExpressions.Linq.Pattern right)
```

### Parameters

**left** &emsp; System\.[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The first element to concatenate\.

**right** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

The second element to concatenate\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** or **right** is `null`\.

