using System;
using System.Collections.Generic;
using Microsoft.FSharp.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _2_3_Ferz;

namespace UnitTests.Ferz
{
    [TestClass]
    public class Order
    {
        [TestMethod]
        public void Order1()
        {
            const bool expected = true;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(3,2),
                new Tuple<int, int>(4,4),
                new Tuple<int, int>(5,1)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Order2()
        {
            const bool expected = true;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(3,2),
                new Tuple<int, int>(5,1),
                new Tuple<int, int>(4,4),
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Order3()
        {
            const bool expected = true;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(5,1),
                new Tuple<int, int>(4,4),
                new Tuple<int, int>(3,2),
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }
    }
}