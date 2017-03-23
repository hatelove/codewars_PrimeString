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

        private static void ShoudBePrimeString(string s)
        {
            Assert.IsTrue(new Kata().PrimeString(s));
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

            throw new NotImplementedException();
        }
    }
}