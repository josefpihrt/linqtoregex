# Pattern\.Split Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Split(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Split_System_String_) | Splits the specified input string at the positions defined by the current instance\. |
| [Split(String, RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Split_System_String_System_Text_RegularExpressions_RegexOptions_) | Splits the specified input string at the positions defined by the current instance, using the specified matching options\. |

## Split\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Split_System_String_"></a>

\
Splits the specified input string at the positions defined by the current instance\.

```csharp
public string[] Split(string input)
```

### Parameters

**input** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to split\.

### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\[\]

## Split\(String, RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_Split_System_String_System_Text_RegularExpressions_RegexOptions_"></a>

\
Splits the specified input string at the positions defined by the current instance, using the specified matching options\.

```csharp
public string[] Split(string input, System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**input** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to split\.

**options** &ensp; [RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that specify options for matching\.

### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\[\]

