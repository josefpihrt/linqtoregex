# Patterns\.EndInputOrLine Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EndInputOrLine()](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_EndInputOrLine) | Returns a pattern that is matched at the end of the string \(or line if the [RegexOptions.Multiline](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions.multiline) option is applied\)\. End of line is defined as the position before a linefeed\. |
| [EndInputOrLine(Boolean)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_EndInputOrLine_System_Boolean_) | Returns a pattern that is matched \(before carriage return\) at the end of the string \(or \(before carriage return\) at the end of line if the [RegexOptions.Multiline](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions.multiline) option is applied\)\. End of line is defined as the position before a linefeed\. |

## EndInputOrLine\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_EndInputOrLine"></a>

\
Returns a pattern that is matched at the end of the string \(or line if the [RegexOptions.Multiline](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions.multiline) option is applied\)\. End of line is defined as the position before a linefeed\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern EndInputOrLine()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## EndInputOrLine\(Boolean\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_EndInputOrLine_System_Boolean_"></a>

\
Returns a pattern that is matched \(before carriage return\) at the end of the string \(or \(before carriage return\) at the end of line if the [RegexOptions.Multiline](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regexoptions.multiline) option is applied\)\. End of line is defined as the position before a linefeed\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern EndInputOrLine(bool beforeCarriageReturn)
```

### Parameters

**beforeCarriageReturn** &ensp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

Indicates whether a position of the match should be before a carriage return if present and not already consumed by regex engine

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

