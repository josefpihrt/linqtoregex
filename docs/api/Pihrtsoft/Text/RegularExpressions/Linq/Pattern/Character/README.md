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
public QuantifiablePattern Character(AsciiChar value)
```

### Parameters

**value**

An enumerated constant that identifies ASCII character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Character\(GeneralCategory\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

### Summary

Appends a pattern that matches a character from a specified Unicode category\.

```csharp
public QuantifiablePattern Character(GeneralCategory category)
```

### Parameters

**category**

An enumerated constant that identifies Unicode category\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Character\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_System_Char_"></a>

### Summary

Appends a pattern that matches a specified character\.

```csharp
public QuantifiablePattern Character(char value)
```

### Parameters

**value**

A Unicode character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Character\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

### Summary

Appends a pattern that matches a character from a specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public QuantifiablePattern Character(CharGrouping value)
```

### Parameters

**value**

A content of a character group\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## Character\(NamedBlock\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

### Summary

Appends a pattern that matches a character from a specified Unicode block\.

```csharp
public QuantifiablePattern Character(NamedBlock block)
```

### Parameters

**block**

An enumerated constant that identifies Unicode block\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## Character\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Character_System_String_"></a>

### Summary

Appends a pattern that matches a character from a specified [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\.

```csharp
public QuantifiablePattern Character(string characters)
```

### Parameters

**characters**

A set of characters any one of which has to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

