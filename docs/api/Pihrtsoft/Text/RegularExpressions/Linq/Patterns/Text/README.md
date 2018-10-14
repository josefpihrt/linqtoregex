# Patterns\.Text Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Text(String)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Text_System_String_) | Returns a pattern that matches a specified text\. |
| [Text(String, Boolean)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Text_System_String_System_Boolean_) | Returns a pattern that matches a specified text, ignoring or honoring its case\. |

## Text\(String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Text_System_String_"></a>

### Summary

Returns a pattern that matches a specified text\.

```csharp
public static Pattern Text(string value)
```

### Parameters

**value**

A text to append\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Pattern](../../Pattern/README.md)

## Text\(String, Boolean\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_Text_System_String_System_Boolean_"></a>

### Summary

Returns a pattern that matches a specified text, ignoring or honoring its case\.

```csharp
public static QuantifiablePattern Text(string value, bool ignoreCase)
```

### Parameters

**value**

A text to append\.

**ignoreCase**

true to ignore case during the matching; otherwise, false\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[QuantifiablePattern](../../QuantifiablePattern/README.md)

