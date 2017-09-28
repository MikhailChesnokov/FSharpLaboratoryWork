using System;
using Microsoft.FSharp.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _2_2_FatherToSon;

namespace UnitTests.FatherToSon
{
    [TestClass]
    public class InputDataClasses
    {
        [TestMethod]
        public void AllSons()
        {
            string man = "A1";
            SortedSet<string> expected = new SortedSet<string> { "B1","B2","B3" };
            List<Tuple<string, string>> CSarpPairs = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("A1", "B1"),
                new Tuple<string, string>("A1", "B2"),
                new Tuple<string, string>("A1", "B3")
            };
            FSharpList<Tuple<string, string>> FSarpPairs = ListModule.OfSeq(CSarpPairs);

            string result = printChildren(FSarpPairs, man, "");
            SortedSet<string> resultCollection = Functions.ConvertToSet(result);

            CollectionAssert.AreEqual(expected, resultCollection);
        }

        [TestMethod]
        public void AllNotSoons()
        {
            string man = "A1";
            SortedSet<string> expected = new SortedSet<string> {  };
            List<Tuple<string, string>> CSarpPairs = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("A2", "B1"),
                new Tuple<string, string>("A2", "B2"),
                new Tuple<string, string>("A2", "B3")
            };
            FSharpList<Tuple<string, string>> FSarpPairs = ListModule.OfSeq(CSarpPairs);

            string result = printChildren(FSarpPairs, man, "");
            SortedSet<string> resultCollection = Functions.ConvertToSet(result);

            CollectionAssert.AreEqual(expected, resultCollection);
        }

        [TestMethod]
        public void Stairway()
        {
            string man = "A1";
            SortedSet<string> expected = new SortedSet<string> { "B1","C1","D1"};
            List<Tuple<string, string>> CSarpPairs = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("A1", "B1"),
                      new Tuple<string, string>("B1", "C1"),
                            new Tuple<string, string>("C1", "D1")
            };
            FSharpList<Tuple<string, string>> FSarpPairs = ListModule.OfSeq(CSarpPairs);

            string result = printChildren(FSarpPairs, man, "");
            SortedSet<string> resultCollection = Functions.ConvertToSet(result);

            CollectionAssert.AreEqual(expected, resultCollection);
        }

        [TestMethod]
        public void RandomWithChain()
        {
            string man = "A1";
            SortedSet<string> expected = new SortedSet<string> { "B1", "B2", "C1", "D1" };
            List<Tuple<string, string>> CSarpPairs = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("A1", "B1"),
                new Tuple<string, string>("A1", "B2"),
                      new Tuple<string, string>("B2", "C1"),
                            new Tuple<string, string>("C1", "D1"),

                new Tuple<string, string>("A2", "B3"),

                new Tuple<string, string>("A2", "B4"),

                            new Tuple<string, string>("C2", "D2"),

                new Tuple<string, string>("A3", "B5"),
            };
            FSharpList<Tuple<string, string>> FSarpPairs = ListModule.OfSeq(CSarpPairs);

            string result = printChildren(FSarpPairs, man, "");
            SortedSet<string> resultCollection = Functions.ConvertToSet(result);

            CollectionAssert.AreEqual(expected, resultCollection);
        }

        [TestMethod]
        public void RandomWithoutChain()
        {
            string man = "A1";
            SortedSet<string> expected = new SortedSet<string> {  };
            List<Tuple<string, string>> CSarpPairs = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("A2", "B1"),

                      new Tuple<string, string>("B1", "C1"),

                            new Tuple<string, string>("C2", "D1"),

                new Tuple<string, string>("A3", "B3"),

                new Tuple<string, string>("A3", "B4"),

                            new Tuple<string, string>("C3", "D2"),

                new Tuple<string, string>("A4", "B5"),
            };
            FSharpList<Tuple<string, string>> FSarpPairs = ListModule.OfSeq(CSarpPairs);

            string result = printChildren(FSarpPairs, man, "");
            SortedSet<string> resultCollection = Functions.ConvertToSet(result);

            CollectionAssert.AreEqual(expected, resultCollection);
        }
    }
}