using Microsoft.FSharp.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1_3_Euler;

namespace UnitTests.Euler
{
    [TestClass]
    public class InputDataClasses
    {
        [TestMethod]
        public void _1()
        {
            const int n = 1;
            FSharpOption<int> expected = new FSharpOption<int>(1);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void _n()
        {
            const int n = 100;
            FSharpOption<int> expected = new FSharpOption<int>(40);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }
    }
}