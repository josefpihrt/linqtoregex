# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Changed

- Rename `master` to `main`

-----

## [2.5.0] - 2017-01-09

* Add support for .NET Standard 1.3
* New patterns: CrawlLine, SlashOrBackslash, NotSlashOrBackslash

## [2.4.0] - 2016-09-13

* Add support for Portable Class Library

## [2.3.0] - 2016-02-07

* New PatternOptions value: InlineOptions.
* New enum SplitOptions with values: None, OmitGroupValues, OmitEmptyValues.
* New extension methods that extends Regex: ReplaceMatchChar, ReplaceGroupChar.
* New extension method that extends Regex: EnumerateSplit (3 overloads added).
* New pattern: Characters.

## [2.2.2] - 2015-11-19

* New patterns: LatinLetters, ArabicDigits, Spaces, RequireGroup, DisallowGroup.
* New extension methods that extends Regex: EnumerateIndexes, EnumerateLengths, EnumerateValues.

## [2.2.1] - 2015-10-04

* New patterns: BalanceParentheses, BalanceSquareBrackets, BalanceCurlyBrackets, BalanceAngleBrackets.
* New extension methods that extend IEnumerable<Capture>: EnumerateIndexes, EnumerateLengths.
* New extension method that extends Capture: EndIndex.

## [2.2.0] - 2015-09-15

* New patterns: WhileNot, UntilChar(string).

## [2.1.0] - 2015-08-25

* New substitution pattern: Text(char), Group.
* New patterns: Until, WhileNotDigit, WhileNotWhiteSpace, WhileNotWordChar.
* Added capability to convert pattern to C# or Visual Basic string literal.
* + operator overloaded for Substitution class.
* Bug fixed in AppendIfAssert method.
