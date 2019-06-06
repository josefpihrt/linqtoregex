# PatternBuilder\.Append Method

[Home](../../../../../../README.md)

**Containing Type**: [PatternBuilder](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Append(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends specified character to this instance\. |
| [Append(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_Char_) | Appends specified character to this instance\. |
| [Append(Char\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_Char___) | Appends specified characters to this instance\. |
| [Append(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Appends the text representation of the pattern to this instance\. |
| [Append(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_Int32_) | Appends specified character to this instance\. |
| [Append(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_Object_) | Appends the pattern representation of an object\. The object must be convertible to [Pattern](../../Pattern/README.md), [CharGrouping](../../CharGrouping/README.md), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char), object array or [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)\. |
| [Append(Pattern)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_) | Appends the text representation of the pattern to this instance\. |
| [Append(String)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_String_) | Appends specified text to this instance\. |

## Append\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

\
Appends specified character to this instance\.

```csharp
public void Append(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &ensp; [AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies an ASCII character to append\.

## Append\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_Char_"></a>

\
Appends specified character to this instance\.

```csharp
public void Append(char value)
```

### Parameters

**value** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The character to append\.

## Append\(Char\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_Char___"></a>

\
Appends specified characters to this instance\.

```csharp
public void Append(char[] characters)
```

### Parameters

**characters** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)\[\]

Unicode characters\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

## Append\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

\
Appends the text representation of the pattern to this instance\.

```csharp
public void Append(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value** &ensp; [CharGrouping](../../CharGrouping/README.md)

The pattern to append\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## Append\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_Int32_"></a>

\
Appends specified character to this instance\.

```csharp
public void Append(int value)
```

### Parameters

**value** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A code of the character to append\.

## Append\(Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_Object_"></a>

\
Appends the pattern representation of an object\. The object must be convertible to [Pattern](../../Pattern/README.md), [CharGrouping](../../CharGrouping/README.md), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char), object array or [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)\.

```csharp
public void Append(object value)
```

### Parameters

**value** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The object to append\.

## Append\(Pattern\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_Pihrtsoft_Text_RegularExpressions_Linq_Pattern_"></a>

\
Appends the text representation of the pattern to this instance\.

```csharp
public void Append(Pihrtsoft.Text.RegularExpressions.Linq.Pattern pattern)
```

### Parameters

**pattern** &ensp; [Pattern](../../Pattern/README.md)

The pattern to append\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**pattern** is `null`\.

## Append\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_Append_System_String_"></a>

\
Appends specified text to this instance\.

```csharp
public void Append(string value)
```

### Parameters

**value** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The text to append\.