using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.FSharp.Collections;
using static _3_2_TopologicalSort;

namespace UnitTests.TopologicalSort
{
    [TestClass]
    public class Order
    {
        [TestMethod]
        public void Order1()
        {
            //  4
            //   \
            //    3 --- 1
            //     \   /     
            //       2
            FSharpList<int> expected = ListModule.OfArray(new[] { 4, 3, 2, 1 });
            FSharpList<Tuple<int, int>> input = ListModule.OfArray(new[]
            {
                new Tuple<int, int>(4,3),
                new Tuple<int, int>(3,2),
                new Tuple<int, int>(3,1),
                new Tuple<int, int>(2,1)
            });

            FSharpList<int> result = sortGraph(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Order2()
        {
            //  4
            //   \
            //    3 --- 1
            //     \   /     
            //       2
            FSharpList<int> expected = ListModule.OfArray(new[] { 4, 3, 2, 1 });
            FSharpList<Tuple<int, int>> input = ListModule.OfArray(new[]
            {
                new Tuple<int, int>(4,3),
                new Tuple<int, int>(3,2),
                new Tuple<int, int>(2,1),
                new Tuple<int, int>(3,1)
            });

            FSharpList<int> result = sortGraph(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Order3()
        {
            //  4
            //   \
            //    3 --- 1
            //     \   /     
            //       2
            FSharpList<int> expected = ListModule.OfArray(new[] { 4, 3, 2, 1 });
            FSharpList<Tuple<int, int>> input = ListModule.OfArray(new[]
            {
                new Tuple<int, int>(2,1),
                new Tuple<int, int>(3,2),
                new Tuple<int, int>(3,1),
                new Tuple<int, int>(4,3)
            });

            FSharpList<int> result = sortGraph(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Order4()
        {
            //  4
            //   \
            //    3 --- 1
            //     \   /     
            //       2
            FSharpList<int> expected = ListModule.OfArray(new[] { 4, 3, 2, 1 });
            FSharpList<Tuple<int, int>> input = ListModule.OfArray(new[]
            {
                new Tuple<int, int>(2,1),
                new Tuple<int, int>(4,3),
                new Tuple<int, int>(3,2),
                new Tuple<int, int>(3,1)
            });

            FSharpList<int> result = sortGraph(input);

            Assert.AreEqual(expected, result);
        }
    }
}
