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
            FSharpList<int> initial = ListModule.OfSeq(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            FSharpList<int> expected = ListModule.OfSeq(new[] {1, 3, 5, 7, 9});

            FSharpList<int> result = removeEverySecond<int>(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RealNumbers()
        {
            FSharpList<double> initial = ListModule.OfSeq(new[] {1.0, 2.5, 3, 4E1, 5.0000000000001});
            FSharpList<double> expected = ListModule.OfSeq(new[] {1.0, 3, 5.0000000000001});

            FSharpList<double> result = removeEverySecond<double>(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Chars()
        {
            FSharpList<char> initial = ListModule.OfSeq(new[] {'A', 'B', 'C', 'D', 'E'});
            FSharpList<char> expected = ListModule.OfSeq(new[] {'A', 'C', 'E'});

            FSharpList<char> result = removeEverySecond<char>(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Strings()
        {
            FSharpList<string> initial = ListModule.OfSeq(new[] {"one", "two", "three", "four", "five"});
            FSharpList<string> expected = ListModule.OfSeq(new[] {"one", "three", "five"});

            FSharpList<string> result = removeEverySecond<string>(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void bools()
        {
            FSharpList<bool> initial = ListModule.OfSeq(new[] {true, false, true, false, true});
            FSharpList<bool> expected = ListModule.OfSeq(new[] {true, true, true});

            FSharpList<bool> result = removeEverySecond<bool>(initial);

            Assert.AreEqual(expected, result);
        }
    }
}