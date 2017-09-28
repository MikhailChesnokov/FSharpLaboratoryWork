using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1_1_SquareEquation;
namespace UnitTests.SquareEquation
{
    [TestClass]
    public class Range
    {
        [TestMethod]
        public void SimpleRealNumbers()
        {
            const double a = 1.0, b = 2.0, c = -3.0;
            squareEquationRoots expected = squareEquationRoots.NewQuad(1,-3);

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExtraLargeRealNumbers()
        {
            const double a = 99999999999999E294, b = double.MaxValue, c = double.MaxValue;
            squareEquationRoots expected = squareEquationRoots.None;

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExtraSmallRealNumbers()
        {
            const double a = -1.9999999999E-100, b = -1.9999999999E-100, c = -1.9999999999E-100;
            squareEquationRoots expected = squareEquationRoots.None;

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NotRealNumbers()
        {
            const double a = Double.PositiveInfinity, b = 0, c = 0;
            squareEquationRoots expected = squareEquationRoots.None;

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NaN()
        {
            const double a = Double.NaN, b = 0, c = 0;
            squareEquationRoots expected = squareEquationRoots.None;

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }
    }
}