using System;
using Microsoft.FSharp.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _3_2_TopologicalSort;

namespace UnitTests.TopologicalSort
{
    [TestClass]
    public class InputDataLength
    {
        [TestMethod]
        public void EmptyGraph()
        {
            FSharpList<int> expected = ListModule.OfArray(new int[] { });
            FSharpList<Tuple<int, int>> input = ListModule.OfArray(new Tuple<int, int>[0]);

            FSharpList<int> result = sortGraph<int>(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TwoElementGraph()
        {
            FSharpList<int> expected = ListModule.OfArray(new[] {2, 1});
            FSharpList<Tuple<int, int>> input = ListModule.OfArray(new[]
            {
                new Tuple<int, int>(2, 1)
            });

            FSharpList<int> result = sortGraph<int>(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ThreeElementGraph()
        {
            FSharpList<int> expected = ListModule.OfArray(new[] {3, 2, 1});
            FSharpList<Tuple<int, int>> input = ListModule.OfArray(new[]
            {
                new Tuple<int, int>(2, 1),
                new Tuple<int, int>(3, 1)
            });

            FSharpList<int> result = sortGraph<int>(input);

            Assert.AreEqual(expected, result);
        }
    }
}