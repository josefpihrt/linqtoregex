# Patterns\.WhileChar Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WhileChar(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Returns a pattern that matches a specified character zero or more times\. |
| [WhileChar(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileChar_System_Char_) | Returns a pattern that matches a specified character zero or more times\. |
| [WhileChar(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Returns a pattern that matches a specified character zero or more times\. |

## WhileChar\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

\
Returns a pattern that matches a specified character zero or more times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedPattern WhileChar(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &ensp; [AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies ASCII character\.

### Returns

[QuantifiedPattern](../../QuantifiedPattern/README.md)

## WhileChar\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileChar_System_Char_"></a>

\
Returns a pattern that matches a specified character zero or more times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedPattern WhileChar(char value)
```

### Parameters

**value** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

### Returns

[QuantifiedPattern](../../QuantifiedPattern/README.md)

## WhileChar\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_WhileChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

\
Returns a pattern that matches a specified character zero or more times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedPattern WhileChar(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value** &ensp; [CharGrouping](../../CharGrouping/README.md)

A set of Unicode characters\.

### Returns

[QuantifiedPattern](../../QuantifiedPattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

