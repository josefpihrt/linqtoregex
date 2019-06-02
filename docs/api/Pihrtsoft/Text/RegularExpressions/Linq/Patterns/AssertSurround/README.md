# Patterns\.AssertSurround Method

[Home](../../../../../../README.md)

**Containing Type**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [AssertSurround(Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AssertSurround_System_Object_System_Object_) | Returns a pattern that matches a specified content with lookbehind assertion on the left side and lookahead assertion on the right side\. |
| [AssertSurround(Object, Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AssertSurround_System_Object_System_Object_System_Object_) | Returns a pattern that matches a specified content with lookbehind assertion on the left side and lookahead assertion on the right side\. |

## AssertSurround\(Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AssertSurround_System_Object_System_Object_"></a>

### Summary

Returns a pattern that matches a specified content with lookbehind assertion on the left side and lookahead assertion on the right side\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.SurroundAssertion AssertSurround(object assertion, object content)
```

### Parameters

**assertion** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content of the assertions\.

**content** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[SurroundAssertion](../../SurroundAssertion/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**assertion** **content** is `null`\.

## AssertSurround\(Object, Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_AssertSurround_System_Object_System_Object_System_Object_"></a>

### Summary

Returns a pattern that matches a specified content with lookbehind assertion on the left side and lookahead assertion on the right side\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.SurroundAssertion AssertSurround(object backAssertion, object content, object assertion)
```

### Parameters

**backAssertion** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content of the lookbehind assertion\.

**content** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

**assertion** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content of the lookahead assertion\.

### Returns

Pihrtsoft\.Text\.RegularExpressions\.Linq\.[SurroundAssertion](../../SurroundAssertion/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**backAssertion** or **content** or **assertion** is `null`\.

