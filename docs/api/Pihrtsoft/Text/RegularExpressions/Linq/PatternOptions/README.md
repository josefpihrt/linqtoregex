# PatternOptions Enum

[Home](../../../../../README.md) &#x2022; [Fields](#fields)

**Namespace**: [Pihrtsoft.Text.RegularExpressions.Linq](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Provides enumerated values to use when creating a text representation of a pattern\.

```csharp
[Flags]
public enum PatternOptions
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) &#x2192; PatternOptions

### Attributes

* [FlagsAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.flagsattribute)

## Fields

| Name | Value | Combination of | Summary |
| ---- | ----- | -------------- | ------- |
| None | 0 | | Specifies that no options are set\. |
| IfConditionWithoutAssertion | 1 | | Specifies that an if construct condition will not be expressed as an assertion\. |
| SeparateGroupNumberReference | 2 | | Specifies that an empty \(noncapturing\) group will be added after the group number backreference\. |
| Format | 4 | | Specifies that a pattern text will be formatted\. |
| Comment | 8 | | Specifies that a comment will be added to the end of each line\. This options is relevant only in combination with [PatternOptions.Format](Format/README.md) option\. |
| FormatAndComment | 12 | Format \| Comment | Indicates that the [PatternOptions.Format](Format/README.md) and [PatternOptions.Comment](Comment/README.md) options are used\. This is a composite options\. |
| CSharpLiteral | 16 | | Specifies that a pattern will be converted to C\# multiline literal\. This option cannot be used in a combination with [PatternOptions.VisualBasicLiteral](VisualBasicLiteral/README.md)\. |
| VisualBasicLiteral | 32 | | Specifies that a pattern will be converted to Visual Basic multiline literal\. This option cannot be used in a combination with [PatternOptions.CSharpLiteral](CSharpLiteral/README.md)\. |
| InlineOptions | 64 | | Specifies that current inline options will be added to each line\. This options is relevant only in combination with [PatternOptions.Format](Format/README.md) option\. |

