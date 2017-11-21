using System;
using System.Collections.Generic;
using Microsoft.FSharp.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _2_3_Ferz;

namespace UnitTests.Ferz
{
    [TestClass]
    public class Functions
    {
        [TestMethod]
        public void IsCorrectArrangement()
        {
            const bool expected = false;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(6, 2),
                new Tuple<int, int>(7, 1),
                new Tuple<int, int>(3, 3)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Beat()
        {
            const bool expected = false;

            bool result = beat(7, 6, 7, 6);

            Assert.AreEqual(expected, result);
        }
    }
}