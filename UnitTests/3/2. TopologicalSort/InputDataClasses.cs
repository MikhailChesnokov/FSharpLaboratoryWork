using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.FSharp.Collections;
using static _3_2_TopologicalSort;

namespace UnitTests.TopologicalSort
{
    [TestClass]
    public class InputDataClasses
    {
        [TestMethod]
        public void TreeGraph_Integer()
        {
            //     / 3
            //    6 
            //   / \ 4
            //  7
            //   \ / 1
            //    5
            //     \ 2
            FSharpList<int> expected = ListModule.OfArray(new[] { 7, 6, 4, 3, 5, 2, 1 });
            FSharpList<Tuple<int, int>> input = ListModule.OfArray(new[]
            {
                new Tuple<int, int>(5,1),
                new Tuple<int, int>(5,2),
                new Tuple<int, int>(6,3),
                new Tuple<int, int>(6,4),
                new Tuple<int, int>(7,5),
                new Tuple<int, int>(7,6)
            });

            FSharpList<int> result = sortGraph(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void StandartGraph_Integer()
        {
            //    6   3
            //   / \ / \
            //  7   4   1
            //   \ / \ /
            //    5   2
            FSharpList<int> expected = ListModule.OfArray(new[] {  7, 6, 5, 4, 3, 2, 1 });
            FSharpList<Tuple<int, int>> input = ListModule.OfArray(new[]
            {
                new Tuple<int, int>(2,1),
                new Tuple<int, int>(3,1),
                new Tuple<int, int>(4,2),
                new Tuple<int, int>(4,3),
                new Tuple<int, int>(5,4),
                new Tuple<int, int>(6,4),
                new Tuple<int, int>(7,5),
                new Tuple<int, int>(7,6)
            });

            FSharpList<int> result = sortGraph(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TreeGraph_String()
        {
            //     / 3
            //    6 
            //   / \ 4
            //  7
            //   \ / 1
            //    5
            //     \ 2
            FSharpList<string> expected = ListModule.OfArray(new[] { "seven", "six", "four", "three", "five", "two", "one" });
            FSharpList<Tuple<string, string>> input = ListModule.OfArray(new[]
            {
                new Tuple<string, string>("five","one"),
                new Tuple<string, string>("five","two"),
                new Tuple<string, string>("six","three"),
                new Tuple<string, string>("six","four"),
                new Tuple<string, string>("seven","five"),
                new Tuple<string, string>("seven","six")
            });

            FSharpList<string> result = sortGraph(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ListGraph()
        {
            //     7 --> 6 --> 5 --> 4 --> 3 --> 2 --> 1
            FSharpList<int> expected = ListModule.OfArray(new[] { 7, 6, 5, 4, 3, 2, 1 });
            FSharpList<Tuple<int, int>> input = ListModule.OfArray(new[]
            {
                new Tuple<int, int>(2,1),
                new Tuple<int, int>(3,2),
                new Tuple<int, int>(4,3),
                new Tuple<int, int>(5,4),
                new Tuple<int, int>(6,5),
                new Tuple<int, int>(7,6)
            });

            FSharpList<int> result = sortGraph(input);

            Assert.AreEqual(expected, result);
        }
    }
}