// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq.Extensions
{
    /// <summary>
    /// Provides a set of static methods that extends <see cref="Capture"/> class.
    /// </summary>
    public static class CaptureExtensions
    {
        /// <summary>
        /// Returns a sum of index and length of a specified <paramref name="capture"/>.
        /// </summary>
        /// <param name="capture">A regular expression capture.</param>
        /// <exception cref="ArgumentNullException"><paramref name="capture"/> is <c>null</c>.</exception>
        public static int EndIndex(this Capture capture)
        {
            if (capture is null)
                throw new ArgumentNullException(nameof(capture));

            return capture.Index + capture.Length;
        }
    }
}
