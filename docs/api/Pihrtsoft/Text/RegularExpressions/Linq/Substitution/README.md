# Substitution Class

[Home](../../../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Methods](#methods) &#x2022; [Operators](#operators)

**Namespace**: [Pihrtsoft.Text.RegularExpressions.Linq](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Represents a base class for a substitution in the replacement pattern\. This class is abstract\.

```csharp
public abstract class Substitution
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; Substitution

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [Substitution()](-ctor/README.md) | Initializes a new instance of the [Substitution](./README.md) class\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [AfterMatch()](AfterMatch/README.md) | Appends a substitution pattern that substitutes all the text of the input string after the match\. |
| [BeforeMatch()](BeforeMatch/README.md) | Appends a substitution pattern that substitutes all the text of the input string before the match\. |
| [EntireInput()](EntireInput/README.md) | Appends a substitution pattern that substitutes the entire input string\. |
| [EntireMatch()](EntireMatch/README.md) | Appends a substitution pattern that substitutes the entire match\. |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Group(Int32)](Group/README.md) | Appends a substitution pattern that substitutes the last substring matched by the numbered or named group\. |
| [LastCapturedGroup()](LastCapturedGroup/README.md) | Appends a substitution pattern that substitutes the last captured group\. |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [NamedGroup(String)](NamedGroup/README.md) | Appends a substitution pattern that substitutes the last substring matched by the named group\. |
| [Text(Char)](Text/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Substitution_Text_System_Char_) | Appends a specified character to the substitution pattern\. |
| [Text(String)](Text/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Substitution_Text_System_String_) | Appends a specified text to the substitution pattern\. |
| [ToString()](ToString/README.md) | Converts the value of this instance to a [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)\. \(Overrides [Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring)\) |

## Operators

| Operator | Summary |
| -------- | ------- |
| [Addition(Char, Substitution)](op_Addition/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_System_Char_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_) | Concatenate two elements into a new [Substitution](./README.md)\. |
| [Addition(String, Substitution)](op_Addition/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_System_String_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_) | Concatenate two elements into a new [Substitution](./README.md)\. |
| [Addition(Substitution, Char)](op_Addition/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_System_Char_) | Concatenate two elements into a new [Substitution](./README.md)\. |
| [Addition(Substitution, String)](op_Addition/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_System_String_) | Concatenate two elements into a new [Substitution](./README.md)\. |
| [Addition(Substitution, Substitution)](op_Addition/README.md#Pihrtsoft_Text_RegularExpressions_Linq_Substitution_op_Addition_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_Pihrtsoft_Text_RegularExpressions_Linq_Substitution_) | Concatenate two elements into a new [Substitution](./README.md)\. |

