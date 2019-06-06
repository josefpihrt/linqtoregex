# Patterns\.UntilChar Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [UntilChar(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_UntilChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Returns a pattern that matches zero or more characters until it reaches a specified character\. |
| [UntilChar(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_UntilChar_System_Char_) | Returns a pattern that matches zero or more characters until it reaches a specified character\. |
| [UntilChar(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_UntilChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Returns a pattern that matches zero or more characters until it reaches a character that is matched by a specified [CharGrouping](../../CharGrouping/README.md)\. |
| [UntilChar(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_UntilChar_System_String_) | Returns a pattern that matches zero or more characters until it reaches any one of the specified characters\. |

## UntilChar\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_UntilChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

\
Returns a pattern that matches zero or more characters until it reaches a specified character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern UntilChar(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &ensp; [AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies ASCII character\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## UntilChar\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_UntilChar_System_Char_"></a>

\
Returns a pattern that matches zero or more characters until it reaches a specified character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern UntilChar(char value)
```

### Parameters

**value** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## UntilChar\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_UntilChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

\
Returns a pattern that matches zero or more characters until it reaches a character that is matched by a specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern UntilChar(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value** &ensp; [CharGrouping](../../CharGrouping/README.md)

A content of a character group\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## UntilChar\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_UntilChar_System_String_"></a>

\
Returns a pattern that matches zero or more characters until it reaches any one of the specified characters\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern UntilChar(string characters)
```

### Parameters

**characters** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Unicode characters\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

