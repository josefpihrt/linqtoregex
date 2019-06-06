# PatternBuilder\.AppendNegativeCharGroup Method

[Home](../../../../../../README.md)

**Containing Type**: [PatternBuilder](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AppendNegativeCharGroup(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends a pattern that matches a character that is not a specified character\. |
| [AppendNegativeCharGroup(GeneralCategory)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Appends a pattern that matches a character that is not from a specified Unicode category\. |
| [AppendNegativeCharGroup(Char, Char)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_System_Char_System_Char_) | Appends a pattern that matches a character that is not in the specified range\. |
| [AppendNegativeCharGroup(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Appends a negative character group containing specified [CharGrouping](../../CharGrouping/README.md)\. |
| [AppendNegativeCharGroup(NamedBlock)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Appends a pattern that matches a character that is not from a specified Unicode block\. |
| [AppendNegativeCharGroup(String)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_System_String_) | Appends a negative character group containing specified characters\. |

## AppendNegativeCharGroup\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

\
Appends a pattern that matches a character that is not a specified character\.

```csharp
public void AppendNegativeCharGroup(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &ensp; [AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies ASCII character\.

## AppendNegativeCharGroup\(GeneralCategory\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

\
Appends a pattern that matches a character that is not from a specified Unicode category\.

```csharp
public void AppendNegativeCharGroup(Pihrtsoft.Text.RegularExpressions.Linq.GeneralCategory category)
```

### Parameters

**category** &ensp; [GeneralCategory](../../GeneralCategory/README.md)

An enumerated constant that identifies Unicode category\.

## AppendNegativeCharGroup\(Char, Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_System_Char_System_Char_"></a>

\
Appends a pattern that matches a character that is not in the specified range\.

```csharp
public void AppendNegativeCharGroup(char first, char last)
```

### Parameters

**first** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The first character of the range\.

**last** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

The last character of the range\.

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**last** character number is less than **first** character number\.

## AppendNegativeCharGroup\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

\
Appends a negative character group containing specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public void AppendNegativeCharGroup(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value** &ensp; [CharGrouping](../../CharGrouping/README.md)

A content of a character group\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## AppendNegativeCharGroup\(NamedBlock\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

\
Appends a pattern that matches a character that is not from a specified Unicode block\.

```csharp
public void AppendNegativeCharGroup(Pihrtsoft.Text.RegularExpressions.Linq.NamedBlock block)
```

### Parameters

**block** &ensp; [NamedBlock](../../NamedBlock/README.md)

An enumerated constant that identifies Unicode block\.

## AppendNegativeCharGroup\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendNegativeCharGroup_System_String_"></a>

\
Appends a negative character group containing specified characters\.

```csharp
public void AppendNegativeCharGroup(string characters)
```

### Parameters

**characters** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Unicode characters\.

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

