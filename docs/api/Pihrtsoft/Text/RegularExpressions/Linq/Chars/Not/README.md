# Chars\.Not Method

[Home](../../../../../../README.md)

**Containing Type**: [Chars](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Not(GeneralCategory)](#Pihrtsoft_Text_RegularExpressions_Linq_Chars_Not_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Returns a pattern that matches a character that is not from the specified Unicode category\. |
| [Not(NamedBlock)](#Pihrtsoft_Text_RegularExpressions_Linq_Chars_Not_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Returns a pattern that matches a character that is not from the specified Unicode block\. |

## Not\(GeneralCategory\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Chars_Not_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

\
Returns a pattern that matches a character that is not from the specified Unicode category\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Not(Pihrtsoft.Text.RegularExpressions.Linq.GeneralCategory category)
```

### Parameters

**category** &ensp; [GeneralCategory](../../GeneralCategory/README.md)

An enumerated constant that identifies Unicode category\.

### Returns

[CharGrouping](../../CharGrouping/README.md)

## Not\(NamedBlock\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Chars_Not_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

\
Returns a pattern that matches a character that is not from the specified Unicode block\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Not(Pihrtsoft.Text.RegularExpressions.Linq.NamedBlock block)
```

### Parameters

**block** &ensp; [NamedBlock](../../NamedBlock/README.md)

An enumerated constant that identifies Unicode block\.

### Returns

[CharGrouping](../../CharGrouping/README.md)

