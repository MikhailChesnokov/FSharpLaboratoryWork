using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _2_6_VerticesCount;
using static _2_5_MaxBranchLength;

namespace UnitTests.VerticesCount
{
    [TestClass]
    public class InputDataClasses
    {
        [TestMethod]
        public void Len_0L_0R()
        {
            BinaryTree<int> tree = BinaryTree<int>.Empty;
            const int expected = 0;

            int result = countVertices(tree, 0);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Len_1L_1R()
        {
            BinaryTree<int> tree = BinaryTree<int>.NewBinaryTree(
                BinaryTree<int>.Empty,
                1,
                BinaryTree<int>.Empty
                );
            const int expected = 1;

            int result = countVertices(tree, 0);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Len_2L_1R()
        {
            const int expected = 2;
            BinaryTree<int> tree = BinaryTree<int>.NewBinaryTree(
                BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                              2,
                                              BinaryTree<int>.Empty),
                1,
                BinaryTree<int>.Empty);

            int result = countVertices(tree, 0);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Len_2L_2R()
        {
            const int expected = 3;
            BinaryTree<int> tree = BinaryTree<int>.NewBinaryTree(
                BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                              2,
                                              BinaryTree<int>.Empty),
                1,
                BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                              3,
                                              BinaryTree<int>.Empty));

            int result = countVertices(tree, 0);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Len_1L_2R()
        {
            const int expected = 2;
            BinaryTree<int> tree = BinaryTree<int>.NewBinaryTree(
                BinaryTree<int>.Empty,
                1,
                BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                              2,
                                              BinaryTree<int>.Empty));

            int result = countVertices(tree, 0);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Len_3L_1R()
        {
            const int expected = 4;
            BinaryTree<int> tree = BinaryTree<int>.NewBinaryTree(
                BinaryTree<int>.NewBinaryTree(BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                                                            4,
                                                                            BinaryTree<int>.Empty),
                                              2,
                                              BinaryTree<int>.Empty),
                1,
                BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                              3,
                                              BinaryTree<int>.Empty));

            int result = countVertices(tree, 0);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Len_3L_3R()
        {
            const int expected = 7;
            BinaryTree<int> tree = BinaryTree<int>.NewBinaryTree(
                BinaryTree<int>.NewBinaryTree(BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                                                            4,
                                                                            BinaryTree<int>.Empty),
                                              2,
                                              BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                                                            5,
                                                                            BinaryTree<int>.Empty)),
                1,
                BinaryTree<int>.NewBinaryTree(BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                                                            6,
                                                                            BinaryTree<int>.Empty),
                                              3,
                                              BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                                                            7,
                                                                            BinaryTree<int>.Empty)));

            int result = countVertices(tree, 0);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Len_4L_3R()
        {
            const int expected = 9;
            BinaryTree<int> tree = BinaryTree<int>.NewBinaryTree(
                BinaryTree<int>.NewBinaryTree(BinaryTree<int>.NewBinaryTree(BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                                                                                          8,
                                                                                                          BinaryTree<int>.Empty),
                                                                            4,
                                                                            BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                                                                                          9,
                                                                                                          BinaryTree<int>.Empty)),
                                              2,
                                              BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                                                            5,
                                                                            BinaryTree<int>.Empty)),
                1,
                BinaryTree<int>.NewBinaryTree(BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                                                            6,
                                                                            BinaryTree<int>.Empty),
                                              3,
                                              BinaryTree<int>.NewBinaryTree(BinaryTree<int>.Empty,
                                                                            7,
                                                                            BinaryTree<int>.Empty)));

            int result = countVertices(tree, 0);

            Assert.AreEqual(expected, result);
        }
    }
}