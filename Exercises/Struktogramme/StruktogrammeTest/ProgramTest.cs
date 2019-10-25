using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StruktogrammeTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void Test_SucheMaximum_Ok()
        {
            var arr = new[] {8, 3, 6, 1, 2, 9};

            int ergebnis = Struktogramme.Program.SucheMaximum(arr);

            Assert.AreEqual(9, ergebnis);
        }

        [TestMethod]
        public void Test_SucheMaximumIndex_Ok()
        {
            var arr = new[] {8, 3, 6, 1, 2, 9};

            int ergebnis = Struktogramme.Program.SucheMaximumIndex(arr);

            Assert.AreEqual(5, ergebnis);
        }

        [TestMethod]
        public void Test_IndexWert_Ok()
        {
            var arr = new[] { 8, 3, 6, 1, 2, 9 };

            int ergebnis = Struktogramme.Program.IndexWert(arr,6);

            Assert.AreEqual(2, ergebnis);
            Assert.AreEqual(6, arr[ergebnis]);
            
        }

        [TestMethod]
        public void Test_IndexWert_NotFound()
        {
            var arr = new[] { 8, 3, 6, 1, 2, 9 };

            int ergebnis = Struktogramme.Program.IndexWert(arr, 7);

            Assert.AreEqual(-1, ergebnis);
        }
    }
}
