# Substitution\.Addition Operator

[Home](../../../../../../README.md)

**Containing Type**: [Substitution](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Operator | Summary |
| -------- | ------- |
| [Addition(Char, Substitution)](#Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_System_Char_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_) | Concatenate two elements into a new [Substitution](../README.md)\. |
| [Addition(String, Substitution)](#Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_System_String_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_) | Concatenate two elements into a new [Substitution](../README.md)\. |
| [Addition(Substitution, Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_System_Char_) | Concatenate two elements into a new [Substitution](../README.md)\. |
| [Addition(Substitution, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_System_String_) | Concatenate two elements into a new [Substitution](../README.md)\. |
| [Addition(Substitution, Substitution)](#Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_) | Concatenate two elements into a new [Substitution](../README.md)\. |

## Addition\(Char, Substitution\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_System_Char_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_"></a>

\
Concatenate two elements into a new [Substitution](../README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Substitution operator +(char left, Pihrtsoft.Text.RegularExpressions.Linq.Substitution right)
```

### Parameters

**left** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The first element to concatenate\.

**right** &ensp; [Substitution](../README.md)

The second element to concatenate\.

### Returns

[Substitution](../README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**right** is `null`\.

## Addition\(String, Substitution\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_System_String_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_"></a>

\
Concatenate two elements into a new [Substitution](../README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Substitution operator +(string left, Pihrtsoft.Text.RegularExpressions.Linq.Substitution right)
```

### Parameters

**left** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The first element to concatenate\.

**right** &ensp; [Substitution](../README.md)

The second element to concatenate\.

### Returns

[Substitution](../README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** or **right** is `null`\.

## Addition\(Substitution, Char\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_System_Char_"></a>

\
Concatenate two elements into a new [Substitution](../README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Substitution operator +(Pihrtsoft.Text.RegularExpressions.Linq.Substitution left, char right)
```

### Parameters

**left** &ensp; [Substitution](../README.md)

The first element to concatenate\.

**right** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The second element to concatenate\.

### Returns

[Substitution](../README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** is `null`\.

## Addition\(Substitution, String\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_System_String_"></a>

\
Concatenate two elements into a new [Substitution](../README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Substitution operator +(Pihrtsoft.Text.RegularExpressions.Linq.Substitution left, string right)
```

### Parameters

**left** &ensp; [Substitution](../README.md)

The first element to concatenate\.

**right** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The second element to concatenate\.

### Returns

[Substitution](../README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** or **right** is `null`\.

## Addition\(Substitution, Substitution\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_"></a>

\
Concatenate two elements into a new [Substitution](../README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.Substitution operator +(Pihrtsoft.Text.RegularExpressions.Linq.Substitution left, Pihrtsoft.Text.RegularExpressions.Linq.Substitution right)
```

### Parameters

**left** &ensp; [Substitution](../README.md)

The first element to concatenate\.

**right** &ensp; [Substitution](../README.md)

The second element to concatenate\.

### Returns

[Substitution](../README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**left** or **right** is `null`\.

