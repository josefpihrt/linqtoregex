# Patterns\.NotAssertSurround Method

[Home](../../../../../../README.md)

**Containing Type**: [Patterns](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NotAssertSurround(Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssertSurround_System_Object_System_Object_) | Returns a pattern that matches a specified content with negative lookbehind assertion on the left side and negative lookahead assertion on the right side\. |
| [NotAssertSurround(Object, Object, Object)](#Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssertSurround_System_Object_System_Object_System_Object_) | Returns a pattern that matches a specified content with negative lookbehind assertion on the left side and negative lookahead assertion on the right side\. |

## NotAssertSurround\(Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssertSurround_System_Object_System_Object_"></a>

### Summary

Returns a pattern that matches a specified content with negative lookbehind assertion on the left side and negative lookahead assertion on the right side\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.NegativeSurroundAssertion NotAssertSurround(object assertion, object content)
```

### Parameters

**assertion** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content of the negative assertions\.

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

### Returns

[NegativeSurroundAssertion](../../NegativeSurroundAssertion/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**assertion** **content** is `null`\.

## NotAssertSurround\(Object, Object, Object\) <a name="Pihrtsoft_Text_RegularExpressions_Linq_Patterns_NotAssertSurround_System_Object_System_Object_System_Object_"></a>

### Summary

Returns a pattern that matches a specified content with negative lookbehind assertion on the left side and negative lookahead assertion on the right side\.

```csharp
public static Pihrtsoft.Text.RegularExpressions.Linq.NegativeSurroundAssertion NotAssertSurround(object backAssertion, object content, object assertion)
```

### Parameters

**backAssertion** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content of the negative lookbehind assertion\.

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

The content to be matched\.

**assertion** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

A content of the negative lookahead assertion\.

### Returns

[NegativeSurroundAssertion](../../NegativeSurroundAssertion/README.md)

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**backAssertion** or **content** or **assertion** is `null`\.

