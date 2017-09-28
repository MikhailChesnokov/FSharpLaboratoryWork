using System;
using Microsoft.FSharp.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _2_2_FatherToSon;

namespace UnitTests.FatherToSon
{
    [TestClass]
    public class Order
    {

        [TestMethod]
        public void Order1()
        {
            string man = "A1";
            SortedSet<string> expected = new SortedSet<string> { "B1", "C1", "B2", "C2", "D1"};
            List<Tuple<string, string>> CSarpPairs = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("A1", "B1"),
                      new Tuple<string, string>("B1", "C1"),
                new Tuple<string, string>("A1", "B2"),
                      new Tuple<string, string>("B2", "C2"),
                            new Tuple<string, string>("C2", "D1")
            };
            FSharpList<Tuple<string, string>> FSarpPairs = ListModule.OfSeq(CSarpPairs);

            string result = printChildren(FSarpPairs, man, "");
            SortedSet<string> resultCollection = Functions.ConvertToSet(result);

            CollectionAssert.AreEqual(expected, resultCollection);
        }

        [TestMethod]
        public void Order2()
        {
            string man = "A1";
            SortedSet<string> expected = new SortedSet<string> { "B1", "C1", "B2", "C2", "D1" };
            List<Tuple<string, string>> CSarpPairs = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("A1", "B2"),
                      new Tuple<string, string>("B2", "C2"),
                            new Tuple<string, string>("C2", "D1"),
                new Tuple<string, string>("A1", "B1"),
                      new Tuple<string, string>("B1", "C1"),
                
            };
            FSharpList<Tuple<string, string>> FSarpPairs = ListModule.OfSeq(CSarpPairs);

            string result = printChildren(FSarpPairs, man, "");
            SortedSet<string> resultCollection = Functions.ConvertToSet(result);

            CollectionAssert.AreEqual(expected, resultCollection);
        }

        [TestMethod]
        public void Order3()
        {
            string man = "A1";
            SortedSet<string> expected = new SortedSet<string> { "B1", "C1", "B2", "C2", "D1" };
            List<Tuple<string, string>> CSarpPairs = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("A1", "B2"),
                new Tuple<string, string>("A1", "B1"),
                      new Tuple<string, string>("B2", "C2"),
                      new Tuple<string, string>("B1", "C1"),
                            new Tuple<string, string>("C2", "D1"),
            };
            FSharpList<Tuple<string, string>> FSarpPairs = ListModule.OfSeq(CSarpPairs);

            string result = printChildren(FSarpPairs, man, "");
            SortedSet<string> resultCollection = Functions.ConvertToSet(result);

            CollectionAssert.AreEqual(expected, resultCollection);
        }
    }
}