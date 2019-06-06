# INegateable\<TPattern> Interface

[Home](../../../../../README.md) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Text.RegularExpressions.Linq](../README.md)

**Assembly**: Pihrtsoft\.Text\.RegularExpressions\.Linq\.dll

\
Supports negation of a pattern\.

```csharp
public interface INegateable<TPattern> where TPattern : Pihrtsoft.Text.RegularExpressions.Linq.Pattern
```

### Type Parameters

**TPattern**

A pattern to be negated\.

### Derived

* [Assertion](../Assertion/README.md)
* [BackAssertion](../BackAssertion/README.md)
* [CharGroup](../CharGroup/README.md)
* [CharPattern](../CharPattern/README.md)
* [WordBoundary](../WordBoundary/README.md)

## Methods

| Method | Summary |
| ------ | ------- |
| [Negate()](Negate/README.md) | Returns a pattern that is a negation of the current instance\. |

