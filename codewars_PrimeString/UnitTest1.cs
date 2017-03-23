using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace codewars_PrimeString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void s_is_b_should_be_prime_string()
        {
            var s = "b";
            ShoudBePrimeString(s);
        }

        [TestMethod]
        public void s_is_ab_should_be_not_prime_string()
        {
            var s = "ab";
            ShouldBeNotPrimeString(s);
        }

        private static void ShouldBeNotPrimeString(string s)
        {
            Assert.IsFalse(new Kata().PrimeString(s));
        }

        private static void ShoudBePrimeString(string s)
        {
            Assert.IsTrue(new Kata().PrimeString(s));
        }

        [TestMethod]
        public void s_is_bb_should_be_prime_string()
        {
            var s = "bb";
            ShoudBePrimeString(s);
        }
    }

    public class Kata
    {
        public bool PrimeString(string s)
        {
            if (s.Length == 1)
            {
                return true;
            }
            else
            {
                if (s[0] != s[1])
                {
                    return false;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}