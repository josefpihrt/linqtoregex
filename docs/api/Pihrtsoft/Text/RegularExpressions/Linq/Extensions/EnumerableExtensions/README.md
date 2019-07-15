# EnumerableExtensions Class

[Home](../../../../../../README.md) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Text.RegularExpressions.Linq.Extensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Provides a set of static methods that extends the [IEnumerable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1) whose generic type argument is [Match](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match) or [Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)\.

```csharp
public static class EnumerableExtensions
```

## Methods

| Method | Summary |
| ------ | ------- |
| [EnumerateCaptures(IEnumerable\<Group>)](EnumerateCaptures/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateCaptures_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Group__) | Returns an enumerable collection of captures\. |
| [EnumerateCaptures(IEnumerable\<Match>)](EnumerateCaptures/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateCaptures_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__) | Returns an enumerable collection of captures\. |
| [EnumerateCaptures(IEnumerable\<Match>, Int32)](EnumerateCaptures/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateCaptures_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_Int32_) | Returns an enumerable collection of captures from groups that have a specified number\. |
| [EnumerateCaptures(IEnumerable\<Match>, String)](EnumerateCaptures/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateCaptures_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_String_) | Returns an enumerable collection of captures from groups thas have a specified name\. |
| [EnumerateGroups(IEnumerable\<Match>)](EnumerateGroups/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateGroups_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__) | Returns an enumerable collection of groups\. |
| [EnumerateGroups(IEnumerable\<Match>, Int32)](EnumerateGroups/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateGroups_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_Int32_) | Returns an enumerable collection of groups with a specified number\. |
| [EnumerateGroups(IEnumerable\<Match>, String)](EnumerateGroups/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateGroups_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_String_) | Returns an enumerable collection of groups with a specified name\. |
| [EnumerateIndexes(IEnumerable\<Capture>)](EnumerateIndexes/README.md) | Returns an enumerable collection of captures indexes\. |
| [EnumerateLengths(IEnumerable\<Capture>)](EnumerateLengths/README.md) | Returns enumerable collection of captures lengths\. |
| [EnumerateSuccessGroups(IEnumerable\<Match>)](EnumerateSuccessGroups/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateSuccessGroups_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__) | Returns an enumerable collection of groups that have at least one capture\. |
| [EnumerateSuccessGroups(IEnumerable\<Match>, Int32)](EnumerateSuccessGroups/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateSuccessGroups_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_Int32_) | Returns an enumerable collection of groups that have a specified name and have at least one capture\. |
| [EnumerateSuccessGroups(IEnumerable\<Match>, String)](EnumerateSuccessGroups/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateSuccessGroups_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_String_) | Returns an enumerable collection of groups thas have a specified name and have at least one capture\. |
| [EnumerateValues(IEnumerable\<Capture>)](EnumerateValues/README.md) | Returns enumerable collection of captures values\. |

