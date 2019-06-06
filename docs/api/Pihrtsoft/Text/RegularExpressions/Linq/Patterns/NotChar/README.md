# Patterns\.NotChar Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotChar(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Returns a pattern that matches a character that is not a specified character\. |
| [NotChar(GeneralCategory)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Returns a pattern that matches a character that is not from a specified Unicode category\. |
| [NotChar(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_System_Char_) | Returns a pattern that matches a character that is not a specified character\. |
| [NotChar(Char\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_System_Char___) | Returns a pattern that matches any character that is not contained in the specified characters\. |
| [NotChar(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Returns a negative character group containing specified [CharGrouping](../../CharGrouping/README.md)\. |
| [NotChar(NamedBlock)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Returns a pattern that matches a character that is not from a specified Unicode block\. |
| [NotChar(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_System_String_) | Returns a pattern that matches any character that is not contained in the specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\. |

## NotChar\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

\
Returns a pattern that matches a character that is not a specified character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup NotChar(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &ensp; [AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies ASCII character\.

### Returns

[CharGroup](../../CharGroup/README.md)

## NotChar\(GeneralCategory\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

\
Returns a pattern that matches a character that is not from a specified Unicode category\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern NotChar(Pihrtsoft.Text.RegularExpressions.Linq.GeneralCategory category)
```

### Parameters

**category** &ensp; [GeneralCategory](../../GeneralCategory/README.md)

An enumerated constant that identifies Unicode category\.

### Returns

[CharPattern](../../CharPattern/README.md)

## NotChar\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_System_Char_"></a>

\
Returns a pattern that matches a character that is not a specified character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup NotChar(char value)
```

### Parameters

**value** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

### Returns

[CharGroup](../../CharGroup/README.md)

## NotChar\(Char\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_System_Char___"></a>

\
Returns a pattern that matches any character that is not contained in the specified characters\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup NotChar(params char[] characters)
```

### Parameters

**characters** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)\[\]

Unicode characters\.

### Returns

[CharGroup](../../CharGroup/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** is empty\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

## NotChar\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

\
Returns a negative character group containing specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup NotChar(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value** &ensp; [CharGrouping](../../CharGrouping/README.md)

A content of a character group\.

### Returns

[CharGroup](../../CharGroup/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## NotChar\(NamedBlock\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

\
Returns a pattern that matches a character that is not from a specified Unicode block\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharPattern NotChar(Pihrtsoft.Text.RegularExpressions.Linq.NamedBlock block)
```

### Parameters

**block** &ensp; [NamedBlock](../../NamedBlock/README.md)

An enumerated constant that identifies Unicode block\.

### Returns

[CharPattern](../../CharPattern/README.md)

## NotChar\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_System_String_"></a>

\
Returns a pattern that matches any character that is not contained in the specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGroup NotChar(string characters)
```

### Parameters

**characters** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Unicode characters\.

### Returns

[CharGroup](../../CharGroup/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

