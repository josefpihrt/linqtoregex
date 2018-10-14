# Patterns\.Character Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Character(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Character_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Returns a pattern that matches a specified character\. |
| [Character(GeneralCategory)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Character_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Returns a pattern that matches a character from a specified Unicode category\. |
| [Character(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Character_System_Char_) | Returns a pattern that matches a specified character\. |
| [Character(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Character_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Returns a pattern that matches a character from a specified [CharGrouping](../../CharGrouping/README.md)\. |
| [Character(NamedBlock)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Character_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Returns a pattern that matches a character from a specified Unicode block\. |
| [Character(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Character_System_String_) | Returns a pattern that matches a character from a specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\. |

## Character\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Character_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

### Summary

Returns a pattern that matches a specified character\.

```csharp
public static CharPattern Character(AsciiChar value)
```

### Parameters

**value**

An enumerated constant that identifies ASCII character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Character\(GeneralCategory\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Character_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

### Summary

Returns a pattern that matches a character from a specified Unicode category\.

```csharp
public static CharPattern Character(GeneralCategory category)
```

### Parameters

**category**

An enumerated constant that identifies Unicode category\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Character\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Character_System_Char_"></a>

### Summary

Returns a pattern that matches a specified character\.

```csharp
public static CharPattern Character(char value)
```

### Parameters

**value**

A Unicode character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Character\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Character_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

### Summary

Returns a pattern that matches a character from a specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public static CharGroup Character(CharGrouping value)
```

### Parameters

**value**

A content of a character group\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## Character\(NamedBlock\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Character_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

### Summary

Returns a pattern that matches a character from a specified Unicode block\.

```csharp
public static CharPattern Character(NamedBlock block)
```

### Parameters

**block**

An enumerated constant that identifies Unicode block\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## Character\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Character_System_String_"></a>

### Summary

Returns a pattern that matches a character from a specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\.

```csharp
public static CharGroup Character(string characters)
```

### Parameters

**characters**

A set of characters any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

