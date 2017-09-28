using System.Collections.Generic;
using Microsoft.FSharp.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1_5_ListFilter;

namespace UnitTests.ListFilterIndex
{
    [TestClass]
    public class inputDataLength
    {
        [TestMethod]
        public void EmptyList()
        {
            FSharpList<int> initial = ListModule.OfSeq<int>(new List<int>());
            FSharpList<int> expected = ListModule.OfSeq<int>(new List<int>());

            FSharpList<int> result = removeEverySecond(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void OneElement()
        {
            FSharpList<int> initial = ListModule.OfSeq<int>(new List<int>() { 1 });
            FSharpList<int> expected = ListModule.OfSeq<int>(new List<int>() { 1 });

            FSharpList<int> result = removeEverySecond(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TwoElements()
        {
            FSharpList<int> initial = ListModule.OfSeq<int>(new List<int>() {1,2} );
            FSharpList<int> expected = ListModule.OfSeq<int>(new List<int>() {1});

            FSharpList<int> result = removeEverySecond(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ThreeElements()
        {
            FSharpList<int> initial = ListModule.OfSeq<int>(new List<int>() {1,2,3});
            FSharpList<int> expected = ListModule.OfSeq<int>(new List<int>() {1,3});

            FSharpList<int> result = removeEverySecond(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Medium_1E3()
        {
            const int n = 1000;
            List<int> initialList = new List<int>(),
                      expectedList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                initialList.Add(i);
                if (i % 2 == 0) 
                    expectedList.Add(i);
            }
            FSharpList<int> initial = ListModule.OfSeq<int>(initialList);
            FSharpList<int> expected = ListModule.OfSeq<int>(expectedList);

            FSharpList<int> result = removeEverySecond(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Large_1E6()
        {
            const int n = 1000*1000;
            List<int> initialList = new List<int>(),
                      expectedList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                initialList.Add(i);
                if (i % 2 == 0)
                    expectedList.Add(i);
            }
            FSharpList<int> initial = ListModule.OfSeq<int>(initialList);
            FSharpList<int> expected = ListModule.OfSeq<int>(expectedList);

            FSharpList<int> result = removeEverySecond(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExtraLarge_1E7()
        {
            const int n = 1000*1000*10;
            List<int> initialList = new List<int>(),
                      expectedList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                initialList.Add(i);
                if (i % 2 == 0)
                    expectedList.Add(i);
            }
            FSharpList<int> initial = ListModule.OfSeq<int>(initialList);
            FSharpList<int> expected = ListModule.OfSeq<int>(expectedList);

            FSharpList<int> result = removeEverySecond(initial);

            Assert.AreEqual(expected, result);
        }
    }
}