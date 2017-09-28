using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _2_5_MaxBranchLength;

namespace UnitTests.MaxBranchLength
{
    [TestClass]
    public class Functions
    {
        [TestMethod]
        public void MaxBranchLength()
        {
            BinaryTree<int> tree = BinaryTree<int>.NewBinaryTree(
                BinaryTree<int>.Empty,
                1,
                BinaryTree<int>.Empty
                );
            const int expected = 1;

            int result = getMaxBranchLength(tree, 0);

            Assert.AreEqual(expected, result);
        }
    }
}