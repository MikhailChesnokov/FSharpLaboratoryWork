using Microsoft.FSharp.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1_5_ListFilter;

namespace UnitTests.ListFilterIndex
{
    [TestClass]
    public class Functions
    {
        [TestMethod]
        public void RemoveEverySecond()
        {
            FSharpList<int> initial = ListModule.OfSeq(new[] {1, 2, 3, 4, 5, 6});
            FSharpList<int> expected = ListModule.OfSeq(new[] {1, 3, 5});

            FSharpList<int> result = removeEverySecond<int>(initial);

            Assert.AreEqual(expected, result);
        }
    }
}