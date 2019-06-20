# Pattern\.Characters Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Characters(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Characters_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends a pattern that matches a specified character one or more times\. |
| [Characters(GeneralCategory)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Characters_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Appends a pattern that matches one or more characters from a specified Unicode category\. |
| [Characters(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Characters_System_Char_) | Appends a pattern that matches a specified character one or more times\. |
| [Characters(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Characters_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Appends a pattern that matches one or more characters from a specified [CharGrouping](../../CharGrouping/README.md)\. |
| [Characters(NamedBlock)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Characters_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Appends a pattern that matches one or more characters from a specified Unicode block\. |
| [Characters(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Characters_System_String_) | Appends a pattern that matches one or more characters from a specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\. |

## Characters\(AsciiChar\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Characters_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

\
Appends a pattern that matches a specified character one or more times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Characters(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &ensp; [AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies ASCII character\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

## Characters\(GeneralCategory\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Characters_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

\
Appends a pattern that matches one or more characters from a specified Unicode category\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Characters(Pihrtsoft.Text.RegularExpressions.Linq.GeneralCategory category)
```

### Parameters

**category** &ensp; [GeneralCategory](../../GeneralCategory/README.md)

An enumerated constant that identifies Unicode category\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

## Characters\(Char\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Characters_System_Char_"></a>

\
Appends a pattern that matches a specified character one or more times\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Characters(char value)
```

### Parameters

**value** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

## Characters\(CharGrouping\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Characters_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

\
Appends a pattern that matches one or more characters from a specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Characters(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value** &ensp; [CharGrouping](../../CharGrouping/README.md)

A content of a character group\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## Characters\(NamedBlock\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Characters_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

\
Appends a pattern that matches one or more characters from a specified Unicode block\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Characters(Pihrtsoft.Text.RegularExpressions.Linq.NamedBlock block)
```

### Parameters

**block** &ensp; [NamedBlock](../../NamedBlock/README.md)

An enumerated constant that identifies Unicode block\.

### Returns

[QuantifiedGroup](../../QuantifiedGroup/README.md)

## Characters\(String\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Characters_System_String_"></a>

\
Appends a pattern that matches one or more characters from a specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiedGroup Characters(string value)
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

