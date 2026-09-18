using System;
using NUnit.Framework;
using Lab1;

namespace Lab1.Tests
{
    [TestFixture]
    public class Tests
    {
        // ============================================================
        // 1.1 Sort
        // ============================================================

        [Test]
        public void Sort_NullArray_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Tasks.Sort(null));
        }

        [Test]
        public void Sort_EmptyArray_ReturnsEmptyArray()
        {
            int[] result = Tasks.Sort(new int[0]);
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Sort_UnsortedArray_ReturnsSorted()
        {
            int[] result = Tasks.Sort(new[] { 5, 2, 9, 1, 7 });
            Assert.That(result, Is.EqualTo(new[] { 1, 2, 5, 7, 9 }));
        }

        [Test]
        public void Sort_WithNegatives_SortsCorrectly()
        {
            int[] result = Tasks.Sort(new[] { -3, 0, -10, 5 });
            Assert.That(result, Is.EqualTo(new[] { -10, -3, 0, 5 }));
        }

        // ============================================================
        // 1.2 Palindrome
        // ============================================================

        [Test]
        public void Palindrome_Null_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Tasks.Palindrome(null));
        }

        [Test]
        public void Palindrome_EmptyString_ReturnsTrue()
        {
            Assert.That(Tasks.Palindrome(""), Is.True);
        }

        [Test]
        public void Palindrome_SingleChar_ReturnsTrue()
        {
            Assert.That(Tasks.Palindrome("a"), Is.True);
        }

        [Test]
        public void Palindrome_SimplePalindrome_ReturnsTrue()
        {
            Assert.That(Tasks.Palindrome("level"), Is.True);
        }

        [Test]
        public void Palindrome_NotPalindrome_ReturnsFalse()
        {
            Assert.That(Tasks.Palindrome("hello"), Is.False);
        }
        

        // ============================================================
        // 1.3 Factorial
        // ============================================================

        [Test]
        public void Factorial_Negative_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Tasks.Factorial(-1));
        }

        [Test]
        public void Factorial_Zero_ReturnsOne()
        {
            Assert.That(Tasks.Factorial(0), Is.EqualTo(1));
        }

        [Test]
        public void Factorial_Five_Returns120()
        {
            Assert.That(Tasks.Factorial(5), Is.EqualTo(120));
        }

        [Test]
        public void Factorial_Ten_Returns3628800()
        {
            Assert.That(Tasks.Factorial(10), Is.EqualTo(3628800L));
        }

        [Test]
        public void Factorial_Twenty_ReturnsLongValue()
        {
            // 20! = 2 432 902 008 176 640 000
            Assert.That(Tasks.Factorial(20), Is.EqualTo(2432902008176640000L));
        }

        // ============================================================
        // 1.4 Fibbonachi
        // ============================================================

        [Test]
        public void Fibonacci_Negative_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Tasks.Fibonacci(-1));
        }

        [Test]
        public void Fibonacci_Zero_ReturnsZero()
        {
            Assert.That(Tasks.Fibonacci(0), Is.EqualTo(0));
        }

        [Test]
        public void Fibonacci_Two_ReturnsOne()
        {
            Assert.That(Tasks.Fibonacci(2), Is.EqualTo(1));
        }

        [Test]
        public void Fibonacci_Three_ReturnsTwo()
        {
            Assert.That(Tasks.Fibonacci(3), Is.EqualTo(2));
        }

        [Test]
        public void Fibonacci_Ten_ReturnsFiftyFive()
        {
            Assert.That(Tasks.Fibonacci(10), Is.EqualTo(55));
        }

        // ============================================================
        // 1.5 FindSubStr
        // ============================================================

        [Test]
        public void FindSubStr_NullString_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Tasks.FindSubStr(null, "a"));
        }

        [Test]
        public void FindSubStr_EmptySubstring_ReturnsZero()
        {
            Assert.That(Tasks.FindSubStr("abc", ""), Is.EqualTo(0));
        }

        [Test]
        public void FindSubStr_FoundInMiddle_ReturnsIndex()
        {
            Assert.That(Tasks.FindSubStr("hello world", "wor"), Is.EqualTo(6));
        }

        [Test]
        public void FindSubStr_FoundAtEnd_ReturnsIndex()
        {
            Assert.That(Tasks.FindSubStr("hello", "lo"), Is.EqualTo(3));
        }

        [Test]
        public void FindSubStr_SubstringLongerThanString_ReturnsMinusOne()
        {
            Assert.That(Tasks.FindSubStr("ab", "abcdef"), Is.EqualTo(-1));
        }

        // ============================================================
        // 1.6 Prost
        // ============================================================

        [Test]
        public void Prost_LessThanTwo_ReturnsFalse()
        {
            Assert.That(Tasks.Prost(0), Is.False);
            Assert.That(Tasks.Prost(1), Is.False);
            Assert.That(Tasks.Prost(-5), Is.False);
        }

        [Test]
        public void Prost_Two_ReturnsTrue()
        {
            Assert.That(Tasks.Prost(2), Is.True);
        }

        [Test]
        public void Prost_Four_ReturnsFalse()
        {
            Assert.That(Tasks.Prost(4), Is.False);
        }

        [Test]
        public void Prost_PrimeLarge_ReturnsTrue()
        {
            Assert.That(Tasks.Prost(97), Is.True);
        }

        [Test]
        public void Prost_CompositeLarge_ReturnsFalse()
        {
            Assert.That(Tasks.Prost(100), Is.False);
        }

        // ============================================================
        // 1.7 Reverse
        // ============================================================

        [Test]
        public void Reverse_PositiveNumber_ReturnsReversed()
        {
            Assert.That(Tasks.Reverse(123), Is.EqualTo(321));
        }

        [Test]
        public void Reverse_NegativeNumber_ReturnsReversed()
        {
            Assert.That(Tasks.Reverse(-120), Is.EqualTo(-21));
        }

        [Test]
        public void Reverse_Zero_ReturnsZero()
        {
            Assert.That(Tasks.Reverse(0), Is.EqualTo(0));
        }

        [Test]
        public void Reverse_Overflow_ReturnsZero()
        {
            Assert.That(Tasks.Reverse(int.MaxValue), Is.EqualTo(0));
        }

        // ============================================================
        // 1.8 Rim
        // ============================================================

        [Test]
        public void Rim_One_ReturnsI()
        {
            Assert.That(Tasks.Rim(1), Is.EqualTo("I"));
        }

        [Test]
        public void Rim_Ten_ReturnsX()
        {
            Assert.That(Tasks.Rim(10), Is.EqualTo("X"));
        }

        [Test]
        public void Rim_TwentySeven_ReturnsXXVII()
        {
            Assert.That(Tasks.Rim(27), Is.EqualTo("XXVII"));
        }

        [Test]
        public void Rim_1994_ReturnsMCMXCIV()
        {
            Assert.That(Tasks.Rim(1994), Is.EqualTo("MCMXCIV"));
        }

        [Test]
        public void Rim_3999_ReturnsMMMCMXCIX()
        {
            Assert.That(Tasks.Rim(3999), Is.EqualTo("MMMCMXCIX"));
        }
    }
}