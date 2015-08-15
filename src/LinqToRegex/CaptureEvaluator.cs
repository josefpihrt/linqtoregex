// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Represents the method that is called each time a regular expression capture is found during a Replace method operation.
    /// </summary>
    /// <param name="capture">The <see cref="Capture"/> object that represents a single regular expression capture during a Replace method operation.</param>
    /// <returns></returns>
    public delegate string CaptureEvaluator(Capture capture);
}
