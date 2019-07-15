# RegexUtility Class

[Home](../../../../../README.md) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Text.RegularExpressions.Linq](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Provides static methods for escaping and validating regular expressions elements\.

```csharp
public static class RegexUtility
```

## Methods

| Method | Summary |
| ------ | ------- |
| [Escape(Char)](Escape/README.md#Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_Escape_System_Char_) | Converts a specified character to the [String](https://docs.microsoft.com/en-us/dotnet/api/system.string) object that represents the character as a literal rather than a metacharacter\. The character is considered not to be in the character group\. |
| [Escape(Char, Boolean)](Escape/README.md#Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_Escape_System_Char_System_Boolean_) | Converts a specified character to the [String](https://docs.microsoft.com/en-us/dotnet/api/system.string) object that represents the character as a literal rather than a metacharacter\. |
| [Escape(String)](Escape/README.md#Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_Escape_System_String_) | Converts a specified text to the [String](https://docs.microsoft.com/en-us/dotnet/api/system.string) object that represents each character as a literal rather than a metacharacter\. The text is considered not to be in the character group\. |
| [Escape(String, Boolean)](Escape/README.md#Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_Escape_System_String_System_Boolean_) | Converts a specified input to the [String](https://docs.microsoft.com/en-us/dotnet/api/system.string) object that represents each character as a literal rather than a metacharacter\. |
| [EscapeSubstitution(String)](EscapeSubstitution/README.md) | Escapes all dollar signs by doubling them\. |
| [GetBlockDescription(NamedBlock)](GetBlockDescription/README.md) | Gets a description of the specified Unicode block\. |
| [GetBlockDesignation(NamedBlock)](GetBlockDesignation/README.md) | Gets a designation of the specified Unicode block\. |
| [GetCategoryDescription(GeneralCategory)](GetCategoryDescription/README.md) | Gets a description of the specified Unicode category\. |
| [GetCategoryDesignation(GeneralCategory)](GetCategoryDesignation/README.md) | Gets a designation of the specified Unicode category\. |
| [GetEscapeMode(Char)](GetEscapeMode/README.md#Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_GetEscapeMode_System_Char_) | Gets a value indicating how a specified character is represented in the regular expression pattern\. |
| [GetEscapeMode(Char, Boolean)](GetEscapeMode/README.md#Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_GetEscapeMode_System_Char_System_Boolean_) | Gets a value indicating how a specified character is represented in the regular expression pattern, specifying whether the character is inside or outside of the character group\. |
| [GetRandomGroupName()](GetRandomGroupName/README.md#Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_GetRandomGroupName) | Returns randomly generated group name\. |
| [GetRandomGroupName(Int32)](GetRandomGroupName/README.md#Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_GetRandomGroupName_System_Int32_) | Returns randomly generated group name with a specified length\. |
| [IsValidGroupName(String)](IsValidGroupName/README.md) | Gets a value indicating whether the specified group name is a valid name of a regex group\. |
| [IsValidInlineOptions(RegexOptions)](IsValidInlineOptions/README.md) | Gets a value indicating whether the **options** can be expressed as inline char\(s\)\. |

