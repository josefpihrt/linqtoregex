# Patterns\.NotChar Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

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

### Summary

Returns a pattern that matches a character that is not a specified character\.

```csharp
public static CharGroup NotChar(AsciiChar value)
```

### Parameters

**value**

An enumerated constant that identifies ASCII character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## NotChar\(GeneralCategory\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

### Summary

Returns a pattern that matches a character that is not from a specified Unicode category\.

```csharp
public static CharPattern NotChar(GeneralCategory category)
```

### Parameters

**category**

An enumerated constant that identifies Unicode category\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## NotChar\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_System_Char_"></a>

### Summary

Returns a pattern that matches a character that is not a specified character\.

```csharp
public static CharGroup NotChar(char value)
```

### Parameters

**value**

A Unicode character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

## NotChar\(Char\[\]\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_System_Char___"></a>

### Summary

Returns a pattern that matches any character that is not contained in the specified characters\.

```csharp
public static CharGroup NotChar(params char[] characters)
```

### Parameters

**characters**

Unicode characters\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** is empty\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

## NotChar\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

### Summary

Returns a negative character group containing specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public static CharGroup NotChar(CharGrouping value)
```

### Parameters

**value**

A content of a character group\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## NotChar\(NamedBlock\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

### Summary

Returns a pattern that matches a character that is not from a specified Unicode block\.

```csharp
public static CharPattern NotChar(NamedBlock block)
```

### Parameters

**block**

An enumerated constant that identifies Unicode block\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../../CharPattern/README.md)

## NotChar\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotChar_System_String_"></a>

### Summary

Returns a pattern that matches any character that is not contained in the specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\.

```csharp
public static CharGroup NotChar(string characters)
```

### Parameters

**characters**

Unicode characters\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../../CharGroup/README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

