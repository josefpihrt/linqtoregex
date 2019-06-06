# Pattern\.ToRegex Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ToRegex()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_ToRegex) | Compiles a new instance of the [Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex) class for the current instance\. |
| [ToRegex(RegexOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_ToRegex_System_Text_RegularExpressions_RegexOptions_) | Compiles a new instance of the [Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex) class for the current instance, with options that modify the pattern\. |

## ToRegex\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_ToRegex"></a>

\
Compiles a new instance of the [Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex) class for the current instance\.

```csharp
public System.Text.RegularExpressions.Regex ToRegex()
```

### Returns

[Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex)

## ToRegex\(RegexOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_ToRegex_System_Text_RegularExpressions_RegexOptions_"></a>

\
Compiles a new instance of the [Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex) class for the current instance, with options that modify the pattern\.

```csharp
public System.Text.RegularExpressions.Regex ToRegex(System.Text.RegularExpressions.RegexOptions options)
```

### Parameters

**options** &ensp; [RegexOptions](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions)

A bitwise combination of the enumeration values that modify the regular expression\.

### Returns

[Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex)

