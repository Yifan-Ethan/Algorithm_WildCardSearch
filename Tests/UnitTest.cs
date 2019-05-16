using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms_WildCardSearch;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestTSIWCS()
        {
            //Full text test
            Assert.AreEqual(true, TSIWCS.Run("ABCDEFG", "ABCDEFG"));

            //Leading percent test
            Assert.AreEqual(true, TSIWCS.Run("%EFG", "ABCDEFG"));

            //Trailing percent test
            Assert.AreEqual(true, TSIWCS.Run("ABC%", "ABCDEFG"));

            //Middle percent test
            Assert.AreEqual(true, TSIWCS.Run("ABC%EFG", "ABCDEFG"));

            //Leading underscore test
            Assert.AreEqual(true, TSIWCS.Run("_BCDEFG", "ABCDEFG"));

            //Trailing underscore test
            Assert.AreEqual(true, TSIWCS.Run("ABCDEF_", "ABCDEFG"));

            //Middle underscore test
            Assert.AreEqual(true, TSIWCS.Run("ABC_EFG", "ABCDEFG"));

            //Mixed wild card test
            Assert.AreEqual(true, TSIWCS.Run("_BCD%_", "ABCDEFG"));

            //Repeated character test
            Assert.AreEqual(true, TSIWCS.Run("ABC%DEF", "ABCXXDDEF"));

            //Repeated pattern test
            Assert.AreEqual(true, TSIWCS.Run("ABC%FGHI%FGHI", "ABCFGHIFGHIFGHI"));

            //Multiple percent test
            Assert.AreEqual(true, TSIWCS.Run("ABC%EF%GHI%MNQ%XYZ", "ABCDEFGHIJKLMNQRSTUVWXYZ"));

            //Search length test
            Assert.AreEqual(true, TSIWCS.Run("ABC%DEF", "ABCDEF"));

            //Search length test 2
            Assert.AreEqual(false, TSIWCS.Run("ABC%DEFG", "ABCDEF"));

            //All percent test
            Assert.AreEqual(true, TSIWCS.Run("%%%%%%", "ABCDEF"));

            //Leading percent underscore mismatch test
            Assert.AreEqual(false, TSIWCS.Run("%_HIJKL", "ABCDEFG"));

            //Character following percent is last character in string mismatch test
            Assert.AreEqual(false, TSIWCS.Run("%GABCDE", "ABCDEFG"));
        }

        [TestMethod]
        public void TestNaive()
        {
            //Full text test
            Assert.AreEqual(true, Naive.Run("ABCDEFG", "ABCDEFG"));

            //Leading percent test
            Assert.AreEqual(true, Naive.Run("%EFG", "ABCDEFG"));

            //Trailing percent test
           Assert.AreEqual(true, Naive.Run("ABC%", "ABCDEFG"));

            //Middle percent test
           Assert.AreEqual(true, Naive.Run("ABC%EFG", "ABCDEFG"));

            //Leading underscore test
            Assert.AreEqual(true, Naive.Run("_BCDEFG", "ABCDEFG"));

            //Trailing underscore test
          Assert.AreEqual(true, Naive.Run("ABCDEF_", "ABCDEFG"));

            //Middle underscore test
            Assert.AreEqual(true, Naive.Run("ABC_EFG", "ABCDEFG"));

            //Mixed wild card test
           Assert.AreEqual(true, Naive.Run("_BCD%_", "ABCDEFG"));

            //Repeated character test
           Assert.AreEqual(true, Naive.Run("ABC%DEF", "ABCXXDDEF"));

            //Repeated pattern test
           Assert.AreEqual(true, Naive.Run("ABC%FGHI%FGHI", "ABCFGHIFGHIFGHI"));

            //Multiple percent test
           Assert.AreEqual(true, Naive.Run("ABC%EF%GHI%MNQ%XYZ", "ABCDEFGHIJKLMNQRSTUVWXYZ"));

            //Search length test
           Assert.AreEqual(true, Naive.Run("ABC%DEF", "ABCDEF"));

            //Search length test 2
           Assert.AreEqual(false, Naive.Run("ABC%DEFG", "ABCDEF"));

            //All percent test
           Assert.AreEqual(true, Naive.Run("%%%%%%", "ABCDEF"));

            //Leading percent underscore mismatch test
           Assert.AreEqual(false, Naive.Run("%_HIJKL", "ABCDEFG"));

            //Character following percent is last character in string mismatch test
          Assert.AreEqual(false, Naive.Run("%GABCDE", "ABCDEFG"));
        }

        [TestMethod]
        public void TestSM()
        {
            //Full text test
            Assert.AreEqual(true, SM.Run("ABCDEFG", "ABCDEFG"));

            //Leading percent test
            Assert.AreEqual(true, SM.Run("%EFG", "ABCDEFG"));

            //Trailing percent test
            Assert.AreEqual(true, SM.Run("ABC%", "ABCDEFG"));

            //Middle percent test
            Assert.AreEqual(true, SM.Run("ABC%EFG", "ABCDEFG"));

            //Leading underscore test
            Assert.AreEqual(true, SM.Run("_BCDEFG", "ABCDEFG"));

            //Trailing underscore test
            Assert.AreEqual(true, SM.Run("ABCDEF_", "ABCDEFG"));

            //Middle underscore test
            Assert.AreEqual(true, SM.Run("ABC_EFG", "ABCDEFG"));

            //Mixed wild card test
            Assert.AreEqual(true, SM.Run("_BCD%_", "ABCDEFG"));

            //Repeated character test
            Assert.AreEqual(true, SM.Run("ABC%DEF", "ABCXXDDEF"));

            //Repeated pattern test
            Assert.AreEqual(true, SM.Run("ABC%FGHI%FGHI", "ABCFGHIFGHIFGHI"));

            //Multiple percent test
            Assert.AreEqual(true, SM.Run("ABC%EF%GHI%MNQ%XYZ", "ABCDEFGHIJKLMNQRSTUVWXYZ"));

            //Search length test
            Assert.AreEqual(true, SM.Run("ABC%DEF", "ABCDEF"));

            //Search length test 2
            Assert.AreEqual(false, SM.Run("ABC%DEFG", "ABCDEF"));

            //All percent test
            Assert.AreEqual(true, SM.Run("%%%%%%", "ABCDEF"));

            //Leading percent underscore mismatch test
            Assert.AreEqual(false, SM.Run("%_HIJKL", "ABCDEFG"));

            //Character following percent is last character in string mismatch test
            Assert.AreEqual(false, SM.Run("%GABCDE", "ABCDEFG"));
        }
    }
}
