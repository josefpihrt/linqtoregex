# Pattern\.Character Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Character(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends a pattern that matches a specified character\. |
| [Character(GeneralCategory)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Appends a pattern that matches a character from a specified Unicode category\. |
| [Character(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_System_Char_) | Appends a pattern that matches a specified character\. |
| [Character(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Appends a pattern that matches a character from a specified [CharGrouping](../../CharGrouping/README.md)\. |
| [Character(NamedBlock)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Appends a pattern that matches a character from a specified Unicode block\. |
| [Character(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_System_String_) | Appends a pattern that matches a character from a specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\. |

## Character\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

### Summary

Appends a pattern that matches a specified character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Character(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies ASCII character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Character\(GeneralCategory\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

### Summary

Appends a pattern that matches a character from a specified Unicode category\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Character(Pihrtsoft.Text.RegularExpressions.Linq.GeneralCategory category)
```

### Parameters

**category** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[GeneralCategory](../../GeneralCategory/README.md)

An enumerated constant that identifies Unicode category\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Character\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_System_Char_"></a>

### Summary

Appends a pattern that matches a specified character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Character(char value)
```

### Parameters

**value** &emsp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Character\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

### Summary

Appends a pattern that matches a character from a specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Character(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGrouping](../../CharGrouping/README.md)

A content of a character group\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## Character\(NamedBlock\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

### Summary

Appends a pattern that matches a character from a specified Unicode block\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Character(Pihrtsoft.Text.RegularExpressions.Linq.NamedBlock block)
```

### Parameters

**block** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[NamedBlock](../../NamedBlock/README.md)

An enumerated constant that identifies Unicode block\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Character\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_System_String_"></a>

### Summary

Appends a pattern that matches a character from a specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Character(string characters)
```

### Parameters

**characters** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A set of characters any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

