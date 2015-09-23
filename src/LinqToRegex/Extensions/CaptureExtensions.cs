// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq.Extensions
{
#if DEBUG
    public static class CaptureExtensions
    {
        public static int EndIndex(this Capture capture)
        {
            if (capture == null)
                throw new ArgumentNullException(nameof(capture));

            return capture.Index + capture.Length;
        }
    }
#endif
}
