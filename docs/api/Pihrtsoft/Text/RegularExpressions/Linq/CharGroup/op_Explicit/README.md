# CharGroup\.Explicit Operator

[Home](../../../../../../README.md)

**Containing Type**: [CharGroup](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Operator | Summary |
| -------- | ------- |
| [Explicit(CharGrouping to CharGroup)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Explicit_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping__Pihrtsoft_Text_RegularExpressions_Linq_CharGroup) | Converts specified [CharGrouping](../../CharGrouping/README.md) to an instance of the [CharGroup](../README.md) class\. |
| [Explicit(String to CharGroup)](#Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Explicit_System_String__Pihrtsoft_Text_RegularExpressions_Linq_CharGroup) | Converts specified characters to an instance of the [CharGroup](../README.md) class\. |

## Explicit\(CharGrouping to CharGroup\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Explicit_Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping__Pihrtsoft_Text_RegularExpressions_Linq_CharGroup"></a>

\
Converts specified [CharGrouping](../../CharGrouping/README.md) to an instance of the [CharGroup](../README.md) class\.

```csharp
public static explicit operator Pihrtsoft.Text.RegularExpressions.Linq.CharGroup(Pihrtsoft.Text.RegularExpressions.Linq.CharGrouping value)
```

### Parameters

**value** &ensp; [CharGrouping](../../CharGrouping/README.md)

An instance of the [CharGrouping](../../CharGrouping/README.md) class\.

### Returns

[CharGroup](../README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**value** is `null`\.

## Explicit\(String to CharGroup\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_CharGroup_op_Explicit_System_String__Pihrtsoft_Text_RegularExpressions_Linq_CharGroup"></a>

\
Converts specified characters to an instance of the [CharGroup](../README.md) class\.

```csharp
public static explicit operator Pihrtsoft.Text.RegularExpressions.Linq.CharGroup(string characters)
```

### Parameters

**characters** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

A set of Unicode characters\.

### Returns

[CharGroup](../README.md)

### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**characters** length is equal to zero\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**characters** is `null`\.

