// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Globalization;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal static class TextUtility
    {
        public static string NumberToString(int number)
        {
            if (number >= 0 && number <= 9)
            {
                return _numbers[number];
            }
            else
            {
                return number.ToString(CultureInfo.InvariantCulture);
            }
        }

        private static readonly string[] _numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    }
}
