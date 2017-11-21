using Microsoft.FSharp.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1_3_Euler;

namespace UnitTests.Euler
{
    [TestClass]
    public class InputDataLength
    {
        [TestMethod]
        public void Small_1E0()
        {
            const int n = 1;
            FSharpOption<int> expected = new FSharpOption<int>(1);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Small_1E1()
        {
            const int n = 13;
            FSharpOption<int> expected = new FSharpOption<int>(12);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Small_1E2()
        {
            const int n = 101;
            FSharpOption<int> expected = new FSharpOption<int>(100);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Medium_1E3()
        {
            const int n = 1009;
            FSharpOption<int> expected = new FSharpOption<int>(1008);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Medium_1E4()
        {
            const int n = 1000 * 10 + 7;
            FSharpOption<int> expected = new FSharpOption<int>(1000 * 10 + 6);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Large_1E5()
        {
            const int n = 1000 * 100 + 3;
            FSharpOption<int> expected = new FSharpOption<int>(1000 * 100 + 2);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Large_1E6()
        {
            const int n = 1000 * 1000 + 3;
            FSharpOption<int> expected = new FSharpOption<int>(1000 * 1000 + 2);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExtraLarge_1E7()
        {
            const int n = 1000 * 1000 * 10 + 19;
            FSharpOption<int> expected = new FSharpOption<int>(1000 * 1000 * 10 + 18);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }
    }
}