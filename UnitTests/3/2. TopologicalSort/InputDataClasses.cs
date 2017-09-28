using System;
using System.Collections.Generic;
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
            FSharpList<int> expected = ListModule.OfArray(new int[] { 7,6,5,4,3,2,1});
            Vertex<int> _1 = Vertex<int>.NewVertex(1, ListModule.OfSeq(new List<Vertex<int>> { }));
            Vertex<int> _2 = Vertex<int>.NewVertex(2, ListModule.OfSeq(new List<Vertex<int>> { }));
            Vertex<int> _3 = Vertex<int>.NewVertex(3, ListModule.OfSeq(new List<Vertex<int>> { }));
            Vertex<int> _4 = Vertex<int>.NewVertex(4, ListModule.OfSeq(new List<Vertex<int>> { }));
            Vertex<int> _5 = Vertex<int>.NewVertex(5, ListModule.OfSeq(new List<Vertex<int>> { _1, _2 }));
            Vertex<int> _6 = Vertex<int>.NewVertex(6, ListModule.OfSeq(new List<Vertex<int>> { _3, _4}));
            Vertex<int> _7 = Vertex<int>.NewVertex(7, ListModule.OfSeq(new List<Vertex<int>> { _5, _6}));
            //Vertex<int> _8 = Vertex<int>.NewVertex(8, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _9 = Vertex<int>.NewVertex(9, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _10 = Vertex<int>.NewVertex(10, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _11 = Vertex<int>.NewVertex(11, ListModule.OfSeq(new List<Vertex<int>> { }));
            FSharpList<Vertex<int>> input = ListModule.OfArray(new Vertex<int>[] { _1,_2,_3,_4,_5,_6,_7 });

            Tuple<FSharpList<Vertex<int>>, FSharpList<int>> result = dfs(FSharpList<Vertex<int>>.Empty, FSharpList<int>.Empty, input);

            Assert.AreEqual(expected, result.Item2);
        }

        [TestMethod]
        public void StandartGraph_Integer()
        {
            //    6   3
            //   / \ / \
            //  7   4   1
            //   \ / \ /
            //    5   2
            FSharpList<int> expected = ListModule.OfArray(new int[] { 7, 6, 5, 4, 3, 2, 1 });
            Vertex<int> _1 = Vertex<int>.NewVertex(1, ListModule.OfSeq(new List<Vertex<int>> { }));
            Vertex<int> _2 = Vertex<int>.NewVertex(2, ListModule.OfSeq(new List<Vertex<int>> { _1}));
            Vertex<int> _3 = Vertex<int>.NewVertex(3, ListModule.OfSeq(new List<Vertex<int>> { _1}));
            Vertex<int> _4 = Vertex<int>.NewVertex(4, ListModule.OfSeq(new List<Vertex<int>> { _2, _3}));
            Vertex<int> _5 = Vertex<int>.NewVertex(5, ListModule.OfSeq(new List<Vertex<int>> {  _4}));
            Vertex<int> _6 = Vertex<int>.NewVertex(6, ListModule.OfSeq(new List<Vertex<int>> {  _4}));
            Vertex<int> _7 = Vertex<int>.NewVertex(7, ListModule.OfSeq(new List<Vertex<int>> {  _5, _6}));
            //Vertex<int> _8 = Vertex<int>.NewVertex(8, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _9 = Vertex<int>.NewVertex(9, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _10 = Vertex<int>.NewVertex(10, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _11 = Vertex<int>.NewVertex(11, ListModule.OfSeq(new List<Vertex<int>> { }));
            FSharpList<Vertex<int>> input = ListModule.OfArray(new Vertex<int>[] { _1, _2, _3, _4, _5, _6, _7 });

            Tuple<FSharpList<Vertex<int>>, FSharpList<int>> result = dfs(FSharpList<Vertex<int>>.Empty, FSharpList<int>.Empty, input);

            Assert.AreEqual(expected, result.Item2);
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
            FSharpList<string> expected = ListModule.OfArray(new string[] { "seven", "six", "five", "four", "three", "two", "one" });
            Vertex<string> _1 = Vertex<string>.NewVertex("one", ListModule.OfSeq(new List<Vertex<string>> { }));
            Vertex<string> _2 = Vertex<string>.NewVertex("two", ListModule.OfSeq(new List<Vertex<string>> { }));
            Vertex<string> _3 = Vertex<string>.NewVertex("three", ListModule.OfSeq(new List<Vertex<string>> { }));
            Vertex<string> _4 = Vertex<string>.NewVertex("four", ListModule.OfSeq(new List<Vertex<string>> { }));
            Vertex<string> _5 = Vertex<string>.NewVertex("five", ListModule.OfSeq(new List<Vertex<string>> { _1, _2 }));
            Vertex<string> _6 = Vertex<string>.NewVertex("six", ListModule.OfSeq(new List<Vertex<string>> { _3, _4 }));
            Vertex<string> _7 = Vertex<string>.NewVertex("seven", ListModule.OfSeq(new List<Vertex<string>> { _5, _6 }));
            //Vertex<int> _8 = Vertex<int>.NewVertex(8, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _9 = Vertex<int>.NewVertex(9, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _10 = Vertex<int>.NewVertex(10, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _11 = Vertex<int>.NewVertex(11, ListModule.OfSeq(new List<Vertex<int>> { }));
            FSharpList<Vertex<string>> input = ListModule.OfArray(new Vertex<string>[] { _1, _2, _3, _4, _5, _6, _7 });

            Tuple<FSharpList<Vertex<string>>, FSharpList<string>> result = dfs(FSharpList<Vertex<string>>.Empty, FSharpList<string>.Empty, input);

            Assert.AreEqual(expected, result.Item2);
        }

        [TestMethod]
        public void TreeGraph_Double()
        {
            //     / 3
            //    6 
            //   / \ 4
            //  7
            //   \ / 1
            //    5
            //     \ 2
            FSharpList<double> expected = ListModule.OfArray(new double[] { 7.0d, 6.0d, 5.0d, 4.0d, 3.0d, 2.0d, 1.0d });
            Vertex<double> _1 = Vertex<double>.NewVertex(1d, ListModule.OfSeq(new List<Vertex<double>> { }));
            Vertex<double> _2 = Vertex<double>.NewVertex(2d, ListModule.OfSeq(new List<Vertex<double>> { }));
            Vertex<double> _3 = Vertex<double>.NewVertex(3d, ListModule.OfSeq(new List<Vertex<double>> { }));
            Vertex<double> _4 = Vertex<double>.NewVertex(4d, ListModule.OfSeq(new List<Vertex<double>> { }));
            Vertex<double> _5 = Vertex<double>.NewVertex(5d, ListModule.OfSeq(new List<Vertex<double>> { _1, _2 }));
            Vertex<double> _6 = Vertex<double>.NewVertex(6d, ListModule.OfSeq(new List<Vertex<double>> { _3, _4 }));
            Vertex<double> _7 = Vertex<double>.NewVertex(7d, ListModule.OfSeq(new List<Vertex<double>> { _5, _6 }));
            //Vertex<int> _8 = Vertex<int>.NewVertex(8, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _9 = Vertex<int>.NewVertex(9, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _10 = Vertex<int>.NewVertex(10, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _11 = Vertex<int>.NewVertex(11, ListModule.OfSeq(new List<Vertex<int>> { }));
            FSharpList<Vertex<double>> input = ListModule.OfArray(new Vertex<double>[] { _1, _2, _3, _4, _5, _6, _7 });

            Tuple<FSharpList<Vertex<double>>, FSharpList<double>> result = dfs(FSharpList<Vertex<double>>.Empty, FSharpList<double>.Empty, input);

            Assert.AreEqual(expected, result.Item2);
        }

        [TestMethod]
        public void ListGraph()
        {
            //  7 --- 6 -- 5 -- 4 -- 3 -- 2 -- 1
            FSharpList<double> expected = ListModule.OfArray(new double[] { 7.0d, 6.0d, 5.0d, 4.0d, 3.0d, 2.0d, 1.0d });
            Vertex<double> _1 = Vertex<double>.NewVertex(1d, ListModule.OfSeq(new List<Vertex<double>> { }));
            Vertex<double> _2 = Vertex<double>.NewVertex(2d, ListModule.OfSeq(new List<Vertex<double>> { _1}));
            Vertex<double> _3 = Vertex<double>.NewVertex(3d, ListModule.OfSeq(new List<Vertex<double>> { _2}));
            Vertex<double> _4 = Vertex<double>.NewVertex(4d, ListModule.OfSeq(new List<Vertex<double>> { _3}));
            Vertex<double> _5 = Vertex<double>.NewVertex(5d, ListModule.OfSeq(new List<Vertex<double>> { _4}));
            Vertex<double> _6 = Vertex<double>.NewVertex(6d, ListModule.OfSeq(new List<Vertex<double>> { _5}));
            Vertex<double> _7 = Vertex<double>.NewVertex(7d, ListModule.OfSeq(new List<Vertex<double>> { _6}));
            //Vertex<int> _8 = Vertex<int>.NewVertex(8, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _9 = Vertex<int>.NewVertex(9, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _10 = Vertex<int>.NewVertex(10, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _11 = Vertex<int>.NewVertex(11, ListModule.OfSeq(new List<Vertex<int>> { }));
            FSharpList<Vertex<double>> input = ListModule.OfArray(new Vertex<double>[] { _3, _4, _5, _1, _2, _6, _7 });

            Tuple<FSharpList<Vertex<double>>, FSharpList<double>> result = dfs(FSharpList<Vertex<double>>.Empty, FSharpList<double>.Empty, input);

            Assert.AreEqual(expected, result.Item2);
        }
    }
}