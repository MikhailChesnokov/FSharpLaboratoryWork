using System;
using Microsoft.FSharp.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _2_2_FatherToSon;

namespace UnitTests.FatherToSon
{
    [TestClass]
    public class Functions
    {
        internal static SortedSet<string> ConvertToSet(string result)
        {
            if (result == String.Empty) return new SortedSet<string>();
            result = result.Trim('\n');
            while (result.IndexOf(" ") > 0)
                result = result.Remove(result.IndexOf(" "), 1);
            SortedSet<string> sortedSet = new SortedSet<string>();
            foreach (string s in result.Split('\n'))
                sortedSet.Add(s);
            return sortedSet;
        }

        [TestMethod]
        public void FatherToSon()
        {
            string man = "A1";
            SortedSet<string> expected = new SortedSet<string> {"B1","B3","B2"};
            List<Tuple<string, string>> CSarpPairs = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("A1", "B1"),
                new Tuple<string, string>("A1", "B2"),
                new Tuple<string, string>("A1", "B3"),

                new Tuple<string, string>("A2", "B4"),
                new Tuple<string, string>("A2", "B5"),
                      new Tuple<string, string>("B5", "C1")
            };
            FSharpList<Tuple<string, string>> FSarpPairs = ListModule.OfSeq(CSarpPairs);

            string result = printChildren(FSarpPairs, man, "");
            SortedSet<string> resultCollection = ConvertToSet(result);
            
            CollectionAssert.AreEqual(expected, resultCollection);
        }
    }
}