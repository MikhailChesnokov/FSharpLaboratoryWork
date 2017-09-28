using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.FSharp.Core;
using static _1_3_Euler;

namespace UnitTests.Euler
{
    [TestClass]
    public class Functions
    {
        [TestMethod]
        public void Euler()
        {
            const int n = 70;
            FSharpOption<int> expected = new FSharpOption<int>(24);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }
    }
}