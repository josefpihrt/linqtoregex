# EnumerableExtensions\.EnumerateCaptures Method

[Home](../../../../../../../README.md)

**Containing Type**: [EnumerableExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EnumerateCaptures(IEnumerable\<Group>)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateCaptures_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Group__) | Returns an enumerable collection of captures\. |
| [EnumerateCaptures(IEnumerable\<Match>)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateCaptures_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__) | Returns an enumerable collection of captures\. |
| [EnumerateCaptures(IEnumerable\<Match>, Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateCaptures_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_Int32_) | Returns an enumerable collection of captures from groups that have a specified number\. |
| [EnumerateCaptures(IEnumerable\<Match>, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateCaptures_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_String_) | Returns an enumerable collection of captures from groups thas have a specified name\. |

## EnumerateCaptures\(IEnumerable\<Group>\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateCaptures_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Group__"></a>

\
Returns an enumerable collection of captures\.

```csharp
public static System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture> EnumerateCaptures(this System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> groups)
```

### Parameters

**groups** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)>

The sequence to enumerate\.

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groups** is `null`\.

## EnumerateCaptures\(IEnumerable\<Match>\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateCaptures_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__"></a>

\
Returns an enumerable collection of captures\.

```csharp
public static System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture> EnumerateCaptures(this System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match> matches)
```

### Parameters

**matches** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Match](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match)>

The sequence to enumerate\.

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**matches** is `null`\.

## EnumerateCaptures\(IEnumerable\<Match>, Int32\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateCaptures_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_Int32_"></a>

\
Returns an enumerable collection of captures from groups that have a specified number\.

```csharp
public static System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture> EnumerateCaptures(this System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match> matches, int groupNumber)
```

### Parameters

**matches** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Match](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match)>

The sequence to enumerate\.

**groupNumber** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A number of the group\.

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**matches** is `null`\.

## EnumerateCaptures\(IEnumerable\<Match>, String\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_EnumerableExtensions_EnumerateCaptures_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Match__System_String_"></a>

\
Returns an enumerable collection of captures from groups thas have a specified name\.

```csharp
public static System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture> EnumerateCaptures(this System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match> matches, string groupName)
```

### Parameters

**matches** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Match](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match)>

The sequence to enumerate\.

**groupName** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A name of the group\.

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Capture](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.capture)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**matches** or **groupName** is `null`\.

