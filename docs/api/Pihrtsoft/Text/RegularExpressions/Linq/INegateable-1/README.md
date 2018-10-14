# INegateable\<TPattern> Interface

[Home](../../../../../README.md) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Text.RegularExpressions.Linq](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

## Summary

Supports negation of a pattern\.

```csharp
public interface INegateable<TPattern> where TPattern : Pattern
```

### Type Parameters

**TPattern**

A pattern to be negated\.

### Derived

* Pihrtsoft\.Text\.RegularExpressions\.Linq\.[Assertion](../Assertion/README.md)
* Pihrtsoft\.Text\.RegularExpressions\.Linq\.[BackAssertion](../BackAssertion/README.md)
* Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharGroup](../CharGroup/README.md)
* Pihrtsoft\.Text\.RegularExpressions\.Linq\.[CharPattern](../CharPattern/README.md)
* Pihrtsoft\.Text\.RegularExpressions\.Linq\.[WordBoundary](../WordBoundary/README.md)

## Methods

| Method | Summary |
| ------ | ------- |
| [Negate()](Negate/README.md) | Returns a pattern that is a negation of the current instance\. |

