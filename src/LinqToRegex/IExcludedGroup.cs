// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Represents the excluded part of the character subtraction pattern.
    /// </summary>
    public interface IExcludedGroup
    {
        /// <summary>
        /// Appends the text representation of the excluded group to the specified <see cref="PatternBuilder"/>.
        /// </summary>
        /// <param name="builder">The builder to use for appending the text.</param>
        void AppendExcludedGroupTo(PatternBuilder builder);
    }
}