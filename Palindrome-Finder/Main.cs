using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PalindromeFinder
{
    public class FindPalindrome
    {
        public bool IsPalindrome(string wordToCheck)
        {
            wordToCheck = wordToCheck.ToLower();

            int min = 0;
            int max = wordToCheck.Length - 1;

            while (true)
            {
                if (min > max)
                {
                    return true;
                }

                char a = wordToCheck[min];
                char b = wordToCheck[max];
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
            foreach (string word in input)
            {
                int min = 0;
                int max = word.Length - 1;

                while (true)
                {
                    if (min > max)
                    {
                        return true;
                    }

                    char a = word[min];
                    char b = word[max];
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
    }
}
