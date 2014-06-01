using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsInCSharpTest
{

    [TestClass]
    public class LongestCommonSubsequenceTest
    {
        private static LongestCommonSubsequenceSolution solution;
        private readonly String strEmpty = "";
        private String expected;
        private String actual;
        private readonly String str1 = "XMJYAUZ";
        private readonly String str2 = "MZJAWXU";
        private readonly String str3 = "MJAU";

        [ClassInitialize]
        public static void LongestCommonSubsequenceTestClassInitizlie(TestContext context)
        {
            solution = new LongestCommonSubsequenceSolution();
        }

        [ClassCleanup]
        public static void LongestCommonSubsequenceTestClassCleanup() 
        {
        }

        [TestMethod]
        public void LongestCommonSubsequenceTest_Empty()
        {

            actual = solution.LCS(strEmpty, strEmpty);
            expected = strEmpty;
            Assert.AreEqual(expected, actual);

            actual = solution.LCS(strEmpty, str1);
            expected = strEmpty;
            Assert.AreEqual(expected, actual);

            actual = solution.LCS(str2, strEmpty);
            expected = strEmpty;
            Assert.AreEqual(expected, actual);

            actual = solution.LCS("ABC", "EFG");
            expected = strEmpty;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestCommonSubsequenceTest_Normal()
        {
            actual = solution.LCS(str1, str2);
            expected = str3;
            Assert.AreEqual(expected, actual);
        }
    }
}
