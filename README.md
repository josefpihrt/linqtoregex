# LINQ to Regex
* LINQ to Regex library provides language integrated access to the .NET regular expressions.
* It allows you to create and use regular expressions directly in your code and develop complex expressions while keeping its readability and maintainability.
* Knowledge of the regular expression syntax is not required (but you should be familiar with basics).

The library contains two namespaces:
```c#
Pihrtsoft.Text.RegularExpressions.Linq;
Pihrtsoft.Text.RegularExpressions.Linq.Extensions;
```
First namespace is a library root namespace. Second namespace contains static classes with extensions methods that extends existing .NET types.

### Pattern Class
`Pattern` is the very base library type. It represent an immutable regular expression pattern. Instances of the `Pattern` class and its descendants can be obtained through `Patterns` static class. `Pattern` class also offers instance methods that enables to combine patterns.
Following pattern will match a digit character.
```c#
Pattern pattern = Patterns.Digit();
```
Regex syntax: `\d`

It is recommended to reference `Patterns` class with `using static` (C# 6.0 or higher)
```c#
using static Pihrtsoft.Text.RegularExpressions.Linq.Patterns;
```
or `Imports` (Visual Basic)
```vb
Imports Pihrtsoft.Text.RegularExpressions.Linq.Patterns
```
This will allow you to create patterns without repeatedly referencing `Patterns` class.
```c#
Pattern pattern = Digit();
```

### CharGrouping Class
`CharGrouping` type represents a content of a character group. Instances of the `CharGrouping` class and its descendants can be obtained through `Chars` static class. `CharGrouping` class also offers instance methods that enables to combine elements.

### Pattern Text
`Pattern` object can be converted to a regular expression text using a `ToString` method.
```c#
public override string ToString()
public string ToString(PatternOptions options)
public string ToString(PatternSettings settings)
```

### String Parameter
LINQ to Regex always interprets each character in a `string` parameter as a literal, never as a metacharacter. Following pattern will match a combination of a backslash and a dot.
```c#
Pattern pattern = @"\.";
```
Regex syntax: `\\\.`

### Collection Parameter
A parameter that implements at least non-generic `IEnumerable` interface is interpreted in a way that any one element of the collection has to be matched.

There is one exception from this rule and that is `Patterns.Concat` static method.

### Object or Object[]  Parameter
A lot of methods that returns instance of the `Pattern` class accepts parameter of type `object` which is usually named `content`. This methods can handle following types (typed as `object`):
* `Pattern`
* `CharGrouping`
* `string`
* `char`
* `object[]`
* `IEnumerable`

Last two items in the list, `Object[]` and `IEnumerable` can contains zero or more elements (patterns) any one of which has to be matched.

Methods that allows to pass a content typed as `object` usually allows to pass an array of object with `params` (`ParamArray` in Visual Basic) keyword. This overload simply convert the array of objects to the `object` and calls overload that accept `object` as an argument. 

### Concat and Join Methods
Static method `Patterns.Concat` concatenates elements of the specified collection.
```c#
var pattern = Concat("a", "b", "c", "d");
```
Regex syntax: `abcd`

Static method `Patterns.Join` concatenates the elements of the specified collection using the specified separator between each element. It is very similar to a `string.Join` method.
```c#
var pattern = Join(WhiteSpaces(), "a", "b", "c", "d");
```
Regex syntax: `a\s+b\s+c\s+d`

### Quantifiers
Use `Maybe` method to match previoud element zero or one time.
```c#
var pattern = Digit().Maybe();
```
Regex syntax: `\d?`

Use `MaybeMany` method to match previoud element zero or more times.
```c#
var pattern = Digit().MaybeMany();
```
Regex syntax: `\d*`

Use `OneMany` method to match previoud element one or more times.
```c#
var pattern = Digit().OneMany();
```
Regex syntax: `\d+`

Quantifiers are "greedy" by default which means that previous element is matched as many times as possible. If you want to match previous element as few times as possible, use `Lazy` method.

Following pattern will match any character zero or more times but as few times as possible.
```c#
var pattern = Any().MaybeMany().Lazy();
```
Regex syntax: `[\s\S]*?`

Previous pattern is quite common so it is wrapped into a `Crawl` method.
```c#
var pattern = Patterns.Crawl();
```

#### Quantifier group
In regular expressions syntax you can apply quantifier only after the element that should be quantified. In LINQ to Regex you can define a quantifier group and put a quantified content into it.

### Operators
#### + Operator
The `+` operator concatenates the operands into a new pattern. Following pattern matches an empty line.
```c#
var pattern = Patterns.BeginLine().Assert(Patterns.NewLine());
```
Regex syntax: `(?m:^)(?=(?:\r?\n))`

Same goal can be achieved using `+` operator.
```c#
var pattern = Patterns.BeginLine() + Patterns.Assert(Patterns.NewLine());
```
With "using static" statement the expression is more concise.
```c#
var pattern = BeginLine() + Assert(NewLine());
```

#### - Operator
`-` operator can be used to create character subtraction. This operator is defined for `CharGroup`, `CharGrouping` and `CharPattern` types. `Except` method is used to create character subtraction. Following pattern matches a white-space character except a carriage return and a linefeed.
```c#
var pattern = Patterns.WhiteSpace().Except(Chars.CarriageReturn().Linefeed());
```
Regex syntax: `[\s-[\r\n]]`

Same goal can be achieved using `-` operator.
```c#
var pattern = Patterns.WhiteSpace() - Chars.CarriageReturn().Linefeed();
```
Previous pattern is quite common so it is wrapped into a `WhiteSpaceExceptNewLine` method.
```c#
var pattern = Patterns.WhiteSpaceExceptNewLine();
```

#### | Operator
`Any` method represents a group in which any one of the specified patterns has to be matched. Following pattern matches a word that begin with a or b.
```c#
var pattern = Any(
    WordBoundary() + "a" + WordChars(), 
    WordBoundary() + "b" + WordChars());
```
Regex syntax: `(?:\ba\w+|\bb\w+)`

Same goal can be achieved using `|` operator
```c#
var pattern = (WordBoundary() + "a" + WordChars()) | (WordBoundary() + "b" + WordChars());
```

#### ! Operator
`!` operator is used to create pattern that has opposite meaning than operand. Following pattern represents a linefeed that is not preceded with a carriage return and can be used to normalize line endings to Windows mode.
```c#
var pattern = Patterns.NotAssertBack(CarriageReturn()).Linefeed();
```
Regex syntax: `(?:(?<!\r)\n)`

Same goal can be achieved using ! operator.
```c#
var pattern = !Patterns.AssertBack(CarriageReturn()) + Patterns.Linefeed();
```
With "using static" statement the expression is more concise.
```c#
var pattern = !AssertBack(CarriageReturn()) + Linefeed();
```

### Prefix "While"
"While" is an alias for a `*` quantifier. Methods whose name  begins with "While" returns pattern that matches a specified character zero or more times.

```c#
var pattern = WhileChar('a'); // a*
```
```c#
var pattern = WhileDigit(); // \d*
```
```c#
var pattern = WhileWhiteSpace(); // \s*
```
```c#
var pattern = WhileWhiteSpaceExceptNewLine(); // [\s-[\r\n]]*
```
```c#
var pattern = WhileWordChar(); // \w*
```
### Prefix "WhileNot"
Methods whose name  begins with "WhileNot" returns pattern that matches a character that is not a specified character zero or more times.
```c#
var pattern = WhileNotChar('a'); // [^a]*
```
```c#
var pattern = WhileNotNewLineChar(); // [^\r\n]*
```
### Prefix "Until"
Methods whose name begins with "Until" returns pattern that matches a character that is not a specified character zero or more times terminated with the same character.
```c#
var pattern = UntilChar('a'); // (?:[^a]*a)
```
```c#
var pattern = UntilNewLine(); // (?:[^\n]*\n)
```

### Suffix "Native"
There are methods, such as `AnyNative` or `CrawlNative` that behaves differently depending on the provided `RegexOptions` value.
In these two patterns, a dot can match any character except linefeed or any character in `RegexOptions.Singleline` option is applied.

### Examples

#### Leading White-space
```c#
Pattern pattern = BeginInputOrLine().WhiteSpaceExceptNewLine().OneMany());

Console.WriteLine(pattern.ToString(PatternOptions.FormatAndComment));
```
Output:
```
^            # beginning of input
[\s-[\r\n]]+ # character group one or more times
```
#### Repeated Word
```c#
var pattern = 
    Group(Word())
        .NotWordChars()
        .GroupReference(1)
        .WordBoundary();

Console.WriteLine(pattern.ToString(PatternOptions.FormatAndComment));
```
Output:
```
(           # numbered group
    (?:     # noncapturing group
        \b  # word boundary
        \w+ # word character one or more times
        \b  # word boundary
    )       # group end
)           # group end
\W+         # non-word character one or more times
\1          # group reference
\b          # word boundary
```
#### C# Verbatim String Literal
```c#
string q = "\"";

var pattern = "@" + q + WhileNotChar(q) + MaybeMany(q + q + WhileNotChar(q)) + q;

Console.WriteLine(pattern.ToString(PatternOptions.FormatAndComment));
```
Output:
```
@"        # text
[^"]*     # negative character group zero or more times
(?:       # noncapturing group
    ""    # text
    [^"]* # negative character group zero or more times
)*        # group zero or more times
"         # character
```
#### Words in Sequence in Any Order
```c#
var pattern = 
    WordBoundary()
        .CountFrom(3,
            Any(values.Select(f => Group(Patterns.Text(f))))
            .WordBoundary()
            .NotWordChar().MaybeMany().Lazy())
        .GroupReference(1)
        .GroupReference(2)
        .GroupReference(3);

Console.WriteLine(pattern.ToString(PatternOptions.FormatAndComment));
```
Output:
```
\b                # word boundary
(?:               # noncapturing group
    (?:           # noncapturing group
        (         # numbered group
            one   # text
        )         # group end
    |             # or
        (         # numbered group
            two   # text
        )         # group end
    |             # or
        (         # numbered group
            three # text
        )         # group end
    )             # group end
    \b            # word boundary
    \W*?          # non-word character zero or more times but as few times as possible
){3,}             # group at least n times
\1                # group reference
\2                # group reference
\3                # group reference
```
#### XML CDATA Value
```c#
Pattern pattern = 
    SurroundAngleBrackets(
        "!" + SurroundSquareBrackets(
            "CDATA" + SurroundSquareBrackets(
                Group(
                    WhileNotChar(']')
                    + MaybeMany(
                        "]"
                        + NotAssert("]>")
                        + WhileNotChar(']'))
                )
            )
        )
    );

Console.WriteLine(pattern.ToString(PatternOptions.FormatAndComment));
```
Output:
```
<              # character
!              # character
\[             # character
CDATA          # text
\[             # character
(              # numbered group
    [^\]]*     # negative character group zero or more times
    (?:        # noncapturing group
        ]      # character
        (?!    # negative lookahead assertion
            ]> # text
        )      # group end
        [^\]]* # negative character group zero or more times
    )*         # group zero or more times
)              # group end
]              # character
]              # character
>              # character
```

### NuGet Package
The library is distributed via [NuGet](https://www.nuget.org/packages/LinqToRegex).
