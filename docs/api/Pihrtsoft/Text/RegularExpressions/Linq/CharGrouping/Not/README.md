# CharGrouping\.Not Method

[Home](../../../../../../README.md)

**Containing Type**: [CharGrouping](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Not(GeneralCategory)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Not_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_) | Appends a pattern that matches a character that is not from the specified Unicode category\. |
| [Not(NamedBlock)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Not_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_) | Appends a pattern that matches a character that is not from the specified Unicode block\. |

## Not\(GeneralCategory\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Not_Pihrtsoft_Text_RegularExpressions_Linq_GeneralCategory_"></a>

\
Appends a pattern that matches a character that is not from the specified Unicode category\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Not(Pihrtsoft.Text.RegularExpressions.Linq.GeneralCategory category)
```

### Parameters

**category** &ensp; [GeneralCategory](../../GeneralCategory/README.md)

An enumerated constant that identifies Unicode category\.

### Returns

[CharGrouping](../README.md)

## Not\(NamedBlock\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping_Not_Pihrtsoft_Text_RegularExpressions_Linq_NamedBlock_"></a>

\
Appends a pattern that matches a character that is not from the specified Unicode block\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping Not(Pihrtsoft.Text.RegularExpressions.Linq.NamedBlock block)
```

### Parameters

**block** &ensp; [NamedBlock](../../NamedBlock/README.md)

An enumerated constant that identifies Unicode block\.

### Returns

[CharGrouping](../README.md)

