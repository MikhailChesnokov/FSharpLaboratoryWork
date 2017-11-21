using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1_1_SquareEquation;

namespace UnitTests.SquareEquation
{
    [TestClass]
    public class InputDataClasses
    {
        [TestMethod]
        public void n_n_n()
        {
            const double a = 1, b = 2, c = -3;
            squareEquationRoots expected = squareEquationRoots.NewQuad(1, -3);

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void n_n_0()
        {
            const double a = 1, b = 2, c = 0;
            squareEquationRoots expected = squareEquationRoots.NewQuad(0, -2);

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void n_0_n()
        {
            const double a = 1, b = 0, c = -4;
            squareEquationRoots expected = squareEquationRoots.NewQuad(2, -2);

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void n_0_0()
        {
            const double a = 1, b = 0, c = 0;
            squareEquationRoots expected = squareEquationRoots.NewQuad(0, 0);

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void _0_n_n()
        {
            const double a = 0, b = 1, c = -2;
            squareEquationRoots expected = squareEquationRoots.NewLin(2);

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void _0_n_0()
        {
            const double a = 0, b = 2, c = 0;
            squareEquationRoots expected = squareEquationRoots.NewLin(0);

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void _0_0_n()
        {
            const double a = 0, b = 0, c = 2;
            squareEquationRoots expected = squareEquationRoots.None;

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void _0_0_0()
        {
            const double a = 0, b = 0, c = 0;
            squareEquationRoots expected = squareEquationRoots.Any;

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }
    }
}