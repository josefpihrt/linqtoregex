# Pattern\.UntilChar Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [UntilChar(AsciiChar)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_UntilChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_) | Appends a pattern that matches zero or more characters until it reaches a specified character\. |
| [UntilChar(Char)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_UntilChar_System_Char_) | Appends a pattern that matches zero or more characters until it reaches a specified character\. |
| [UntilChar(CharGrouping)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_UntilChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_) | Appends a pattern that matches zero or more characters until it reaches a character that is matched by a specified [CharGrouping](../../CharGrouping/README.md)\. |
| [UntilChar(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_UntilChar_System_String_) | Appends a pattern that matches zero or more characters until it reaches any one of the specified characters\. |

## UntilChar\(AsciiChar\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_UntilChar_Pihrtsoft_Text_RegularExpressions_Linq_AsciiChar_"></a>

### Summary

Appends a pattern that matches zero or more characters until it reaches a specified character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern UntilChar(Pihrtsoft.Text.RegularExpressions.Linq.AsciiChar value)
```

### Parameters

**value**

An enumerated constant that identifies ASCII character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## UntilChar\(Char\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_UntilChar_System_Char_"></a>

### Summary

Appends a pattern that matches zero or more characters until it reaches a specified character\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern UntilChar(char value)
```

### Parameters

**value**

A Unicode character\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

## UntilChar\(CharGrouping\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_UntilChar_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_"></a>

### Summary

Appends a pattern that matches zero or more characters until it reaches a character that is matched by a specified [CharGrouping](../../CharGrouping/README.md)\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern UntilChar(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value**

A content of a character group\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## UntilChar\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_UntilChar_System_String_"></a>

### Summary

Appends a pattern that matches zero or more characters until it reaches any one of the specified characters\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern UntilChar(string characters)
```

### Parameters

**characters**

Unicode characters\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

