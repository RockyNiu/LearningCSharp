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
        private const String strEmpty = "";
        private String expected;
        private String actual;
        private const String str1 = "XMJYAUZ";
        private const String str2 = "MZJAWXU";
        private const String str3 = "MJAU";

        [TestMethod]
        public void LongestCommonSubsequenceTest_Empty()
        {

            actual = LCSLine.LCS(strEmpty, strEmpty);
            expected = strEmpty;
            Assert.AreEqual(expected, actual);

            actual = LCSLine.LCS(strEmpty, str1);
            expected = strEmpty;
            Assert.AreEqual(expected, actual);

            actual = LCSLine.LCS(str2, strEmpty);
            expected = strEmpty;
            Assert.AreEqual(expected, actual);

            actual = LCSLine.LCS("ABC", "EFG");
            expected = strEmpty;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestCommonSubsequenceTest_Normal()
        {
            actual = LCSLine.LCS(str1, str2);
            expected = str3;
            Assert.AreEqual(expected, actual);
        }
    }
}
