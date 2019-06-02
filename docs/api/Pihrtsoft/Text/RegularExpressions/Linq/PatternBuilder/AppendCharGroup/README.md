# PatternBuilder\.AppendCharGroup Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[PatternBuilder](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AppendCharGroup(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends a pattern that matches a specified character\. |
| [AppendCharGroup(GeneralCategory)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Appends a pattern that matches a character from a specified Unicode category\. |
| [AppendCharGroup(Char, Char)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_System_Char_System_Char_) | Appends a pattern that matches a character in the specified range\. |
| [AppendCharGroup(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Appends a character group containing specified [CharGrouping](../../CharGrouping/README.md)\. |
| [AppendCharGroup(NamedBlock)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Appends a pattern that matches a character from a specified Unicode block\. |
| [AppendCharGroup(String)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_System_String_) | Appends a character group containing specified characters\. |

## AppendCharGroup\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

### Summary

Appends a pattern that matches a specified character\.

```csharp
public void AppendCharGroup(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value**

An enumerated constant that identifies ASCII character\.

## AppendCharGroup\(GeneralCategory\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

### Summary

Appends a pattern that matches a character from a specified Unicode category\.

```csharp
public void AppendCharGroup(Pihrtsoft.Text.RegularExpressions.Linq.GeneralCategory category)
```

### Parameters

**category**

An enumerated constant that identifies Unicode category\.

## AppendCharGroup\(Char, Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_System_Char_System_Char_"></a>

### Summary

Appends a pattern that matches a character in the specified range\.

```csharp
public void AppendCharGroup(char first, char last)
```

### Parameters

**first**

The first character of the range\.

**last**

The last character of the range\.

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**last** character number is less than **first** character number\.

## AppendCharGroup\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

### Summary

Appends a character group containing specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public void AppendCharGroup(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value**

A content of a character group\.

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## AppendCharGroup\(NamedBlock\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

### Summary

Appends a pattern that matches a character from a specified Unicode block\.

```csharp
public void AppendCharGroup(Pihrtsoft.Text.RegularExpressions.Linq.NamedBlock block)
```

### Parameters

**block**

An enumerated constant that identifies Unicode block\.

## AppendCharGroup\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder_AppendCharGroup_System_String_"></a>

### Summary

Appends a character group containing specified characters\.

```csharp
public void AppendCharGroup(string characters)
```

### Parameters

**characters**

A set of characters any one of which has to be matched\.

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

