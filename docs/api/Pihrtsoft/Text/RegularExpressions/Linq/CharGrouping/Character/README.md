# CharGrouping\.Character Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGrouping](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Character(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends a pattern that matches specified Unicode character\. |
| [Character(GeneralCategory)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Appends a pattern that matches a character from the specified Unicode category\. |
| [Character(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_System_Char_) | Appends a pattern that matches specified Unicode character\. |
| [Character(NamedBlock)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Appends a pattern that matches a character from the specified Unicode block\. |
| [Character(String)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_System_String_) | Appends a pattern that matches any one of the specified characters\. |

## Character\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

### Summary

Appends a pattern that matches specified Unicode character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Character(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies ASCII character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGrouping](../README.md)

## Character\(GeneralCategory\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

### Summary

Appends a pattern that matches a character from the specified Unicode category\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Character(Pihrtsoft.Text.RegularExpressions.Linq.GeneralCategory category)
```

### Parameters

**category** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[GeneralCategory](../../GeneralCategory/README.md)

An enumerated constant that identifies Unicode category\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGrouping](../README.md)

## Character\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_System_Char_"></a>

### Summary

Appends a pattern that matches specified Unicode character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Character(char value)
```

### Parameters

**value** &emsp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGrouping](../README.md)

## Character\(NamedBlock\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

### Summary

Appends a pattern that matches a character from the specified Unicode block\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Character(Pihrtsoft.Text.RegularExpressions.Linq.NamedBlock block)
```

### Parameters

**block** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[NamedBlock](../../NamedBlock/README.md)

An enumerated constant that identifies Unicode block\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGrouping](../README.md)

## Character\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Character_System_String_"></a>

### Summary

Appends a pattern that matches any one of the specified characters\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Character(string characters)
```

### Parameters

**characters** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A set of Unicode characters\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGrouping](../README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

