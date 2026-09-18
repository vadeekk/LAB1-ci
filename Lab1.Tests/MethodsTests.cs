using NUnit.Framework;
using System;
using Lab1.Core;

namespace Lab1.Tests
{
    [TestFixture]
    public class MethodsTests
    {
        // ================== SORT ==================
        [Test]
        public void SortArray_UnsortedArray_ReturnsSorted()
        {
            var input = new[] { 5, 2, 8, 1, 9, 3 };
            var result = Methods.SortArray(input);
            Assert.That(result, Is.EqualTo(new[] { 1, 2, 3, 5, 8, 9 }));
        }

        [Test]
        public void SortArray_EmptyArray_ReturnsEmpty()
        {
            var result = Methods.SortArray(Array.Empty<int>());
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void SortArray_SingleElement_ReturnsSame()
        {
            var result = Methods.SortArray(new[] { 42 });
            Assert.That(result, Is.EqualTo(new[] { 42 }));
        }

        [Test]
        public void SortArray_Duplicates_ReturnsSorted()
        {
            var result = Methods.SortArray(new[] { 3, 3, 1, 2, 1 });
            Assert.That(result, Is.EqualTo(new[] { 1, 1, 2, 3, 3 }));
        }

        [Test]
        public void SortArray_Null_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Methods.SortArray(null));
        }

