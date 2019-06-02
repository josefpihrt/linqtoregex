# Chars\.Not Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Chars](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Not(GeneralCategory)](#Pihrtsoft_Text_RegularExpressions_Linq_Chars_Not_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Returns a pattern that matches a character that is not from the specified Unicode category\. |
| [Not(NamedBlock)](#Pihrtsoft_Text_RegularExpressions_Linq_Chars_Not_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Returns a pattern that matches a character that is not from the specified Unicode block\. |

## Not\(GeneralCategory\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Chars_Not_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

### Summary

Returns a pattern that matches a character that is not from the specified Unicode category\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Not(Pihrtsoft.Text.RegularExpressions.Linq.GeneralCategory category)
```

### Parameters

**category**

An enumerated constant that identifies Unicode category\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGrouping](../../CharGrouping/README.md)

## Not\(NamedBlock\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Chars_Not_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

### Summary

Returns a pattern that matches a character that is not from the specified Unicode block\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Not(Pihrtsoft.Text.RegularExpressions.Linq.NamedBlock block)
```

### Parameters

**block**

An enumerated constant that identifies Unicode block\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGrouping](../../CharGrouping/README.md)

