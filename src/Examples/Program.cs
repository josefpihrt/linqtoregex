// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using static Pihrtsoft.Text.RegularExpressions.Linq.Patterns;

namespace Pihrtsoft.Text.RegularExpressions.Linq.Examples
{
    internal static class Program
    {
        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "args")]
        internal static void Main(string[] args)
        {
            Dump("c# quotation", Snippets.CSharpLiteral());

            Dump("cdata value", Snippets.XmlCData());

            Dump("email address", Snippets.EmailAddress());

            Dump("verbatim string literal", Snippets.CSharpVerbatimTextLiteral());

            Dump("leading whitespace", Snippets.LeadingWhiteSpace());

            Dump("trailing whitespace", Snippets.TrailingWhiteSpace());

            Dump("empty or whitespace line", Snippets.EmptyOrWhiteSpaceLine());

            Dump("empty line", Snippets.EmptyLine());

            Dump("first line without new line", Snippets.FirstLineWithoutNewLine());

            Dump("linefeed without carriage return", Snippets.LinefeedWithoutCarriageReturn());

            Dump("invalid file name chars", Any(Path.GetInvalidFileNameChars()));

            Pattern exp = BeginInput()
                .Assert(Crawl().SurroundWordBoundary("word1"))
                .Assert(Crawl().SurroundWordBoundary("word2"))
                .Any().MaybeMany();

            Dump("all words anywhere", exp);

            var words = new string[] { "one", "two", "three" };

            exp = WordBoundary()
                .CountFrom(3,
                    Any(words.Select(f => Group(Patterns.Text(f))))
                    .WordBoundary()
                    .NotWordChar().MaybeMany().Lazy())
                .GroupReference(1)
                .GroupReference(2)
                .GroupReference(3);

            Dump("words in sequence in any order", exp);

            exp = Group(Word())
                .NotWordChars()
                .GroupReference(1)
                .WordBoundary();

            Dump("repeated word", exp);

            Console.ReadKey();
        }

        private static void Dump(string title, Pattern pattern)
        {
            var options = PatternOptions.FormatAndComment;

            if (!string.IsNullOrEmpty(title))
                Console.WriteLine($"{title}:");

            Console.WriteLine(pattern.ToString(options));
            Console.WriteLine(string.Empty);
        }
    }
}
