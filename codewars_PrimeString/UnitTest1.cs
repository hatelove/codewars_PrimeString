using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            ShoudBePrimeString(s);
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
            ShouldBeNotPrimeString(s);
        }

        [TestMethod]
        public void s_is_baba_should_be_prime_string()
        {
            var s = "baba";
            ShouldBeNotPrimeString(s);
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
                var partialString = "";
                for (int i = 0; i < s.Length / 2; i++)
                {
                    partialString += s[i];
                    var remainString = s.Substring(i + 1, s.Length - i - 1);
                    var result = remainString.Replace(partialString, "");
                    if (result.Length == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}