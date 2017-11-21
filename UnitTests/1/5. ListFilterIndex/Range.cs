using Microsoft.FSharp.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1_5_ListFilter;

namespace UnitTests.ListFilterIndex
{
    [TestClass]
    public class Range
    {
        [TestMethod]
        public void StandartList()
        {
            FSharpList<int> initial = ListModule.OfSeq(new[] {1, 2, 3, 4, 5, 6, 7, 8});
            FSharpList<int> expected = ListModule.OfSeq(new[] {1, 3, 5, 7});

            FSharpList<int> result = removeEverySecond<int>(initial);

            Assert.AreEqual(expected, result);
        }
    }
}