# Pattern\.WhileNotChar Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WhileNotChar(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileNotChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends a pattern that matches zero or more characters that are not a specified character\. |
| [WhileNotChar(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileNotChar_System_Char_) | Appends a pattern that matches zero or more characters that are not a specified character\. |
| [WhileNotChar(Char\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileNotChar_System_Char___) | Appends a pattern that matches zero or more characters that are not contained in the specified characters |
| [WhileNotChar(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileNotChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Appends a pattern that matches zero or more characters that are not matched by a specified [CharGrouping](../../CharGrouping/README.md)\. |
| [WhileNotChar(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileNotChar_System_String_) | Appends a pattern that matches zero or more characters that are not contained in the specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\. |

## WhileNotChar\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileNotChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

### Summary

Appends a pattern that matches zero or more characters that are not a specified character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern WhileNotChar(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &ensp; [AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies ASCII character\.

### Returns

[Pattern](../README.md)

## WhileNotChar\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileNotChar_System_Char_"></a>

### Summary

Appends a pattern that matches zero or more characters that are not a specified character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern WhileNotChar(char value)
```

### Parameters

**value** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

### Returns

[Pattern](../README.md)

## WhileNotChar\(Char\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileNotChar_System_Char___"></a>

### Summary

Appends a pattern that matches zero or more characters that are not contained in the specified characters

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedPattern WhileNotChar(params char[] characters)
```

### Parameters

**characters** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)\[\]

Unicode characters\.

### Returns

[QuantifiedPattern](../../QuantifiedPattern/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** is empty\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

## WhileNotChar\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileNotChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

### Summary

Appends a pattern that matches zero or more characters that are not matched by a specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern WhileNotChar(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value** &ensp; [CharGrouping](../../CharGrouping/README.md)

A set of Unicode characters\.

### Returns

[Pattern](../README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## WhileNotChar\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_WhileNotChar_System_String_"></a>

### Summary

Appends a pattern that matches zero or more characters that are not contained in the specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedPattern WhileNotChar(string characters)
```

### Parameters

**characters** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Unicode characters\.

### Returns

[QuantifiedPattern](../../QuantifiedPattern/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

