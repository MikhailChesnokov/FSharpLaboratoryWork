using System;
using System.Collections.Generic;
using Microsoft.FSharp.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _2_3_Ferz;

namespace UnitTests.Ferz
{
    [TestClass]
    public class InputDataLength
    {
        [TestMethod]
        public void Zero()
        {
            const bool expected = true;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>();
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void One()
        {
            const bool expected = true;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(1, 1)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Two()
        {
            const bool expected = false;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(1, 1),
                new Tuple<int, int>(2, 2)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Three()
        {
            const bool expected = true;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(1, 1),
                new Tuple<int, int>(3, 2),
                new Tuple<int, int>(6, 7)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Many()
        {
            const bool expected = true;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(1, 1),
                new Tuple<int, int>(3, 2),
                new Tuple<int, int>(5, 7),
                new Tuple<int, int>(7, 8),
                new Tuple<int, int>(2, 6)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }
    }
}