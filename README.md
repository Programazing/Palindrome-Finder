# Palindrome Finder
A simple library to find palindromes.

##Usage

Palindrome Finder has one smiple method:

```C#
isPalindrome(string stringToCheck, string charctersToIgnore)
```
All you have to do is pass the string you want to check and then another string containing all of the symbols you want to ignore. (**i.e** question marks, exclimations, and etc.)

The method simply returns true or false.

##Example

```C#
using PalindromeFinder;
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            FindPalindrome test = new FindPalindrome();

            string input = Console.ReadLine();

            if (test.isPalindrome(input, ".?,';\"!") == true)
            {
                Console.Write("true");
                Console.ReadKey();
            }
            else if (test.isPalindrome(input, ".?,';\"!") == false)
            {
                Console.Write("false");
                Console.ReadKey();
            }
        }
    }
}

```
