using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4_2710;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2710.Tests
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void PalindromTest()
        {
            // arrange
            int n = 122;
            bool expected = true;

            // act
            bool result = Palindrome.Palindrom(n);

            // assert
            Assert.AreEqual(expected, result);
        }
    }
}