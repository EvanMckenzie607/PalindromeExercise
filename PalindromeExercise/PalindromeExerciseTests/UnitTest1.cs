using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class WordTest
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("helping", false)]
        [InlineData("tacocat", true)]
        public void Test1(string input, bool expected)
        {
            var x = new WordSmith();
            
            var outcome =  x.IsAPalindrome(input);

            Assert.Equal(expected, outcome);
        }
    }
}
