using System;
using Microsoft.FSharp.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _3_2_TopologicalSort;

namespace UnitTests.TopologicalSort
{
    [TestClass]
    public class Function
    {
        [TestMethod]
        public void SortGraph()
        {
            FSharpList<int> expected = ListModule.OfArray(new[] {8, 7, 6, 5, 4, 3, 2, 1});
            FSharpList<Tuple<int, int>> input = ListModule.OfArray(new[]
            {
                new Tuple<int, int>(4, 1),
                new Tuple<int, int>(4, 2),
                new Tuple<int, int>(4, 3),
                new Tuple<int, int>(5, 2),
                new Tuple<int, int>(6, 4),
                new Tuple<int, int>(6, 5),
                new Tuple<int, int>(7, 4),
                new Tuple<int, int>(8, 3),
                new Tuple<int, int>(8, 5)
            });

            FSharpList<int> result = sortGraph<int>(input);

            Assert.AreEqual(expected, result);
        }
    }
}