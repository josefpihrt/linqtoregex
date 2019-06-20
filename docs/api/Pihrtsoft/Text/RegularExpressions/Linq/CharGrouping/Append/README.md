# CharGrouping\.Append Method

[Home](../../../../../../README.md)

**Containing Type**: [CharGrouping](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Append(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends a pattern that matches specified Unicode character\. |
| [Append(GeneralCategory)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Appends a pattern that matches a character from the specified Unicode category\. |
| [Append(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_System_Char_) | Appends a pattern that matches specified Unicode character\. |
| [Append(NamedBlock)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Appends a pattern that matches a character from the specified Unicode block\. |
| [Append(String)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_System_String_) | Appends a pattern that matches any one of the specified characters\. |

## Append\(AsciiChar\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

\
Appends a pattern that matches specified Unicode character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Append(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value** &ensp; [AsciiChar](../../AsciiChar/README.md)

An enumerated constant that identifies ASCII character\.

### Returns

[CharGrouping](../README.md)

## Append\(GeneralCategory\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

\
Appends a pattern that matches a character from the specified Unicode category\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Append(Pihrtsoft.Text.RegularExpressions.Linq.GeneralCategory category)
```

### Parameters

**category** &ensp; [GeneralCategory](../../GeneralCategory/README.md)

An enumerated constant that identifies Unicode category\.

### Returns

[CharGrouping](../README.md)

## Append\(Char\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_System_Char_"></a>

\
Appends a pattern that matches specified Unicode character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Append(char value)
```

### Parameters

**value** &ensp; [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)

A Unicode character\.

### Returns

[CharGrouping](../README.md)

## Append\(NamedBlock\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

\
Appends a pattern that matches a character from the specified Unicode block\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Append(Pihrtsoft.Text.RegularExpressions.Linq.NamedBlock block)
```

### Parameters

**block** &ensp; [NamedBlock](../../NamedBlock/README.md)

An enumerated constant that identifies Unicode block\.

### Returns

[CharGrouping](../README.md)

## Append\(String\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Append_System_String_"></a>

\
Appends a pattern that matches any one of the specified characters\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Append(string characters)
```

### Parameters

**characters** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A set of Unicode characters\.

### Returns

[CharGrouping](../README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

