# EnumerableExtensions\.EnumerateSuccessGroups Method

[Home](../../../../../../../README.md)

**Containing Type**: [EnumerableExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EnumerateSuccessGroups(IEnumerable\<Match>)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateSuccessGroups_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__) | Returns an enumerable collection of groups that have at least one capture\. |
| [EnumerateSuccessGroups(IEnumerable\<Match>, Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateSuccessGroups_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_Int32_) | Returns an enumerable collection of groups that have a specified name and have at least one capture\. |
| [EnumerateSuccessGroups(IEnumerable\<Match>, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateSuccessGroups_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_String_) | Returns an enumerable collection of groups thas have a specified name and have at least one capture\. |

## EnumerateSuccessGroups\(IEnumerable\<Match>\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateSuccessGroups_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__"></a>

\
Returns an enumerable collection of groups that have at least one capture\.

```csharp
public static System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> EnumerateSuccessGroups(this System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match> matches)
```

### Parameters

**matches** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Match](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match)>

The sequence to enumerate\.

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**matches** is `null`\.

## EnumerateSuccessGroups\(IEnumerable\<Match>, Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateSuccessGroups_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_Int32_"></a>

\
Returns an enumerable collection of groups that have a specified name and have at least one capture\.

```csharp
public static System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> EnumerateSuccessGroups(this System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match> matches, int groupNumber)
```

### Parameters

**matches** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Match](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match)>

The sequence to enumerate\.

**groupNumber** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of the group\.

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**matches** is `null`\.

## EnumerateSuccessGroups\(IEnumerable\<Match>, String\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateSuccessGroups_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_String_"></a>

\
Returns an enumerable collection of groups thas have a specified name and have at least one capture\.

```csharp
public static System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> EnumerateSuccessGroups(this System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match> matches, string groupName)
```

### Parameters

**matches** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Match](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match)>

The sequence to enumerate\.

**groupName** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group\.

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**matches** or **groupName** is `null`\.

