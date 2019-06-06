# GroupEvaluator Delegate

[Home](../../../../../README.md)

**Namespace**: [Pihrtsoft.Text.RegularExpressions.Linq](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Represents the method that is called each time a regular expression group is found during a Replace method operation\.

```csharp
public delegate string GroupEvaluator(System.Text.RegularExpressions.Group group)
```

### Parameters

**group** &ensp; [Group](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.group)

### Return Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [Delegate](https://docs.microsoft.com/en-us/dotnet/api/system.delegate) &#x2192; [MulticastDelegate](https://docs.microsoft.com/en-us/dotnet/api/system.multicastdelegate) &#x2192; GroupEvaluator
