﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.FSharp.Collections;
using static _3_2_TopologicalSort;

namespace UnitTests.TopologicalSort
{
    [TestClass]
    public class InputDataLength
    {
        [TestMethod]
        public void EmptyGraph()
        {
            FSharpList<int> expected = ListModule.OfArray(new int[] {  });
            //Vertex<int> _1 = Vertex<int>.NewVertex(1, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _2 = Vertex<int>.NewVertex(2, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _3 = Vertex<int>.NewVertex(3, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _4 = Vertex<int>.NewVertex(4, ListModule.OfSeq(new List<Vertex<int>> { _1, _2, _3 }));
            //Vertex<int> _5 = Vertex<int>.NewVertex(5, ListModule.OfSeq(new List<Vertex<int>> { _2 }));
            //Vertex<int> _6 = Vertex<int>.NewVertex(6, ListModule.OfSeq(new List<Vertex<int>> { _4, _5 }));
            //Vertex<int> _7 = Vertex<int>.NewVertex(7, ListModule.OfSeq(new List<Vertex<int>> { _4 }));
            //Vertex<int> _8 = Vertex<int>.NewVertex(8, ListModule.OfSeq(new List<Vertex<int>> { _5, _3 }));
            //Vertex<int> _9 = Vertex<int>.NewVertex(9, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _10 = Vertex<int>.NewVertex(10, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _11 = Vertex<int>.NewVertex(11, ListModule.OfSeq(new List<Vertex<int>> { }));
            FSharpList<Vertex<int>> input = ListModule.OfArray(new Vertex<int>[] {});

            Tuple<FSharpList<Vertex<int>>, FSharpList<int>> result = dfs(FSharpList<Vertex<int>>.Empty, FSharpList<int>.Empty, input);

            Assert.AreEqual(expected, result.Item2);
        }

        [TestMethod]
        public void OneElementGraph()
        {
            FSharpList<int> expected = ListModule.OfArray(new[] { 1 });
            Vertex<int> _1 = Vertex<int>.NewVertex(1, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _2 = Vertex<int>.NewVertex(2, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _3 = Vertex<int>.NewVertex(3, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _4 = Vertex<int>.NewVertex(4, ListModule.OfSeq(new List<Vertex<int>> { _1, _2, _3 }));
            //Vertex<int> _5 = Vertex<int>.NewVertex(5, ListModule.OfSeq(new List<Vertex<int>> { _2 }));
            //Vertex<int> _6 = Vertex<int>.NewVertex(6, ListModule.OfSeq(new List<Vertex<int>> { _4, _5 }));
            //Vertex<int> _7 = Vertex<int>.NewVertex(7, ListModule.OfSeq(new List<Vertex<int>> { _4 }));
            //Vertex<int> _8 = Vertex<int>.NewVertex(8, ListModule.OfSeq(new List<Vertex<int>> { _5, _3 }));
            //Vertex<int> _9 = Vertex<int>.NewVertex(9, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _10 = Vertex<int>.NewVertex(10, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _11 = Vertex<int>.NewVertex(11, ListModule.OfSeq(new List<Vertex<int>> { }));
            FSharpList<Vertex<int>> input = ListModule.OfArray(new[] { _1 });

            Tuple<FSharpList<Vertex<int>>, FSharpList<int>> result = dfs(FSharpList<Vertex<int>>.Empty, FSharpList<int>.Empty, input);

            Assert.AreEqual(expected, result.Item2);
        }

        [TestMethod]
        public void TwoElementsGraph()
        {
            FSharpList<int> expected = ListModule.OfArray(new[] {  2, 1 });
            Vertex<int> _1 = Vertex<int>.NewVertex(1, ListModule.OfSeq(new List<Vertex<int>> { }));
            Vertex<int> _2 = Vertex<int>.NewVertex(2, ListModule.OfSeq(new List<Vertex<int>> { _1}));
            //Vertex<int> _3 = Vertex<int>.NewVertex(3, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _4 = Vertex<int>.NewVertex(4, ListModule.OfSeq(new List<Vertex<int>> { _1, _2, _3 }));
            //Vertex<int> _5 = Vertex<int>.NewVertex(5, ListModule.OfSeq(new List<Vertex<int>> { _2 }));
            //Vertex<int> _6 = Vertex<int>.NewVertex(6, ListModule.OfSeq(new List<Vertex<int>> { _4, _5 }));
            //Vertex<int> _7 = Vertex<int>.NewVertex(7, ListModule.OfSeq(new List<Vertex<int>> { _4 }));
            //Vertex<int> _8 = Vertex<int>.NewVertex(8, ListModule.OfSeq(new List<Vertex<int>> { _5, _3 }));
            //Vertex<int> _9 = Vertex<int>.NewVertex(9, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _10 = Vertex<int>.NewVertex(10, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _11 = Vertex<int>.NewVertex(11, ListModule.OfSeq(new List<Vertex<int>> { }));
            FSharpList<Vertex<int>> input = ListModule.OfArray(new[] { _1, _2 });

            Tuple<FSharpList<Vertex<int>>, FSharpList<int>> result = dfs(FSharpList<Vertex<int>>.Empty, FSharpList<int>.Empty, input);

            Assert.AreEqual(expected, result.Item2);
        }

        [TestMethod]
        public void ThreeElementsGraph()
        {
            FSharpList<int> expected = ListModule.OfArray(new[] { 3, 2, 1 });
            Vertex<int> _1 = Vertex<int>.NewVertex(1, ListModule.OfSeq(new List<Vertex<int>> { }));
            Vertex<int> _2 = Vertex<int>.NewVertex(2, ListModule.OfSeq(new List<Vertex<int>> { _1 }));
            Vertex<int> _3 = Vertex<int>.NewVertex(3, ListModule.OfSeq(new List<Vertex<int>> { _2}));
            //Vertex<int> _4 = Vertex<int>.NewVertex(4, ListModule.OfSeq(new List<Vertex<int>> { _1, _2, _3 }));
            //Vertex<int> _5 = Vertex<int>.NewVertex(5, ListModule.OfSeq(new List<Vertex<int>> { _2 }));
            //Vertex<int> _6 = Vertex<int>.NewVertex(6, ListModule.OfSeq(new List<Vertex<int>> { _4, _5 }));
            //Vertex<int> _7 = Vertex<int>.NewVertex(7, ListModule.OfSeq(new List<Vertex<int>> { _4 }));
            //Vertex<int> _8 = Vertex<int>.NewVertex(8, ListModule.OfSeq(new List<Vertex<int>> { _5, _3 }));
            //Vertex<int> _9 = Vertex<int>.NewVertex(9, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _10 = Vertex<int>.NewVertex(10, ListModule.OfSeq(new List<Vertex<int>> { }));
            //Vertex<int> _11 = Vertex<int>.NewVertex(11, ListModule.OfSeq(new List<Vertex<int>> { }));
            FSharpList<Vertex<int>> input = ListModule.OfArray(new[] { _1, _2,_3 });

            Tuple<FSharpList<Vertex<int>>, FSharpList<int>> result = dfs(FSharpList<Vertex<int>>.Empty, FSharpList<int>.Empty, input);

            Assert.AreEqual(expected, result.Item2);
        }
    }
}