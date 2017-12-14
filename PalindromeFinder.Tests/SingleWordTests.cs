using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PalindromeFinder.Tests
{
    public class SingleWordTests
    {
        FindPalindrome findPalindrome;

        public SingleWordTests()
        {
            findPalindrome = new FindPalindrome();
        }

        [Fact]
        public void IsPalindrome_WhenPassedANull_ReturnsFalse()
        {
            bool sut = findPalindrome.IsPalindrome(null);

            Assert.False(sut);
        }

        [Fact]
        public void IsPalindrome_WhenPassedABlankString_ReturnsFalse()
        {
            bool sut = findPalindrome.IsPalindrome("");

            Assert.False(sut);
        }

        [Theory]
        [InlineData("Madam", true)]
        [InlineData("Redivider", true)]
        [InlineData("Noon", true)]
        [InlineData("Civic", true)]
        [InlineData("Kayak", true)]
        [InlineData("Tacocat", true)]
        public void IsPalindrome_WhenGivenASingleWordPalindrome_ReturnTrue
            (string input, bool expected)
        {
            bool sut = findPalindrome.IsPalindrome(input);

            Assert.Equal(expected, sut);
        }

        [Theory]
        [InlineData("Car", false)]
        [InlineData("River", false)]
        [InlineData("Moon", false)]
        [InlineData("Kohn", false)]
        [InlineData("Bird", false)]
        public void IsPalindrome_WhenGivenANonPalindromeWord_ReturnFalse
            (string input, bool expected)
        {
            bool sut = findPalindrome.IsPalindrome(input);

            Assert.Equal(expected, sut);
        }

        [Theory]
        [InlineData(new string[] {"Madam", "Redivider", "Noon", "Civic", "Kayak"}, true)]
        public void IsPalindrome_WhenUsedToCheckAListOfSingleWordPalindromes_ReturnTrue
            (IEnumerable<string> input, bool expected)
        {
            bool sut = input.All(findPalindrome.IsPalindrome);

            Assert.Equal(expected, sut);
        }

        [Theory]
        [InlineData(new string[] { "Car", "River", "Moon", "Kohn", "Bird" }, false)]
        public void IsPalindrome_WhenUsedToCheckAListOfSingleWordNonPalindromes_ReturnFalse
            (IEnumerable<string> input, bool expected)
        {
            bool sut = input.All(findPalindrome.IsPalindrome);

            Assert.Equal(expected, sut);
        }
    }
}
