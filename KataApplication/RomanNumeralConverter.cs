using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework.Constraints;

namespace KataApplication
{
    public class RomanNumeralConverter
    {
        public static int convert(string numeralText)
        {
            Dictionary<char, int> numeralValuesMap = new Dictionary<Char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };


            char lastCharacter = numeralText[numeralText.Length - 1];
            if (numeralText.Length > 1)
            {
                char secondToLast = numeralText[numeralText.Length - 2];


                if (lastCharacter != secondToLast)
                {
                    return numeralValuesMap[lastCharacter] - numeralValuesMap[secondToLast];
                }
            }
            return numeralText.Length * numeralValuesMap[lastCharacter];
        }
    }
}