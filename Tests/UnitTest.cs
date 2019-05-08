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
        }
    }
}
