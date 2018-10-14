# CharGroup\.Explicit Operator

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Operator | Summary |
| -------- | ------- |
| [Explicit(CharGrouping to CharGroup)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Explicit_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping__Pihrtsoft_Text_RegularExpressions_Linq_CharGroup) | Converts specified [CharGrouping](../../CharGrouping/README.md) to an instance of the [CharGroup](../README.md) class\. |
| [Explicit(String to CharGroup)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Explicit_System_String__Pihrtsoft_Text_RegularExpressions_Linq_CharGroup) | Converts specified characters to an instance of the [CharGroup](../README.md) class\. |

## Explicit\(CharGrouping to CharGroup\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Explicit_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping__Pihrtsoft_Text_RegularExpressions_Linq_CharGroup"></a>

### Summary

Converts specified [CharGrouping](../../CharGrouping/README.md) to an instance of the [CharGroup](../README.md) class\.

```csharp
public static explicit operator CharGroup(CharGrouping value)
```

### Parameters

**value**

An instance of the [CharGrouping](../../CharGrouping/README.md) class\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../README.md)

### Exceptions

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## Explicit\(String to CharGroup\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Explicit_System_String__Pihrtsoft_Text_RegularExpressions_Linq_CharGroup"></a>

### Summary

Converts specified characters to an instance of the [CharGroup](../README.md) class\.

```csharp
public static explicit operator CharGroup(string characters)
```

### Parameters

**characters**

A set of Unicode characters\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

