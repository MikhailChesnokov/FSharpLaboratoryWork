using Microsoft.FSharp.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1_3_Euler;

namespace UnitTests.Euler
{
    [TestClass]
    public class OutputDataClasses
    {
        [TestMethod]
        public void integerValue()
        {
            const int n = 11;
            FSharpOption<int> expected = new FSharpOption<int>(10);

            FSharpOption<int> result = euler(n);

            Assert.AreEqual(expected, result);
        }
    }
}