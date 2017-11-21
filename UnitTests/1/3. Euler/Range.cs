using Microsoft.FSharp.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1_3_Euler;

namespace UnitTests.Euler
{
    [TestClass]
    public class Range
    {
        [TestMethod]
        public void SimpleN()
        {
            const int n = 7;
            FSharpOption<int> expected = new FSharpOption<int>(6);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LargeN()
        {
            const int n = 1001;
            FSharpOption<int> expected = new FSharpOption<int>(720);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NegativeN()
        {
            const int n = -1;
            FSharpOption<int> expected = null;

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ZeroN()
        {
            const int n = 0;
            FSharpOption<int> expected = null;

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }
    }
}