        // ================== PALINDROME ==================
        [Test]
        public void IsPalindrome_SimplePalindrome_ReturnsTrue()
        {
            Assert.That(Methods.IsPalindrome("level"), Is.True);
        }

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            Assert.That(Methods.IsPalindrome("hello"), Is.False);
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            Assert.That(Methods.IsPalindrome(""), Is.True);
        }

        [Test]
        public void IsPalindrome_SingleChar_ReturnsTrue()
        {
            Assert.That(Methods.IsPalindrome("a"), Is.True);
        }

        [Test]
        public void IsPalindrome_Null_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Methods.IsPalindrome(null));
        }

        // ================== FACTORIAL ==================
        [Test]
        public void Factorial_Zero_ReturnsOne()
        {
            Assert.That(Methods.Factorial(0), Is.EqualTo(1));
        }

        [Test]
        public void Factorial_Five_Returns120()
        {
            Assert.That(Methods.Factorial(5), Is.EqualTo(120));
        }

        [Test]
        public void Factorial_One_ReturnsOne()
        {
            Assert.That(Methods.Factorial(1), Is.EqualTo(1));
        }

        [Test]
        public void Factorial_Twenty_ReturnsCorrect()
        {
            Assert.That(Methods.Factorial(20), Is.EqualTo(2432902008176640000L));
        }

        [Test]
        public void Factorial_Negative_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Methods.Factorial(-1));
        }

        [Test]
        public void Factorial_TooLarge_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Methods.Factorial(21));
        }

        // ================== FIBONACCI ==================
        [Test]
        public void Fibonacci_Zero_ReturnsZero()
        {
            Assert.That(Methods.Fibonacci(0), Is.EqualTo(0));
        }

        [Test]
        public void Fibonacci_One_ReturnsOne()
        {
            Assert.That(Methods.Fibonacci(1), Is.EqualTo(1));
        }

        [Test]
        public void Fibonacci_Ten_Returns55()
        {
            Assert.That(Methods.Fibonacci(10), Is.EqualTo(55));
        }

        [Test]
        public void Fibonacci_Twenty_Returns6765()
        {
            Assert.That(Methods.Fibonacci(20), Is.EqualTo(6765));
        }

        [Test]
        public void Fibonacci_Negative_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Methods.Fibonacci(-1));
        }

        [Test]
        public void Fibonacci_TooLarge_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Methods.Fibonacci(93));
        }

        // ================== FIND SUBSTRING ==================
        [Test]
        public void FindSubstring_Found_ReturnsIndex()
        {
            Assert.That(Methods.FindSubstring("hello world", "world"), Is.EqualTo(6));
        }

        [Test]
        public void FindSubstring_NotFound_ReturnsMinusOne()
        {
            Assert.That(Methods.FindSubstring("hello", "xyz"), Is.EqualTo(-1));
        }

        [Test]
        public void FindSubstring_EmptySubstring_ReturnsZero()
        {
            Assert.That(Methods.FindSubstring("hello", ""), Is.EqualTo(0));
        }

        [Test]
        public void FindSubstring_SubstringLongerThanText_ReturnsMinusOne()
        {
            Assert.That(Methods.FindSubstring("hi", "hello"), Is.EqualTo(-1));
        }

        [Test]
        public void FindSubstring_AtStart_ReturnsZero()
        {
            Assert.That(Methods.FindSubstring("hello", "he"), Is.EqualTo(0));
        }

        [Test]
        public void FindSubstring_NullText_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Methods.FindSubstring(null, "a"));
        }

        [Test]
        public void FindSubstring_NullSubstring_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Methods.FindSubstring("abc", null));
        }

        // ================== IS PRIME ==================
        [Test]
        public void IsPrime_Two_ReturnsTrue()
        {
            Assert.That(Methods.IsPrime(2), Is.True);
        }

        [Test]
        public void IsPrime_Seventeen_ReturnsTrue()
        {
            Assert.That(Methods.IsPrime(17), Is.True);
        }

        [Test]
        public void IsPrime_Four_ReturnsFalse()
        {
            Assert.That(Methods.IsPrime(4), Is.False);
        }

        [Test]
        public void IsPrime_One_ReturnsFalse()
        {
            Assert.That(Methods.IsPrime(1), Is.False);
        }

        [Test]
        public void IsPrime_Zero_ReturnsFalse()
        {
            Assert.That(Methods.IsPrime(0), Is.False);
        }

        [Test]
        public void IsPrime_Negative_ReturnsFalse()
        {
            Assert.That(Methods.IsPrime(-7), Is.False);
        }

        // ================== REVERSE INTEGER ==================
        [Test]
        public void ReverseInteger_Positive_ReturnsReversed()
        {
            Assert.That(Methods.ReverseInteger(123), Is.EqualTo(321));
        }

        [Test]
        public void ReverseInteger_NegativeWithZero_ReturnsNegativeReversed()
        {
            Assert.That(Methods.ReverseInteger(-120), Is.EqualTo(-21));
        }

        [Test]
        public void ReverseInteger_Zero_ReturnsZero()
        {
            Assert.That(Methods.ReverseInteger(0), Is.EqualTo(0));
        }

        [Test]
        public void ReverseInteger_Overflow_ReturnsZero()
        {
            Assert.That(Methods.ReverseInteger(1534236469), Is.EqualTo(0));
        }

        [Test]
        public void ReverseInteger_SingleDigit_ReturnsSame()
        {
            Assert.That(Methods.ReverseInteger(7), Is.EqualTo(7));
        }

        // ================== TO ROMAN ==================
        [Test]
        public void ToRoman_One_ReturnsI()
        {
            Assert.That(Methods.ToRoman(1), Is.EqualTo("I"));
        }

        [Test]
        public void ToRoman_Four_ReturnsIV()
        {
            Assert.That(Methods.ToRoman(4), Is.EqualTo("IV"));
        }

        [Test]
        public void ToRoman_Nine_ReturnsIX()
        {
            Assert.That(Methods.ToRoman(9), Is.EqualTo("IX"));
        }

        [Test]
        public void ToRoman_1994_ReturnsMCMXCIV()
        {
            Assert.That(Methods.ToRoman(1994), Is.EqualTo("MCMXCIV"));
        }

        [Test]
        public void ToRoman_3999_ReturnsMMMCMXCIX()
        {
            Assert.That(Methods.ToRoman(3999), Is.EqualTo("MMMCMXCIX"));
        }

        [Test]
        public void ToRoman_Zero_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Methods.ToRoman(0));
        }

        [Test]
        public void ToRoman_TooLarge_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Methods.ToRoman(4000));
        }
    }
}