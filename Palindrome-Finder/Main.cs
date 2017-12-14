using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PalindromeFinder
{
    public class FindPalindrome
    {
        public bool IsPalindrome(string input)
        {
            input = input.ToLower();

            if(Regex.IsMatch(input, @"\W|\d"))
            {
                input = Regex.Replace(input, @"\W|\d", "");
            }

            int min = 0;
            int max = input.Length - 1;

            while (true)
            {
                if (min > max)
                {
                    return true;
                }

                char a = input[min];
                char b = input[max];
                if (a != b)
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        public bool IsPalindrome(IEnumerable<string> input)
        {
            foreach (string entry in input)
            {
                string modifiableEntry = entry;

                if (IsStringDirty(modifiableEntry))
                    modifiableEntry = StringSanitizer(entry);

                int min = 0;
                int max = modifiableEntry.Length - 1;

                while (true)
                {
                    if (min > max)
                    {
                        return true;
                    }

                    char a = modifiableEntry[min];
                    char b = modifiableEntry[max];
                    if (char.ToLower(a) != char.ToLower(b))
                    {
                        return false;
                    }
                    min++;
                    max--;
                }
            }

            return true;
        }

        internal bool IsStringDirty(string input)
        {
            if (Regex.IsMatch(input, @"\W|\d"))
                return true;

            return false;
        }

        internal string StringSanitizer(string input) => Regex.Replace(input, @"\W|\d", "");
    }
}
