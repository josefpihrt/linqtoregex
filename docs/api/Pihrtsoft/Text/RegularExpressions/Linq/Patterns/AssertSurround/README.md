# Patterns\.AssertSurround Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

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

**assertion** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content of the assertions\.

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[SurroundAssertion](../../SurroundAssertion/README.md)

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

**backAssertion** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content of the lookbehind assertion\.

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

**assertion** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content of the lookahead assertion\.

### Returns

[SurroundAssertion](../../SurroundAssertion/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**backAssertion** or **content** or **assertion** is `null`\.

