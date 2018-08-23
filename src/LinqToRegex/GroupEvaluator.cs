// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text.RegularExpressions;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    /// <summary>
    /// Represents the method that is called each time a regular expression group is found during a Replace method operation.
    /// </summary>
    /// <param name="group">The <see cref="Group"/> object that represents a single regular expression group during a Replace method operation.</param>
    public delegate string GroupEvaluator(Group group);
}
