# MatchExtensions\.Group Method

[Home](../../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.Extensions\.[MatchExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Group(Match, Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_MatchExtensions_Group_System_Text_RegularExpressions_Match_System_Int32_) | Returns a group that has a specified number and it is contained in a specified match\. |
| [Group(Match, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_MatchExtensions_Group_System_Text_RegularExpressions_Match_System_String_) | Returns a group that has a specified name and it is contained in a specified match\. |

## Group\(Match, Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_MatchExtensions_Group_System_Text_RegularExpressions_Match_System_Int32_"></a>

### Summary

Returns a group that has a specified number and it is contained in a specified match\.

```csharp
public static Group Group(this Match match, int groupNumber)
```

### Parameters

**match**

A regular expression match\.

**groupNumber**

A number of the group\.

### Returns

System\.Text\.RegularExpressions\.[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**match** is `null`\.

## Group\(Match, String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_MatchExtensions_Group_System_Text_RegularExpressions_Match_System_String_"></a>

### Summary

Returns a group that has a specified name and it is contained in a specified match\.

```csharp
public static Group Group(this Match match, string groupName)
```

### Parameters

**match**

A regular expression match\.

**groupName**

A name of the group\.

### Returns

System\.Text\.RegularExpressions\.[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**match** is `null`\.

