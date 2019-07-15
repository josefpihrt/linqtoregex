# Pattern\.Character Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

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

## Character\(AsciiChar\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

\
Appends a pattern that matches a specified character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Character(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &ensp; [AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies ASCII character\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Character\(GeneralCategory\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

\
Appends a pattern that matches a character from a specified Unicode category\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Character(Pihrtsoft.Text.RegularExpressions.Linq.GeneralCategory category)
```

### Parameters

**category** &ensp; [GeneralCategory](../../GeneralCategory/README.md)

An enumerated constant that identifies Unicode category\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Character\(Char\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_System_Char_"></a>

\
Appends a pattern that matches a specified character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Character(char value)
```

### Parameters

**value** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Character\(CharGrouping\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

\
Appends a pattern that matches a character from a specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Character(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value** &ensp; [CharGrouping](../../CharGrouping/README.md)

A content of a character group\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## Character\(NamedBlock\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

\
Appends a pattern that matches a character from a specified Unicode block\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Character(Pihrtsoft.Text.RegularExpressions.Linq.NamedBlock block)
```

### Parameters

**block** &ensp; [NamedBlock](../../NamedBlock/README.md)

An enumerated constant that identifies Unicode block\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Character\(String\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_System_String_"></a>

\
Appends a pattern that matches a character from a specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern Character(string characters)
```

### Parameters

**characters** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A set of characters any one of which has to be matched\.

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

