using System;
using System.Collections.Generic;
using Microsoft.FSharp.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _2_2_FatherToSon;

namespace UnitTests.FatherToSon
{
    [TestClass]
    public class InputDataLength
    {
        [TestMethod]
        public void Zero()
        {
            string man = "A1";
            SortedSet<string> expected = new SortedSet<string>();
            List<Tuple<string, string>> CSarpPairs = new List<Tuple<string, string>>();
            FSharpList<Tuple<string, string>> FSarpPairs = ListModule.OfSeq(CSarpPairs);

            string result = printChildren(FSarpPairs, man, "");
            SortedSet<string> resultCollection = Functions.ConvertToSet(result);

            CollectionAssert.AreEqual(expected, resultCollection);
        }

        [TestMethod]
        public void One()
        {
            string man = "A1";
            SortedSet<string> expected = new SortedSet<string> {"B1"};
            List<Tuple<string, string>> CSarpPairs = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("A1", "B1")
            };
            FSharpList<Tuple<string, string>> FSarpPairs = ListModule.OfSeq(CSarpPairs);

            string result = printChildren(FSarpPairs, man, "");
            SortedSet<string> resultCollection = Functions.ConvertToSet(result);

            CollectionAssert.AreEqual(expected, resultCollection);
        }

        [TestMethod]
        public void Many()
        {
            string man = "A1";
            SortedSet<string> expected = new SortedSet<string> {"B1", "B2"};
            List<Tuple<string, string>> CSarpPairs = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("A1", "B1"),
                new Tuple<string, string>("A1", "B2")
            };
            FSharpList<Tuple<string, string>> FSarpPairs = ListModule.OfSeq(CSarpPairs);

            string result = printChildren(FSarpPairs, man, "");
            SortedSet<string> resultCollection = Functions.ConvertToSet(result);

            CollectionAssert.AreEqual(expected, resultCollection);
        }
    }
}