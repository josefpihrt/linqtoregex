## LINQ to Regex
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
The very base library type is the `Pattern` class that represent an immutable regular expression pattern.
Another very important type is the `Patterns` class. This static class returns instances of various kinds of `Pattern` class or its derived types.
When you want to create a pattern you have start with `Patterns` class.
Following pattern will match a digit character. Regex syntax is `\d` .
```c#
var pattern = Patterns.Digit();
```

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
var pattern = Digit();
```

### CharGrouping Class

`CharGrouping` represents a content of a character group. `CharGrouping` can be created using `Chars` static class that has the same purpose as `Patterns` class.

### Pattern Text
`Pattern` object can be converted to a regular expression text using a `ToString` method.
```c#
public override string ToString()
public string ToString(PatternOptions options)
public string ToString(PatternSettings settings)
```

### String Parameter
LINQ to Regex always interprets `String` parameters as literals, never as metacharacters.
```c#
// This pattern will match a combination of a backslash character and a dot character.
Pattern pattern = @"\.";

// "\\\."
string text = pattern.ToString();
```

### Collection Parameter

A parameter that implements at least non-generic `IEnumerable` interface is interpreted in a way that any one element of the collection has to be matched.

There is one exception from this rule and that is `Patterns.Concat` static method.

### Object or Object[]  Parameter
A lot of methods that returns instance of the `Pattern` class accepts parameters of type `Object` that is usually named `content`. This methods can handle following types (typed as `Object`):
* `Pattern`
* `CharGrouping`
* `String`
* `Char`
* `Object[]`
* `IEnumerable`

Last two items in the list, `Object[]` and `IEnumerable` can contains zero or more items (patterns) any one of which has to be matched.

Methods that allows to pass a content typed as `Object` usually allows to pass an array of object with `params` (`ParamArray` in Visual Basic) keyword. This overload simply convert the array of object to the object and calls overload that accept object as an argument. 

### Concat and Join Methods
`Patterns.Concat` static method concatenates elements of the specified collection.
```c#
// "abcd"
var pattern = Concat("a", "b", "c", "d");
```

`Patterns.Join` static method is very similar to a `String.Join` method.
```c#
// "a\s+b\s+c\s+d"
var pattern = Join(WhiteSpaces(), "a", "b", "c", "d");
```

### Quantifiers

`?` quantifier matches previous element zero or one times. Use `Maybe` method to apply this quantifier.
```c#
var pattern = Patterns.Digit().Maybe();
```
`*` quantifier matches previous element zero or more times. Use `MaybeMany` method to apply this quantifier.
```c#
var pattern = Patterns.Digit().MaybeMany();
```
`+` quantifier matches previous element one or more times. Use `OneMany` method to apply this quantifier.
```c#
var pattern = Patterns.Digit().OneMany();
```

By default quantifiers are "greedy" which means that previous element is matched as many times as possible. If you want to match previous element as few times as possible, use `Lazy` method.

Following pattern will match any character zero or more times but as few times as possible. Regex syntax is `[\s\S]*?` .
```c#
var pattern = Patterns.Any().MaybeMany().Lazy();
```

Previous pattern is quite common so it is wrapped into a following method.
```c#
var pattern = Patterns.Crawl();
```

#### Quantifier group

In regular expressions syntax you can apply quantifier only after the element that should be quantified. In LINQ to Regex you can define a quantifier group and put a quantified content into it.

### Operators
#### + Operator
The `+` operator concatenates the operands into a new pattern. Following three pattern have the same meaning.

Pattern class has many instance methods that allows you to concatenate the current instance with another pattern. Following pattern matches an empty line.
```c#
var pattern = Patterns.BeginLine().Assert(Patterns.NewLine());
```
Same goal can be achieved using `+` operator.
```c#
var pattern = Patterns.BeginLine() + Patterns.Assert(Patterns.NewLine());
```
With "using static" statement pattern more concise.
```c#
var pattern = BeginLine() + Assert(NewLine());
```

#### - Operator
`-` operator can be used to create character subtraction. This operator is defined for `CharGroup`, `CharGrouping` and `CharPattern` types.

`Except` method is used to create character subtraction. Following pattern matches a white-space character except a carriage return and a linefeed. Regex syntax is `[\s-[\r\n]]` .
```c#
var pattern = Patterns.WhiteSpace().Except(Chars.CarriageReturn().Linefeed());
```
Same goal can be achieved using `-` operator.
```c#
var pattern = Patterns.WhiteSpace() - Chars.CarriageReturn().Linefeed();
```
In fact this pattern is quite common so it is wrapped into a following method.
```c#
var pattern = Patterns.WhiteSpaceExceptNewLine();
```

#### | Operator
`Any` method represents a group in which any one of the specified patterns has to be matched.
```c#
var pattern = Pattern.Any("first", "second", "third");
```
Same goal can be achieved using `|` operator
```c#
var pattern = "first" | "second" | "third;
```

#### ! Operator
`!` operator is used to create pattern that has opposite meaning than operand. Following pattern represents a linefeed that is not preceded with a carriage return and can be used to normalize line endings to Windows mode.
```c#
var pattern = Patterns.NotAssertBack(CarriageReturn()).Linefeed();
```
Same goal can be achieved using ! operator.
```c#
var pattern = !Patterns.AssertBack(CarriageReturn()) + Patterns.Linefeed();
```

With "using static" statement the pattern is more concise.
```c#
var pattern = !AssertBack(CarriageReturn()) + Linefeed();
```

### Suffix "Native"

There are methods, such as `AnyNative` or `CrawlNative` that behaves differently depending on the provided `RegexOptions` value.
In these two patterns, a dot can match any character except linefeed or any character in `RegexOptions.Singleline` option is applied.

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
