# Chars\.Character Method

[Home](../../../../../../README.md)

**Containing Type**: [Chars](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Character(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_Chars_Character_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Returns a pattern that matches specified Unicode character\. |
| [Character(GeneralCategory)](#Pihrtsoft_Text_RegularExpressions_Linq_Chars_Character_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Returns a pattern that matches a character from the specified Unicode category\. |
| [Character(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Chars_Character_System_Char_) | Returns a pattern that matches specified Unicode character\. |
| [Character(NamedBlock)](#Pihrtsoft_Text_RegularExpressions_Linq_Chars_Character_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Returns a pattern that matches a character from the specified Unicode block\. |
| [Character(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Chars_Character_System_String_) | Returns a pattern that matches any one of the specified characters\. |

## Character\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Chars_Character_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

### Summary

Returns a pattern that matches specified Unicode character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Character(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &ensp; [AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies ASCII character\.

### Returns

[CharGrouping](../../CharGrouping/README.md)

## Character\(GeneralCategory\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Chars_Character_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

### Summary

Returns a pattern that matches a character from the specified Unicode category\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Character(Pihrtsoft.Text.RegularExpressions.Linq.GeneralCategory category)
```

### Parameters

**category** &ensp; [GeneralCategory](../../GeneralCategory/README.md)

An enumerated constant that identifies Unicode category\.

### Returns

[CharGrouping](../../CharGrouping/README.md)

## Character\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Chars_Character_System_Char_"></a>

### Summary

Returns a pattern that matches specified Unicode character\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Character(char value)
```

### Parameters

**value** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

### Returns

[CharGrouping](../../CharGrouping/README.md)

## Character\(NamedBlock\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Chars_Character_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

### Summary

Returns a pattern that matches a character from the specified Unicode block\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Character(Pihrtsoft.Text.RegularExpressions.Linq.NamedBlock block)
```

### Parameters

**block** &ensp; [NamedBlock](../../NamedBlock/README.md)

An enumerated constant that identifies Unicode block\.

### Returns

[CharGrouping](../../CharGrouping/README.md)

## Character\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Chars_Character_System_String_"></a>

### Summary

Returns a pattern that matches any one of the specified characters\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Character(string characters)
```

### Parameters

**characters** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A set of Unicode characters\.

### Returns

[CharGrouping](../../CharGrouping/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

