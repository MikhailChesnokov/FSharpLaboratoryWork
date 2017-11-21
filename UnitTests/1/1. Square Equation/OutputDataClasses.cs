using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1_1_SquareEquation;

namespace UnitTests.SquareEquation
{
    [TestClass]
    public class OutputDataClasses
    {
        [TestMethod]
        public void NoRoots()
        {
            const double a = 0, b = 0, c = 1;
            squareEquationRoots expected = squareEquationRoots.None;

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AnyRealNumber()
        {
            const double a = 0, b = 0, c = 0;
            squareEquationRoots expected = squareEquationRoots.Any;

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void OneRoot()
        {
            const double a = 1, b = 2, c = 1;
            squareEquationRoots expected = squareEquationRoots.NewQuad(-1, -1);

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TwoRoots()
        {
            const double a = 1, b = 2, c = -3;
            squareEquationRoots expected = squareEquationRoots.NewQuad(1, -3);

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }
    }
}