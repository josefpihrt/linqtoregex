# Patterns\.GroupReference Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [GroupReference(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_GroupReference_System_Int32_) | Returns a pattern that matches previously defined numbered group\. |
| [GroupReference(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_GroupReference_System_String_) | Returns a pattern that matches previously defined named group\. |

## GroupReference\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_GroupReference_System_Int32_"></a>

### Summary

Returns a pattern that matches previously defined numbered group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern GroupReference(int groupNumber)
```

### Parameters

**groupNumber**

A number of the group\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**groupNumber** is less than zero\.

## GroupReference\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_GroupReference_System_String_"></a>

### Summary

Returns a pattern that matches previously defined named group\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.QuantifiablePattern GroupReference(string groupName)
```

### Parameters

**groupName**

A name of the group\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**groupName** is not a valid regex group name\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**groupName** is `null`\.

