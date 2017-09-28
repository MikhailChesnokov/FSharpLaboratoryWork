using Microsoft.FSharp.Collections;
using Microsoft.FSharp.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1_5_ListFilter;

namespace UnitTests.ListFilterIndex
{
    [TestClass]
    public class OutputDataClasses
    {
        [TestMethod]
        public void OutputList()
        {
            FSharpList<int> initial = ListModule.OfSeq<int>(new[] { 1, 2, 3});
            FSharpList<int> expected = ListModule.OfSeq<int>(new[] { 1, 3 });

            FSharpList<int> result = removeEverySecond(initial);

            Assert.AreEqual(expected, result);
        }
    }
}