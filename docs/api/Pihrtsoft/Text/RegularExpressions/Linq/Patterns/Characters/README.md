# Patterns\.Characters Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Characters(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Characters_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Returns a pattern that matches a specified character one or more times\. |
| [Characters(GeneralCategory)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Characters_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Returns a pattern that matches one or more characters from a specified Unicode category\. |
| [Characters(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Characters_System_Char_) | Returns a pattern that matches a specified character one or more times\. |
| [Characters(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Characters_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Returns a pattern that matches one or more characters from a specified [CharGrouping](../../CharGrouping/README.md)\. |
| [Characters(NamedBlock)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Characters_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Returns a pattern that matches one or more characters from a specified Unicode block\. |
| [Characters(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Characters_System_String_) | Returns a pattern that matches one or more characters from a specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\. |

## Characters\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Characters_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

### Summary

Returns a pattern that matches a specified character one or more times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Characters(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &ensp; [AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies ASCII character\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

## Characters\(GeneralCategory\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Characters_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

### Summary

Returns a pattern that matches one or more characters from a specified Unicode category\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Characters(Pihrtsoft.Text.RegularExpressions.Linq.GeneralCategory category)
```

### Parameters

**category** &ensp; [GeneralCategory](../../GeneralCategory/README.md)

An enumerated constant that identifies Unicode category\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

## Characters\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Characters_System_Char_"></a>

### Summary

Returns a pattern that matches a specified character one or more times\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Characters(char value)
```

### Parameters

**value** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

## Characters\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Characters_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

### Summary

Returns a pattern that matches one or more characters from a specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Characters(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value** &ensp; [CharGrouping](../../CharGrouping/README.md)

A content of a character group\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## Characters\(NamedBlock\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Characters_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

### Summary

Returns a pattern that matches one or more characters from a specified Unicode block\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Characters(Pihrtsoft.Text.RegularExpressions.Linq.NamedBlock block)
```

### Parameters

**block** &ensp; [NamedBlock](../../NamedBlock/README.md)

An enumerated constant that identifies Unicode block\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

## Characters\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Characters_System_String_"></a>

### Summary

Returns a pattern that matches one or more characters from a specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Characters(string value)
```

### Parameters

**value** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A set of characters any one of which has to be matched\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**value** length is equal to zero\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

