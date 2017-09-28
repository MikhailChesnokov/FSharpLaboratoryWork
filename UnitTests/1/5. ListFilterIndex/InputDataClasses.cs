using Microsoft.FSharp.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1_5_ListFilter;

namespace UnitTests.ListFilterIndex
{
    [TestClass]
    public class InputDataClasses
    {
        [TestMethod]
        public void IntegerNumbers()
        {
            FSharpList<int> initial = ListModule.OfSeq<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            FSharpList<int> expected = ListModule.OfSeq<int>(new[] { 1, 3, 5, 7, 9 });

            FSharpList<int> result = removeEverySecond(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RealNumbers()
        {
            FSharpList<double> initial = ListModule.OfSeq<double>(new[] { 1.0, 2.5, 3, 4E1, 5.0000000000001 });
            FSharpList<double> expected = ListModule.OfSeq<double>(new[] { 1.0, 3, 5.0000000000001 });

            FSharpList<double> result = removeEverySecond(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Chars()
        {
            FSharpList<char> initial = ListModule.OfSeq<char>(new[] { 'A', 'B', 'C', 'D', 'E' });
            FSharpList<char> expected = ListModule.OfSeq<char>(new[] { 'A', 'C', 'E' });

            FSharpList<char> result = removeEverySecond(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Strings()
        {
            FSharpList<string> initial = ListModule.OfSeq<string>(new[] { "one", "two", "three", "four", "five" });
            FSharpList<string> expected = ListModule.OfSeq<string>(new[] { "one", "three", "five" });

            FSharpList<string> result = removeEverySecond(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void bools()
        {
            FSharpList<bool> initial = ListModule.OfSeq<bool>(new[] { true, false, true, false, true });
            FSharpList<bool> expected = ListModule.OfSeq<bool>(new[] { true, true, true });

            FSharpList<bool> result = removeEverySecond(initial);

            Assert.AreEqual(expected, result);
        }
    }
}