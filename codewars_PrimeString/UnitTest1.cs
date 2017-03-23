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

        [TestMethod]
        public void s_is_fdsyffdsyffdsyffdsyffdsyf_should_be_not_prime_string()
        {
            var s = "fdsyffdsyffdsyffdsyffdsyf";
            ShouldBeNotPrimeString(s);
        }
    }

    public class Kata
    {
        public bool PrimeString(string s)
        {
            var partialString = "";
            for (int i = 0; i < s.Length / 2; i++)
            {
                partialString += s[i];
                var startIndex = i + 1;
                var remainString = GetRemainString(s, startIndex);
                var result = remainString.Replace(partialString, "");
                if (string.IsNullOrWhiteSpace(result))
                {
                    return false;
                }
            }

            return true;
        }

        private static string GetRemainString(string s, int startIndex)
        {
            return s.Substring(startIndex, s.Length - startIndex);
        }
    }
}