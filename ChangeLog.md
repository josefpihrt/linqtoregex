#### LINQ to Regex 2.2.1 (not released yet)

New extension methods EnumerateIndexes, EnumerateLengths that extend IEnumerable<Capture> added.
New extension method EndIndex that extends Capture added.
New patterns: BalanceParentheses, BalanceSquareBrackets, BalanceCurlyBrackets, BalanceAngleBrackets.

#### LINQ to Regex 2.2.0 (2015-09-15)

New patterns: WhileNot, UntilChar(string).

#### LINQ to Regex 2.1.0 (2015-08-25)

* Added capability to convert pattern to C# or Visual Basic string literal.
* + operator overloaded for Substitution class.
* "Text(char)", "Group" substitution patterns added.
* "Until", "WhileNotDigit", "WhileNotWhiteSpace", "WhileNotWordChar" patterns added.
* Bug fixed in AppendIfAssert method.
