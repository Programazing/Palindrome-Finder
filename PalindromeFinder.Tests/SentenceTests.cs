using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PalindromeFinder.Tests
{
    public class SentenceTests
    {
        FindPalindrome findPalindrome;

        public SentenceTests()
        {
            findPalindrome = new FindPalindrome();
        }

        [Theory]
        [InlineData("Mr. Owl ate my metal worm.", true)]
        [InlineData("Was it a car or a cat I saw?", true)]
        [InlineData("Go hang a salami, I'm a lasagna hog.", true)]
        [InlineData("Rats live on no evil star", true)]
        [InlineData("Live on time, emit no evil.", true)]
        public void IsPalindrome_WhenGivenAPalindromeSentence_ReturnsTrue(string input, bool expected)
        {
            var sut = findPalindrome.IsPalindrome(input);

            Assert.Equal(expected, sut);
        }

        [Theory]
        [InlineData("Mr. Owl ate my metal worms.", false)]
        [InlineData("Was it a car or a cow I saw?", false)]
        [InlineData("Go hang a salami, I'm a lasagna fan.", false)]
        [InlineData("Rats live on an evil star", false)]
        [InlineData("Live on time, die on time.", false)]
        public void IsPalindrome_WhenGivenANonPalindromeSentence_ReturnsFalse(string input, bool expected)
        {
            var sut = findPalindrome.IsPalindrome(input);

            Assert.Equal(expected, sut);
        }

        [Theory]
        [InlineData(new string[] { "Mr. Owl ate my metal worm.", "Rats live on no evil star", "Live on time, emit no evil." }, true)]
        public void IsPalindrome_WhenGivenAListOfPalindromeSentences_ReturnsTrue(string[] input, bool expected)
        {
            var sut = findPalindrome.IsPalindrome(input);

            Assert.Equal(expected, sut);
        }

        [Theory]
        [InlineData(new string[] { "Mr. Owl ate my metal worms.", "Rats live on an evil star", "Live on time, die on time." }, false)]
        public void IsPalindrome_WhenGivenAListOfNonPalindromeSentences_ReturnsFalse(string[] input, bool expected)
        {
            var sut = findPalindrome.IsPalindrome(input);

            Assert.Equal(expected, sut);
        }
    }
}
