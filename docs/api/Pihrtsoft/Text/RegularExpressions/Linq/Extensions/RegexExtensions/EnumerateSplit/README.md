# RegexExtensions\.EnumerateSplit Method

[Home](../../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.Extensions\.[RegexExtensions](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EnumerateSplit(Regex, String)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_) | Splits the specified input string at the positions defined by the regular expression into an enumerable collection of strings\. |
| [EnumerateSplit(Regex, String, Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_System_Int32_) | Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings\. |
| [EnumerateSplit(Regex, String, Int32, Int32)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_System_Int32_System_Int32_) | Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings\. The search starts at a specified position in the input string\. |
| [EnumerateSplit(Regex, String, Int32, Int32, SplitOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_System_Int32_System_Int32_Pihrtsoft_Text_RegularExpressions_Linq_SplitOptions_) | Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings, using the specified split options\. The search starts at a specified position in the input string\. |
| [EnumerateSplit(Regex, String, Int32, SplitOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_System_Int32_Pihrtsoft_Text_RegularExpressions_Linq_SplitOptions_) | Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings, using the specified split options\. |
| [EnumerateSplit(Regex, String, SplitOptions)](#Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_Pihrtsoft_Text_RegularExpressions_Linq_SplitOptions_) | Splits the specified input string at the positions defined by the regular expression into an enumerable collection of strings, using the specified split options\. |

## EnumerateSplit\(Regex, String\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_"></a>

### Summary

Splits the specified input string at the positions defined by the regular expression into an enumerable collection of strings\.

```csharp
public static System.Collections.Generic.IEnumerable<string> EnumerateSplit(this System.Text.RegularExpressions.Regex regex, string input)
```

### Parameters

**regex** &emsp; System\.Text\.RegularExpressions\.[Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex)

The regular expression to be matched\.

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to split\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**regex** or **input** is `null`\.

## EnumerateSplit\(Regex, String, Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_System_Int32_"></a>

### Summary

Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings\.

```csharp
public static System.Collections.Generic.IEnumerable<string> EnumerateSplit(this System.Text.RegularExpressions.Regex regex, string input, int count)
```

### Parameters

**regex** &emsp; System\.Text\.RegularExpressions\.[Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex)

The regular expression to be matched\.

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to split\.

**count** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

The maximum number of times the input can be split\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**regex** or **input** is `null`\.

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**count** is less than zero\.

## EnumerateSplit\(Regex, String, Int32, Int32\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_System_Int32_System_Int32_"></a>

### Summary

Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings\.
The search starts at a specified position in the input string\.

```csharp
public static System.Collections.Generic.IEnumerable<string> EnumerateSplit(this System.Text.RegularExpressions.Regex regex, string input, int count, int startAt)
```

### Parameters

**regex** &emsp; System\.Text\.RegularExpressions\.[Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex)

The regular expression to be matched\.

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to split\.

**count** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

The maximum number of times the input can be split\.

**startAt** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

The position in the input string where the search starts\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**regex** or **input** is `null`\.

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**count** is less than zero\.


**startAt** is less than zero or greater than the length of **input**\.



## EnumerateSplit\(Regex, String, Int32, Int32, SplitOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_System_Int32_System_Int32_Pihrtsoft_Text_RegularExpressions_Linq_SplitOptions_"></a>

### Summary

Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings, using the specified split options\.
The search starts at a specified position in the input string\.

```csharp
public static System.Collections.Generic.IEnumerable<string> EnumerateSplit(this System.Text.RegularExpressions.Regex regex, string input, int count, int startAt, Pihrtsoft.Text.RegularExpressions.Linq.SplitOptions splitOptions)
```

### Parameters

**regex** &emsp; System\.Text\.RegularExpressions\.[Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex)

The regular expression to be matched\.

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to split\.

**count** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

The maximum number of times the input can be split\.

**startAt** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

The position in the input string where the search starts\.

**splitOptions** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[SplitOptions](../../../SplitOptions/README.md)

A bitwise combination of the enumeration values that specify options\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**regex** or **input** is `null`\.

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**count** is less than zero\.


**startAt** is less than zero or greater than the length of **input**\.



## EnumerateSplit\(Regex, String, Int32, SplitOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_System_Int32_Pihrtsoft_Text_RegularExpressions_Linq_SplitOptions_"></a>

### Summary

Splits the specified input string a specified number of times at the positions defined by the regular expression into an enumerable collection of strings, using the specified split options\.

```csharp
public static System.Collections.Generic.IEnumerable<string> EnumerateSplit(this System.Text.RegularExpressions.Regex regex, string input, int count, Pihrtsoft.Text.RegularExpressions.Linq.SplitOptions splitOptions)
```

### Parameters

**regex** &emsp; System\.Text\.RegularExpressions\.[Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex)

The regular expression to be matched\.

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to split\.

**count** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

The maximum number of times the input can be split\.

**splitOptions** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[SplitOptions](../../../SplitOptions/README.md)

A bitwise combination of the enumeration values that specify options\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**regex** or **input** is `null`\.

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)

**count** is less than zero\.

## EnumerateSplit\(Regex, String, SplitOptions\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Extensions_RegexExtensions_EnumerateSplit_System_Text_RegularExpressions_Regex_System_String_Pihrtsoft_Text_RegularExpressions_Linq_SplitOptions_"></a>

### Summary

Splits the specified input string at the positions defined by the regular expression into an enumerable collection of strings, using the specified split options\.

```csharp
public static System.Collections.Generic.IEnumerable<string> EnumerateSplit(this System.Text.RegularExpressions.Regex regex, string input, Pihrtsoft.Text.RegularExpressions.Linq.SplitOptions splitOptions)
```

### Parameters

**regex** &emsp; System\.Text\.RegularExpressions\.[Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex)

The regular expression to be matched\.

**input** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to split\.

**splitOptions** &emsp; Pihrtsoft\.Text\.RegularExpressions\.Linq\.[SplitOptions](../../../SplitOptions/README.md)

A bitwise combination of the enumeration values that specify options\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)>

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**regex** or **input** is `null`\.

