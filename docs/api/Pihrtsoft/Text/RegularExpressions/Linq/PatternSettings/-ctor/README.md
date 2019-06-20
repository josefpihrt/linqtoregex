# PatternSettings Constructors

[Home](../../../../../../README.md)

**Containing Type**: [PatternSettings](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Constructor | Summary |
| ----------- | ------- |
| [PatternSettings()](#Pihrtsoft_Text_RegularExpressions_Linq_PatternSettings__ctor) | Initializes a new instance of the [PatternSettings](../README.md) class\. |
| [PatternSettings(PatternOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_PatternSettings__ctor_Pihrtsoft_Text_RegularExpressions_Linq_PatternOptions_) | Initializes a new instance of the [PatternSettings](../README.md) class with a specified options\. |

## PatternSettings\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_PatternSettings__ctor"></a>

\
Initializes a new instance of the [PatternSettings](../README.md) class\.

```csharp
public PatternSettings()
```

## PatternSettings\(PatternOptions\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_PatternSettings__ctor_Pihrtsoft_Text_RegularExpressions_Linq_PatternOptions_"></a>

\
Initializes a new instance of the [PatternSettings](../README.md) class with a specified options\.

```csharp
public PatternSettings(Pihrtsoft.Text.RegularExpressions.Linq.PatternOptions options)
```

### Parameters

**options** &ensp; [PatternOptions](../../PatternOptions/README.md)

A bitwise combination of the enumeration values\.

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**options** has both [PatternOptions.CSharpLiteral](../../PatternOptions/CSharpLiteral/README.md) flag and [PatternOptions.VisualBasicLiteral](../../PatternOptions/VisualBasicLiteral/README.md) flag set\.

