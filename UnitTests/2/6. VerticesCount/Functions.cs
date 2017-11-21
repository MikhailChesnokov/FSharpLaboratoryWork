using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _2_6_VerticesCount;
using static _2_5_MaxBranchLength;

namespace UnitTests.VerticesCount
{
    [TestClass]
    public class Functions
    {
        [TestMethod]
        public void VerticesCount()
        {
            BinaryTree<int> tree = BinaryTree<int>.NewBinaryTree(
                BinaryTree<int>.Empty,
                1,
                BinaryTree<int>.Empty
            );
            const int expected = 1;

            int result = countVertices(0, tree);

            Assert.AreEqual(expected, result);
        }
    }
}