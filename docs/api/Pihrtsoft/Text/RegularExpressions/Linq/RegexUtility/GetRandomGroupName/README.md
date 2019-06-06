# RegexUtility\.GetRandomGroupName Method

[Home](../../../../../../README.md)

**Containing Type**: [RegexUtility](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [GetRandomGroupName()](#Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_GetRandomGroupName) | Returns randomly generated group name\. |
| [GetRandomGroupName(Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_GetRandomGroupName_System_Int32_) | Returns randomly generated group name with a specified length\. |

## GetRandomGroupName\(\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_GetRandomGroupName"></a>

\
Returns randomly generated group name\.

```csharp
public static string GetRandomGroupName()
```

### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

## GetRandomGroupName\(Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_RegexUtility_GetRandomGroupName_System_Int32_"></a>

\
Returns randomly generated group name with a specified length\.

```csharp
public static string GetRandomGroupName(int length)
```

### Parameters

**length** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

Length of a group name\.

### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Exceptions

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**length** is less than one\.

