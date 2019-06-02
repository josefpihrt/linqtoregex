# Patterns\.WhileNotChar Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WhileNotChar(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileNotChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Returns a pattern that matches zero or more characters that are not a specified character\. |
| [WhileNotChar(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileNotChar_System_Char_) | Returns a pattern that matches zero or more characters that are not a specified character\. |
| [WhileNotChar(Char\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileNotChar_System_Char___) | Returns a pattern that matches zero or more characters that are not contained in the specified characters |
| [WhileNotChar(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileNotChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Returns a pattern that matches zero or more characters that are not matched by a specified [CharGrouping](../../CharGrouping/README.md)\. |
| [WhileNotChar(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileNotChar_System_String_) | Returns a pattern that matches zero or more characters that are not contained in the specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\. |

## WhileNotChar\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileNotChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

### Summary

Returns a pattern that matches zero or more characters that are not a specified character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedPattern WhileNotChar(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies ASCII character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedPattern](../../QuantifiedPattern/README.md)

## WhileNotChar\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileNotChar_System_Char_"></a>

### Summary

Returns a pattern that matches zero or more characters that are not a specified character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedPattern WhileNotChar(char value)
```

### Parameters

**value** &emsp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedPattern](../../QuantifiedPattern/README.md)

## WhileNotChar\(Char\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileNotChar_System_Char___"></a>

### Summary

Returns a pattern that matches zero or more characters that are not contained in the specified characters

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedPattern WhileNotChar(params char[] characters)
```

### Parameters

**characters** &emsp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)\[\]

Unicode characters\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedPattern](../../QuantifiedPattern/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** is empty\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

## WhileNotChar\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileNotChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

### Summary

Returns a pattern that matches zero or more characters that are not matched by a specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedPattern WhileNotChar(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGrouping](../../CharGrouping/README.md)

A set of Unicode characters\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedPattern](../../QuantifiedPattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## WhileNotChar\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileNotChar_System_String_"></a>

### Summary

Returns a pattern that matches zero or more characters that are not contained in the specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedPattern WhileNotChar(string characters)
```

### Parameters

**characters** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Unicode characters\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiedPattern](../../QuantifiedPattern/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

