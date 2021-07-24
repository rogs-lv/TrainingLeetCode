using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Algorithms.Test
{
    public class PalindromeNumberTest
    {
        PalindromeNumber _palindromeNumber;
        public PalindromeNumberTest() {
            _palindromeNumber = new PalindromeNumber();
        }
        [Fact]
        public void IsPalindrome_IsMoreOrEqualThan_ReturnFalse() {
            int number = -2147483648;

            var result = _palindromeNumber.IsPalindrome(number);
            Assert.False(result);
        }
        [Fact]
        public void IsPalindrome_IsLessOrEqualThan_ReturnFalse() { 
            int number = 2147483647;

            var result = _palindromeNumber.IsPalindrome(number);
            Assert.False(result);
        }
        [Fact]
        public void IsPalindrome_ValueZero_ReturnTrue() {
            int number = 0;

            var result = _palindromeNumber.IsPalindrome(number);
            Assert.True(result);
        }
        [Fact]
        public void IsPalindrome_NumberPositive_ReturnTrue() {
            int number = 121;

            var result = _palindromeNumber.IsPalindrome(number);
            Assert.True(result);
        }
        [Fact]
        public void IsPalindrome_NumberNegative_ReturnFalse()
        {
            int number = -515;

            var result = _palindromeNumber.IsPalindrome(number);
            Assert.False(result);
        }
        [Fact]
        public void IsPalindrome_NumberTwoDigits_ReturnFalse()
        {
            int number = 10;

            var result = _palindromeNumber.IsPalindrome(number);
            Assert.False(result);
        }
    }
}
