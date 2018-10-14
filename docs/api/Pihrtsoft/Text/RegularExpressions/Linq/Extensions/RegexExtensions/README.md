# RegexExtensions Class

[Home](../../../../../../README.md) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Text.RegularExpressions.Linq.Extensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Provides a set of static methods that extends the [Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex) class\.

```csharp
public static class RegexExtensions
```

## Methods

| Method | Summary |
| ------ | ------- |
| [EnumerateCaptures(Regex, String)](EnumerateCaptures/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateCaptures_System_Text_RegularExpressions_Regex_System_String_) | Searches the specified input string and returns enumerable collection of captures\. |
| [EnumerateCaptures(Regex, String, Int32)](EnumerateCaptures/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateCaptures_System_Text_RegularExpressions_Regex_System_String_System_Int32_) | Searches the specified input string and returns enumerable collection of captures from groups that have a specified number\. |
| [EnumerateCaptures(Regex, String, String)](EnumerateCaptures/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateCaptures_System_Text_RegularExpressions_Regex_System_String_System_String_) | Searches the specified input string and returns enumerable collection of captures from groups that have a specified name\. |
| [EnumerateGroups(Regex, String)](EnumerateGroups/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateGroups_System_Text_RegularExpressions_Regex_System_String_) | Searches the specified input string and returns enumerable collection of groups\. |
| [EnumerateGroups(Regex, String, Int32)](EnumerateGroups/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateGroups_System_Text_RegularExpressions_Regex_System_String_System_Int32_) | Searches the specified input string and returns enumerable collection of groups that have a specified number\. |
| [EnumerateGroups(Regex, String, String)](EnumerateGroups/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateGroups_System_Text_RegularExpressions_Regex_System_String_System_String_) | Searches the specified input string and returns enumerable collection of groups with a specified name\. |
| [EnumerateIndexes(Regex, String)](EnumerateIndexes/README.md) | Searches the specified input string for occurrence of the specified regular expression and returns an enumerable collection of matches indexes\. |
| [EnumerateLengths(Regex, String)](EnumerateLengths/README.md) | Searches the specified input string for occurrence of the specified regular expression and returns an enumerable collection of matches lengths\. |
| [EnumerateMatches(Regex, String)](EnumerateMatches/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateMatches_System_Text_RegularExpressions_Regex_System_String_) | Searches the specified input string and returns enumerable collection of regular expression matches\. |
| [EnumerateMatches(Regex, String, Int32)](EnumerateMatches/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateMatches_System_Text_RegularExpressions_Regex_System_String_System_Int32_) | Searches the specified input string beginning at the specified position and returns enumerable collection of regular expression matches\. |
| [EnumerateMatches(Regex, String, Int32, Int32)](EnumerateMatches/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateMatches_System_Text_RegularExpressions_Regex_System_String_System_Int32_System_Int32_) | Searches the specified input string beginning at the specified position and searching only the specified number of characters and returns enumerable collection of regular expression matches\. |
| [EnumerateSplit(Regex, String)](EnumerateSplit/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_) | Splits the specified input string at the positions defined by the regular expression into an enumerable collection of strings\. |
| [EnumerateSplit(Regex, String, Int32)](EnumerateSplit/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_System_Int32_) | Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings\. |
| [EnumerateSplit(Regex, String, Int32, Int32)](EnumerateSplit/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_System_Int32_System_Int32_) | Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings\. The search starts at a specified position in the input string\. |
| [EnumerateSplit(Regex, String, Int32, Int32, SplitOptions)](EnumerateSplit/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_System_Int32_System_Int32_Pihrtsoft_Text_RegularExpressions_Linq_SplitOptions_) | Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings, using the specified split options\. The search starts at a specified position in the input string\. |
| [EnumerateSplit(Regex, String, Int32, SplitOptions)](EnumerateSplit/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_System_Int32_Pihrtsoft_Text_RegularExpressions_Linq_SplitOptions_) | Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings, using the specified split options\. |
| [EnumerateSplit(Regex, String, SplitOptions)](EnumerateSplit/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_Pihrtsoft_Text_RegularExpressions_Linq_SplitOptions_) | Splits the specified input string at the positions defined by the regular expression into an enumerable collection of strings, using the specified split options\. |
| [EnumerateSuccessGroups(Regex, String)](EnumerateSuccessGroups/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSuccessGroups_System_Text_RegularExpressions_Regex_System_String_) | Searches the specified input string and returns enumerable collection of groups that have at least one capture\. |
| [EnumerateSuccessGroups(Regex, String, Int32)](EnumerateSuccessGroups/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSuccessGroups_System_Text_RegularExpressions_Regex_System_String_System_Int32_) | Searches the specified input string and returns enumerable collection of groups that have a specified number and have at least one capture\. |
| [EnumerateSuccessGroups(Regex, String, String)](EnumerateSuccessGroups/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSuccessGroups_System_Text_RegularExpressions_Regex_System_String_System_String_) | Searches the specified input string and returns enumerable collection of groups that have a specified name and have at least one capture\. |
| [EnumerateValues(Regex, String)](EnumerateValues/README.md) | Searches the specified input string for occurrence of the specified regular expression and returns an enumerable collection of matches values\. |
| [ReplaceGroupChar(Regex, String, Char, Int32)](ReplaceGroupChar/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_ReplaceGroupChar_System_Text_RegularExpressions_Regex_System_String_System_Char_System_Int32_) | Within a specified input string, replaces all groups with the specified number that match the regular expression with a string where each character is replaced with the specified character\. |
| [ReplaceGroupChar(Regex, String, Char, String)](ReplaceGroupChar/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_ReplaceGroupChar_System_Text_RegularExpressions_Regex_System_String_System_Char_System_String_) | Within a specified input string, replaces all groups with the specified name that match the regular expression with a string where each character is replaced with the specified character\. |
| [ReplaceMatchChar(Regex, String, Char)](ReplaceMatchChar/README.md) | Within a specified input string, replaces all strings that match the regular expression with a string where each character is replaced with the specified character\. |

