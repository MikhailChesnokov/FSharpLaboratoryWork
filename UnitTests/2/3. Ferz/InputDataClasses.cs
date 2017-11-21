using System;
using System.Collections.Generic;
using Microsoft.FSharp.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _2_3_Ferz;

namespace UnitTests.Ferz
{
    [TestClass]
    public class InputDataClasses_Beat
    {
        [TestMethod]
        public void BeatItseft()
        {
            const bool expected = false;

            bool result = beat(7, 6, 7, 6);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BeatDiagonal()
        {
            const bool expected = true;

            bool
                result = beat(7, 7, 6, 6);
            Assert.AreEqual(expected, result);

            result = beat(7, 7, 8, 8);
            Assert.AreEqual(expected, result);

            result = beat(7, 7, 8, 6);
            Assert.AreEqual(expected, result);

            result = beat(7, 7, 6, 8);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BeatHorizontalVertical()
        {
            const bool expected = true;

            bool
                result = beat(7, 7, 7, 6);
            Assert.AreEqual(expected, result);

            result = beat(7, 7, 7, 8);
            Assert.AreEqual(expected, result);

            result = beat(7, 7, 8, 7);
            Assert.AreEqual(expected, result);

            result = beat(7, 7, 6, 7);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NotBeat()
        {
            const bool expected = false;

            bool
                result = beat(6, 2, 4, 1);
            Assert.AreEqual(expected, result);

            result = beat(6, 2, 8, 1);
            Assert.AreEqual(expected, result);

            result = beat(6, 2, 8, 3);
            Assert.AreEqual(expected, result);

            result = beat(6, 2, 4, 3);
            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class InputDataClasses_IsCorrectArrangement
    {
        [TestMethod]
        public void Itself()
        {
            const bool expected = true;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(6, 2)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Uncorrect_Two_Horizontal()
        {
            const bool expected = false;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(6, 2),
                new Tuple<int, int>(6, 3)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Uncorrect_Three_Horizontal()
        {
            const bool expected = false;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(6, 2),
                new Tuple<int, int>(6, 3),
                new Tuple<int, int>(6, 4)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Uncorrect_Two_Vertical()
        {
            const bool expected = false;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(6, 2),
                new Tuple<int, int>(7, 2)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Uncorrect_Tree_Vertical()
        {
            const bool expected = false;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(6, 2),
                new Tuple<int, int>(6, 3)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Uncorrect_Two_Diagonal()
        {
            const bool expected = false;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(6, 2),
                new Tuple<int, int>(5, 1)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Uncorrect_Tree_Diagonal()
        {
            const bool expected = false;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(5, 3),
                new Tuple<int, int>(4, 2),
                new Tuple<int, int>(6, 4)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Correct_Two()
        {
            const bool expected = true;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(6, 2),
                new Tuple<int, int>(1, 1)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Correct_Three()
        {
            const bool expected = true;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(6, 2),
                new Tuple<int, int>(1, 1),
                new Tuple<int, int>(7, 8)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Correct_Two_of_three()
        {
            const bool expected = false;
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(6, 2),
                new Tuple<int, int>(1, 1),
                new Tuple<int, int>(5, 1)
            };
            FSharpList<Tuple<int, int>> input = ListModule.OfSeq(coords);

            bool result = isCorrectArrangement(input);

            Assert.AreEqual(expected, result);
        }
    }
}