using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PalindromeFinder
{
    public class FindPalindrome
    {
        public bool IsPalindrome(string input)
        {
            if (String.IsNullOrEmpty(input))
                return false;

            string lower = input.ToLowerInvariant();

            if(IsStringDirty(lower))
                lower = Santize(lower);

            return CheckForPalindrome(lower);
        }

        private bool IsStringDirty(string input)
        {
            if (Regex.IsMatch(input, @"\W|\d"))
                return true;

            return false;
        }

        private string Santize(string input) => Regex.Replace(input, @"\W|\d", "");

        private bool CheckForPalindrome(string input)
        {
            return input.Zip(input.Reverse(), Tuple.Create)
            .Take(Convert.ToInt16(Math.Ceiling(input.Length / 2.0)))
            .All(x => x.Item1 == x.Item2);
        }
    }
}
