# Pattern\.SurroundParentheses Method

[Home](../../../../../../README.md)

**Containing Type**: [Pattern](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SurroundParentheses()](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundParentheses) | Appends a pattern that matches a text consisting of a left parenthesis and a right parenthesis, allowing zero or more characters that are not a right parenthesis between the parentheses\. |
| [SurroundParentheses(Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundParentheses_System_Object_) | Appends a pattern that matches specified pattern surrounded with left and right parenthesis\. |
| [SurroundParentheses(Object\[\])](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundParentheses_System_Object___) | Appends a pattern that matches specified content surrounded with left and right parenthesis\. |

## SurroundParentheses\(\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundParentheses"></a>

\
Appends a pattern that matches a text consisting of a left parenthesis and a right parenthesis, allowing zero or more characters that are not a right parenthesis between the parentheses\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundParentheses()
```

### Returns

[Pattern](../README.md)

## SurroundParentheses\(Object\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundParentheses_System_Object_"></a>

\
Appends a pattern that matches specified pattern surrounded with left and right parenthesis\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundParentheses(object content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[Pattern](../README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

## SurroundParentheses\(Object\[\]\) <a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern_SurroundParentheses_System_Object___"></a>

\
Appends a pattern that matches specified content surrounded with left and right parenthesis\.

```csharp
public Pihrtsoft.Text.RegularExpressions.Linq.Pattern SurroundParentheses(params object[] content)
```

### Parameters

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

An object array that contains zero or more patterns any one of which has to be matched\.

### Returns

[Pattern](../README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**content** is `null`\.

