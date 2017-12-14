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

            string lower = Sanitize(input).ToLowerInvariant();

            return lower.Zip(lower.Reverse(), Tuple.Create)
            .Take((int)Math.Ceiling(lower.Length / 2.0))
            .All(x => x.Item1 == x.Item2);
        }

        private string Sanitize(string input) => Regex.Replace(input, @"\W|\d", "");
    }
}
