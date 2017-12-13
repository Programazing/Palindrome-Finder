using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PalindromeFinder;

namespace PalindromeFinder.Tests
{
    public class Tests
    {
        FindPalindrome findPalindrome;

        public Tests()
        {
            findPalindrome = new FindPalindrome();
        }

        [Theory]
        [InlineData("Madam", true)]
        [InlineData("Redivider", true)]
        [InlineData("Noon", true)]
        [InlineData("Civic", true)]
        [InlineData("Kayak", true)]
        public void IsPalindrome_WhenGivenASingleWordPalindrome_WillReturnTrue
            (string input, bool expected)
        {
            var sut = findPalindrome.IsPalindrome(input);

            Assert.Equal(expected, sut);
        }

        [Theory]
        [InlineData(new string[] {"Madam", "Redivider", "Noon", "Civic", "Kayak"}, true)]
        public void IsPalindrome_WhenGivenAListOfSingleWordStringPalindromes_WillReturnTrue
            (IEnumerable<string> input, bool expected)
        {
            var sut = findPalindrome.IsPalindrome(input);

            Assert.Equal(expected, sut);
        }

    }
}
