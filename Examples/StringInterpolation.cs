using static Pihrtsoft.Text.RegularExpressions.Linq.Patterns;

namespace Pihrtsoft.Text.RegularExpressions.Linq.Examples
{
    public static class StringInterpolation
    {
        public const string OpenToken = "$\"";

        public static Pattern Pattern
        {
            get
            {
                return OpenToken
                    + Open()
                    + MaybeMany(
                        OneMany(NamedGroup("open", OpenToken) + Open())
                        + OneMany(BalancingGroup("close", "open", '"') + Close())
                    )
                    + '"';
            }
        }

        private static Pattern Open()
        {
            return
                TextPart()
                + MaybeMany('{' + CodePart() + '}' + TextPart())
                + Any(
                    Assert('"'),
                    '{' + CodePart() + Assert(OpenToken)
                );
        }

        private static Pattern Close()
        {
            return
                CodePart()
                + MaybeMany('}' + TextPart() + '{' + CodePart())
                + Any(
                    Assert(OpenToken),
                    '}' + TextPart() + Assert('"')
                );
        }

        private static Pattern TextPart()
        {
            var whileNot = WhileNotChar('\\', '{', '"');

            return NamedGroup("text",
                whileNot
                + MaybeMany(
                    Any(
                        '\\' + NotNewLineChar(),
                        "{{"
                    )
                    + whileNot
                )
            );
        }

        private static Pattern CodePart()
        {
            var whileNot = WhileNotChar('\'', '"', '@', '/', '}', '$');

            return whileNot
                + MaybeMany(
                    Any(
                        NamedGroup("text", Snippets.CSharpEscapedTextLiteral()),
                        NamedGroup("text", Snippets.CSharpVerbatimTextLiteral()),
                        NamedGroup("char", Snippets.CSharpCharacterLiteral()),
                        NamedGroup("comment", Snippets.CSharpMultilineComment())
                    )
                    + whileNot
                );
        }
    }
}
