# Pattern\.EndLine Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EndLine()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EndLine) | Appends a pattern that is matched at the end of the string or line\. End of line is defined as the position before a linefeed\. |
| [EndLine(Boolean)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EndLine_System_Boolean_) | Appends a pattern that is matched \(before carriage return\) at the end of the string or line\. End of line is defined as the position before a linefeed\. |

## EndLine\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EndLine"></a>

\
Appends a pattern that is matched at the end of the string or line\. End of line is defined as the position before a linefeed\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern EndLine()
```

### Returns

[QuantifiablePattern](../../QuantifiablePattern/README.md)

## EndLine\(Boolean\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_EndLine_System_Boolean_"></a>

\
Appends a pattern that is matched \(before carriage return\) at the end of the string or line\. End of line is defined as the position before a linefeed\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern EndLine(bool beforeCarriageReturn)
```

### Parameters

**beforeCarriageReturn** &ensp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

Indicates whether a position of the match should be before a carriage return if present and not already consumed by regex engine\.

### Returns

[Pattern](../README.md)

