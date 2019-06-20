# LINQ to Regex API Reference

[Namespaces](#namespaces) &#x2022; [Class Hierarchy](#class-hierarchy) &#x2022; [Other](#other)

## Namespaces

* [Pihrtsoft.Text.RegularExpressions.Linq](Pihrtsoft/Text/RegularExpressions/Linq/README.md)
* [Pihrtsoft.Text.RegularExpressions.Linq.Extensions](Pihrtsoft/Text/RegularExpressions/Linq/Extensions/README.md)

## Class Hierarchy

* \([Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\)<a id="System_Object"></a>
* &emsp; [CharGrouping](Pihrtsoft/Text/RegularExpressions/Linq/CharGrouping/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_CharGrouping"></a>
* &emsp; [Pattern](Pihrtsoft/Text/RegularExpressions/Linq/Pattern/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_Pattern"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [NegativeSurroundAssertion](Pihrtsoft/Text/RegularExpressions/Linq/NegativeSurroundAssertion/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_NegativeSurroundAssertion"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [QuantifiablePattern](Pihrtsoft/Text/RegularExpressions/Linq/QuantifiablePattern/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern "QuantifiablePattern") &emsp; [CharGroup](Pihrtsoft/Text/RegularExpressions/Linq/CharGroup/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_CharGroup"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern "QuantifiablePattern") &emsp; [CharPattern](Pihrtsoft/Text/RegularExpressions/Linq/CharPattern/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_CharPattern"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern "QuantifiablePattern") &emsp; [CharSubtraction](Pihrtsoft/Text/RegularExpressions/Linq/CharSubtraction/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_CharSubtraction"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern "QuantifiablePattern") &emsp; [GroupingPattern](Pihrtsoft/Text/RegularExpressions/Linq/GroupingPattern/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_GroupingPattern"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern "QuantifiablePattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_GroupingPattern "GroupingPattern") &emsp; [Assertion](Pihrtsoft/Text/RegularExpressions/Linq/Assertion/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_Assertion"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern "QuantifiablePattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_GroupingPattern "GroupingPattern") &emsp; [BackAssertion](Pihrtsoft/Text/RegularExpressions/Linq/BackAssertion/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_BackAssertion"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern "QuantifiablePattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_GroupingPattern "GroupingPattern") &emsp; [NegativeAssertion](Pihrtsoft/Text/RegularExpressions/Linq/NegativeAssertion/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_NegativeAssertion"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern "QuantifiablePattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_GroupingPattern "GroupingPattern") &emsp; [NegativeBackAssertion](Pihrtsoft/Text/RegularExpressions/Linq/NegativeBackAssertion/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_NegativeBackAssertion"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern "QuantifiablePattern") &emsp; [NegativeWordBoundary](Pihrtsoft/Text/RegularExpressions/Linq/NegativeWordBoundary/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_NegativeWordBoundary"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_QuantifiablePattern "QuantifiablePattern") &emsp; [WordBoundary](Pihrtsoft/Text/RegularExpressions/Linq/WordBoundary/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_WordBoundary"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [QuantifiedPattern](Pihrtsoft/Text/RegularExpressions/Linq/QuantifiedPattern/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_QuantifiedPattern"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_QuantifiedPattern "QuantifiedPattern") &emsp; [QuantifiedGroup](Pihrtsoft/Text/RegularExpressions/Linq/QuantifiedGroup/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_QuantifiedGroup"></a>
* &emsp; [&bull;](#Pihrtsoft_Text_RegularExpressions_Linq_Pattern "Pattern") &emsp; [SurroundAssertion](Pihrtsoft/Text/RegularExpressions/Linq/SurroundAssertion/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_SurroundAssertion"></a>
* &emsp; [PatternBuilder](Pihrtsoft/Text/RegularExpressions/Linq/PatternBuilder/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_PatternBuilder"></a>
* &emsp; [PatternSettings](Pihrtsoft/Text/RegularExpressions/Linq/PatternSettings/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_PatternSettings"></a>
* &emsp; [Substitution](Pihrtsoft/Text/RegularExpressions/Linq/Substitution/README.md)<a id="Pihrtsoft_Text_RegularExpressions_Linq_Substitution"></a>

## [Pihrtsoft.Text.RegularExpressions.Linq](Pihrtsoft/Text/RegularExpressions/Linq/README.md) Namespace

### Classes

* [Assertion](Pihrtsoft/Text/RegularExpressions/Linq/Assertion/README.md)
* [BackAssertion](Pihrtsoft/Text/RegularExpressions/Linq/BackAssertion/README.md)
* [BaseGroupExtensions](Pihrtsoft/Text/RegularExpressions/Linq/BaseGroupExtensions/README.md)
* [CharGroup](Pihrtsoft/Text/RegularExpressions/Linq/CharGroup/README.md)
* [CharGrouping](Pihrtsoft/Text/RegularExpressions/Linq/CharGrouping/README.md)
* [CharPattern](Pihrtsoft/Text/RegularExpressions/Linq/CharPattern/README.md)
* [CharSubtraction](Pihrtsoft/Text/RegularExpressions/Linq/CharSubtraction/README.md)
* [Chars](Pihrtsoft/Text/RegularExpressions/Linq/Chars/README.md)
* [GroupingPattern](Pihrtsoft/Text/RegularExpressions/Linq/GroupingPattern/README.md)
* [NegativeAssertion](Pihrtsoft/Text/RegularExpressions/Linq/NegativeAssertion/README.md)
* [NegativeBackAssertion](Pihrtsoft/Text/RegularExpressions/Linq/NegativeBackAssertion/README.md)
* [NegativeSurroundAssertion](Pihrtsoft/Text/RegularExpressions/Linq/NegativeSurroundAssertion/README.md)
* [NegativeWordBoundary](Pihrtsoft/Text/RegularExpressions/Linq/NegativeWordBoundary/README.md)
* [Pattern](Pihrtsoft/Text/RegularExpressions/Linq/Pattern/README.md)
* [PatternBuilder](Pihrtsoft/Text/RegularExpressions/Linq/PatternBuilder/README.md)
* [PatternSettings](Pihrtsoft/Text/RegularExpressions/Linq/PatternSettings/README.md)
* [Patterns](Pihrtsoft/Text/RegularExpressions/Linq/Patterns/README.md)
* [QuantifiablePattern](Pihrtsoft/Text/RegularExpressions/Linq/QuantifiablePattern/README.md)
* [QuantifiedGroup](Pihrtsoft/Text/RegularExpressions/Linq/QuantifiedGroup/README.md)
* [QuantifiedPattern](Pihrtsoft/Text/RegularExpressions/Linq/QuantifiedPattern/README.md)
* [RegexUtility](Pihrtsoft/Text/RegularExpressions/Linq/RegexUtility/README.md)
* [Substitution](Pihrtsoft/Text/RegularExpressions/Linq/Substitution/README.md)
* [Substitutions](Pihrtsoft/Text/RegularExpressions/Linq/Substitutions/README.md)
* [SurroundAssertion](Pihrtsoft/Text/RegularExpressions/Linq/SurroundAssertion/README.md)
* [WordBoundary](Pihrtsoft/Text/RegularExpressions/Linq/WordBoundary/README.md)

### Interfaces

* [IBaseGroup](Pihrtsoft/Text/RegularExpressions/Linq/IBaseGroup/README.md)
* [IExcludedGroup](Pihrtsoft/Text/RegularExpressions/Linq/IExcludedGroup/README.md)
* [INegateable\<TPattern>](Pihrtsoft/Text/RegularExpressions/Linq/INegateable-1/README.md)

### Enums

* [AsciiChar](Pihrtsoft/Text/RegularExpressions/Linq/AsciiChar/README.md)
* [CharEscapeMode](Pihrtsoft/Text/RegularExpressions/Linq/CharEscapeMode/README.md)
* [GeneralCategory](Pihrtsoft/Text/RegularExpressions/Linq/GeneralCategory/README.md)
* [IdentifierBoundary](Pihrtsoft/Text/RegularExpressions/Linq/IdentifierBoundary/README.md)
* [NamedBlock](Pihrtsoft/Text/RegularExpressions/Linq/NamedBlock/README.md)
* [PatternOptions](Pihrtsoft/Text/RegularExpressions/Linq/PatternOptions/README.md)
* [SplitOptions](Pihrtsoft/Text/RegularExpressions/Linq/SplitOptions/README.md)

### Delegates

* [GroupEvaluator](Pihrtsoft/Text/RegularExpressions/Linq/GroupEvaluator/README.md)

## [Pihrtsoft.Text.RegularExpressions.Linq.Extensions](Pihrtsoft/Text/RegularExpressions/Linq/Extensions/README.md) Namespace

### Classes

* [CaptureExtensions](Pihrtsoft/Text/RegularExpressions/Linq/Extensions/CaptureExtensions/README.md)
* [EnumerableExtensions](Pihrtsoft/Text/RegularExpressions/Linq/Extensions/EnumerableExtensions/README.md)
* [GroupExtensions](Pihrtsoft/Text/RegularExpressions/Linq/Extensions/GroupExtensions/README.md)
* [MatchExtensions](Pihrtsoft/Text/RegularExpressions/Linq/Extensions/MatchExtensions/README.md)
* [RegexExtensions](Pihrtsoft/Text/RegularExpressions/Linq/Extensions/RegexExtensions/README.md)

## Other

* [Extensions of External Types](_Extensions.md)
