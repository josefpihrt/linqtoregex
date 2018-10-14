# Pihrtsoft\.Text\.RegularExpressions\.Linq Namespace

[Home](../../../../README.md) &#x2022; [Classes](#classes) &#x2022; [Interfaces](#interfaces) &#x2022; [Enums](#enums) &#x2022; [Delegates](#delegates)

**Containing Namespace**: [Pihrtsoft.Text.RegularExpressions](../README.md)

## Classes

| Class | Summary |
| ----- | ------- |
| [Assertion](Assertion/README.md) | Represents a zero\-width positive lookahead assertion\. This class cannot be inherited\. |
| [BackAssertion](BackAssertion/README.md) | Represents a zero\-width positive lookbehind assertion\. This class cannot be inherited\. |
| [BaseGroupExtensions](BaseGroupExtensions/README.md) | Provides a set of static methods that extends [IBaseGroup](IBaseGroup/README.md) interface\. |
| [GroupingPattern](GroupingPattern/README.md) | Represents a base class for all kind of grouping constructs including assertions\. This class is abstract\. |
| [CharGroup](CharGroup/README.md) | Represents a positive or a negative character group pattern\. This class is abstract\. |
| [CharGrouping](CharGrouping/README.md) | Represents an immutable content of the character group\. Content can be a base group or an excluded group\. This class is abstract\. |
| [CharPattern](CharPattern/README.md) | Represents a pattern that matches a single character\. This includes Unicode category, Unicode block or character class \(\(non\-\)digit, \(non\-\)white\-space, \(non\-\)word\)\. This class is abstract\. |
| [Chars](Chars/README.md) | Exposes static methods that returns instance of [CharGrouping](CharGrouping/README.md) class\. [CharGrouping](CharGrouping/README.md) class represents a character group content\. |
| [CharSubtraction](CharSubtraction/README.md) | Represents a character subtraction pattern\. This pattern matches a character from a base group except characters from a excluded group\. |
| [NegativeAssertion](NegativeAssertion/README.md) | Represents a zero\-width negative lookahead assertion\. This class cannot be inherited\. |
| [NegativeBackAssertion](NegativeBackAssertion/README.md) | Represents a zero\-width negative lookbehind assertion\. This class cannot be inherited\. |
| [NegativeSurroundAssertion](NegativeSurroundAssertion/README.md) | Represents a pattern that matches a specified content with negative lookbehind assertion on the left side and negative lookahead assertion on the right side\. This class cannot be inherited\. |
| [NegativeWordBoundary](NegativeWordBoundary/README.md) | Represents a pattern that is matched not on a boundary between a word character and a non\-word character\. This class cannot be inherited\. |
| [Pattern](Pattern/README.md) | Represents an immutable regular expression pattern\. This class is abstract\. |
| [PatternBuilder](PatternBuilder/README.md) | Represents a class that enables to create a text representation of the [Pattern](Pattern/README.md)\. This class cannot be inherited\. |
| [Patterns](Patterns/README.md) | Provides static methods that returns various kinds of patterns\. |
| [PatternSettings](PatternSettings/README.md) | Specifies a set of features to support on the [PatternBuilder](PatternBuilder/README.md) object\. This class cannot be inherited\. |
| [QuantifiablePattern](QuantifiablePattern/README.md) | Represents a pattern that can be quantified, i\.e\. quantifier can be applied on it\. This class is abstract\. |
| [QuantifiedGroup](QuantifiedGroup/README.md) | Represents a pattern that is quantified, i\.e\. the quantifier is applied on it\. If required, pattern will be enclosed in the \(noncapturing\) group\. This class is abstract\. |
| [QuantifiedPattern](QuantifiedPattern/README.md) | Represents a pattern that is quantified, i\.e\. quantifier is applied on it\. This class is abstract\. |
| [RegexUtility](RegexUtility/README.md) | Provides static methods for escaping and validating regular expressions elements\. |
| [Substitution](Substitution/README.md) | Represents a base class for a substitution in the replacement pattern\. This class is abstract\. |
| [Substitutions](Substitutions/README.md) | Provides static methods for obtaining substitutions for a replacement pattern\. |
| [SurroundAssertion](SurroundAssertion/README.md) | Represents a pattern that matches a specified content with lookbehind assertion on the left side and lookahead assertion on the right side\. This class cannot be inherited\. |
| [WordBoundary](WordBoundary/README.md) | Represents a pattern that is matched on a boundary between a word character and a non\-word character\. The pattern may be also matched on a word boundary at the beginning or end of the string\. This class cannot be inherited\. |

## Interfaces

| Interface | Summary |
| --------- | ------- |
| [IBaseGroup](IBaseGroup/README.md) | Represents the base part of the character subtraction pattern\. |
| [IExcludedGroup](IExcludedGroup/README.md) | Represents the excluded part of the character subtraction pattern\. |
| [INegateable\<TPattern>](INegateable-1/README.md) | Supports negation of a pattern\. |

## Enums

| Enum | Summary |
| ---- | ------- |
| [AsciiChar](AsciiChar/README.md) | Specifies Unicode character from the first block\. |
| [GeneralCategory](GeneralCategory/README.md) | Specifies Unicode general category\. |
| [CharEscapeMode](CharEscapeMode/README.md) | Specifies how the character is represented in the regular expression pattern\. |
| [IdentifierBoundary](IdentifierBoundary/README.md) | Specifies which characters will be used to surround group name in the named group, balancing group and named group backreference\. |
| [NamedBlock](NamedBlock/README.md) | Specifies the Unicode named block\. The set of supported named blocks is based on Unicode 4\.0\. |
| [PatternOptions](PatternOptions/README.md) | Provides enumerated values to use when creating a text representation of a pattern\. |
| [SplitOptions](SplitOptions/README.md) | Provides enumerated values to use when splitting a text\. |

## Delegates

| Delegate | Summary |
| -------- | ------- |
| [GroupEvaluator](GroupEvaluator/README.md) | Represents the method that is called each time a regular expression group is found during a Replace method operation\. |

