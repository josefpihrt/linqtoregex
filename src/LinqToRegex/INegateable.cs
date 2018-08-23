// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Supports negation of a pattern.
    /// </summary>
    /// <typeparam name="TPattern">A pattern to be negated.</typeparam>
    public interface INegateable<TPattern> where TPattern : Pattern
    {
        /// <summary>
        /// Returns a pattern that is a negation of the current instance.
        /// </summary>
        TPattern Negate();
    }
}
