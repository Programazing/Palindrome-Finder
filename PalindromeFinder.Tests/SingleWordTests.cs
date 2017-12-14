using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PalindromeFinder;

namespace PalindromeFinder.Tests
{
    public class SingleWordTests
    {
        FindPalindrome findPalindrome;

        public SingleWordTests()
        {
            findPalindrome = new FindPalindrome();
        }

        [Theory]
        [InlineData("Madam", true)]
        [InlineData("Redivider", true)]
        [InlineData("Noon", true)]
        [InlineData("Civic", true)]
        [InlineData("Kayak", true)]
        [InlineData("Tacocat", true)]
        public void IsPalindrome_WhenGivenASingleWordPalindrome_WillReturnTrue
            (string input, bool expected)
        {
            var sut = findPalindrome.IsPalindrome(input);

            Assert.Equal(expected, sut);
        }

        [Theory]
        [InlineData("Car", false)]
        [InlineData("River", false)]
        [InlineData("Moon", false)]
        [InlineData("Kohn", false)]
        [InlineData("Bird", false)]
        public void IsPalindrome_WhenGivenANonPalindromeWord_WillReturnFalse
            (string input, bool expected)
        {
            var sut = findPalindrome.IsPalindrome(input);

            Assert.Equal(expected, sut);
        }

        [Theory]
        [InlineData(new string[] {"Madam", "Redivider", "Noon", "Civic", "Kayak"}, true)]
        public void IsPalindrome_WhenGivenAListOfSingleWordPalindromes_WillReturnTrue
            (IEnumerable<string> input, bool expected)
        {
            var sut = findPalindrome.IsPalindrome(input);

            Assert.Equal(expected, sut);
        }

        [Theory]
        [InlineData(new string[] { "Car", "River", "Moon", "Kohn", "Bird" }, false)]
        public void IsPalindrome_WhenGivenAListOfSingleWordNonPalindromes_WillReturnFalse
            (IEnumerable<string> input, bool expected)
        {
            var sut = findPalindrome.IsPalindrome(input);

            Assert.Equal(expected, sut);
        }
    }
}
