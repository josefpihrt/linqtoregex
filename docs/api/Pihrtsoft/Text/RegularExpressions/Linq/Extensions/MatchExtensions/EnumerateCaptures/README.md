# MatchExtensions\.EnumerateCaptures Method

[Home](../../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.Extensions\.[MatchExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EnumerateCaptures(Match)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_MatchExtensions_EnumerateCaptures_System_Text_RegularExpressions_Match_) | Enumerates through groups of a specified match and returns each capture from each group\. |
| [EnumerateCaptures(Match, Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_MatchExtensions_EnumerateCaptures_System_Text_RegularExpressions_Match_System_Int32_) | Returns an enumerable collection of captures of a group with a specified number that is from a specified match\. |
| [EnumerateCaptures(Match, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_MatchExtensions_EnumerateCaptures_System_Text_RegularExpressions_Match_System_String_) | Returns an enumerable collection of captures of a group with a specified name that is from a specified match\. |

## EnumerateCaptures\(Match\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_MatchExtensions_EnumerateCaptures_System_Text_RegularExpressions_Match_"></a>

### Summary

Enumerates through groups of a specified match and returns each capture from each group\.

```csharp
public static IEnumerable<Capture> EnumerateCaptures(this Match match)
```

### Parameters

**match**

A regular expression match\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**match** is `null`\.

## EnumerateCaptures\(Match, Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_MatchExtensions_EnumerateCaptures_System_Text_RegularExpressions_Match_System_Int32_"></a>

### Summary

Returns an enumerable collection of captures of a group with a specified number that is from a specified match\.

```csharp
public static IEnumerable<Capture> EnumerateCaptures(this Match match, int groupNumber)
```

### Parameters

**match**

A regular expression match\.

**groupNumber**

A number of the group\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**match** is `null`\.

## EnumerateCaptures\(Match, String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_MatchExtensions_EnumerateCaptures_System_Text_RegularExpressions_Match_System_String_"></a>

### Summary

Returns an enumerable collection of captures of a group with a specified name that is from a specified match\.

```csharp
public static IEnumerable<Capture> EnumerateCaptures(this Match match, string groupName)
```

### Parameters

**match**

A regular expression match\.

**groupName**

A name of the group\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**match** or **groupName** is `null`\.

